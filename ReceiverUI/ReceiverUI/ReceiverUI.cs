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
using System.Runtime.InteropServices;

namespace ReceiverUI
{
    public partial class ReceiverUI : Form
    {
        SerialPort _ser;
        BinaryReader _rd;
        BinaryWriter _wr;
        bool connected = false;
        bool onState = false;
        byte onOffCmd = 1;
        byte sendTextCmd = 2;
        byte freqChangeCmd = 3;
        byte volChangeCmd = 4;

        public ReceiverUI()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            msgTimer.Enabled = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // send Off when closed
            if (connected)
            {
                _wr.Write((byte)onOffCmd);
                _wr.Write((byte)0);
            }
        }

        void OnConnectBtnClicked(object sender, EventArgs e)
        {
            if (!connected)
            {
                _ser = new SerialPort(_COMInput.Text, 500000, Parity.None, 8, StopBits.One);
                try
                {
                    _ser.Open();
                    _rd = new BinaryReader(_ser.BaseStream);
                    _wr = new BinaryWriter(_ser.BaseStream);
                    connected = true;
                    _connectionStatus.Text = "Connected";
                    msgTimer.Enabled = true;
                }
                catch (Exception ex)
                {
                    _connectionStatus.Text = "COM Port not found";
                }
            }
            else
            {
                // send Off
                _wr.Write((byte)2);
                _wr.Write((byte)onOffCmd);
                _wr.Write((byte)0);
                msgTimer.Enabled = false;
            }
        }

        void OnFrequencyChanged(object sender, EventArgs e)
        {
            short val;
            if (connected)
            {
                val = (short)(_frequency.Value*100);
                byte len = (byte)(Marshal.SizeOf(freqChangeCmd) + Marshal.SizeOf(val));

                _wr.Write(len);
                _wr.Write(freqChangeCmd);
                _wr.Write((byte)val);

                _wr.Flush();
            }
        }

        void OnVolumeChanged(object sender, EventArgs e)
        {
            if (connected)
            {
                byte len = (byte)(Marshal.SizeOf(volChangeCmd) + Marshal.SizeOf((byte)_volume.Value));

                _wr.Write(len);
                _wr.Write(volChangeCmd);
                _wr.Write((byte)_volume.Value);

                _wr.Flush();
            }
        }

        void OnOnOffBtnClicked(object sender, EventArgs e)
        {
            if (connected)
            {
                byte val;
                if (onState)
                    val = 1;
                else
                    val = 0;

                _wr.Write((byte)2);
                _wr.Write((byte)onOffCmd);
                _wr.Write((byte)val);
                
                _wr.Flush();

                if (!onState)
                {
                    _offLbl.BackColor = Color.Green;
                    _offLbl.Text = "On";
                    _onOffBtn.Text = "Turn Off";
                    onState = true;
                }
                else
                {
                    _offLbl.BackColor = Color.Red;
                    _offLbl.Text = "Off";
                    _onOffBtn.Text = "Turn On";
                    onState = false;
                }
            }
        }

        void OnMsgTimer(object sender, EventArgs e)
        {
            if (connected)
            {
                _wr.Write(sendTextCmd);

                _wr.Flush();
            }
        }   // not working
    }
}

// ToDo:
// - RadioText
// - receive answers
