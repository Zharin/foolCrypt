namespace gmailFool
{
    partial class Form2
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
            this.hvad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.generatekeyBtn = new System.Windows.Forms.Button();
            this.savekey_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hvad
            // 
            this.hvad.Location = new System.Drawing.Point(100, 23);
            this.hvad.MaxLength = 8;
            this.hvad.Name = "hvad";
            this.hvad.Size = new System.Drawing.Size(187, 20);
            this.hvad.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Never share your key with someone you dont trust!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter 8 random characters. Save these somewhere safe.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "HELP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // generatekeyBtn
            // 
            this.generatekeyBtn.Location = new System.Drawing.Point(12, 21);
            this.generatekeyBtn.Name = "generatekeyBtn";
            this.generatekeyBtn.Size = new System.Drawing.Size(82, 23);
            this.generatekeyBtn.TabIndex = 6;
            this.generatekeyBtn.Text = "Generate Key";
            this.generatekeyBtn.UseVisualStyleBackColor = true;
            this.generatekeyBtn.Click += new System.EventHandler(this.generatekeyBtn_Click);
            // 
            // savekey_button
            // 
            this.savekey_button.Location = new System.Drawing.Point(293, 62);
            this.savekey_button.Name = "savekey_button";
            this.savekey_button.Size = new System.Drawing.Size(51, 52);
            this.savekey_button.TabIndex = 7;
            this.savekey_button.Text = "LOAD KEY";
            this.savekey_button.UseVisualStyleBackColor = true;
            this.savekey_button.Visible = false;
            this.savekey_button.Click += new System.EventHandler(this.savekey_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 117);
            this.Controls.Add(this.savekey_button);
            this.Controls.Add(this.generatekeyBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hvad);
            this.Name = "Form2";
            this.Text = "File Observation Obligation Loss";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hvad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button generatekeyBtn;
        private System.Windows.Forms.Button savekey_button;
    }
}