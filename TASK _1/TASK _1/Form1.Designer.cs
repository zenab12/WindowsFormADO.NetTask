
namespace TASK__1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet11 = new TASK__1.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Bdate = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Superssn = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Dno = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Fname, Lname, SSN, Bdate, Address, Sex, Salary, Superssn, Dno\r\nFROM     Em" +
    "ployee";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ZENAB-MOHAMMED\\SQLEXPRESS;Initial Catalog=Company;Integrated Security" +
    "=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fname", System.Data.SqlDbType.NVarChar, 0, "Fname"),
            new System.Data.SqlClient.SqlParameter("@Lname", System.Data.SqlDbType.NVarChar, 0, "Lname"),
            new System.Data.SqlClient.SqlParameter("@SSN", System.Data.SqlDbType.Int, 0, "SSN"),
            new System.Data.SqlClient.SqlParameter("@Bdate", System.Data.SqlDbType.DateTime, 0, "Bdate"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, "Address"),
            new System.Data.SqlClient.SqlParameter("@Sex", System.Data.SqlDbType.NVarChar, 0, "Sex"),
            new System.Data.SqlClient.SqlParameter("@Salary", System.Data.SqlDbType.Int, 0, "Salary"),
            new System.Data.SqlClient.SqlParameter("@Superssn", System.Data.SqlDbType.Int, 0, "Superssn"),
            new System.Data.SqlClient.SqlParameter("@Dno", System.Data.SqlDbType.Int, 0, "Dno")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fname", System.Data.SqlDbType.NVarChar, 0, "Fname"),
            new System.Data.SqlClient.SqlParameter("@Lname", System.Data.SqlDbType.NVarChar, 0, "Lname"),
            new System.Data.SqlClient.SqlParameter("@SSN", System.Data.SqlDbType.Int, 0, "SSN"),
            new System.Data.SqlClient.SqlParameter("@Bdate", System.Data.SqlDbType.DateTime, 0, "Bdate"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, "Address"),
            new System.Data.SqlClient.SqlParameter("@Sex", System.Data.SqlDbType.NVarChar, 0, "Sex"),
            new System.Data.SqlClient.SqlParameter("@Salary", System.Data.SqlDbType.Int, 0, "Salary"),
            new System.Data.SqlClient.SqlParameter("@Superssn", System.Data.SqlDbType.Int, 0, "Superssn"),
            new System.Data.SqlClient.SqlParameter("@Dno", System.Data.SqlDbType.Int, 0, "Dno"),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fname", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lname", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SSN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SSN", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Bdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Bdate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Bdate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Bdate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Sex", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Sex", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Salary", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Salary", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Superssn", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Superssn", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Superssn", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Superssn", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dno", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dno", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IsNull_Fname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fname", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lname", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SSN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SSN", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Bdate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Bdate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Bdate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Bdate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Sex", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Sex", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sex", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Salary", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Salary", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Superssn", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Superssn", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Superssn", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Superssn", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dno", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dno", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employee", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Fname", "Fname"),
                        new System.Data.Common.DataColumnMapping("Lname", "Lname"),
                        new System.Data.Common.DataColumnMapping("SSN", "SSN"),
                        new System.Data.Common.DataColumnMapping("Bdate", "Bdate"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("Sex", "Sex"),
                        new System.Data.Common.DataColumnMapping("Salary", "Salary"),
                        new System.Data.Common.DataColumnMapping("Superssn", "Superssn"),
                        new System.Data.Common.DataColumnMapping("Dno", "Dno")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(366, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(24, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "fill data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("MV Boli", 9.8F, System.Drawing.FontStyle.Italic);
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(406, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "load data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 28);
            this.textBox1.TabIndex = 3;
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.ForeColor = System.Drawing.Color.Red;
            this.Fname.Location = new System.Drawing.Point(420, 98);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(50, 18);
            this.Fname.TabIndex = 4;
            this.Fname.Text = "Fname";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(499, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 28);
            this.textBox2.TabIndex = 5;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lname.ForeColor = System.Drawing.Color.Red;
            this.Lname.Location = new System.Drawing.Point(425, 127);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(50, 18);
            this.Lname.TabIndex = 6;
            this.Lname.Text = "Lname";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(499, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 28);
            this.textBox3.TabIndex = 7;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.ForeColor = System.Drawing.Color.Red;
            this.id.Location = new System.Drawing.Point(425, 157);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(37, 18);
            this.id.TabIndex = 8;
            this.id.Text = "SSN";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(499, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 28);
            this.textBox4.TabIndex = 9;
            // 
            // Bdate
            // 
            this.Bdate.AutoSize = true;
            this.Bdate.ForeColor = System.Drawing.Color.Red;
            this.Bdate.Location = new System.Drawing.Point(425, 189);
            this.Bdate.Name = "Bdate";
            this.Bdate.Size = new System.Drawing.Size(45, 18);
            this.Bdate.TabIndex = 10;
            this.Bdate.Text = "Bdate";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(499, 214);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 28);
            this.textBox5.TabIndex = 11;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.ForeColor = System.Drawing.Color.Red;
            this.Address.Location = new System.Drawing.Point(421, 219);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(59, 18);
            this.Address.TabIndex = 12;
            this.Address.Text = "Address";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(499, 243);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(229, 28);
            this.textBox6.TabIndex = 13;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.ForeColor = System.Drawing.Color.Red;
            this.Sex.Location = new System.Drawing.Point(425, 249);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(31, 18);
            this.Sex.TabIndex = 14;
            this.Sex.Text = "Sex";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(499, 277);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(229, 28);
            this.textBox7.TabIndex = 15;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.ForeColor = System.Drawing.Color.Red;
            this.Salary.Location = new System.Drawing.Point(425, 287);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(48, 18);
            this.Salary.TabIndex = 16;
            this.Salary.Text = "Salary";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(499, 311);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(229, 28);
            this.textBox8.TabIndex = 17;
            // 
            // Superssn
            // 
            this.Superssn.AutoSize = true;
            this.Superssn.ForeColor = System.Drawing.Color.Red;
            this.Superssn.Location = new System.Drawing.Point(425, 321);
            this.Superssn.Name = "Superssn";
            this.Superssn.Size = new System.Drawing.Size(66, 18);
            this.Superssn.TabIndex = 18;
            this.Superssn.Text = "Superssn";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(499, 345);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(229, 28);
            this.textBox9.TabIndex = 19;
            // 
            // Dno
            // 
            this.Dno.AutoSize = true;
            this.Dno.ForeColor = System.Drawing.Color.Red;
            this.Dno.Location = new System.Drawing.Point(425, 355);
            this.Dno.Name = "Dno";
            this.Dno.Size = new System.Drawing.Size(33, 18);
            this.Dno.TabIndex = 20;
            this.Dno.Text = "Dno";
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Red;
            this.insert.Font = new System.Drawing.Font("MV Boli", 9.8F, System.Drawing.FontStyle.Italic);
            this.insert.ForeColor = System.Drawing.Color.Snow;
            this.insert.Location = new System.Drawing.Point(499, 425);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(229, 40);
            this.insert.TabIndex = 21;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(499, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 40);
            this.button3.TabIndex = 22;
            this.button3.Text = "UpdateDB";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Update_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(24, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(366, 40);
            this.button4.TabIndex = 23;
            this.button4.Text = "UpdateValue";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(499, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 25);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(401, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select Emp:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(762, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.Dno);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.Superssn);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Bdate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Bdate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label Superssn;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label Dno;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

