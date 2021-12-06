namespace Drivers
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.loginLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.sighInButton = new System.Windows.Forms.Button();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLb.Location = new System.Drawing.Point(235, 27);
            this.nameLb.Size = new System.Drawing.Size(177, 29);
            this.nameLb.Text = "Авторизация";
            this.nameLb.Click += new System.EventHandler(this.nameLb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 12);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(169, 144);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(54, 18);
            this.loginLb.TabIndex = 2;
            this.loginLb.Text = "Логин:";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(169, 174);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(65, 18);
            this.passwordLb.TabIndex = 3;
            this.passwordLb.Text = "Пароль:";
            // 
            // sighInButton
            // 
            this.sighInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.sighInButton.Location = new System.Drawing.Point(229, 275);
            this.sighInButton.Name = "sighInButton";
            this.sighInButton.Size = new System.Drawing.Size(149, 31);
            this.sighInButton.TabIndex = 4;
            this.sighInButton.Text = "Войти";
            this.sighInButton.UseVisualStyleBackColor = false;
            this.sighInButton.Click += new System.EventHandler(this.sighInButton_Click);
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(240, 141);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(174, 24);
            this.loginTb.TabIndex = 5;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(240, 171);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(174, 24);
            this.passwordTb.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.button1.Location = new System.Drawing.Point(229, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выйти из системы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(611, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.sighInButton);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.loginLb);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.Controls.SetChildIndex(this.loginLb, 0);
            this.Controls.SetChildIndex(this.passwordLb, 0);
            this.Controls.SetChildIndex(this.sighInButton, 0);
            this.Controls.SetChildIndex(this.loginTb, 0);
            this.Controls.SetChildIndex(this.passwordTb, 0);
            this.Controls.SetChildIndex(this.nameLb, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Button sighInButton;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Button button1;
    }
}

