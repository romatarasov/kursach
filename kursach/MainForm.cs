using kursach.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{

    public partial class MainForm : Form
    {
        public event EventHandler SelectUser;
        public event EventHandler SelectAdmin;
        public event EventHandler Login;

        public MainForm()
        {
            InitializeComponent();
            this.groupBox1.Controls.Add(new UserLoginUC());
            
    }
   public     void Bind(UserControl control)
        {
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectUser(this, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SelectAdmin(this, e);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Login(this, e);
        }
        public void SetAuthControl(UserControl control)
        {
            this.groupBox1.Controls.Clear();
            this.groupBox1.Controls.Add(control);
        }
    }
}
