using SharpDX.XAudio2;
using SharpDX.Multimedia;
using Microsoft.VisualBasic.Devices;
using System.IO.Ports;

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

        DateTime lastPlayedAt;
        void StartTick()
        {
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

                        sp.NewLine = "\r\n";
                        var line = sp.ReadLine();
                        foreach (var piezo in line.Split(',').Select(str => int.Parse(str)))
                        {
                            Invoke(
                                new Action(() =>
                                {
                                    piezo1PB.Value = piezo;
                                }));


                            if (piezo > 500)
                            {
                                if ((DateTime.Now - lastPlayedAt).TotalMilliseconds > 500)
                                {
                                    lastPlayedAt = DateTime.Now;
                                    PLaySoundFileAsync("sounds/d1.wav");
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
    }
}