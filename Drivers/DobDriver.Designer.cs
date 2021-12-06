namespace Drivers
{
    partial class DobDriver
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobDriver));
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label addressLifeLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label jobnameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label passportLabel;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressLifeTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.jobnameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.phoneMtb = new System.Windows.Forms.MaskedTextBox();
            this.photoPic = new System.Windows.Forms.PictureBox();
            this.descriptionRTb = new System.Windows.Forms.RichTextBox();
            this.driversBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.driversBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.attachBtn = new System.Windows.Forms.Button();
            this.namePhotoTb = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            addressLifeLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            jobnameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLb.Location = new System.Drawing.Point(225, 28);
            this.nameLb.Size = new System.Drawing.Size(292, 29);
            this.nameLb.Text = "Добавление водителя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 12);
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(24, 318);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(143, 18);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Адрес регистрации:";
            // 
            // addressLifeLabel
            // 
            addressLifeLabel.AutoSize = true;
            addressLifeLabel.Location = new System.Drawing.Point(25, 355);
            addressLifeLabel.Name = "addressLifeLabel";
            addressLifeLabel.Size = new System.Drawing.Size(142, 18);
            addressLifeLabel.TabIndex = 9;
            addressLifeLabel.Text = "Адрес проживания:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(54, 385);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(113, 18);
            companyLabel.TabIndex = 11;
            companyLabel.Text = "Место работы:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(78, 508);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(89, 18);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Замечания:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(118, 478);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(49, 18);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(142, 105);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(26, 18);
            iDLabel.TabIndex = 17;
            iDLabel.Text = "ID:";
            // 
            // jobnameLabel
            // 
            jobnameLabel.AutoSize = true;
            jobnameLabel.Location = new System.Drawing.Point(74, 418);
            jobnameLabel.Name = "jobnameLabel";
            jobnameLabel.Size = new System.Drawing.Size(93, 18);
            jobnameLabel.TabIndex = 19;
            jobnameLabel.Text = "Должность:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(88, 208);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(79, 18);
            middleNameLabel.TabIndex = 21;
            middleNameLabel.Text = "Отчество:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(126, 178);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(42, 18);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Имя:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(7, 448);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(161, 18);
            phoneLabel.TabIndex = 27;
            phoneLabel.Text = "Мобильный телефон:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(488, 102);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(101, 18);
            photoLabel.TabIndex = 29;
            photoLabel.Text = "Фотография:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(91, 142);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(77, 18);
            surnameLabel.TabIndex = 31;
            surnameLabel.Text = "Фамилия:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(31, 283);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(136, 18);
            postcodeLabel.TabIndex = 42;
            postcodeLabel.Text = "Почтовый индекс:";
            postcodeLabel.Click += new System.EventHandler(this.postcodeLabel_Click);
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(13, 244);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(154, 18);
            passportLabel.TabIndex = 43;
            passportLabel.Text = "Паспортные данные:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(173, 315);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(222, 24);
            this.addressTextBox.TabIndex = 4;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataSource = typeof(Drivers.drivers);
            // 
            // addressLifeTextBox
            // 
            this.addressLifeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "AddressLife", true));
            this.addressLifeTextBox.Location = new System.Drawing.Point(173, 352);
            this.addressLifeTextBox.Name = "addressLifeTextBox";
            this.addressLifeTextBox.Size = new System.Drawing.Size(222, 24);
            this.addressLifeTextBox.TabIndex = 10;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(173, 382);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(261, 24);
            this.companyTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(173, 475);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(227, 24);
            this.emailTextBox.TabIndex = 16;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(173, 102);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(75, 24);
            this.iDTextBox.TabIndex = 18;
            // 
            // jobnameTextBox
            // 
            this.jobnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Jobname", true));
            this.jobnameTextBox.Location = new System.Drawing.Point(173, 415);
            this.jobnameTextBox.Name = "jobnameTextBox";
            this.jobnameTextBox.Size = new System.Drawing.Size(158, 24);
            this.jobnameTextBox.TabIndex = 20;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(173, 205);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(155, 24);
            this.middleNameTextBox.TabIndex = 22;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(173, 175);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(122, 24);
            this.nameTextBox.TabIndex = 24;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(173, 139);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(122, 24);
            this.surnameTextBox.TabIndex = 32;
            // 
            // phoneMtb
            // 
            this.phoneMtb.Location = new System.Drawing.Point(173, 445);
            this.phoneMtb.Name = "phoneMtb";
            this.phoneMtb.Size = new System.Drawing.Size(204, 24);
            this.phoneMtb.TabIndex = 33;
            // 
            // photoPic
            // 
            this.photoPic.Location = new System.Drawing.Point(465, 123);
            this.photoPic.Name = "photoPic";
            this.photoPic.Size = new System.Drawing.Size(145, 99);
            this.photoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPic.TabIndex = 34;
            this.photoPic.TabStop = false;
            // 
            // descriptionRTb
            // 
            this.descriptionRTb.Location = new System.Drawing.Point(173, 505);
            this.descriptionRTb.Name = "descriptionRTb";
            this.descriptionRTb.Size = new System.Drawing.Size(243, 25);
            this.descriptionRTb.TabIndex = 35;
            this.descriptionRTb.Text = "";
            // 
            // driversBindingSource1
            // 
            this.driversBindingSource1.DataSource = typeof(Drivers.drivers);
            // 
            // driversBindingSource2
            // 
            this.driversBindingSource2.DataSource = typeof(Drivers.drivers);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.saveBtn.Location = new System.Drawing.Point(327, 557);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 30);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.exitBtn.Location = new System.Drawing.Point(230, 557);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(91, 30);
            this.exitBtn.TabIndex = 39;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // attachBtn
            // 
            this.attachBtn.BackColor = System.Drawing.Color.White;
            this.attachBtn.Location = new System.Drawing.Point(465, 256);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(145, 48);
            this.attachBtn.TabIndex = 40;
            this.attachBtn.Text = "Прикрепить фотографию";
            this.attachBtn.UseVisualStyleBackColor = false;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // namePhotoTb
            // 
            this.namePhotoTb.Location = new System.Drawing.Point(465, 228);
            this.namePhotoTb.Name = "namePhotoTb";
            this.namePhotoTb.ReadOnly = true;
            this.namePhotoTb.Size = new System.Drawing.Size(145, 24);
            this.namePhotoTb.TabIndex = 42;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(173, 280);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(188, 24);
            this.postcodeTextBox.TabIndex = 43;
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(173, 241);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(155, 24);
            this.passportTextBox.TabIndex = 44;
            // 
            // DobDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(646, 599);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(this.namePhotoTb);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.descriptionRTb);
            this.Controls.Add(this.photoPic);
            this.Controls.Add(this.phoneMtb);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(addressLifeLabel);
            this.Controls.Add(this.addressLifeTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(jobnameLabel);
            this.Controls.Add(this.jobnameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(photoLabel);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Name = "DobDriver";
            this.Text = "Добавление водителя";
            this.Load += new System.EventHandler(this.AddChangeDriver_Load);
            this.Controls.SetChildIndex(this.nameLb, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.surnameTextBox, 0);
            this.Controls.SetChildIndex(surnameLabel, 0);
            this.Controls.SetChildIndex(photoLabel, 0);
            this.Controls.SetChildIndex(phoneLabel, 0);
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(nameLabel, 0);
            this.Controls.SetChildIndex(this.middleNameTextBox, 0);
            this.Controls.SetChildIndex(middleNameLabel, 0);
            this.Controls.SetChildIndex(this.jobnameTextBox, 0);
            this.Controls.SetChildIndex(jobnameLabel, 0);
            this.Controls.SetChildIndex(this.iDTextBox, 0);
            this.Controls.SetChildIndex(iDLabel, 0);
            this.Controls.SetChildIndex(this.emailTextBox, 0);
            this.Controls.SetChildIndex(emailLabel, 0);
            this.Controls.SetChildIndex(descriptionLabel, 0);
            this.Controls.SetChildIndex(this.companyTextBox, 0);
            this.Controls.SetChildIndex(companyLabel, 0);
            this.Controls.SetChildIndex(this.addressLifeTextBox, 0);
            this.Controls.SetChildIndex(addressLifeLabel, 0);
            this.Controls.SetChildIndex(this.addressTextBox, 0);
            this.Controls.SetChildIndex(addressLabel, 0);
            this.Controls.SetChildIndex(this.phoneMtb, 0);
            this.Controls.SetChildIndex(this.photoPic, 0);
            this.Controls.SetChildIndex(this.descriptionRTb, 0);
            this.Controls.SetChildIndex(this.saveBtn, 0);
            this.Controls.SetChildIndex(this.exitBtn, 0);
            this.Controls.SetChildIndex(this.attachBtn, 0);
            this.Controls.SetChildIndex(this.namePhotoTb, 0);
            this.Controls.SetChildIndex(this.postcodeTextBox, 0);
            this.Controls.SetChildIndex(postcodeLabel, 0);
            this.Controls.SetChildIndex(this.passportTextBox, 0);
            this.Controls.SetChildIndex(passportLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource driversBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox addressLifeTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox jobnameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMtb;
        private System.Windows.Forms.PictureBox photoPic;
        private System.Windows.Forms.RichTextBox descriptionRTb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button attachBtn;
        private System.Windows.Forms.BindingSource driversBindingSource1;
        private System.Windows.Forms.BindingSource driversBindingSource2;
        private System.Windows.Forms.TextBox namePhotoTb;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
    }
}