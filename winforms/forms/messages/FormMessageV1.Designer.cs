
namespace UI.Forms.Messages
{
    partial class FormMessageV1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RichTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxCode = new System.Windows.Forms.GroupBox();
            this.TxtCode = new System.Windows.Forms.RichTextBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupBoxCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.GroupBoxCode);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.TxtBoxPassword);
            this.panel1.Controls.Add(this.BtnOk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 497);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RichTextBoxMessage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 143);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // RichTextBoxMessage
            // 
            this.RichTextBoxMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RichTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxMessage.Location = new System.Drawing.Point(18, 19);
            this.RichTextBoxMessage.Name = "RichTextBoxMessage";
            this.RichTextBoxMessage.Size = new System.Drawing.Size(496, 115);
            this.RichTextBoxMessage.TabIndex = 0;
            this.RichTextBoxMessage.Text = "";
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
            this.BtnOk.ForeColor = System.Drawing.Color.LawnGreen;
            this.BtnOk.Location = new System.Drawing.Point(262, 428);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(156, 34);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(178, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Título";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBoxCode
            // 
            this.GroupBoxCode.Controls.Add(this.TxtCode);
            this.GroupBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCode.Location = new System.Drawing.Point(226, 341);
            this.GroupBoxCode.Name = "GroupBoxCode";
            this.GroupBoxCode.Size = new System.Drawing.Size(232, 81);
            this.GroupBoxCode.TabIndex = 15;
            this.GroupBoxCode.TabStop = false;
            this.GroupBoxCode.Text = "Código";
            // 
            // TxtCode
            // 
            this.TxtCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCode.Location = new System.Drawing.Point(13, 19);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(208, 48);
            this.TxtCode.TabIndex = 0;
            this.TxtCode.Text = "";
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::UI.Properties.Resources.btn_close_green;
            this.BtnClose.Location = new System.Drawing.Point(645, 7);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 27);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 13;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.success_tick_icon;
            this.pictureBox2.Location = new System.Drawing.Point(262, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FormMessageV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(698, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMessageV1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.GroupBoxCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RichTextBoxMessage;
        private System.Windows.Forms.GroupBox GroupBoxCode;
        private System.Windows.Forms.RichTextBox TxtCode;
    }
}