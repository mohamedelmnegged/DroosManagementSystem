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
	public partial class mainPageForm : Form
	{
		private string teacherid;
		public mainPageForm(string id)
		{
			InitializeComponent();
			this.teacherid = id;
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
			//this show time and date  
			string time = DateTime.Now.ToString("hh:mm:ss");
			string date = DateTime.Now.ToString("dddd , MMM dd yyyy"); 
			Hours.Text = time;
			label1.Text = date;
        }

        private void mainPageForm_Load(object sender, EventArgs e)
        {
			//this to call timer function when load form
			timer1_Tick(sender, e);
        }

        
    }
}
