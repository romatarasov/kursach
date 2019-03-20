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
    public partial class OnParking : UserControl
    {
        public OnParking()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

        }
        public void bind(Payment payment)
        {

            label3.Text = payment.ArrivalDate.ToString();
            label4.Text = payment.DepartureDate.ToString();
        }
        public void bind(Cars cars)
        {
            label1.Text = cars.CarBrand;
            label2.Text = cars.CarModel;
            listBox1.Items.Add(cars);

        }
        public void bind (Subscription subscription)
        {
            label5.Text = subscription.Duration;
            label6.Text = subscription.Price.ToString();
            label7.Text = subscription.StartDate.ToString();
            label8.Text = subscription.EndDate.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
