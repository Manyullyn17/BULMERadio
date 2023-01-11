using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// using MV;
using System.IO.Ports;
using System.IO;

namespace ReceiverUI
{
    public partial class Form1 : Form
    {
        SerialPort _ser;
        BinaryReaderEx _rd;
        BinaryWriter _wr;
        bool connected = false;
        short freqChangeCmd = 0; // change

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // send AcqOff when closed
            if (connected)
            {
                _wr.Write((byte)1); // cmd = 1
                _wr.Write((byte)0); // data = 0
            }
        }

        void OnConnectBtnClicked(object sender, EventArgs e)
        {
            _ser = new SerialPort(_COMInput.Text, 500000, Parity.None, 8, StopBits.One);
            try
            {
                _ser.Open();
                _rd = new BinaryReaderEx(_ser.BaseStream);
                _wr = new BinaryWriter(_ser.BaseStream);
                connected = true;
                _connectionStatus.Text = "Connected";
            } catch (Exception ex)
            {
                _connectionStatus.Text = "COM Port not found";
            }
        }

        void OnFrequencyChanged(object sender, EventArgs e)
        {
            short cmd;
            double val;
            if (connected)
            {
                cmd = freqChangeCmd;
                val = (double)_frequency.Value;

                _wr.Write((byte)cmd);
                _wr.Write((float)val);

                _wr.Flush();
            }
        }

        void OnAqcChecked(object sender, EventArgs e)
        {
            if (connected)
            {
                if (_sendBox.Checked)
                {
                    _wr.Write((byte)1); // cmd = 1
                    _wr.Write((byte)1); // data = 1
                }
                else
                {
                    _wr.Write((byte)1); // cmd = 1
                    _wr.Write((byte)0); // data = 0
                }
            }
        }
    }
}

// ToDo:
// - Add Ability to send commands
//   - send frequency done
//   - aqc done
// - (Add Ability to receive stuff)
