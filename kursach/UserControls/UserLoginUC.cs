using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach.UserControls
{
    public partial class UserLoginUC : UserControl
    {
        public UserLoginUC()
        {
            InitializeComponent();
        }
        public int NumberPhone => int.Parse(this.textBox1.Text);
        public string Password => this.textBox2.Text;
    }
}
