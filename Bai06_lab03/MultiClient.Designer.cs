namespace Bai06_lab03
{
    partial class MultiClient
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

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.TextBox txtFriend;
        private System.Windows.Forms.RichTextBox sendMsgTextBox;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnSendIcon;
        private System.Windows.Forms.Button btnSendImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;

        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFriend = new System.Windows.Forms.Label();
            this.txtFriend = new System.Windows.Forms.TextBox();
            this.sendMsgTextBox = new System.Windows.Forms.RichTextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSendIcon = new System.Windows.Forms.Button();
            this.btnSendImage = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LightCoral;
            this.btnConnect.Location = new System.Drawing.Point(587, 54);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 26;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.BackColor = System.Drawing.Color.PeachPuff;
            this.txtServerAddress.Location = new System.Drawing.Point(118, 54);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(100, 22);
            this.txtServerAddress.TabIndex = 25;
            this.txtServerAddress.Text = "127.0.0.1";
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.AutoSize = true;
            this.lblServerAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblServerAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServerAddress.Location = new System.Drawing.Point(10, 58);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(100, 16);
            this.lblServerAddress.TabIndex = 24;
            this.lblServerAddress.Text = "Server address";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Location = new System.Drawing.Point(231, 58);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 27;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.PeachPuff;
            this.txtUsername.Location = new System.Drawing.Point(310, 54);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 28;
            this.txtUsername.Text = "Alice";
            // 
            // lblFriend
            // 
            this.lblFriend.AutoSize = true;
            this.lblFriend.BackColor = System.Drawing.Color.Transparent;
            this.lblFriend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFriend.Location = new System.Drawing.Point(427, 59);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(45, 16);
            this.lblFriend.TabIndex = 29;
            this.lblFriend.Text = "Friend";
            // 
            // txtFriend
            // 
            this.txtFriend.BackColor = System.Drawing.Color.PeachPuff;
            this.txtFriend.Location = new System.Drawing.Point(480, 56);
            this.txtFriend.Name = "txtFriend";
            this.txtFriend.Size = new System.Drawing.Size(100, 22);
            this.txtFriend.TabIndex = 30;
            this.txtFriend.Text = "Bob";
            // 
            // sendMsgTextBox
            // 
            this.sendMsgTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.sendMsgTextBox.Location = new System.Drawing.Point(11, 360);
            this.sendMsgTextBox.Name = "sendMsgTextBox";
            this.sendMsgTextBox.Size = new System.Drawing.Size(644, 96);
            this.sendMsgTextBox.TabIndex = 20;
            this.sendMsgTextBox.Text = "";
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.BackColor = System.Drawing.Color.LightCoral;
            this.btnSendMsg.Location = new System.Drawing.Point(660, 360);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(165, 96);
            this.btnSendMsg.TabIndex = 21;
            this.btnSendMsg.Text = "Send Message";
            this.btnSendMsg.UseVisualStyleBackColor = false;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.BackColor = System.Drawing.Color.LightCoral;
            this.btnSendFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendFile.Location = new System.Drawing.Point(667, 54);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(49, 23);
            this.btnSendFile.TabIndex = 32;
            this.btnSendFile.Text = "File";
            this.btnSendFile.UseVisualStyleBackColor = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSendIcon
            // 
            this.btnSendIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendIcon.Location = new System.Drawing.Point(721, 54);
            this.btnSendIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendIcon.Name = "btnSendIcon";
            this.btnSendIcon.Size = new System.Drawing.Size(45, 22);
            this.btnSendIcon.TabIndex = 33;
            this.btnSendIcon.Text = "Icon";
            this.btnSendIcon.UseVisualStyleBackColor = true;
            // 
            // btnSendImage
            // 
            this.btnSendImage.BackColor = System.Drawing.Color.LightCoral;
            this.btnSendImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendImage.Location = new System.Drawing.Point(772, 54);
            this.btnSendImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendImage.Name = "btnSendImage";
            this.btnSendImage.Size = new System.Drawing.Size(53, 23);
            this.btnSendImage.TabIndex = 34;
            this.btnSendImage.Text = "Hình";
            this.btnSendImage.UseVisualStyleBackColor = false;
            this.btnSendImage.Click += new System.EventHandler(this.btnSendImage_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(814, 270);
            this.flowLayoutPanel1.TabIndex = 31;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(346, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 31);
            this.label5.TabIndex = 35;
            this.label5.Text = "Client";
            // 
            // MultiClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(837, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSendImage);
            this.Controls.Add(this.btnSendIcon);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtFriend);
            this.Controls.Add(this.lblFriend);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.lblServerAddress);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.sendMsgTextBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MultiClient";
            this.Text = "MultiClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

//#endregion
    }
}
