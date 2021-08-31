using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataReader dr;
            sqlConnection1.Open();
            dr = sqlCommand1.ExecuteReader();
            string result="";
            while(dr.Read())
            {
                if(dr["email"].ToString() == textBox1.Text)
                {
                    if (dr["password"].ToString() == textBox2.Text)
                    {
                        result = $"Hello {dr["userName"]} you are signed in";
                   
                    }

                }else
                {
                  result = $"sorry there are a problem in mail or password please try again ";
                    continue;

                }
                MessageBox.Show(result);
            }
            dr.Close();
            sqlConnection1.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            sqlConnection1.Open();
            string updateUser = $"update RestauranrUsers set userName = '{textBox4.Text}' where email = '{textBox3.Text}'";
            sqlCommand1.CommandText = updateUser;
            int affectedVal;
            affectedVal = sqlCommand1.ExecuteNonQuery();
            
            sqlConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            string updateUser = $"update RestauranrUsers set password = '{textBox5.Text}' where email = '{textBox3.Text}'";
            sqlCommand1.CommandText = updateUser;
            int affectedVal;
            affectedVal = sqlCommand1.ExecuteNonQuery();

            sqlConnection1.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertedRow = $"insert into RestauranrUsers values ('{textBox3.Text}' , '{textBox4.Text}' , '{textBox5.Text}','{Convert.ToDateTime(monthCalendar1.SelectionStart)}')";
            sqlCommand1.CommandText = insertedRow;
            sqlConnection1.Open();
            int affectedRows;
            affectedRows = sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string deletedRow = $"Delete from RestauranrUsers where email = '{textBox3.Text}'";
            sqlCommand1.CommandText = deletedRow;
            sqlConnection1.Open();
            int affectedRows;
            affectedRows = sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }
}
