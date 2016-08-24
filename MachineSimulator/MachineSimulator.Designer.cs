namespace MachineSimulator
{
    partial class MachineSimulator
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
            this.label3 = new System.Windows.Forms.Label();
            this.MachinePortTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MachineIPText = new System.Windows.Forms.TextBox();
            this.BeginListenButton = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.RichTextBox();
            this.lbOnline = new System.Windows.Forms.ListBox();
            this.StartToTestCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Machine Port";
            // 
            // MachinePortTextBox
            // 
            this.MachinePortTextBox.Location = new System.Drawing.Point(223, 74);
            this.MachinePortTextBox.Name = "MachinePortTextBox";
            this.MachinePortTextBox.Size = new System.Drawing.Size(100, 20);
            this.MachinePortTextBox.TabIndex = 1;
            this.MachinePortTextBox.Text = "30000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Machine IP";
            // 
            // MachineIPText
            // 
            this.MachineIPText.Location = new System.Drawing.Point(223, 28);
            this.MachineIPText.Name = "MachineIPText";
            this.MachineIPText.Size = new System.Drawing.Size(100, 20);
            this.MachineIPText.TabIndex = 1;
            this.MachineIPText.Text = "172.26.203.39";
            // 
            // BeginListenButton
            // 
            this.BeginListenButton.Location = new System.Drawing.Point(561, 74);
            this.BeginListenButton.Name = "BeginListenButton";
            this.BeginListenButton.Size = new System.Drawing.Size(75, 44);
            this.BeginListenButton.TabIndex = 2;
            this.BeginListenButton.Text = "Server";
            this.BeginListenButton.UseVisualStyleBackColor = true;
            this.BeginListenButton.Click += new System.EventHandler(this.BeginListenButton_Click);
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(143, 136);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(384, 222);
            this.ResultText.TabIndex = 3;
            this.ResultText.Text = "";
            // 
            // lbOnline
            // 
            this.lbOnline.FormattingEnabled = true;
            this.lbOnline.Location = new System.Drawing.Point(548, 177);
            this.lbOnline.Name = "lbOnline";
            this.lbOnline.Size = new System.Drawing.Size(120, 95);
            this.lbOnline.TabIndex = 4;
            // 
            // StartToTestCheckBox
            // 
            this.StartToTestCheckBox.AutoSize = true;
            this.StartToTestCheckBox.Location = new System.Drawing.Point(561, 136);
            this.StartToTestCheckBox.Name = "StartToTestCheckBox";
            this.StartToTestCheckBox.Size = new System.Drawing.Size(80, 17);
            this.StartToTestCheckBox.TabIndex = 5;
            this.StartToTestCheckBox.Text = "checkBox1";
            this.StartToTestCheckBox.UseVisualStyleBackColor = true;
            this.StartToTestCheckBox.CheckedChanged += new System.EventHandler(this.StartToTestCheckBox_CheckedChanged);
            // 
            // MachineSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 398);
            this.Controls.Add(this.StartToTestCheckBox);
            this.Controls.Add(this.lbOnline);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.BeginListenButton);
            this.Controls.Add(this.MachineIPText);
            this.Controls.Add(this.MachinePortTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "MachineSimulator";
            this.Text = "Machine Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MachinePortTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MachineIPText;
        private System.Windows.Forms.Button BeginListenButton;
        private System.Windows.Forms.RichTextBox ResultText;
        private System.Windows.Forms.ListBox lbOnline;
        private System.Windows.Forms.CheckBox StartToTestCheckBox;
    }
}

