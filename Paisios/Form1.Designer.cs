namespace Paisios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.chkDSR = new System.Windows.Forms.CheckBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.chkCTS = new System.Windows.Forms.CheckBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.chkDTR = new System.Windows.Forms.CheckBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send_6 = new System.Windows.Forms.Button();
            this.txtSendData_6 = new System.Windows.Forms.TextBox();
            this.grpbx_Send_Data = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_iterations6 = new System.Windows.Forms.TextBox();
            this.txtbx_delay6 = new System.Windows.Forms.TextBox();
            this.txtbx_iterations5 = new System.Windows.Forms.TextBox();
            this.txtbx_delay5 = new System.Windows.Forms.TextBox();
            this.txtbx_iterations4 = new System.Windows.Forms.TextBox();
            this.txtbx_delay4 = new System.Windows.Forms.TextBox();
            this.txtbx_iterations3 = new System.Windows.Forms.TextBox();
            this.txtbx_delay3 = new System.Windows.Forms.TextBox();
            this.txtbx_iterations2 = new System.Windows.Forms.TextBox();
            this.txtbx_delay2 = new System.Windows.Forms.TextBox();
            this.txtbx_iterations1 = new System.Windows.Forms.TextBox();
            this.txtbx_delay1 = new System.Windows.Forms.TextBox();
            this.btn_clr1 = new System.Windows.Forms.Button();
            this.btn_clr2 = new System.Windows.Forms.Button();
            this.btn_clr3 = new System.Windows.Forms.Button();
            this.btn_clr4 = new System.Windows.Forms.Button();
            this.btn_clr5 = new System.Windows.Forms.Button();
            this.btn_clr6 = new System.Windows.Forms.Button();
            this.btn_Send_1 = new System.Windows.Forms.Button();
            this.txtSendData_1 = new System.Windows.Forms.TextBox();
            this.btn_Send_2 = new System.Windows.Forms.Button();
            this.txtSendData_2 = new System.Windows.Forms.TextBox();
            this.btn_Send_3 = new System.Windows.Forms.Button();
            this.txtSendData_3 = new System.Windows.Forms.TextBox();
            this.btn_Send_4 = new System.Windows.Forms.Button();
            this.txtSendData_4 = new System.Windows.Forms.TextBox();
            this.btn_Send_5 = new System.Windows.Forms.Button();
            this.txtSendData_5 = new System.Windows.Forms.TextBox();
            this.rchtxtbx_output = new System.Windows.Forms.RichTextBox();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.chkbx_log = new System.Windows.Forms.CheckBox();
            this.chckbx_timestamp = new System.Windows.Forms.CheckBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.tmrCheckComPorts = new System.Windows.Forms.Timer(this.components);
            this.grpbx_send_file = new System.Windows.Forms.GroupBox();
            this.txtbx_times_file = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_times_line = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_delay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_send_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpbx_seq = new System.Windows.Forms.GroupBox();
            this.btn_seq_help = new System.Windows.Forms.Button();
            this.btn_run_seq = new System.Windows.Forms.Button();
            this.rchtxtbx_run_seq = new System.Windows.Forms.RichTextBox();
            this.chkbx_show_data = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbPortSettings.SuspendLayout();
            this.grpbx_Send_Data.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.grpbx_send_file.SuspendLayout();
            this.grpbx_seq.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Controls.Add(this.chkCD);
            this.gbPortSettings.Controls.Add(this.chkRTS);
            this.gbPortSettings.Controls.Add(this.chkDSR);
            this.gbPortSettings.Controls.Add(this.btnOpenPort);
            this.gbPortSettings.Controls.Add(this.chkCTS);
            this.gbPortSettings.Controls.Add(this.cmbPortName);
            this.gbPortSettings.Controls.Add(this.cmbBaudRate);
            this.gbPortSettings.Controls.Add(this.cmbStopBits);
            this.gbPortSettings.Controls.Add(this.chkDTR);
            this.gbPortSettings.Controls.Add(this.cmbParity);
            this.gbPortSettings.Controls.Add(this.cmbDataBits);
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.lblStopBits);
            this.gbPortSettings.Controls.Add(this.lblBaudRate);
            this.gbPortSettings.Controls.Add(this.lblDataBits);
            this.gbPortSettings.Controls.Add(this.label1);
            this.gbPortSettings.Location = new System.Drawing.Point(10, 11);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(148, 262);
            this.gbPortSettings.TabIndex = 5;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "RS232 Port Settings";
            // 
            // chkCD
            // 
            this.chkCD.AutoSize = true;
            this.chkCD.Enabled = false;
            this.chkCD.Location = new System.Drawing.Point(98, 178);
            this.chkCD.Name = "chkCD";
            this.chkCD.Size = new System.Drawing.Size(41, 17);
            this.chkCD.TabIndex = 14;
            this.chkCD.Text = "CD";
            this.chkCD.UseVisualStyleBackColor = true;
            // 
            // chkRTS
            // 
            this.chkRTS.AutoSize = true;
            this.chkRTS.Location = new System.Drawing.Point(98, 107);
            this.chkRTS.Name = "chkRTS";
            this.chkRTS.Size = new System.Drawing.Size(48, 17);
            this.chkRTS.TabIndex = 11;
            this.chkRTS.Text = "RTS";
            this.chkRTS.UseVisualStyleBackColor = true;
            this.chkRTS.CheckedChanged += new System.EventHandler(this.chkRTS_CheckedChanged);
            // 
            // chkDSR
            // 
            this.chkDSR.AutoSize = true;
            this.chkDSR.Enabled = false;
            this.chkDSR.Location = new System.Drawing.Point(98, 154);
            this.chkDSR.Name = "chkDSR";
            this.chkDSR.Size = new System.Drawing.Size(49, 17);
            this.chkDSR.TabIndex = 13;
            this.chkDSR.Text = "DSR";
            this.chkDSR.UseVisualStyleBackColor = true;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(10, 228);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPort.TabIndex = 10;
            this.btnOpenPort.Text = "&Open Port";
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // chkCTS
            // 
            this.chkCTS.AutoSize = true;
            this.chkCTS.Enabled = false;
            this.chkCTS.Location = new System.Drawing.Point(98, 131);
            this.chkCTS.Name = "chkCTS";
            this.chkCTS.Size = new System.Drawing.Size(47, 17);
            this.chkCTS.TabIndex = 12;
            this.chkCTS.Text = "CTS";
            this.chkCTS.UseVisualStyleBackColor = true;
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPortName.Location = new System.Drawing.Point(13, 35);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(67, 21);
            this.cmbPortName.TabIndex = 10;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600",
            "1000000"});
            this.cmbBaudRate.Location = new System.Drawing.Point(13, 76);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(69, 21);
            this.cmbBaudRate.TabIndex = 3;
            this.cmbBaudRate.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBaudRate_Validating);
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits.Location = new System.Drawing.Point(13, 196);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(65, 21);
            this.cmbStopBits.TabIndex = 9;
            // 
            // chkDTR
            // 
            this.chkDTR.AutoSize = true;
            this.chkDTR.Location = new System.Drawing.Point(98, 84);
            this.chkDTR.Name = "chkDTR";
            this.chkDTR.Size = new System.Drawing.Size(49, 17);
            this.chkDTR.TabIndex = 10;
            this.chkDTR.Text = "DTR";
            this.chkDTR.UseVisualStyleBackColor = true;
            this.chkDTR.CheckedChanged += new System.EventHandler(this.chkDTR_CheckedChanged);
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(13, 116);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(60, 21);
            this.cmbParity.TabIndex = 5;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits.Location = new System.Drawing.Point(13, 156);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(60, 21);
            this.cmbDataBits.TabIndex = 7;
            this.cmbDataBits.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDataBits_Validating);
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(10, 19);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(56, 13);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(14, 179);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(52, 13);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "Stop Bits:";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(10, 59);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(61, 13);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(10, 139);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(53, 13);
            this.lblDataBits.TabIndex = 6;
            this.lblDataBits.Text = "Data Bits:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parity:";
            // 
            // btn_Send_6
            // 
            this.btn_Send_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send_6.Location = new System.Drawing.Point(591, 161);
            this.btn_Send_6.Name = "btn_Send_6";
            this.btn_Send_6.Size = new System.Drawing.Size(43, 23);
            this.btn_Send_6.TabIndex = 8;
            this.btn_Send_6.Text = "Send";
            this.btn_Send_6.Click += new System.EventHandler(this.btn_Send_6_Click);
            // 
            // txtSendData_6
            // 
            this.txtSendData_6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData_6.Location = new System.Drawing.Point(73, 163);
            this.txtSendData_6.Name = "txtSendData_6";
            this.txtSendData_6.Size = new System.Drawing.Size(512, 20);
            this.txtSendData_6.TabIndex = 7;
            this.txtSendData_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_6_KeyDown);
            this.txtSendData_6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_6_KeyPress);
            // 
            // grpbx_Send_Data
            // 
            this.grpbx_Send_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_Send_Data.Controls.Add(this.label13);
            this.grpbx_Send_Data.Controls.Add(this.label12);
            this.grpbx_Send_Data.Controls.Add(this.label11);
            this.grpbx_Send_Data.Controls.Add(this.label10);
            this.grpbx_Send_Data.Controls.Add(this.label9);
            this.grpbx_Send_Data.Controls.Add(this.label8);
            this.grpbx_Send_Data.Controls.Add(this.label6);
            this.grpbx_Send_Data.Controls.Add(this.label4);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_iterations6);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_delay6);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_iterations5);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_delay5);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_iterations4);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_delay4);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_iterations3);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_delay3);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_iterations2);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_delay2);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_iterations1);
            this.grpbx_Send_Data.Controls.Add(this.txtbx_delay1);
            this.grpbx_Send_Data.Controls.Add(this.btn_clr1);
            this.grpbx_Send_Data.Controls.Add(this.btn_clr2);
            this.grpbx_Send_Data.Controls.Add(this.btn_clr3);
            this.grpbx_Send_Data.Controls.Add(this.btn_clr4);
            this.grpbx_Send_Data.Controls.Add(this.btn_clr5);
            this.grpbx_Send_Data.Controls.Add(this.btn_clr6);
            this.grpbx_Send_Data.Controls.Add(this.btn_Send_1);
            this.grpbx_Send_Data.Controls.Add(this.txtSendData_1);
            this.grpbx_Send_Data.Controls.Add(this.btn_Send_2);
            this.grpbx_Send_Data.Controls.Add(this.txtSendData_2);
            this.grpbx_Send_Data.Controls.Add(this.btn_Send_3);
            this.grpbx_Send_Data.Controls.Add(this.txtSendData_3);
            this.grpbx_Send_Data.Controls.Add(this.btn_Send_4);
            this.grpbx_Send_Data.Controls.Add(this.txtSendData_4);
            this.grpbx_Send_Data.Controls.Add(this.btn_Send_5);
            this.grpbx_Send_Data.Controls.Add(this.txtSendData_5);
            this.grpbx_Send_Data.Controls.Add(this.btn_Send_6);
            this.grpbx_Send_Data.Controls.Add(this.txtSendData_6);
            this.grpbx_Send_Data.Location = new System.Drawing.Point(166, 12);
            this.grpbx_Send_Data.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx_Send_Data.Name = "grpbx_Send_Data";
            this.grpbx_Send_Data.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx_Send_Data.Size = new System.Drawing.Size(745, 191);
            this.grpbx_Send_Data.TabIndex = 9;
            this.grpbx_Send_Data.TabStop = false;
            this.grpbx_Send_Data.Text = "Data Arena";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Iterations";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Delay ms";
            // 
            // txtbx_iterations6
            // 
            this.txtbx_iterations6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_iterations6.Location = new System.Drawing.Point(686, 165);
            this.txtbx_iterations6.MaxLength = 8;
            this.txtbx_iterations6.Name = "txtbx_iterations6";
            this.txtbx_iterations6.Size = new System.Drawing.Size(53, 20);
            this.txtbx_iterations6.TabIndex = 35;
            this.txtbx_iterations6.Text = "1";
            // 
            // txtbx_delay6
            // 
            this.txtbx_delay6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_delay6.Location = new System.Drawing.Point(639, 165);
            this.txtbx_delay6.MaxLength = 6;
            this.txtbx_delay6.Name = "txtbx_delay6";
            this.txtbx_delay6.Size = new System.Drawing.Size(41, 20);
            this.txtbx_delay6.TabIndex = 34;
            this.txtbx_delay6.Text = "1";
            // 
            // txtbx_iterations5
            // 
            this.txtbx_iterations5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_iterations5.Location = new System.Drawing.Point(686, 138);
            this.txtbx_iterations5.MaxLength = 8;
            this.txtbx_iterations5.Name = "txtbx_iterations5";
            this.txtbx_iterations5.Size = new System.Drawing.Size(53, 20);
            this.txtbx_iterations5.TabIndex = 33;
            this.txtbx_iterations5.Text = "1";
            // 
            // txtbx_delay5
            // 
            this.txtbx_delay5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_delay5.Location = new System.Drawing.Point(639, 138);
            this.txtbx_delay5.MaxLength = 6;
            this.txtbx_delay5.Name = "txtbx_delay5";
            this.txtbx_delay5.Size = new System.Drawing.Size(41, 20);
            this.txtbx_delay5.TabIndex = 32;
            this.txtbx_delay5.Text = "1";
            // 
            // txtbx_iterations4
            // 
            this.txtbx_iterations4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_iterations4.Location = new System.Drawing.Point(686, 112);
            this.txtbx_iterations4.MaxLength = 8;
            this.txtbx_iterations4.Name = "txtbx_iterations4";
            this.txtbx_iterations4.Size = new System.Drawing.Size(53, 20);
            this.txtbx_iterations4.TabIndex = 31;
            this.txtbx_iterations4.Text = "1";
            // 
            // txtbx_delay4
            // 
            this.txtbx_delay4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_delay4.Location = new System.Drawing.Point(639, 112);
            this.txtbx_delay4.MaxLength = 6;
            this.txtbx_delay4.Name = "txtbx_delay4";
            this.txtbx_delay4.Size = new System.Drawing.Size(41, 20);
            this.txtbx_delay4.TabIndex = 30;
            this.txtbx_delay4.Text = "1";
            // 
            // txtbx_iterations3
            // 
            this.txtbx_iterations3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_iterations3.Location = new System.Drawing.Point(686, 86);
            this.txtbx_iterations3.MaxLength = 8;
            this.txtbx_iterations3.Name = "txtbx_iterations3";
            this.txtbx_iterations3.Size = new System.Drawing.Size(53, 20);
            this.txtbx_iterations3.TabIndex = 29;
            this.txtbx_iterations3.Text = "1";
            // 
            // txtbx_delay3
            // 
            this.txtbx_delay3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_delay3.Location = new System.Drawing.Point(639, 86);
            this.txtbx_delay3.MaxLength = 6;
            this.txtbx_delay3.Name = "txtbx_delay3";
            this.txtbx_delay3.Size = new System.Drawing.Size(41, 20);
            this.txtbx_delay3.TabIndex = 28;
            this.txtbx_delay3.Text = "1";
            // 
            // txtbx_iterations2
            // 
            this.txtbx_iterations2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_iterations2.Location = new System.Drawing.Point(686, 60);
            this.txtbx_iterations2.MaxLength = 8;
            this.txtbx_iterations2.Name = "txtbx_iterations2";
            this.txtbx_iterations2.Size = new System.Drawing.Size(53, 20);
            this.txtbx_iterations2.TabIndex = 27;
            this.txtbx_iterations2.Text = "1";
            // 
            // txtbx_delay2
            // 
            this.txtbx_delay2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_delay2.Location = new System.Drawing.Point(639, 60);
            this.txtbx_delay2.MaxLength = 6;
            this.txtbx_delay2.Name = "txtbx_delay2";
            this.txtbx_delay2.Size = new System.Drawing.Size(41, 20);
            this.txtbx_delay2.TabIndex = 26;
            this.txtbx_delay2.Text = "1";
            // 
            // txtbx_iterations1
            // 
            this.txtbx_iterations1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_iterations1.Location = new System.Drawing.Point(685, 30);
            this.txtbx_iterations1.MaxLength = 8;
            this.txtbx_iterations1.Name = "txtbx_iterations1";
            this.txtbx_iterations1.Size = new System.Drawing.Size(53, 20);
            this.txtbx_iterations1.TabIndex = 25;
            this.txtbx_iterations1.Text = "1";
            // 
            // txtbx_delay1
            // 
            this.txtbx_delay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_delay1.Location = new System.Drawing.Point(639, 32);
            this.txtbx_delay1.MaxLength = 6;
            this.txtbx_delay1.Name = "txtbx_delay1";
            this.txtbx_delay1.Size = new System.Drawing.Size(41, 20);
            this.txtbx_delay1.TabIndex = 24;
            this.txtbx_delay1.Text = "1";
            // 
            // btn_clr1
            // 
            this.btn_clr1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clr1.Location = new System.Drawing.Point(5, 30);
            this.btn_clr1.Name = "btn_clr1";
            this.btn_clr1.Size = new System.Drawing.Size(43, 23);
            this.btn_clr1.TabIndex = 24;
            this.btn_clr1.Text = "Clear";
            this.btn_clr1.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr2
            // 
            this.btn_clr2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clr2.Location = new System.Drawing.Point(5, 56);
            this.btn_clr2.Name = "btn_clr2";
            this.btn_clr2.Size = new System.Drawing.Size(43, 23);
            this.btn_clr2.TabIndex = 23;
            this.btn_clr2.Text = "Clear";
            this.btn_clr2.Click += new System.EventHandler(this.btn_clr2_Click);
            // 
            // btn_clr3
            // 
            this.btn_clr3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clr3.Location = new System.Drawing.Point(5, 82);
            this.btn_clr3.Name = "btn_clr3";
            this.btn_clr3.Size = new System.Drawing.Size(43, 23);
            this.btn_clr3.TabIndex = 22;
            this.btn_clr3.Text = "Clear";
            this.btn_clr3.Click += new System.EventHandler(this.btn_clr3_Click);
            // 
            // btn_clr4
            // 
            this.btn_clr4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clr4.Location = new System.Drawing.Point(5, 108);
            this.btn_clr4.Name = "btn_clr4";
            this.btn_clr4.Size = new System.Drawing.Size(43, 23);
            this.btn_clr4.TabIndex = 21;
            this.btn_clr4.Text = "Clear";
            this.btn_clr4.Click += new System.EventHandler(this.btn_clr4_Click);
            // 
            // btn_clr5
            // 
            this.btn_clr5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clr5.Location = new System.Drawing.Point(5, 134);
            this.btn_clr5.Name = "btn_clr5";
            this.btn_clr5.Size = new System.Drawing.Size(43, 23);
            this.btn_clr5.TabIndex = 20;
            this.btn_clr5.Text = "Clear";
            this.btn_clr5.Click += new System.EventHandler(this.btn_clr5_Click);
            // 
            // btn_clr6
            // 
            this.btn_clr6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clr6.Location = new System.Drawing.Point(5, 161);
            this.btn_clr6.Name = "btn_clr6";
            this.btn_clr6.Size = new System.Drawing.Size(43, 23);
            this.btn_clr6.TabIndex = 19;
            this.btn_clr6.Text = "Clear";
            this.btn_clr6.Click += new System.EventHandler(this.btn_clr6_Click);
            // 
            // btn_Send_1
            // 
            this.btn_Send_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send_1.Location = new System.Drawing.Point(591, 30);
            this.btn_Send_1.Name = "btn_Send_1";
            this.btn_Send_1.Size = new System.Drawing.Size(43, 23);
            this.btn_Send_1.TabIndex = 18;
            this.btn_Send_1.Text = "Send";
            this.btn_Send_1.Click += new System.EventHandler(this.btn_Send_1_Click);
            // 
            // txtSendData_1
            // 
            this.txtSendData_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData_1.Location = new System.Drawing.Point(73, 32);
            this.txtSendData_1.Name = "txtSendData_1";
            this.txtSendData_1.Size = new System.Drawing.Size(512, 20);
            this.txtSendData_1.TabIndex = 17;
            this.txtSendData_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_1_KeyDown);
            this.txtSendData_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_1_KeyPress);
            // 
            // btn_Send_2
            // 
            this.btn_Send_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send_2.Location = new System.Drawing.Point(591, 56);
            this.btn_Send_2.Name = "btn_Send_2";
            this.btn_Send_2.Size = new System.Drawing.Size(43, 23);
            this.btn_Send_2.TabIndex = 16;
            this.btn_Send_2.Text = "Send";
            this.btn_Send_2.Click += new System.EventHandler(this.btn_Send_2_Click);
            // 
            // txtSendData_2
            // 
            this.txtSendData_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData_2.Location = new System.Drawing.Point(73, 58);
            this.txtSendData_2.Name = "txtSendData_2";
            this.txtSendData_2.Size = new System.Drawing.Size(512, 20);
            this.txtSendData_2.TabIndex = 15;
            this.txtSendData_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_2_KeyDown);
            this.txtSendData_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_2_KeyPress);
            // 
            // btn_Send_3
            // 
            this.btn_Send_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send_3.Location = new System.Drawing.Point(591, 82);
            this.btn_Send_3.Name = "btn_Send_3";
            this.btn_Send_3.Size = new System.Drawing.Size(43, 23);
            this.btn_Send_3.TabIndex = 14;
            this.btn_Send_3.Text = "Send";
            this.btn_Send_3.Click += new System.EventHandler(this.btn_Send_3_Click);
            // 
            // txtSendData_3
            // 
            this.txtSendData_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData_3.Location = new System.Drawing.Point(73, 84);
            this.txtSendData_3.Name = "txtSendData_3";
            this.txtSendData_3.Size = new System.Drawing.Size(512, 20);
            this.txtSendData_3.TabIndex = 13;
            this.txtSendData_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_3_KeyDown);
            this.txtSendData_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_3_KeyPress);
            // 
            // btn_Send_4
            // 
            this.btn_Send_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send_4.Location = new System.Drawing.Point(591, 108);
            this.btn_Send_4.Name = "btn_Send_4";
            this.btn_Send_4.Size = new System.Drawing.Size(43, 23);
            this.btn_Send_4.TabIndex = 12;
            this.btn_Send_4.Text = "Send";
            this.btn_Send_4.Click += new System.EventHandler(this.btn_Send_4_Click);
            // 
            // txtSendData_4
            // 
            this.txtSendData_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData_4.Location = new System.Drawing.Point(73, 110);
            this.txtSendData_4.Name = "txtSendData_4";
            this.txtSendData_4.Size = new System.Drawing.Size(512, 20);
            this.txtSendData_4.TabIndex = 11;
            this.txtSendData_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_4_KeyDown);
            this.txtSendData_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_4_KeyPress);
            // 
            // btn_Send_5
            // 
            this.btn_Send_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send_5.Location = new System.Drawing.Point(591, 134);
            this.btn_Send_5.Name = "btn_Send_5";
            this.btn_Send_5.Size = new System.Drawing.Size(43, 23);
            this.btn_Send_5.TabIndex = 10;
            this.btn_Send_5.Text = "Send";
            this.btn_Send_5.Click += new System.EventHandler(this.btn_Send_5_Click);
            // 
            // txtSendData_5
            // 
            this.txtSendData_5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData_5.Location = new System.Drawing.Point(73, 136);
            this.txtSendData_5.Name = "txtSendData_5";
            this.txtSendData_5.Size = new System.Drawing.Size(512, 20);
            this.txtSendData_5.TabIndex = 9;
            this.txtSendData_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_5_KeyDown);
            this.txtSendData_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_5_KeyPress);
            // 
            // rchtxtbx_output
            // 
            this.rchtxtbx_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchtxtbx_output.Location = new System.Drawing.Point(166, 208);
            this.rchtxtbx_output.Name = "rchtxtbx_output";
            this.rchtxtbx_output.Size = new System.Drawing.Size(747, 398);
            this.rchtxtbx_output.TabIndex = 1;
            this.rchtxtbx_output.Text = "";
            this.rchtxtbx_output.WordWrap = false;
            this.rchtxtbx_output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rchtxtbx_output_MouseUp);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbText);
            this.gbMode.Controls.Add(this.rbHex);
            this.gbMode.Location = new System.Drawing.Point(10, 282);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(148, 43);
            this.gbMode.TabIndex = 11;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Data &Mode";
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(12, 19);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 0;
            this.rbText.Text = "Text";
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(80, 19);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(44, 17);
            this.rbHex.TabIndex = 1;
            this.rbHex.Text = "Hex";
            this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Location = new System.Drawing.Point(786, 615);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(60, 21);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(852, 615);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(60, 21);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(721, 615);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(60, 21);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chkbx_log
            // 
            this.chkbx_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbx_log.AutoSize = true;
            this.chkbx_log.Location = new System.Drawing.Point(261, 622);
            this.chkbx_log.Margin = new System.Windows.Forms.Padding(2);
            this.chkbx_log.Name = "chkbx_log";
            this.chkbx_log.Size = new System.Drawing.Size(44, 17);
            this.chkbx_log.TabIndex = 15;
            this.chkbx_log.Text = "Log";
            this.chkbx_log.UseVisualStyleBackColor = true;
            this.chkbx_log.CheckedChanged += new System.EventHandler(this.chkbx_log_CheckedChanged);
            // 
            // chckbx_timestamp
            // 
            this.chckbx_timestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chckbx_timestamp.AutoSize = true;
            this.chckbx_timestamp.Location = new System.Drawing.Point(306, 623);
            this.chckbx_timestamp.Margin = new System.Windows.Forms.Padding(2);
            this.chckbx_timestamp.Name = "chckbx_timestamp";
            this.chckbx_timestamp.Size = new System.Drawing.Size(77, 17);
            this.chckbx_timestamp.TabIndex = 16;
            this.chckbx_timestamp.Text = "Timestamp";
            this.chckbx_timestamp.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_help.Location = new System.Drawing.Point(172, 620);
            this.btn_help.Margin = new System.Windows.Forms.Padding(2);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(60, 21);
            this.btn_help.TabIndex = 17;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // tmrCheckComPorts
            // 
            this.tmrCheckComPorts.Enabled = true;
            this.tmrCheckComPorts.Interval = 500;
            this.tmrCheckComPorts.Tick += new System.EventHandler(this.tmrCheckComPorts_Tick);
            // 
            // grpbx_send_file
            // 
            this.grpbx_send_file.Controls.Add(this.txtbx_times_file);
            this.grpbx_send_file.Controls.Add(this.label7);
            this.grpbx_send_file.Controls.Add(this.txtbx_times_line);
            this.grpbx_send_file.Controls.Add(this.label5);
            this.grpbx_send_file.Controls.Add(this.label3);
            this.grpbx_send_file.Controls.Add(this.txtbx_delay);
            this.grpbx_send_file.Controls.Add(this.label2);
            this.grpbx_send_file.Controls.Add(this.btn_send_file);
            this.grpbx_send_file.Location = new System.Drawing.Point(10, 331);
            this.grpbx_send_file.Name = "grpbx_send_file";
            this.grpbx_send_file.Size = new System.Drawing.Size(147, 178);
            this.grpbx_send_file.TabIndex = 18;
            this.grpbx_send_file.TabStop = false;
            this.grpbx_send_file.Text = "Send File";
            // 
            // txtbx_times_file
            // 
            this.txtbx_times_file.Location = new System.Drawing.Point(21, 119);
            this.txtbx_times_file.Name = "txtbx_times_file";
            this.txtbx_times_file.Size = new System.Drawing.Size(101, 20);
            this.txtbx_times_file.TabIndex = 23;
            this.txtbx_times_file.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Iterations of file";
            // 
            // txtbx_times_line
            // 
            this.txtbx_times_line.Location = new System.Drawing.Point(21, 77);
            this.txtbx_times_line.Name = "txtbx_times_line";
            this.txtbx_times_line.Size = new System.Drawing.Size(101, 20);
            this.txtbx_times_line.TabIndex = 20;
            this.txtbx_times_line.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Iterations of each lines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ms";
            // 
            // txtbx_delay
            // 
            this.txtbx_delay.Location = new System.Drawing.Point(21, 32);
            this.txtbx_delay.Name = "txtbx_delay";
            this.txtbx_delay.Size = new System.Drawing.Size(90, 20);
            this.txtbx_delay.TabIndex = 17;
            this.txtbx_delay.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Delay between lines";
            // 
            // btn_send_file
            // 
            this.btn_send_file.Location = new System.Drawing.Point(36, 145);
            this.btn_send_file.Name = "btn_send_file";
            this.btn_send_file.Size = new System.Drawing.Size(75, 23);
            this.btn_send_file.TabIndex = 15;
            this.btn_send_file.Text = "&Send File";
            this.btn_send_file.Click += new System.EventHandler(this.btn_send_file_Click);
            // 
            // grpbx_seq
            // 
            this.grpbx_seq.Controls.Add(this.btn_seq_help);
            this.grpbx_seq.Controls.Add(this.btn_run_seq);
            this.grpbx_seq.Controls.Add(this.rchtxtbx_run_seq);
            this.grpbx_seq.Location = new System.Drawing.Point(12, 514);
            this.grpbx_seq.Name = "grpbx_seq";
            this.grpbx_seq.Size = new System.Drawing.Size(144, 124);
            this.grpbx_seq.TabIndex = 19;
            this.grpbx_seq.TabStop = false;
            this.grpbx_seq.Text = "Run Sequence";
            // 
            // btn_seq_help
            // 
            this.btn_seq_help.Location = new System.Drawing.Point(79, 20);
            this.btn_seq_help.Name = "btn_seq_help";
            this.btn_seq_help.Size = new System.Drawing.Size(59, 21);
            this.btn_seq_help.TabIndex = 2;
            this.btn_seq_help.Text = "?";
            this.btn_seq_help.UseVisualStyleBackColor = true;
            this.btn_seq_help.Click += new System.EventHandler(this.btn_seq_help_Click);
            // 
            // btn_run_seq
            // 
            this.btn_run_seq.Location = new System.Drawing.Point(79, 97);
            this.btn_run_seq.Name = "btn_run_seq";
            this.btn_run_seq.Size = new System.Drawing.Size(59, 21);
            this.btn_run_seq.TabIndex = 1;
            this.btn_run_seq.Text = "Run";
            this.btn_run_seq.UseVisualStyleBackColor = true;
            this.btn_run_seq.Click += new System.EventHandler(this.btn_run_seq_Click);
            // 
            // rchtxtbx_run_seq
            // 
            this.rchtxtbx_run_seq.Location = new System.Drawing.Point(7, 20);
            this.rchtxtbx_run_seq.Name = "rchtxtbx_run_seq";
            this.rchtxtbx_run_seq.Size = new System.Drawing.Size(65, 98);
            this.rchtxtbx_run_seq.TabIndex = 0;
            this.rchtxtbx_run_seq.Text = "";
            // 
            // chkbx_show_data
            // 
            this.chkbx_show_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbx_show_data.AutoSize = true;
            this.chkbx_show_data.Checked = true;
            this.chkbx_show_data.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_show_data.Location = new System.Drawing.Point(387, 624);
            this.chkbx_show_data.Margin = new System.Windows.Forms.Padding(2);
            this.chkbx_show_data.Name = "chkbx_show_data";
            this.chkbx_show_data.Size = new System.Drawing.Size(79, 17);
            this.chkbx_show_data.TabIndex = 20;
            this.chkbx_show_data.Text = "Show Data";
            this.chkbx_show_data.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 650);
            this.Controls.Add(this.chkbx_show_data);
            this.Controls.Add(this.grpbx_seq);
            this.Controls.Add(this.grpbx_send_file);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.chckbx_timestamp);
            this.Controls.Add(this.chkbx_log);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.rchtxtbx_output);
            this.Controls.Add(this.grpbx_Send_Data);
            this.Controls.Add(this.gbPortSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(943, 689);
            this.Name = "Form1";
            this.Text = "Paisios - Patron Saint of Signalmen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.grpbx_Send_Data.ResumeLayout(false);
            this.grpbx_Send_Data.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.grpbx_send_file.ResumeLayout(false);
            this.grpbx_send_file.PerformLayout();
            this.grpbx_seq.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gbPortSettings;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Send_6;
        private System.Windows.Forms.TextBox txtSendData_6;
        private System.Windows.Forms.GroupBox grpbx_Send_Data;
        private System.Windows.Forms.CheckBox chkCD;
        private System.Windows.Forms.CheckBox chkRTS;
        private System.Windows.Forms.CheckBox chkDSR;
        private System.Windows.Forms.CheckBox chkCTS;
        private System.Windows.Forms.CheckBox chkDTR;
        private System.Windows.Forms.RichTextBox rchtxtbx_output;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox chkbx_log;
        private System.Windows.Forms.CheckBox chckbx_timestamp;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Timer tmrCheckComPorts;
        private System.Windows.Forms.GroupBox grpbx_send_file;
        private System.Windows.Forms.Button btn_send_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtbx_times_file;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_times_line;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Send_1;
        private System.Windows.Forms.TextBox txtSendData_1;
        private System.Windows.Forms.Button btn_Send_2;
        private System.Windows.Forms.TextBox txtSendData_2;
        private System.Windows.Forms.Button btn_Send_3;
        private System.Windows.Forms.TextBox txtSendData_3;
        private System.Windows.Forms.Button btn_Send_4;
        private System.Windows.Forms.TextBox txtSendData_4;
        private System.Windows.Forms.Button btn_Send_5;
        private System.Windows.Forms.TextBox txtSendData_5;
        private System.Windows.Forms.Button btn_clr1;
        private System.Windows.Forms.Button btn_clr2;
        private System.Windows.Forms.Button btn_clr3;
        private System.Windows.Forms.Button btn_clr4;
        private System.Windows.Forms.Button btn_clr5;
        private System.Windows.Forms.Button btn_clr6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_iterations6;
        private System.Windows.Forms.TextBox txtbx_delay6;
        private System.Windows.Forms.TextBox txtbx_iterations5;
        private System.Windows.Forms.TextBox txtbx_delay5;
        private System.Windows.Forms.TextBox txtbx_iterations4;
        private System.Windows.Forms.TextBox txtbx_delay4;
        private System.Windows.Forms.TextBox txtbx_iterations3;
        private System.Windows.Forms.TextBox txtbx_delay3;
        private System.Windows.Forms.TextBox txtbx_iterations2;
        private System.Windows.Forms.TextBox txtbx_delay2;
        private System.Windows.Forms.TextBox txtbx_iterations1;
        private System.Windows.Forms.TextBox txtbx_delay1;
        private System.Windows.Forms.GroupBox grpbx_seq;
        private System.Windows.Forms.Button btn_seq_help;
        private System.Windows.Forms.Button btn_run_seq;
        private System.Windows.Forms.RichTextBox rchtxtbx_run_seq;
        private System.Windows.Forms.CheckBox chkbx_show_data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

