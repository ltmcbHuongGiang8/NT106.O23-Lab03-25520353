namespace thuudp
{
    partial class UDPServer
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
            this.ListenButton = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListenButton
            // 
            this.ListenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ListenButton.Location = new System.Drawing.Point(617, 45);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(139, 84);
            this.ListenButton.TabIndex = 0;
            this.ListenButton.Text = "Listen";
            this.ListenButton.UseVisualStyleBackColor = false;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(46, 45);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(484, 353);
            this.tb2.TabIndex = 1;
            // 
            // UDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.ListenButton);
            this.Name = "UDPServer";
            this.Text = "UDPServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.TextBox tb2;
    }
}