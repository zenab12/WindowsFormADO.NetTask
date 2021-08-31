using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestaurantEntities Rest = new RestaurantEntities();
            RestauranrUser user = new RestauranrUser();
            user.email = textBox3.Text;
            user.userName = textBox4.Text;
            user.password = textBox5.Text;
            user.Birthday = monthCalendar1.SelectionStart;
            Rest.RestauranrUsers.Add(user);
            Rest.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestaurantEntities Rest = new RestaurantEntities();
            comboBox1.Items.Clear();
            var rows = from name in Rest.RestauranrUsers
                       select name.userName;
            foreach(var row in rows )
            {
                comboBox1.Items.Add(row);

            }

            var updatedRow = from name in Rest.RestauranrUsers
                       where name.userName == comboBox1.Text
                       select name;


            foreach (var row in updatedRow)
            {
                row.userName = textBox4.Text;
                row.password = textBox5.Text;
                row.Birthday = monthCalendar1.SelectionStart;
            }
            Rest.SaveChanges();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestaurantEntities Rest = new RestaurantEntities();
            comboBox1.Items.Clear();
            var rows = from name in Rest.RestauranrUsers
                       select name.userName;
            foreach (var i in rows)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantEntities Rest = new RestaurantEntities();
            var rows = from name in Rest.RestauranrUsers
                       where name.userName == comboBox1.Text
                       select name;
            foreach (var row in rows) {
                textBox3.Text = row.email;
                textBox4.Text = row.userName;
                textBox5.Text = row.password;
                monthCalendar1.SelectionStart = row.Birthday;
                    }
            Rest.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RestaurantEntities Rest = new RestaurantEntities();
            var rows = from name in Rest.RestauranrUsers
                       where name.userName == comboBox1.Text
                       select name;
            foreach (var row in rows)
            {
                Rest.RestauranrUsers.Remove(row);
            }
            Rest.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestaurantEntities Rest = new RestaurantEntities();
     
            var updatedRow = from name in Rest.RestauranrUsers
                             where name.email== textBox1.Text
                             select name;


            foreach (var row in updatedRow)

            {
                var result = "";
              if((row.email == textBox1.Text )&&(row.password == textBox2.Text))
                {
                    result = $"hello {row.userName} you are signed in";
                }else
                {
                    result = "sorry there are error in email or password ";
                }

                MessageBox.Show(result);
            }
            Rest.SaveChanges();
        }
    }
}
