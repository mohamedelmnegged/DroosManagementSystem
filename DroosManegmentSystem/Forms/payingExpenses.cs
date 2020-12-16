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
    public partial class payingExpenses : Form
    {
        public payingExpenses()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //check if the student is already typed and then check from it 
            string studentname = textBox1.Text;
            //search for the student name in database 
            Connection my = new Connection();
            MySqlDataReader data = my.select("SELECT  Lastmonthpaied, Money_Paied FROM students  where FullName = '" + studentname + "'");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    // check if person is money exampt or not 
                    if (data.GetString(1) == "True")
                    {
                        MessageBox.Show("this student is Money Exampt");
                    }
                    else
                    {
                        // get the last month paied and the month of now and make chec;
                        int LastMonthPaied = int.Parse(data.GetString(0));
                        int thisMonth = int.Parse(DateTime.Today.Date.ToString("MM"));
                        //if student last month paied is less than the current month so pay and update the  data base
                        if (LastMonthPaied < thisMonth)
                        {
                            LastMonthPaied++;
                            Connection my2 = new Connection();
                            bool pay = my2.sqlorder("update students set Lastmonthpaied = '" + LastMonthPaied + "' where FullName = '" + studentname + "'");
                            if (pay == true)
                            {
                                MessageBox.Show("Student pay");
                                button4_Click(sender, e);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("this student is not found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accountStatement accountStatement = new accountStatement();
            accountStatement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            latePayments latePayments = new latePayments();
            latePayments.Show();
        }

        private void payingExpenses_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Today.ToString("yyy/MM/dd");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            textBox2.Text = " ";
            string studentname = textBox1.Text;
            //search for the student name in database 
            Connection my = new Connection();
            MySqlDataReader data = my.select("SELECT s.ID,s.FullName,s.Lastmonthpaied,c.Price, s.Money_Paied FROM students s join classes c on s.Class_id = c.ID where s.FullName = '" + studentname + "'");
            if (data.HasRows)
            {
                while (data.Read())
                {
                    textBox2.Text = data.GetString(3);
                    // get the last month paied and the month of now and make chec;
                    int LastMonthPaied = int.Parse(data.GetString(2));
                    int thisMonth = int.Parse(DateTime.Today.Date.ToString("MM"));

                    //check if student is money exampet or not 
                 
                    if (data.GetString(4) == "True")
                    {
                        comboBox2.Text = "this student is money exampt";
                    }
                    else if (LastMonthPaied == thisMonth)
                    {
                        comboBox2.Text = "all months paied";
                    }
                    else
                    {
                        for (int i = LastMonthPaied; i < thisMonth; i++)
                        {
                            comboBox2.Items.Add(i);
                        }
                    }


                    
                   
                }
            } else
            {
                MessageBox.Show("this student is not found");
            }
        }
    }
}
