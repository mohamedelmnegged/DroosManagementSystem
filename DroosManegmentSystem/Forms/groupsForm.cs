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
	public partial class groupsForm : Form
	{
        private string teacherid;
		public groupsForm(string id)
		{
			InitializeComponent();
            this.teacherid = id;
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupsForm_Load(object sender, EventArgs e)
        {
            Connection my = new Connection();
            MySqlDataReader data = my.select("SELECT classes.ID, classes.Name FROM `classes` join `teachers` on teachers.ID = classes.Teacher_id where teachers.ID = '" + this.teacherid + "'");
            while (data.Read())
            { 
                
                listBox1.Items.Add( data.GetString(1)); 
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string className = listBox1.SelectedItem.ToString();
            Connection my = new Connection();
            MySqlDataReader data = my.select("select * from classes where Name = '" + className + "' and Teacher_id = '" + this.teacherid + "'");
            while (data.Read())
            {
                textBox9.Text = data.GetString(1);
                textBox10.Text = data.GetString(4); 
                textBox11.Text = data.GetString(5).ToString(); 
            }

            MySqlDataReader students = my.select("select  s.ID,s.FullName   from classes c join students s on s.Class_id = c.ID where c.Teacher_id = '" + this.teacherid + "' and c.Name = '" + className + "'");
            while (students.Read())
            {
                dataGridView1.Rows.Add(students.GetString(0), students.GetString(1)); 
                
                
            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
