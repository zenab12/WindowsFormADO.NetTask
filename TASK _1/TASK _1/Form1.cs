using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet11.Tables[0];
            foreach(DataRow dr in dataSet11.Tables[0].Rows)
            {
                comboBox1.Items.Add(dr["SSN"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            sqlDataAdapter1.Fill(dataSet11);
            sqlConnection1.Close();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            sqlConnection1.Open();
            sqlDataAdapter1.Fill(dataSet11);
            sqlConnection1.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            DataRow insertedRow = dataSet11.Tables[0].NewRow();
            insertedRow[0] = textBox1.Text;
            insertedRow[1] = textBox2.Text;
            insertedRow[2] = int.Parse(textBox3.Text);
            insertedRow[3] = textBox4.Text;
            insertedRow[4] = textBox5.Text;
            insertedRow[5] = Convert.ToChar(textBox6.Text);
            insertedRow[6] = int.Parse(textBox7.Text);
            insertedRow[7] = int.Parse(textBox8.Text);
            insertedRow[8] = int.Parse(textBox9.Text);
            dataSet11.Tables[0].Rows.Add(insertedRow);

            textBox1.Text
          = textBox2.Text
          = textBox3.Text
          = textBox4.Text
          = textBox5.Text
          = textBox6.Text
          = textBox7.Text
          = textBox8.Text
          = textBox9.Text
          = "";
        }

        private void Update_click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            sqlDataAdapter1.Update(dataSet11);
            sqlConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int SSN = int.Parse(textBox3.Text);
            DataRow dRows = dataSet11.Tables[0].Rows.Find(SSN);
            dRows[0] = textBox1.Text;
            dRows[1] = textBox2.Text;
            dRows[2] = int.Parse(textBox3.Text);
            dRows[3] = textBox4.Text;
            dRows[4] = textBox5.Text;
            dRows[5] = Convert.ToChar(textBox6.Text);
            dRows[6] = int.Parse(textBox7.Text);
            dRows[7] = int.Parse(textBox8.Text);
            dRows[8] = int.Parse(textBox9.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SSN = int.Parse(comboBox1.Text);
            DataRow dRows = dataSet11.Tables[0].Rows.Find(SSN);
            textBox1.Text = dRows[0].ToString();
            textBox2.Text = dRows[1].ToString(); ;
            textBox3.Text = dRows[2].ToString();
            textBox4.Text = dRows[3].ToString();
            textBox5.Text = dRows[4].ToString();
            textBox6.Text = dRows[5].ToString();
            textBox7.Text = dRows[6].ToString();
            textBox8.Text = dRows[7].ToString();
            textBox9.Text = dRows[8].ToString();

        }
    }
}