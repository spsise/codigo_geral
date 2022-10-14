
namespace UI.Forms.Messages
{
    partial class FormMessageV2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblMessage = new System.Windows.Forms.Label();
            this.PictureBoxCenter = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.TxtBoxPassword);
            this.panel1.Controls.Add(this.BtnOk);
            this.panel1.Controls.Add(this.LblMessage);
            this.panel1.Controls.Add(this.PictureBoxCenter);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 246);
            this.panel1.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::UI.Properties.Resources.exit_icon1;
            this.BtnClose.Location = new System.Drawing.Point(656, 7);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(29, 27);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 13;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtBoxPassword.Location = new System.Drawing.Point(415, 292);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.PasswordChar = '*';
            this.TxtBoxPassword.Size = new System.Drawing.Size(193, 19);
            this.TxtBoxPassword.TabIndex = 1;
            // 
            // BtnOk
            // 
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtnOk.Location = new System.Drawing.Point(271, 187);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(156, 34);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblMessage
            // 
            this.LblMessage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblMessage.Location = new System.Drawing.Point(58, 107);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(581, 72);
            this.LblMessage.TabIndex = 3;
            this.LblMessage.Text = "Message";
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxCenter
            // 
            this.PictureBoxCenter.Image = global::UI.Properties.Resources.vote_icon;
            this.PictureBoxCenter.Location = new System.Drawing.Point(276, 12);
            this.PictureBoxCenter.Name = "PictureBoxCenter";
            this.PictureBoxCenter.Size = new System.Drawing.Size(140, 88);
            this.PictureBoxCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxCenter.TabIndex = 8;
            this.PictureBoxCenter.TabStop = false;
            // 
            // FormMessageV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(691, 264);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMessageV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.PictureBox PictureBoxCenter;
        private System.Windows.Forms.PictureBox BtnClose;
    }
}