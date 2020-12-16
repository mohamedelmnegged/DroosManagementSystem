using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using DroosManegmentSystem.Forms;
using MySql.Data.MySqlClient;

namespace DroosManegmentSystem.Forms
{
	public partial class studentsForm : Form
	{ 
        private string teacherid;
		public studentsForm(string id)
		{
			InitializeComponent();
            this.teacherid = id;
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void studentsForm_Load(object sender, EventArgs e)
        {
            Connection my = new Connection();
            MySqlDataReader data = my.select("select s.* from students s join classes c on s.Class_id = c.ID where c.Teacher_id ='" + this.teacherid+ "'" );
            while (data.Read())
            {
                listBox1.Items.Add(data.GetString(1));
                
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addStudent addStudent= new addStudent(this.teacherid);
            addStudent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            payingExpenses payingExpenses = new payingExpenses();
            payingExpenses.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            carnivalPrint carnivalPrint = new carnivalPrint();
            carnivalPrint.Show();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        { 
            //get the students data and show it 
            string studentname = listBox1.SelectedItem.ToString();
            Connection my = new Connection();
            MySqlDataReader data = my.select(" select s.*, c.Name from students s join classes c on s.Class_id = c.ID where c.Teacher_id = '" + this.teacherid + "'" +  " and s.FullName = '" + studentname + "'" );
            while (data.Read())
            {
                dataGridView1.Rows.Clear();
                textBox6.Text = data.GetString(1);
                comboBox3.Text = data.GetString(5);
                textBox7.Text = data.GetString(6);
                textBox8.Text = data.GetString(2);
                textBox9.Text = data.GetString(3);
                textBox11.Text = data.GetString(9);
                textBox12.Text = data.GetString(0);
                textBox15.Text = data.GetString(8);
                comboBox5.Text = data.GetString(12);
                textBox14.Text = data.GetString(11);
                textBox10.Text = data.GetString(4);
                
                if(bool.Parse(data.GetString(10)) == true)
                {
                    checkBox1.Checked = true;
                } else
                {
                    checkBox1.Checked = false;
                }

                //get the student exams 

                MySqlDataReader exams = my.select("select e.Date, e.Name, d.Value, e.FullMark from degrees d join students s on d.Student_id = s.ID join exams e on e.ID = d.Exam_id join classes c on c.ID = e.Class_id where s.FullName = '" + studentname + "'");
                double fullmarks = 0, getmarks = 0;
                while (exams.Read())
                {
                    //make the degree 
                    double get = double.Parse(exams.GetString(2));
                    double full = double.Parse(exams.GetString(3));
                    double results = get / full;
                    string value;

                    // to calculate the total degree
                    fullmarks += full;
                    getmarks += get;
                
                    if(results == 1)
                    {
                        value = "ممتاز";
                    } else if (results >= .75 && results < 1){
                            value = "جيد ";
                    }
                    else if (results >= .5 && results < .75)
                    {
                        value = "ناجح ";
                    } else
                    {
                        value = "راسب";
                    }
                    dataGridView1.Rows.Add(exams.GetString(0), exams.GetString(1), exams.GetString(2), exams.GetString(3), value);
                }

                //show the toatl percentage  
                double resultsall = getmarks / fullmarks;
                string valueall;
                if(getmarks == 0)
                {
                    valueall = "لم يمتحن";
                } else if (resultsall == 1)
                {
                    valueall = "ممتاز";
                }
                else if (resultsall >= .75 && resultsall < 1)
                {
                    valueall = "جيد ";
                }
                else if (resultsall >= .5 && resultsall < .75)
                {
                    valueall = "مقبول ";
                }
                else
                {
                    valueall = "المستوى سي";
                }

                textBox2.Text = valueall;
            }
        }
    }
}
