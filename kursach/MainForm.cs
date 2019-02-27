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
        public MainForm()
        {
            InitializeComponent();
            this.groupBox1.Controls.Add(new UserLoginUC());
        }
    }
}
