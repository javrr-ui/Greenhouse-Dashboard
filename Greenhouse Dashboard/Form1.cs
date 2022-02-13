using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Greenhouse_Dashboard
{
    public partial class Window : Form
    {
        System.IO.Ports.SerialPort Port;
        bool isClosed = false;
        

        public Window()
        {
            InitializeComponent();
            Port = new System.IO.Ports.SerialPort();
            Port.PortName = "COM1";
            Port.BaudRate = 9600;
            Port.ReadTimeout = 500;

            string[] ports = SerialPort.GetPortNames();
            for(int i = 0; i < ports.Length; i++)
            {
                comboBox1.Items.Add(ports[i]);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Window_Load(object sender, EventArgs e)
        {
            Thread hilo = new Thread(escucharSerial);
            hilo.Start();

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            
            if (!comboBox1.Text.Equals("Seleccionar puerto"))
            {
                Port.Close();
                Port.PortName = comboBox1.Text;
            try
            {
                Port.Open();
                arduinoLabel.ForeColor = Color.DarkGreen;
                arduinoLabel.Text = "Arduino conectado";
                disconnectButton.Enabled = true;
                
            }
            catch
            {
                MessageBox.Show("Error al abrir puerto");
            }
        }
        }

        private void escucharSerial()
        {
            string cadena = "";
            while (!isClosed)
            {

                if (Port.IsOpen)
                {
                    try
                    {
                        cadena = Port.ReadLine();
                    }
                    catch
                    {

                    }
                    
                    sensor1Value.Invoke(new MethodInvoker(
                        delegate
                        {
                            textReplace(sensor1Value,cadena, "sensor1", "%");
                        }));

                    sensor2Value.Invoke(new MethodInvoker(
                        delegate
                        {
                            textReplace(sensor2Value,cadena, "sensor2", "%");
                        }));

                    temperatureValue.Invoke(new MethodInvoker(
                        delegate
                        {
                            textReplace(temperatureValue, cadena, "tempSensor1", "°C");
                        }));
                }
               
            }
        }
        private void textReplace(Label obj,string cadena2, string text, string text2)
        {
            if (cadena2.Contains(text))
            {
                cadena2 = cadena2.Replace(text, text2);
                obj.Text = cadena2;
            }
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosed = true;
            if (Port.IsOpen)
            {
                Port.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fanButton.Text.Equals("Encender ventilador"))
            {
                
                if (Port.IsOpen)
                {
                    fanButton.Text = "Apagar ventilador";
                    Port.Write("fanOn");
                }
            }
            else
            {
                
                if (Port.IsOpen)
                {
                    fanButton.Text = "Encender ventilador";
                    Port.Write("fanOff");
                    
                }
            }
        }

        private void electrovalveButton_Click(object sender, EventArgs e)
        {
            if (electrovalveButton.Text.Equals("Encender electroválvula"))
            {
                
                if (Port.IsOpen)
                {
                    electrovalveButton.Text = "Apagar electroválvula";
                    Port.Write("valveOn");
                }
            }
            else
            {
                if (Port.IsOpen)
                {
                    electrovalveButton.Text = "Encender electroválvula";
                    Port.Write("valveOff");
                }
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                Port.Close();
                disconnectButton.Enabled = false;
                arduinoLabel.ForeColor = Color.DarkRed;
                arduinoLabel.Text = "Arduino desconectado";
            }
        }

        private void humidityButton_Click(object sender, EventArgs e)
        {
            if (humidityButton.Text.Equals("Encender sensores de humedad"))
            {

                if (Port.IsOpen)
                {
                    humidityButton.Text = "Apagar sensores de humedad";
                    Port.Write("humiditySensorOn");
                }
            }
            else
            {
                if (Port.IsOpen)
                {
                    humidityButton.Text = "Encender sensores de humedad";
                    Port.Write("humiditySensorOff");
                }
            }
        }
    }
}
