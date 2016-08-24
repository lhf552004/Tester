namespace Tester
{
    partial class Tester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tester));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.StartButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MachineIPText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.MachinePortText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.InfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ResultText = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Machine IP";
            // 
            // StartButton
            // 
            this.StartButton.Depth = 0;
            this.StartButton.Location = new System.Drawing.Point(481, 86);
            this.StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartButton.Name = "StartButton";
            this.StartButton.Primary = true;
            this.StartButton.Size = new System.Drawing.Size(75, 52);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MachineIPText
            // 
            this.MachineIPText.Depth = 0;
            this.MachineIPText.Hint = "";
            this.MachineIPText.Location = new System.Drawing.Point(139, 16);
            this.MachineIPText.MaxLength = 32767;
            this.MachineIPText.MouseState = MaterialSkin.MouseState.HOVER;
            this.MachineIPText.Name = "MachineIPText";
            this.MachineIPText.PasswordChar = '\0';
            this.MachineIPText.SelectedText = "";
            this.MachineIPText.SelectionLength = 0;
            this.MachineIPText.SelectionStart = 0;
            this.MachineIPText.Size = new System.Drawing.Size(132, 23);
            this.MachineIPText.TabIndex = 2;
            this.MachineIPText.TabStop = false;
            this.MachineIPText.Text = "172.26.203.39";
            this.MachineIPText.UseSystemPasswordChar = false;
            this.MachineIPText.TextChanged += new System.EventHandler(this.MachineIPText_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 55);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Machine Port";
            // 
            // MachinePortText
            // 
            this.MachinePortText.Depth = 0;
            this.MachinePortText.Hint = "";
            this.MachinePortText.Location = new System.Drawing.Point(139, 54);
            this.MachinePortText.MaxLength = 32767;
            this.MachinePortText.MouseState = MaterialSkin.MouseState.HOVER;
            this.MachinePortText.Name = "MachinePortText";
            this.MachinePortText.PasswordChar = '\0';
            this.MachinePortText.SelectedText = "";
            this.MachinePortText.SelectionLength = 0;
            this.MachinePortText.SelectionStart = 0;
            this.MachinePortText.Size = new System.Drawing.Size(132, 23);
            this.MachinePortText.TabIndex = 2;
            this.MachinePortText.TabStop = false;
            this.MachinePortText.Text = "30000";
            this.MachinePortText.UseSystemPasswordChar = false;
            this.MachinePortText.TextChanged += new System.EventHandler(this.MachinePortText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.MachineIPText);
            this.groupBox1.Controls.Add(this.MachinePortText);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Location = new System.Drawing.Point(87, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(87, 232);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Result";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(13, 206);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(594, 13);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = resources.GetString("materialLabel6.Text");
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Depth = 0;
            this.InfoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InfoLabel.Location = new System.Drawing.Point(704, 158);
            this.InfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 19);
            this.InfoLabel.TabIndex = 0;
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(91, 275);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(465, 340);
            this.ResultText.TabIndex = 14;
            this.ResultText.Text = "";
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 652);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.materialLabel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tester";
            this.Text = "MB Tester";
            this.Load += new System.EventHandler(this.Tester_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton StartButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField MachineIPText;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField MachinePortText;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel InfoLabel;
        private System.Windows.Forms.RichTextBox ResultText;
    }
}

