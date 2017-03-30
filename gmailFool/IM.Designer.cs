namespace gmailFool
{
    partial class IM
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
            this.userGrp = new System.Windows.Forms.GroupBox();
            this.remoteGrp = new System.Windows.Forms.GroupBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textDestIp = new System.Windows.Forms.TextBox();
            this.textDestPort = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.chatWindow = new System.Windows.Forms.ListBox();
            this.attachFileBtn = new System.Windows.Forms.Button();
            this.sendMsgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.userGrp.SuspendLayout();
            this.remoteGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGrp
            // 
            this.userGrp.Controls.Add(this.label3);
            this.userGrp.Controls.Add(this.label2);
            this.userGrp.Controls.Add(this.textLocalPort);
            this.userGrp.Controls.Add(this.textLocalIp);
            this.userGrp.Location = new System.Drawing.Point(6, 12);
            this.userGrp.Name = "userGrp";
            this.userGrp.Size = new System.Drawing.Size(113, 99);
            this.userGrp.TabIndex = 0;
            this.userGrp.TabStop = false;
            this.userGrp.Text = "Your Details";
            // 
            // remoteGrp
            // 
            this.remoteGrp.Controls.Add(this.label5);
            this.remoteGrp.Controls.Add(this.label4);
            this.remoteGrp.Controls.Add(this.textDestPort);
            this.remoteGrp.Controls.Add(this.textDestIp);
            this.remoteGrp.Location = new System.Drawing.Point(125, 12);
            this.remoteGrp.Name = "remoteGrp";
            this.remoteGrp.Size = new System.Drawing.Size(99, 99);
            this.remoteGrp.TabIndex = 1;
            this.remoteGrp.TabStop = false;
            this.remoteGrp.Text = "Destination";
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(6, 36);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(100, 20);
            this.textLocalIp.TabIndex = 0;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(6, 73);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(100, 20);
            this.textLocalPort.TabIndex = 2;
            // 
            // textDestIp
            // 
            this.textDestIp.Location = new System.Drawing.Point(6, 34);
            this.textDestIp.Name = "textDestIp";
            this.textDestIp.Size = new System.Drawing.Size(87, 20);
            this.textDestIp.TabIndex = 0;
            // 
            // textDestPort
            // 
            this.textDestPort.Location = new System.Drawing.Point(6, 73);
            this.textDestPort.Name = "textDestPort";
            this.textDestPort.Size = new System.Drawing.Size(87, 20);
            this.textDestPort.TabIndex = 1;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(6, 268);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.Size = new System.Drawing.Size(317, 57);
            this.textMessage.TabIndex = 2;
            // 
            // chatWindow
            // 
            this.chatWindow.FormattingEnabled = true;
            this.chatWindow.Location = new System.Drawing.Point(6, 132);
            this.chatWindow.Name = "chatWindow";
            this.chatWindow.Size = new System.Drawing.Size(410, 121);
            this.chatWindow.TabIndex = 3;
            // 
            // attachFileBtn
            // 
            this.attachFileBtn.Enabled = false;
            this.attachFileBtn.Location = new System.Drawing.Point(330, 273);
            this.attachFileBtn.Name = "attachFileBtn";
            this.attachFileBtn.Size = new System.Drawing.Size(86, 23);
            this.attachFileBtn.TabIndex = 4;
            this.attachFileBtn.Text = "Attach File";
            this.attachFileBtn.UseVisualStyleBackColor = true;
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.Enabled = false;
            this.sendMsgBtn.Location = new System.Drawing.Point(330, 302);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(86, 23);
            this.sendMsgBtn.TabIndex = 5;
            this.sendMsgBtn.Text = "Send";
            this.sendMsgBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File Attached";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Port";
            // 
            // connectBtn
            // 
            this.connectBtn.Enabled = false;
            this.connectBtn.Location = new System.Drawing.Point(230, 85);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(186, 25);
            this.connectBtn.TabIndex = 7;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(284, 69);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(81, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status: Inactive";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IM
            // 
            this.ClientSize = new System.Drawing.Size(421, 344);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendMsgBtn);
            this.Controls.Add(this.attachFileBtn);
            this.Controls.Add(this.chatWindow);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.remoteGrp);
            this.Controls.Add(this.userGrp);
            this.Name = "IM";
            this.userGrp.ResumeLayout(false);
            this.userGrp.PerformLayout();
            this.remoteGrp.ResumeLayout(false);
            this.remoteGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox userGrp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.GroupBox remoteGrp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDestPort;
        private System.Windows.Forms.TextBox textDestIp;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox chatWindow;
        private System.Windows.Forms.Button attachFileBtn;
        private System.Windows.Forms.Button sendMsgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label statusLabel;
    }
}

