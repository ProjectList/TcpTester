namespace TcpTester
{
    partial class SimpleTcpTester
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
            this.ipTxt = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portTxt = new System.Windows.Forms.Label();
            this.headerCheckBox = new System.Windows.Forms.CheckBox();
            this.headerLengthTxt = new System.Windows.Forms.Label();
            this.headerLenTextBox = new System.Windows.Forms.TextBox();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.RequestTxt = new System.Windows.Forms.Label();
            this.responseTxt = new System.Windows.Forms.Label();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.encodingTextBox = new System.Windows.Forms.TextBox();
            this.encodingTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipTxt
            // 
            this.ipTxt.AutoSize = true;
            this.ipTxt.Location = new System.Drawing.Point(13, 22);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(23, 12);
            this.ipTxt.TabIndex = 0;
            this.ipTxt.Text = "IP:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(109, 19);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(232, 21);
            this.ipTextBox.TabIndex = 1;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(452, 19);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(61, 21);
            this.portTextBox.TabIndex = 3;
            // 
            // portTxt
            // 
            this.portTxt.AutoSize = true;
            this.portTxt.Location = new System.Drawing.Point(393, 22);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(35, 12);
            this.portTxt.TabIndex = 2;
            this.portTxt.Text = "PORT:";
            // 
            // headerCheckBox
            // 
            this.headerCheckBox.AutoSize = true;
            this.headerCheckBox.Location = new System.Drawing.Point(395, 56);
            this.headerCheckBox.Name = "headerCheckBox";
            this.headerCheckBox.Size = new System.Drawing.Size(78, 16);
            this.headerCheckBox.TabIndex = 4;
            this.headerCheckBox.Text = "AddHeader";
            this.headerCheckBox.UseVisualStyleBackColor = true;
            // 
            // headerLengthTxt
            // 
            this.headerLengthTxt.AutoSize = true;
            this.headerLengthTxt.Location = new System.Drawing.Point(13, 57);
            this.headerLengthTxt.Name = "headerLengthTxt";
            this.headerLengthTxt.Size = new System.Drawing.Size(71, 12);
            this.headerLengthTxt.TabIndex = 5;
            this.headerLengthTxt.Text = "HEADER LEN:";
            // 
            // headerLenTextBox
            // 
            this.headerLenTextBox.Location = new System.Drawing.Point(109, 54);
            this.headerLenTextBox.Name = "headerLenTextBox";
            this.headerLenTextBox.Size = new System.Drawing.Size(55, 21);
            this.headerLenTextBox.TabIndex = 6;
            // 
            // requestTextBox
            // 
            this.requestTextBox.AcceptsReturn = true;
            this.requestTextBox.Location = new System.Drawing.Point(109, 97);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(404, 177);
            this.requestTextBox.TabIndex = 8;
            // 
            // RequestTxt
            // 
            this.RequestTxt.AutoSize = true;
            this.RequestTxt.Location = new System.Drawing.Point(14, 97);
            this.RequestTxt.Name = "RequestTxt";
            this.RequestTxt.Size = new System.Drawing.Size(53, 12);
            this.RequestTxt.TabIndex = 7;
            this.RequestTxt.Text = "REQUEST:";
            // 
            // responseTxt
            // 
            this.responseTxt.AutoSize = true;
            this.responseTxt.Location = new System.Drawing.Point(18, 337);
            this.responseTxt.Name = "responseTxt";
            this.responseTxt.Size = new System.Drawing.Size(59, 12);
            this.responseTxt.TabIndex = 11;
            this.responseTxt.Text = "RESPONSE:";
            // 
            // responseTextBox
            // 
            this.responseTextBox.Location = new System.Drawing.Point(109, 334);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ReadOnly = true;
            this.responseTextBox.Size = new System.Drawing.Size(404, 160);
            this.responseTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // encodingTextBox
            // 
            this.encodingTextBox.Location = new System.Drawing.Point(267, 54);
            this.encodingTextBox.Name = "encodingTextBox";
            this.encodingTextBox.Size = new System.Drawing.Size(74, 21);
            this.encodingTextBox.TabIndex = 13;
            // 
            // encodingTxt
            // 
            this.encodingTxt.AutoSize = true;
            this.encodingTxt.Location = new System.Drawing.Point(202, 58);
            this.encodingTxt.Name = "encodingTxt";
            this.encodingTxt.Size = new System.Drawing.Size(59, 12);
            this.encodingTxt.TabIndex = 12;
            this.encodingTxt.Text = "ENCODING:";
            // 
            // SimpleTcpTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 522);
            this.Controls.Add(this.encodingTextBox);
            this.Controls.Add(this.encodingTxt);
            this.Controls.Add(this.responseTxt);
            this.Controls.Add(this.responseTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.requestTextBox);
            this.Controls.Add(this.RequestTxt);
            this.Controls.Add(this.headerLenTextBox);
            this.Controls.Add(this.headerLengthTxt);
            this.Controls.Add(this.headerCheckBox);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipTxt);
            this.Name = "SimpleTcpTester";
            this.Text = "SimpleTcpTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipTxt;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portTxt;
        private System.Windows.Forms.CheckBox headerCheckBox;
        private System.Windows.Forms.Label headerLengthTxt;
        private System.Windows.Forms.TextBox headerLenTextBox;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Label RequestTxt;
        private System.Windows.Forms.Label responseTxt;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox encodingTextBox;
        private System.Windows.Forms.Label encodingTxt;
    }
}

