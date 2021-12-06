using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers
{
    public partial class DobDriver : Drivers.BasicForm
    {
        public Model1 db { get; set; }
        public drivers drivers { get; set; }

        public DobDriver()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(surnameTextBox.Text == "" || nameTextBox.Text == "" || middleNameTextBox.Text==""
                ||  addressTextBox.Text ==""||addressLifeTextBox.Text==""
                || companyTextBox.Text=="" || jobnameTextBox.Text == "" || phoneMtb.Text == "")
            {
                MessageBox.Show("Внимание! Заполните все поля!", "Ошибка добавления: незаполненные поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(CartDriver.add == true)
            {                
                drivers drivers = new drivers();
                drivers.Surname = surnameTextBox.Text;
                drivers.Name = nameTextBox.Text;
                drivers.Middlename = middleNameTextBox.Text;                
                drivers.Address= addressTextBox.Text;
                drivers.AddressLife = addressLifeTextBox.Text;
                drivers.Company = companyTextBox.Text;
                drivers.Jobname = jobnameTextBox.Text;
                drivers.Phone = phoneMtb.Text;
                drivers.Email = emailTextBox.Text;
                drivers.Description = descriptionRTb.Text;
                if(photoPic.Image == null)
                {
                    drivers.Photo = null;
                }
                else
                {
                    drivers.Photo = namePhotoTb.Text;
                }
                db.drivers.Add(drivers);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Водитель успешно добавлен!", "Успешное добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
            else if (CartDriver.add == false)
            {
                drivers.Id = Convert.ToInt32(iDTextBox.Text);
                drivers.Surname = surnameTextBox.Text;
                drivers.Name = nameTextBox.Text;
                drivers.Middlename = middleNameTextBox.Text;               
                drivers.Address = addressTextBox.Text;               
                drivers.AddressLife = addressLifeTextBox.Text;
                drivers.Company = companyTextBox.Text;
                drivers.Jobname = jobnameTextBox.Text;
                drivers.Phone = phoneMtb.Text;
                drivers.Email = emailTextBox.Text;
                drivers.Description = descriptionRTb.Text;
                if (photoPic.Image == null)
                {
                    drivers.Photo = null;
                }
                else
                {
                    drivers.Photo = namePhotoTb.Text;//хранится название картинок в бд
                }
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Изменения успешно сохранены!", "Успешное добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }

        private void attachBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите фото водителя";
            ofd.Filter = "Файл jpg, png | *.jpg; *.png;";
            ofd.InitialDirectory = @"C:\Users\Пользователь\Documents\!!Стрепеткова и Семенова\!Производственная практика\Drivers\Drivers\Drivers\photo";
            DialogResult dr = ofd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                photoPic.Image = Image.FromFile(ofd.FileName);
                namePhotoTb.Text = ofd.FileName;
            }
        }

        private void AddChangeDriver_Load(object sender, EventArgs e)
        {
            if(CartDriver.add == true)
            {
                nameLb.Text = "Добавление водителя";
                FillComboBox();
            }
            else if(CartDriver.add == false)
            {
                nameLb.Text = "Изменение водителя";
                FillComboBox();
                surnameTextBox.Text = drivers.Surname;
                nameTextBox.Text = drivers.Name;
                middleNameTextBox.Text = drivers.Middlename;           
                addressTextBox.Text = drivers.Address;
                addressLifeTextBox.Text = drivers.AddressLife;
                companyTextBox.Text = drivers.Company;
                jobnameTextBox.Text = drivers.Jobname;
                phoneMtb.Text = drivers.Phone;
                emailTextBox.Text = drivers.Email;
                descriptionRTb.Text = drivers.Description;
                if (drivers.Photo == null)
                {
                    photoPic.Image = null;
                }
                //else
                //{
                //    string s = drivers.Photo.Trim();
                //    //добавляем, чтобы бралось из папки, прописывая путь
                //    string file = @"C:\Users\315\Desktop\Вариант 3\Ресурсы\Сессия 1\drivers 2\photo" + s;
                //    photoPic.Image = Image.FromFile(file);
                //    namePhotoTb.Text = drivers.Photo.Trim();
                //}
            }
        }
        public void FillComboBox()
        {
            //var addressReg = (from p in db.drivers
            //                  select p.AddressCity)
            //                  .Distinct();
            //addressregCmb.DataSource = addressReg.ToList();
            //var addressLife = (from p in db.drivers
            //                  select p.AddressCityLife)
            //      .Distinct();
            //addresslifeCmb.DataSource = addressLife.ToList();
        }

        private void postcodeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
