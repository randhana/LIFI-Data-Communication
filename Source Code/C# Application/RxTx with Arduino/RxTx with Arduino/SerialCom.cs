using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Text;

namespace RxTx_with_Arduino
{
    public partial class SerialCom : Form
    {
        string serialDataIn;  //To get serial data 
        bool waitForEnd = false;
        
        public SerialCom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SerialCom_Load(object sender, EventArgs e)
        {

            buttonOPEN.Enabled = true;
            button_CLOSE.Enabled = false;
            button_SEND.Enabled = false;
            progressBar_STATUSbar.Value = 0;
            labelSTATUS.Text = "Disconnected";
            labelSTATUS.ForeColor = Color.Red;

            comboBox_BAUD_RATE.Text = "9600";
            string[] portLists = SerialPort.GetPortNames();
            comboBox_COM_PORT.Items.AddRange(portLists);



        }

        private void buttonOPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_COM_PORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_BAUD_RATE.Text);
                serialPort1.Open();

                buttonOPEN.Enabled = false;
                button_CLOSE.Enabled = true;
                button_SEND.Enabled = true;
                progressBar_STATUSbar.Value = 100;
                labelSTATUS.Text = "CONNECTED";
                labelSTATUS.ForeColor = Color.Green;

                comboBox_BAUD_RATE.Text= "9600";


                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button_CLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    buttonOPEN.Enabled = true;
                    button_CLOSE.Enabled = false;
                    button_SEND.Enabled = false;
                    progressBar_STATUSbar.Value = 0;
                    labelSTATUS.Text = "Disconnected";
                    richTextBox_Txt_Receiver.Text = "";
                    labelSTATUS.ForeColor = Color.Red;

                    comboBox_BAUD_RATE.Text = "9600";

                    sending_Status.Text = "Ready";
                    sending_Status.ForeColor = Color.Gray;
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void SerialCom_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void SerialCom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void button_SEND_Click(object sender, EventArgs e)
        {
            try
            {
                
                

                if (waitForEnd == true)
                {
                    button_SEND.Enabled = false;

                    MessageBox.Show("Please Wait!"+serialDataIn+"\n"+waitForEnd);
                }
                else
                {
                    if (textBox_Txt_Send.Text != "")
                    {
                        serialPort1.Write(textBox_Txt_Send.Text);
                        //richTextBox_Txt_Receiver.Text += "Me: ";
                        richTextBox_Txt_Receiver.Text += "";


                        textBox_Txt_Send.Text = "";
                        sending_Status.Text = "Message is sending...";
                        sending_Status.ForeColor = Color.Black;
                        button_SEND.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                    }

                    
                }

                
                
                

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadExisting();


            
            this.Invoke(new EventHandler(ShowData));
            


        }

        private void ShowData(object sender, EventArgs e)

        {

           

            if (sending_Status.Text == "Message is sending...")
            {
                sendingStatus();
            }
            if (sending_Status.Text == "Ready")
            {
                receivingStatusAsync();
               

            }




            

            richTextBox_Txt_Receiver.Text += serialDataIn;
        }
        private async void sendingStatus()
        {

            if (serialDataIn.Contains('\n'))
            {
                
                button_SEND.Enabled = true;
                sending_Status.Text = "Message Sent";
                //richTextBox_Txt_Receiver.Text += "\n";
                sending_Status.ForeColor = Color.Black;
                await Task.Delay(2000);
                sending_Status.Text = "Ready";
                sending_Status.ForeColor = Color.Black;

                waitForEnd = false;


               

            }


        }

        private async Task receivingStatusAsync()
        {
            if (serialDataIn == "\n")
            {
                
                button_SEND.Enabled = true;
                sending_Status.Text = "Message Received";
                
                sending_Status.ForeColor = Color.Black;
               await Task.Delay(2000);
                sending_Status.Text = "Ready";
                sending_Status.ForeColor = Color.Black;

                waitForEnd = false;





            }



        }

        private void richTextBox_Txt_Receiver_TextChanged(object sender, EventArgs e)
        {
            richTextBox_Txt_Receiver.SelectionStart = richTextBox_Txt_Receiver.Text.Length;
            richTextBox_Txt_Receiver.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox_Txt_Receiver.Text = "";
        }

        private void textBox_Txt_Send_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                button_SEND_Click(sender, e);
            }
        }
    }
}
