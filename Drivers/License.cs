using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drivers
{
    public partial class License : Drivers.BasicForm
    {
        Model1 db = new Model1();
        public static Licences drivers { get; set; }
        public License()
        {
            InitializeComponent();
        }

        private void License_Load(object sender, EventArgs e)
        {
            licencesBindingSource.DataSource = db.Licences.ToList();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            CartDriver pmf = new CartDriver();
            pmf.Show();
            Hide();
        }
    }
}
