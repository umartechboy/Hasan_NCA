using SharpDX.XAudio2;
using SharpDX.Multimedia;
using Microsoft.VisualBasic.Devices;
using System.IO.Ports;
using Microsoft.Win32;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace VoicesFE01
{
    public partial class Form1 : Form
    {
        SerialPort sp;
        XAudio2 xaudio2;
        MasteringVoice masteringVoice;
        public Form1()
        {
            InitializeComponent();
            xaudio2 = new XAudio2();
            masteringVoice = new MasteringVoice(xaudio2);
            findPortsB_Click(null, null);
        }

        void PLaySoundFileAsync(string fileName)
        {
            new Thread(() => { PLaySoundFile(xaudio2, fileName); }).Start();
        }
        /// <summary>
        /// Play a sound file. Supported format are Wav(pcm+adpcm) and XWMA
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="text">Text to display</param>
        /// <param name="fileName">Name of the file.</param>
        static void PLaySoundFile(XAudio2 device, string fileName)
        {
            var stream = new SoundStream(File.OpenRead(fileName));
            var waveFormat = stream.Format;
            var buffer = new AudioBuffer
            {
                Stream = stream.ToDataStream(),
                AudioBytes = (int)stream.Length,
                Flags = BufferFlags.EndOfStream
            };
            stream.Close();

            var sourceVoice = new SourceVoice(device, waveFormat, true);
            sourceVoice.SubmitSourceBuffer(buffer, stream.DecodedPacketsInfo);
            sourceVoice.Start();

            while (sourceVoice.State.BuffersQueued > 0)
                Thread.Sleep(10);

            sourceVoice.DestroyVoice();
            sourceVoice.Dispose();
            buffer.Stream.Dispose();
        }

        private void N1B_Click(object sender, EventArgs e)
        {

            PLaySoundFileAsync("sounds/d1.wav");
            Thread.Sleep(100);
            PLaySoundFileAsync("sounds/d2.wav");

        }

        private void N2B_Click(object sender, EventArgs e)
        {
        }

        bool closing = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            masteringVoice.Dispose();
            xaudio2.Dispose();
            if (sp != null)
                sp.Close();
            closing = true;

        }

        Thread thread;

        DateTime[] lastPlayedAt = new DateTime[32];
        private RegistryKey commonRegistry;

        void StartTick()
        {
            flowLayoutPanel1.Controls.Clear();
            Form1_Load(this, EventArgs.Empty);
            if (thread == null)
            {
                thread = new Thread(() =>
                {
                    while (!closing)
                    {
                        if (sp == null)
                        {
                            Thread.Sleep(100);
                            continue;
                        }
                        if (!sp.IsOpen)
                        {
                            Thread.Sleep(100);
                            continue;
                        }

                        sp.NewLine = "\n";
                        var line = sp.ReadLine();
                        if (line.StartsWith("deltas"))
                        {
                            var deltas = line.Split(':')[1].Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(v => int.Parse(v)).ToList();
                            while (flowLayoutPanel1.Controls.Count > deltas.Count)
                                deltas.Add(0);
                            for(int i =0; i < flowLayoutPanel1.Controls.Count; i++)
                            {
                                var c = flowLayoutPanel1.Controls.OfType<ChannelControl>().ToArray()[i];
                                int levelPA = (int)((deltas[i] * 100) / c.Max.Value);
                                c.Invoke(() => {
                                    if (levelPA > c.Level.Maximum)
                                        levelPA = c.Level.Maximum;
                                    c.Level.Value = levelPA;
                                    });

                                if (deltas[i] > levelPA)
                                {
                                    if ((DateTime.Now - lastPlayedAt[i]).TotalMilliseconds > (int)repeatDurationNUD.Value)
                                    {
                                        lastPlayedAt[i] = DateTime.Now;
                                        PLaySoundFileAsync("sounds/d1.wav");
                                    }
                                }
                            }
                        }
                    }
                });
                thread.Start();
            }
        }

        private void findPortsB_Click(object sender, EventArgs e)
        {
            portsCB.Items.AddRange(SerialPort.GetPortNames());
            if (portsCB.Items.Count > 0)
                portsCB.Text = portsCB.Items[0].ToString();
        }
        private void openPortB_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp != null)
                {
                    if (sp.IsOpen)
                        return;
                }
                sp = new SerialPort(portsCB.Text, 115200);
                sp.Open();
                StartTick();
            }
            catch
            {
                sp = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.commonRegistry = Registry.CurrentUser.CreateSubKey("Software\\Curtains", true);
            this.Width = (int)commonRegistry.GetValue("window width", 500);
            this.Height = (int)commonRegistry.GetValue("window height", 300);
            repeatDurationNUD.Value = (int)commonRegistry.GetValue("repeat duration", 500);
            repeatDurationNUD.ValueChanged += (s, e) => commonRegistry.SetValue("repeat duration", (int)repeatDurationNUD.Value);
            portsCB.Text = (string)commonRegistry.GetValue("port", "");
            portsCB.TextChanged += (s, e) => commonRegistry.SetValue("port", (string)portsCB.Text);


            var noOfChannels = (int)commonRegistry.GetValue("no of channels", 6);
            for (int i =0; i < noOfChannels; i++)
            {
                int finalI = i;
                var channel = commonRegistry.CreateSubKey("channel " + i, true);
                var con = new ChannelControl();
                con.Max.ValueChanged += (s, e) =>
                {
                    channel.SetValue("Max", (int)con.Max.Value);
                    if (sp != null) if (sp.IsOpen)
                            sp.WriteLine("max " + finalI + "=" + con.Max.Value);
                };
                con.Max.Value = (int)channel.GetValue("Max", 10000);
                con.Damping.ValueChanged += (s, e) =>
                {
                    channel.SetValue("Damping", (int)con.Damping.Value);
                    if (sp != null) if (sp.IsOpen)
                            sp.WriteLine("damping " + finalI + "=" + con.Damping.Value);
                };
                con.Damping.Value = (int)channel.GetValue("Damping", 4);
                con.Gain.ValueChanged += (s, e) =>
                {
                    channel.SetValue("Gain", (int)con.Gain.Value);
                    if (sp != null) if (sp.IsOpen)
                            sp.WriteLine("gain " + finalI + "=" + con.Gain.Value);
                };
                con.Gain.Value = (int)channel.GetValue("Gain", 10);
                con.soundThreshold.ValueChanged += (s, e) =>
                {
                    channel.SetValue("threshold", (int)con.soundThreshold.Value);
                };
                con.soundThreshold.Value = (int)channel.GetValue("threshold", 5);

                con.Title.Text = "A" + i;
                con.ChannelID = i;
                con.Registry = channel;
                flowLayoutPanel1.Controls.Add(con);
            }

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            commonRegistry.SetValue("window width", this.Width);
            commonRegistry.SetValue("window height", this.Height);
        }

        private void addChannelsB_Click(object sender, EventArgs e)
        {
            commonRegistry.SetValue("no of channels", flowLayoutPanel1.Controls.Count + 1);
            flowLayoutPanel1.Controls.Clear();
            Form1_Load(this, EventArgs.Empty);
        }

        private void removeChannelsB_Click(object sender, EventArgs e)
        {
            commonRegistry.SetValue("no of channels", flowLayoutPanel1.Controls.Count - 1);
            flowLayoutPanel1.Controls.Clear();
            Form1_Load(this, EventArgs.Empty);
        }
    }
}