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
    public partial class Code : Drivers.BasicForm
    {
        public Code()
        {
            InitializeComponent();
        }

        private void PinCode_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            int value1 = rnd.Next(0, 100);
            int value2 = rnd.Next(0, 100);
            int value3 = rnd.Next(0, 100);
            pinCodTb.Text = $"{value}" + $"{value1}" + $"{value2}" + $"{value3}";
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(sendPibTb.Text == "")
            {
                MessageBox.Show("Внимание! Незаполненные поле!", "Пустые поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(pinCodTb.Text != sendPibTb.Text)
                {
                    MessageBox.Show("Пин-код не совпадает!", "Несоответствие пин-кода",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CartDriver vd = new CartDriver();
                    vd.Show();
                    Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
