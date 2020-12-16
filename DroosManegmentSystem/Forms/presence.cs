using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroosManegmentSystem.Forms
{
    public partial class presence : Form
    {
        public presence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم تسجيل الحضور");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم تسجيل الانصراف");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportEmployee reportEmployee = new reportEmployee();
            reportEmployee.Show();
        }
    }
}
