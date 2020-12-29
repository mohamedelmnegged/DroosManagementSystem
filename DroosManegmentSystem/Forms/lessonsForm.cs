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
	public partial class lessonsForm : Form
	{
        private string teacherid, classid, lessonid, studentid;  
		public lessonsForm(string id)
		{
			InitializeComponent();
            this.teacherid = id;
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            homework homework = new homework();
            homework.Show();
        }

        private void lessonsForm_Load(object sender, EventArgs e)
        {
            Connection my = new Connection();
            MySqlDataReader data = my.select("select * from classes where Teacher_id = '" + this.teacherid + "'");

            while (data.Read())
            {
                comboBox1.Items.Add(data.GetString(1));
            }

           
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            string studentname = comboBox2.SelectedItem.ToString();

            Connection my = new Connection();

            MySqlDataReader data = my.select("select ID, ParCode  from students where FullName = '" + studentname + "'");
            while (data.Read())
            {
                this.studentid = data.GetString(0);
                textBox3.Text = data.GetString(0);
                textBox15.Text = data.GetString(1);
            }

            //get the lesson id 

           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check from the student  and add the student to attends tabel 

            Connection my = new Connection();

            //first check from the student  if exist or not 
           MySqlDataReader data =  my.select("select * from Students where ID = '" + this.studentid + "'");
            while (data.Read())
            {
                if(data.GetString(0) == this.studentid)
                {
                    bool insert = my.sqlorder("insert into attends values (NULL, " + this.studentid + ", " + this.lessonid + ")");
                    if (insert == true)
                    {
                        comboBox3_SelectedValueChanged(sender, e);
                        
                    }

                } 
            } 
            
            comboBox2.Text = " ";
            textBox3.Text = " ";
            this.studentid = "0";
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        { 
           //this to show the attends students 

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            comboBox2.Items.Clear();
            string classname = comboBox1.SelectedItem.ToString();
            string lessonnumber = comboBox3.Text;
            Connection my = new Connection();
            MySqlDataReader data = my.select("select c.ID, l.date from lessons l join classes c on l.Class_id = c.ID where c.Name = '" + classname+ "'");
            while (data.Read())
            {
                this.classid = data.GetString(0);
                dateTimePicker1.Value = DateTime.Parse( data.GetString(1));
            }
           

            //get the count of the  attends studens 

            Connection my2 = new Connection();
            Connection my4 = new Connection();
            MySqlDataReader attendstudents = my2.select("select s.FullName, s.ID  from attends a join students s on a.Student_id = s.ID join lessons l on a.Lesson_id = l.id join classes c on c.ID = l.Class_id where c.Name = '" + classname + "' and l.Number = '" + lessonnumber+ "'" );
            MySqlDataReader abcensestudent = my4.select("select s.ID, s.FullName from students s join classes c  on s.Class_id = c.ID where c.Name = '" + classname + "'  and s.ID not IN (select Student_id from attends )");
            
           
            //show the attend students 

            while (attendstudents.Read())
            {
                listBox1.Items.Add(attendstudents.GetString(0));
            }
           
            textBox7.Text = listBox1.Items.Count.ToString();

            ////show the abcense students 

            while (abcensestudent.Read())
            {
                listBox2.Items.Add(abcensestudent.GetString(1)); 
                comboBox2.Items.Add(abcensestudent.GetString(1)); 
            }

            textBox8.Text = listBox2.Items.Count.ToString();

            //show the count of all students in the  class 
            textBox2.Text = (listBox2.Items.Count + listBox1.Items.Count).ToString();

            Connection my3 = new Connection();
            MySqlDataReader lessonid = my3.select("select  ID from lessons where Number = '" + comboBox3.SelectedItem.ToString() + "'");

            while (lessonid.Read())
            {
                this.lessonid = lessonid.GetString(0);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            comboBox2.Items.Clear();
            comboBox2.Text = " " ;
            string classname = comboBox1.SelectedItem.ToString();
            comboBox3.Items.Clear();
            comboBox3.Text = " ";
            Connection my = new Connection();

            MySqlDataReader data = my.select("SELECT l.Number, l.date FROM `classes` c join lessons l on c.ID = l.Class_id where c.Name = '" + classname + "'");
            while (data.Read())
            {
                comboBox3.Items.Add(data.GetString(0));
            }
            
        }
    }
}
