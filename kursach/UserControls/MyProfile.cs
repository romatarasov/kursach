using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using parkingmodels;

namespace kursach.UserControls
{
    public partial class MyProfile : UserControl
    {
        public event EventHandler Change;
        public MyProfile()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
              

        }

        public void bind (CarsOwner carsOwner)
        {

            textBox1.Text = carsOwner.Fio;
            textBox2.Text = carsOwner.Number.ToString();
            textBox3.Text = carsOwner.DrivingLicense.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Change(this, e);
        }
        public string FIO => this.textBox1.Text;
        public int NumberPhone => int.Parse(this.textBox2.Text);
        public int DrivingLicense => int.Parse(this.textBox3.Text);
    }
}
