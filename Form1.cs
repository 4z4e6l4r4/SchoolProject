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

namespace SchoolProject
{
    public partial class Form1 : Form
    {
        SqlConnection db = new SqlConnection("Data Source =AZRA; initial catalog =SchoolDb; user id=sa; password=1453");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentData();
            ClassesData();
        }

        public void StudentData()
        {
            db.Open();

            string sorgu = "select s.Id,c.Name as ClassName, s.Name, s.Surname,s.Age,s.Status from Students s inner join Classes c on(s.ClassesId=c.Id) where s.Status=1";

            SqlCommand sqlCommand = new SqlCommand(sorgu, db);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            StudentDgv.DataSource=dt;

            db.Close();
        }

        public void ClassesData()
        {
            db.Open();

            string sorgu = "select * from Classes where Status=1";
            SqlCommand sqlCommand = new SqlCommand(sorgu, db);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt2 = new DataTable();
            sqlDataAdapter.Fill(dt2);

            ClassesCb.DisplayMember = "Name";
                ClassesCb.ValueMember = "Id";
                ClassesCb.DataSource= dt2;


            db.Close();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string Name = NameLbl.Text;
            string Surname = SurnameLbl.Text;
            int Age = Convert.ToInt32(AgeNud.Value);
            int Status = Convert.ToBoolean(StatusCb.Checked)==true?1:0;
            int ClassesId = Convert.ToInt32(ClassesCb.SelectedValue);

            db.Open();
            string sorgu = $"Insert into Students(ClassesId,Name,Surname,Age,Status) Values({ClassesId}, '{Name}', '{Surname}', {Age}, {Status})";
            SqlCommand sqlCommand = new SqlCommand(sorgu, db);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Öğrenci Eklendi");
            db.Close();

            StudentData();
        }
    }
}
