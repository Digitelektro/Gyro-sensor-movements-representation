namespace Gyro
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
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxPitch = new System.Windows.Forms.TextBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.trackBarRoll = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dxGyro1 = new Gyro.DXGyro();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarPitch
            // 
            this.trackBarPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarPitch.Location = new System.Drawing.Point(56, 439);
            this.trackBarPitch.Maximum = 360;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.Size = new System.Drawing.Size(218, 45);
            this.trackBarPitch.TabIndex = 1;
            this.trackBarPitch.Scroll += new System.EventHandler(this.trackBarPitch_Scroll);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxPitch
            // 
            this.textBoxPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPitch.Location = new System.Drawing.Point(313, 439);
            this.textBoxPitch.Name = "textBoxPitch";
            this.textBoxPitch.Size = new System.Drawing.Size(100, 20);
            this.textBoxPitch.TabIndex = 6;
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenSerial.Location = new System.Drawing.Point(286, 29);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSerial.TabIndex = 7;
            this.btnOpenSerial.Text = "Open";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(151, 29);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(86, 21);
            this.comboBoxPorts.TabIndex = 8;
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRoll.Location = new System.Drawing.Point(313, 484);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoll.TabIndex = 9;
            // 
            // trackBarRoll
            // 
            this.trackBarRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarRoll.Location = new System.Drawing.Point(55, 484);
            this.trackBarRoll.Maximum = 360;
            this.trackBarRoll.Name = "trackBarRoll";
            this.trackBarRoll.Size = new System.Drawing.Size(219, 45);
            this.trackBarRoll.TabIndex = 11;
            this.trackBarRoll.Scroll += new System.EventHandler(this.trackBarRoll_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxPorts);
            this.groupBox1.Controls.Add(this.btnOpenSerial);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ports:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxPitch);
            this.groupBox2.Controls.Add(this.textBoxRoll);
            this.groupBox2.Controls.Add(this.trackBarRoll);
            this.groupBox2.Controls.Add(this.dxGyro1);
            this.groupBox2.Controls.Add(this.trackBarPitch);
            this.groupBox2.Location = new System.Drawing.Point(33, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 563);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Roll:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pitch:";
            // 
            // dxGyro1
            // 
            this.dxGyro1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dxGyro1.CubeColor = System.Drawing.Color.DodgerBlue;
            this.dxGyro1.Location = new System.Drawing.Point(6, 19);
            this.dxGyro1.Name = "dxGyro1";
            this.dxGyro1.Pitch = 0;
            this.dxGyro1.Roll = 0;
            this.dxGyro1.Size = new System.Drawing.Size(472, 380);
            this.dxGyro1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(569, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gyro";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarPitch;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxPitch;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.TextBox textBoxRoll;
        private System.Windows.Forms.TrackBar trackBarRoll;
        private DXGyro dxGyro1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

