namespace ReceiverUI
{
    partial class ReceiverUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this._COMInput = new System.Windows.Forms.TextBox();
            this._connectionStatus = new System.Windows.Forms.Label();
            this._frequency = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._volume = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._msgLbl = new System.Windows.Forms.Label();
            this._onOffBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.msgTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._volume)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnConnectBtnClicked);
            // 
            // _COMInput
            // 
            this._COMInput.Location = new System.Drawing.Point(109, 13);
            this._COMInput.Name = "_COMInput";
            this._COMInput.Size = new System.Drawing.Size(56, 22);
            this._COMInput.TabIndex = 1;
            this._COMInput.Text = "COM11";
            // 
            // _connectionStatus
            // 
            this._connectionStatus.AutoSize = true;
            this._connectionStatus.Location = new System.Drawing.Point(171, 16);
            this._connectionStatus.Name = "_connectionStatus";
            this._connectionStatus.Size = new System.Drawing.Size(114, 16);
            this._connectionStatus.TabIndex = 2;
            this._connectionStatus.Text = "Connection Status";
            // 
            // _frequency
            // 
            this._frequency.DecimalPlaces = 2;
            this._frequency.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this._frequency.Location = new System.Drawing.Point(104, 47);
            this._frequency.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this._frequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._frequency.Name = "_frequency";
            this._frequency.Size = new System.Drawing.Size(68, 22);
            this._frequency.TabIndex = 3;
            this._frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._frequency.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this._frequency.Value = new decimal(new int[] {
            1023,
            0,
            0,
            65536});
            this._frequency.ValueChanged += new System.EventHandler(this.OnFrequencyChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "MHz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Volume";
            // 
            // _volume
            // 
            this._volume.Location = new System.Drawing.Point(104, 75);
            this._volume.Name = "_volume";
            this._volume.Size = new System.Drawing.Size(68, 22);
            this._volume.TabIndex = 8;
            this._volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._volume.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this._volume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._volume.ValueChanged += new System.EventHandler(this.OnVolumeChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "%";
            // 
            // _msgLbl
            // 
            this._msgLbl.AutoSize = true;
            this._msgLbl.Location = new System.Drawing.Point(27, 149);
            this._msgLbl.Name = "_msgLbl";
            this._msgLbl.Size = new System.Drawing.Size(64, 16);
            this._msgLbl.TabIndex = 10;
            this._msgLbl.Text = "Message";
            // 
            // _onOffBtn
            // 
            this._onOffBtn.Location = new System.Drawing.Point(28, 112);
            this._onOffBtn.Name = "_onOffBtn";
            this._onOffBtn.Size = new System.Drawing.Size(75, 23);
            this._onOffBtn.TabIndex = 11;
            this._onOffBtn.Text = "Turn On";
            this._onOffBtn.UseVisualStyleBackColor = true;
            this._onOffBtn.Click += new System.EventHandler(this.OnOnOffBtnClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 113);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Off";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msgTimer
            // 
            this.msgTimer.Interval = 1000;
            this.msgTimer.Tick += new System.EventHandler(this.OnMsgTimer);
            // 
            // ReceiverUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._onOffBtn);
            this.Controls.Add(this._msgLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._volume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._frequency);
            this.Controls.Add(this._connectionStatus);
            this.Controls.Add(this._COMInput);
            this.Controls.Add(this.button1);
            this.Name = "ReceiverUI";
            this.Text = "ReceiverUI";
            ((System.ComponentModel.ISupportInitialize)(this._frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _COMInput;
        private System.Windows.Forms.Label _connectionStatus;
        private System.Windows.Forms.NumericUpDown _frequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _volume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _msgLbl;
        private System.Windows.Forms.Button _onOffBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer msgTimer;
    }
}

