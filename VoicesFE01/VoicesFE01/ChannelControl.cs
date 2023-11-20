using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoicesFE01
{
    public partial class ChannelControl : UserControl
    {
        public int ChannelID { get; set; }
        public RegistryKey Registry { get; internal set; }

        public ChannelControl()
        {
            InitializeComponent();
        }
    }
}
