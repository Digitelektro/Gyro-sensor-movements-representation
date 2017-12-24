using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Gyro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string [] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPorts.Items.Add(port);
            }
            if(ports.Length != 0)
                comboBoxPorts.SelectedIndex = 0;
            textBoxPitch.Text = trackBarPitch.Value.ToString() + "°";
            textBoxRoll.Text = trackBarRoll.Value.ToString() + "°";
            
        }

        
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {


                byte[] buffer = new byte[28];
                if (serialPort1.BytesToRead >= 28)
                {
                    int readed = serialPort1.Read(buffer, 0, 28);
                    for (int i = 0; i < 14; i++)
                    {
                        string str = ASCIIEncoding.ASCII.GetString(buffer, i, 5);
                        if (str == "Data:")
                        {
                            int pitch = BitConverter.ToInt16(buffer, i + 6);
                            int roll = BitConverter.ToInt16(buffer, i + 8);
                            textBoxPitch.BeginInvoke((MethodInvoker)delegate
                            {
                                try
                                {
                                    textBoxPitch.Text = roll.ToString() + "°";
                                    textBoxRoll.Text = pitch.ToString() + "°";
                                    trackBarPitch.Value = Math.Abs(pitch);
                                    trackBarRoll.Value = Math.Abs(roll);
                                }
                                catch (Exception ex)
                                {
                                    textBoxPitch.Text = ex.Message;
                                }
                            });

                            dxGyro1.Roll = roll;
                            dxGyro1.Pitch = pitch;

                        }
                    }
                    serialPort1.DiscardInBuffer();
                }
            }
            catch
            {

            }

        }

        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    btnOpenSerial.Text = "Open";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialPort1.Open();
                    btnOpenSerial.Text = "Close";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void trackBarPitch_Scroll(object sender, EventArgs e)
        {
            dxGyro1.Pitch = trackBarPitch.Value;
            textBoxPitch.Text = trackBarPitch.Value.ToString() + "°";
        }

        private void trackBarRoll_Scroll(object sender, EventArgs e)
        {
            dxGyro1.Roll = trackBarRoll.Value;
            textBoxRoll.Text = trackBarRoll.Value.ToString() + "°";
        }
    }
}

