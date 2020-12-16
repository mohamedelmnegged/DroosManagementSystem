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
    public partial class addStudent : Form
    {
        private string teacherid, classid, checkmoney;
        public addStudent(string id)
        {
            InitializeComponent();
            this.teacherid = id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

       

        private void addStudent_Load(object sender, EventArgs e)
        {
            
            //get all classes to combox 
            Connection my = new Connection();
            MySqlDataReader classes = my.select("select Name from classes where Teacher_id = '" + this.teacherid + "'");
            while (classes.Read())
            {
                addFormStuGroub.Items.Add(classes.GetString(0));
            }

            //put years in combox
            int year = DateTime.Now.Year;
            for (int i = 0; i < 10; i++)
            {
                addFormStuYear.Items.Add(year);
                year -= 1;
            }
        }

        private void addFormStuPhoneNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //to make textbox accept only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addFormStuDadPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void addFormStuDadPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //to make textbox accept only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AddNewStuBtn_Click_1(object sender, EventArgs e)
        {

            string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            //make the validateion after add new student 
            int count = 0;

            if (string.IsNullOrWhiteSpace(addFormStuName.Text))
            {
                count += 1;
                MessageBox.Show("You should Enter Student Name ");
            }
            if (addFormStuYear.SelectedIndex < 0)
            {
                count += 1;
                MessageBox.Show("You should select Year");
            }
            if (string.IsNullOrWhiteSpace(addFormStuPhoneNum.Text))
            {
                count += 1;
                MessageBox.Show("You should type a Phone number");
            }
            if (string.IsNullOrWhiteSpace(addFormStuDadPhoneNum.Text))
            {
                count += 1;
                MessageBox.Show("You should type a Parent Phone number");
            }
            if (string.IsNullOrWhiteSpace(addFormStuDadJob.Text))
            {
                count += 1;
                MessageBox.Show("You should type a Parent jop");
            }
            if (string.IsNullOrWhiteSpace(addFormStuAddress.Text))
            {
                count += 1;
                MessageBox.Show("You should type an address");
            }
            if (addFormStuGroub.SelectedIndex < 0)
            {
                count += 1;
                MessageBox.Show("You should select a class group");
            }

            //check from the validation after add data 
            if (count == 0)
            {
                string studentname = addFormStuName.Text;
                string year = addFormStuYear.SelectedItem.ToString();
                string phone = addFormStuPhoneNum.Text;
                string parent_phone = addFormStuDadPhoneNum.Text;
                string parent_jop = addFormStuDadJob.Text;
                string address = addFormStuAddress.Text;
                string classname = addFormStuGroub.SelectedItem.ToString();
                string notes = addFormStuNotes.Text;
                bool check = addFormStuExempt.Checked;

                //check if student name is exist or not 
                Connection my = new Connection();
                MySqlDataReader checkstudent = my.select("select ID, FullName from students where FullName = '" + studentname + "'");


                if (checkstudent.HasRows == false)
                {
                    //here insert data into database
                    //first get the class id 
                    Connection my2 = new Connection();
                    MySqlDataReader data = my2.select("select ID from classes where Name = '" + classname + "'");

                    while (data.Read())
                    {
                        this.classid = data.GetString(0);
                    }

                    if (check == true)
                    {
                        this.checkmoney = "1";
                    }
                    else
                    {
                        this.checkmoney = "0";
                    }



                    //insert data 
                    Connection my3 = new Connection();
                    bool save = my3.sqlorder("INSERT INTO `students`(`ID`, `FullName`, `Phone`, `Parent_phone`, `Parent_job`, `Year`, `Class_id`, `ParCode`, `Address`, `Money_Paied`, `Notes`)  values(NUll,'" + studentname + "','" + phone + "','" + parent_phone + "','" + parent_jop + "','" + year + "','" + this.classid + "','000','" + address + "','" + this.checkmoney + "','" + notes + "')");
                    if (save == true)
                    {
                        MessageBox.Show("Student is added");
                    }
                }
                else
                {
                    MessageBox.Show("the Student Name you entered is already exist");
                }
            }
        }

        private void AddNewStuBtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
