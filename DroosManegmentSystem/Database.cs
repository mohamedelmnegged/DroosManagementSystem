using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DroosManegmentSystem
{
	public class Connection
	{
		//first make the connection function to call it when want to deal with data base
		public MySqlConnection conn()
		{
			try
			{
				string sql = "server=localhost;port=3306;username=root;password=;database=droos management system";

				MySqlConnection connect = new MySqlConnection(sql);

				connect.Open();

				return connect;
			}
			catch (MySqlException e)
			{
				MessageBox.Show(e.Message);
				return null;
			}
		}

		//this is close function to close the  connection 
		public void close()
		{
			try
			{
				conn().Close();
			}
			catch (MySqlException e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public MySqlDataReader select(string sql)
		{
			MySqlCommand data = new MySqlCommand(sql, conn());
			MySqlDataReader mydata = data.ExecuteReader();
			close();


			return mydata;

		}

		public bool sqlorder(string sql)
		{
			//this is delete function to delete  from data base
			try
			{
				MySqlCommand data = new MySqlCommand(sql, conn());

				int mydata = data.ExecuteNonQuery();

				close();

				if (mydata > 0)
				{
					return true;
				}

				return false;
			}
			catch (MySqlException e)
			{
				MessageBox.Show(e.Message);
				return false;
			}
		}
	}
}
