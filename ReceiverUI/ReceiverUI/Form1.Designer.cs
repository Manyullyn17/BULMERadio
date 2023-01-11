namespace ReceiverUI
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this._COMInput = new System.Windows.Forms.TextBox();
            this._connectionStatus = new System.Windows.Forms.Label();
            this._frequency = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._sendBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._frequency)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 13);
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
            this._connectionStatus.Location = new System.Drawing.Point(172, 19);
            this._connectionStatus.Name = "_connectionStatus";
            this._connectionStatus.Size = new System.Drawing.Size(0, 16);
            this._connectionStatus.TabIndex = 2;
            // 
            // _frequency
            // 
            this._frequency.DecimalPlaces = 2;
            this._frequency.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this._frequency.Location = new System.Drawing.Point(104, 41);
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
            1,
            0,
            0,
            0});
            this._frequency.ValueChanged += new System.EventHandler(this.OnFrequencyChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "MHz";
            // 
            // _sendBox
            // 
            this._sendBox.AutoSize = true;
            this._sendBox.Location = new System.Drawing.Point(179, 14);
            this._sendBox.Name = "_sendBox";
            this._sendBox.Size = new System.Drawing.Size(93, 20);
            this._sendBox.TabIndex = 6;
            this._sendBox.Text = "Acq On/Off";
            this._sendBox.UseVisualStyleBackColor = true;
            this._sendBox.CheckedChanged += new System.EventHandler(this.OnAqcChecked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._sendBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._frequency);
            this.Controls.Add(this._connectionStatus);
            this.Controls.Add(this._COMInput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._frequency)).EndInit();
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
        private System.Windows.Forms.CheckBox _sendBox;
    }
}

