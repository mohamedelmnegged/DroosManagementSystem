using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DroosManegmentSystem.Forms
{
    
	public partial class employersForm : Form
	{
        private string teacherid;
        public employersForm(string id)
		{
			InitializeComponent();

            this.teacherid = id;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			presence presence = new presence();
			presence.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
			salary salary = new salary();
			salary.Show();
        }

        private void employersForm_Load(object sender, EventArgs e)
        {
            //get all empolyee 
            Connection my = new Connection();
            MySqlDataReader data = my.select("select Name from clerks where Teacher_id = '" + this.teacherid + "'");

            while (data.Read())
            {
                listBox1.Items.Add(data.GetString(0));
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string clerkname = listBox1.SelectedItem.ToString();

            Connection my = new Connection();
            MySqlDataReader data = my.select("select * from clerks where Name = '" + clerkname +"'" );

            while (data.Read())
            {
                textBox2.Text = data.GetString(1);
                textBox3.Text = data.GetString(2);
                textBox4.Text = data.GetString(3);
                textBox5.Text = data.GetString(4);
                textBox6.Text = data.GetString(5);
                textBox7.Text = data.GetString(6);
                textBox8.Text = data.GetString(7);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           //first check from the coming data and then 
        }
    }
}
