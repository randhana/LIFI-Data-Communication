namespace RxTx_with_Arduino
{
    partial class SerialCom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_CLOSE = new System.Windows.Forms.Button();
            this.buttonOPEN = new System.Windows.Forms.Button();
            this.progressBar_STATUSbar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_BAUD_RATE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_COM_PORT = new System.Windows.Forms.ComboBox();
            this.labelSTATUS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Txt_Send = new System.Windows.Forms.TextBox();
            this.richTextBox_Txt_Receiver = new System.Windows.Forms.RichTextBox();
            this.button_SEND = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.sending_Status = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.button_CLOSE);
            this.groupBox1.Controls.Add(this.buttonOPEN);
            this.groupBox1.Controls.Add(this.progressBar_STATUSbar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_BAUD_RATE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_COM_PORT);
            this.groupBox1.Controls.Add(this.labelSTATUS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(273, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "         Serial Com Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_CLOSE
            // 
            this.button_CLOSE.Location = new System.Drawing.Point(141, 213);
            this.button_CLOSE.Margin = new System.Windows.Forms.Padding(4);
            this.button_CLOSE.Name = "button_CLOSE";
            this.button_CLOSE.Size = new System.Drawing.Size(121, 70);
            this.button_CLOSE.TabIndex = 7;
            this.button_CLOSE.Text = "CLOSE";
            this.button_CLOSE.UseVisualStyleBackColor = true;
            this.button_CLOSE.Click += new System.EventHandler(this.button_CLOSE_Click);
            // 
            // buttonOPEN
            // 
            this.buttonOPEN.Location = new System.Drawing.Point(16, 213);
            this.buttonOPEN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOPEN.Name = "buttonOPEN";
            this.buttonOPEN.Size = new System.Drawing.Size(113, 70);
            this.buttonOPEN.TabIndex = 6;
            this.buttonOPEN.Text = "OPEN";
            this.buttonOPEN.UseVisualStyleBackColor = true;
            this.buttonOPEN.Click += new System.EventHandler(this.buttonOPEN_Click);
            // 
            // progressBar_STATUSbar
            // 
            this.progressBar_STATUSbar.Location = new System.Drawing.Point(137, 131);
            this.progressBar_STATUSbar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_STATUSbar.Name = "progressBar_STATUSbar";
            this.progressBar_STATUSbar.Size = new System.Drawing.Size(125, 28);
            this.progressBar_STATUSbar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "     STATUS:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox_BAUD_RATE
            // 
            this.comboBox_BAUD_RATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BAUD_RATE.FormattingEnabled = true;
            this.comboBox_BAUD_RATE.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.comboBox_BAUD_RATE.Location = new System.Drawing.Point(137, 89);
            this.comboBox_BAUD_RATE.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_BAUD_RATE.Name = "comboBox_BAUD_RATE";
            this.comboBox_BAUD_RATE.Size = new System.Drawing.Size(124, 29);
            this.comboBox_BAUD_RATE.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "BAUD RATE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox_COM_PORT
            // 
            this.comboBox_COM_PORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COM_PORT.FormattingEnabled = true;
            this.comboBox_COM_PORT.Location = new System.Drawing.Point(137, 51);
            this.comboBox_COM_PORT.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_COM_PORT.Name = "comboBox_COM_PORT";
            this.comboBox_COM_PORT.Size = new System.Drawing.Size(124, 29);
            this.comboBox_COM_PORT.TabIndex = 1;
            // 
            // labelSTATUS
            // 
            this.labelSTATUS.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTATUS.Location = new System.Drawing.Point(130, 163);
            this.labelSTATUS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSTATUS.Name = "labelSTATUS";
            this.labelSTATUS.Size = new System.Drawing.Size(145, 25);
            this.labelSTATUS.TabIndex = 2;
            this.labelSTATUS.Text = "Disconnected";
            this.labelSTATUS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSTATUS.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = " COM PORT:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Txt_Send
            // 
            this.textBox_Txt_Send.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Txt_Send.Location = new System.Drawing.Point(281, 261);
            this.textBox_Txt_Send.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Txt_Send.Name = "textBox_Txt_Send";
            this.textBox_Txt_Send.Size = new System.Drawing.Size(557, 22);
            this.textBox_Txt_Send.TabIndex = 1;
            this.textBox_Txt_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Txt_Send_KeyDown);
            // 
            // richTextBox_Txt_Receiver
            // 
            this.richTextBox_Txt_Receiver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox_Txt_Receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Txt_Receiver.Location = new System.Drawing.Point(281, 43);
            this.richTextBox_Txt_Receiver.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_Txt_Receiver.Name = "richTextBox_Txt_Receiver";
            this.richTextBox_Txt_Receiver.Size = new System.Drawing.Size(557, 193);
            this.richTextBox_Txt_Receiver.TabIndex = 2;
            this.richTextBox_Txt_Receiver.Text = "";
            this.richTextBox_Txt_Receiver.TextChanged += new System.EventHandler(this.richTextBox_Txt_Receiver_TextChanged);
            // 
            // button_SEND
            // 
            this.button_SEND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SEND.Location = new System.Drawing.Point(845, 254);
            this.button_SEND.Margin = new System.Windows.Forms.Padding(4);
            this.button_SEND.Name = "button_SEND";
            this.button_SEND.Size = new System.Drawing.Size(117, 44);
            this.button_SEND.TabIndex = 3;
            this.button_SEND.Text = "Send";
            this.button_SEND.UseVisualStyleBackColor = true;
            this.button_SEND.Click += new System.EventHandler(this.button_SEND_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(845, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sending_Status
            // 
            this.sending_Status.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sending_Status.Location = new System.Drawing.Point(280, 287);
            this.sending_Status.Name = "sending_Status";
            this.sending_Status.Size = new System.Drawing.Size(252, 23);
            this.sending_Status.TabIndex = 5;
            this.sending_Status.Text = "Ready";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(377, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(412, 28);
            this.Title.TabIndex = 6;
            this.Title.Text = "Li-Fi based Text Communication ";
            // 
            // SerialCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(967, 314);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.sending_Status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_SEND);
            this.Controls.Add(this.richTextBox_Txt_Receiver);
            this.Controls.Add(this.textBox_Txt_Send);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SerialCom";
            this.Text = "Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialCom_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialCom_FormClosed);
            this.Load += new System.EventHandler(this.SerialCom_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_COM_PORT;
        private System.Windows.Forms.Label labelSTATUS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_BAUD_RATE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar_STATUSbar;
        private System.Windows.Forms.Button button_CLOSE;
        private System.Windows.Forms.Button buttonOPEN;
        private System.Windows.Forms.TextBox textBox_Txt_Send;
        private System.Windows.Forms.RichTextBox richTextBox_Txt_Receiver;
        private System.Windows.Forms.Button button_SEND;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sending_Status;
        private System.Windows.Forms.Label Title;
    }
}

