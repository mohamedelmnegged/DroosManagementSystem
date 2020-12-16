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
namespace DroosManegmentSystem
{
	

    
	public partial class loginForm : Form
	{
		public loginForm()
		{
			InitializeComponent();
		}

		private void loginForm_Load(object sender, EventArgs e)
		{
			//mainPanel mainpanel = new mainPanel();
			//mainpanel.Show();
		}

		private void fogetPassBtn_Click(object sender, EventArgs e)
		{

		}

		private void iconPictureBox1_Click(object sender, EventArgs e)
		{

		}

        private void loginBtn_Click(object sender, EventArgs e)
        {
			string Username = userName.Text;
			string Password = password.Text; 
			Connection my = new Connection();
			if (Username.Length == 0 || Username == "" || string.IsNullOrWhiteSpace(Username))
			{
				MessageBox.Show("You should type a UserName");
			}
			else if (Password.Length == 0 || Password == "" || string.IsNullOrWhiteSpace(Password))
			{
				MessageBox.Show("You should type a Password");
			}
			else
			{
				MySqlDataReader data = my.select("select ID,UserName,Password, Name from teachers where `UserName` = '" + Username + "'");

				if (data.HasRows)
				{
					while (data.Read())
					{
						if (data.GetString(2) == Password)
						{
							mainPanel main = new mainPanel(data.GetString(0), data.GetString(3));
							main.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("Your Password is not correct");
						}
					}
				}
				else
				{
					MessageBox.Show("you Entered invlaid UserName");
				}

			}
			
        }

		private void remMe_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
