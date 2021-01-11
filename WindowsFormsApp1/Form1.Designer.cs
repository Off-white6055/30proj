
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginPanel = new System.Windows.Forms.TextBox();
            this.PassPanel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SignInButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicMess = new System.Windows.Forms.PictureBox();
            this.PicPass = new System.Windows.Forms.PictureBox();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.textsup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPanel.Font = new System.Drawing.Font("Arial", 20F);
            this.LoginPanel.HideSelection = false;
            this.LoginPanel.Location = new System.Drawing.Point(98, 175);
            this.LoginPanel.MaxLength = 16;
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(331, 39);
            this.LoginPanel.TabIndex = 3;
            this.LoginPanel.TabStop = false;
            this.LoginPanel.Text = "Login";
            this.LoginPanel.MouseEnter += new System.EventHandler(this.LoginPanel_MouseEnter);
            this.LoginPanel.MouseLeave += new System.EventHandler(this.LoginPanel_MouseLeave);
            // 
            // PassPanel
            // 
            this.PassPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PassPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassPanel.Font = new System.Drawing.Font("Arial", 20F);
            this.PassPanel.HideSelection = false;
            this.PassPanel.Location = new System.Drawing.Point(102, 268);
            this.PassPanel.MaxLength = 16;
            this.PassPanel.Name = "PassPanel";
            this.PassPanel.Size = new System.Drawing.Size(331, 39);
            this.PassPanel.TabIndex = 4;
            this.PassPanel.TabStop = false;
            this.PassPanel.Text = "Password";
            this.PassPanel.MouseEnter += new System.EventHandler(this.PassPanel_MouseEnter);
            this.PassPanel.MouseLeave += new System.EventHandler(this.PassPanel_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(28, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(28, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 1);
            this.panel2.TabIndex = 6;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.ForeColor = System.Drawing.Color.Black;
            this.SignInButton.Location = new System.Drawing.Point(96, 366);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(259, 46);
            this.SignInButton.TabIndex = 7;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Close;
            this.pictureBox2.Location = new System.Drawing.Point(414, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.minus_icon;
            this.pictureBox1.Location = new System.Drawing.Point(376, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PicMess
            // 
            this.PicMess.Image = global::WindowsFormsApp1.Properties.Resources.message;
            this.PicMess.Location = new System.Drawing.Point(113, 12);
            this.PicMess.Name = "PicMess";
            this.PicMess.Size = new System.Drawing.Size(128, 128);
            this.PicMess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicMess.TabIndex = 2;
            this.PicMess.TabStop = false;
            this.PicMess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicMess_MouseDown);
            this.PicMess.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicMess_MouseMove);
            // 
            // PicPass
            // 
            this.PicPass.Image = global::WindowsFormsApp1.Properties.Resources.pass;
            this.PicPass.Location = new System.Drawing.Point(28, 250);
            this.PicPass.Name = "PicPass";
            this.PicPass.Size = new System.Drawing.Size(64, 64);
            this.PicPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPass.TabIndex = 1;
            this.PicPass.TabStop = false;
            this.PicPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicPass_MouseDown);
            this.PicPass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicPass_MouseMove);
            // 
            // PicUser
            // 
            this.PicUser.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.PicUser.Location = new System.Drawing.Point(28, 159);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(64, 64);
            this.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicUser.TabIndex = 0;
            this.PicUser.TabStop = false;
            this.PicUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicUser_MouseDown);
            this.PicUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicUser_MouseMove);
            // 
            // textsup
            // 
            this.textsup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(190)))));
            this.textsup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textsup.Location = new System.Drawing.Point(279, 429);
            this.textsup.Multiline = true;
            this.textsup.Name = "textsup";
            this.textsup.Size = new System.Drawing.Size(167, 35);
            this.textsup.TabIndex = 24;
            this.textsup.Text = "По вопросам пишите - Techsupport @mail.ru";
            this.textsup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(458, 476);
            this.Controls.Add(this.textsup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PassPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.PicMess);
            this.Controls.Add(this.PicPass);
            this.Controls.Add(this.PicUser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(10, 10);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.PictureBox PicPass;
        private System.Windows.Forms.PictureBox PicMess;
        private System.Windows.Forms.TextBox LoginPanel;
        private System.Windows.Forms.TextBox PassPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textsup;
    }
}

