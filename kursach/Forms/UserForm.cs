using kursach.UserControls;
using parkingmodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
      public  void bind(CarsOwner carsOwner)
        {
            label2.Text = carsOwner.Fio;
            label1.Text = carsOwner.Balance.ToString();
        }
      public  void bind (OnParking onparking)
        {
            tabControl1.TabPages[0].Controls.Add(onparking);
        }
       public void bind (MyCars mycars)
        {
            tabControl1.TabPages[1].Controls.Add(mycars);

        }
       public void bind (MyProfile myprofile)
        {
            tabControl1.TabPages[2].Controls.Add(myprofile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fillbalance(this ,e);
            
        }
       public event EventHandler Fillbalance;
    }

}
