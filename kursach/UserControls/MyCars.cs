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
    public partial class MyCars : UserControl
    {
        public event EventHandler SelectChangeCar;
        public event EventHandler SelectAddCar;
        
        public MyCars()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            
        }

        public void SetDataSource(List <Cars> Cars)
        {
            this.dataGridView1.DataSource = Cars;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            SelectAddCar(this, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectChangeCar(this, e);
        }
    }
}
