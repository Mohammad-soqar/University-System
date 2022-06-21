using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MohammadAhmadCome202Project
{
    public partial class Form4 : Form
    {
        
        int termInfo = Form2.termInfo;
        string student = Form2.Name2;
        public static string SubjectName;
        public static double Grades;
        public  SQLiteConnection myConnection;
        public static int ECTS;

        public Form4()
        {

            InitializeComponent();
            Coursestable();

        }
        //this will show the student all the available courses 
        public void Coursestable()
        {
            Form1.connect();
            SQLiteCommand command = new SQLiteCommand("Select * From courseInformation", Form1.myConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                data2.Rows.Add(new object[] {


            reader.GetValue(reader.GetOrdinal("courseCode")),
            reader.GetValue(reader.GetOrdinal("courseName")),
            reader.GetValue(reader.GetOrdinal("ECTS"))
           
            });
              

            }
            Form1.myConnection.Close();
            Form1.disconnect();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //this help form will show the student how to insert weight and letter grade of the subject
        private void HelpB_Click(object sender, EventArgs e)
        {
            helpButtonform home = new helpButtonform();
          
            home.ShowDialog();
           
        }
        //this help form will show the student how to insert weight and letter grade of the subject
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            helpButtonform home = new helpButtonform();
            home.ShowDialog();
        }
        //add subject
        private void AddButton_Click(object sender, EventArgs e)
        {

            Form1.connect();
            double grade = double.Parse(Grade.Text);
            double weight = double.Parse(W.Text);
            int ECTS = int.Parse(Credit.Text);

            SQLiteCommand command = new SQLiteCommand("INSERT INTO " + student + " (courseCode, grade, letterGrade, weight, ECTS, term ) VALUES('" + CourseCode.Text + "','" + grade + "','" + LGrade.Text + "','" + weight + "','" + ECTS + "','" + termInfo + "')", Form1.myConnection);
            command.ExecuteNonQuery();
            newN.Text = "New!";
            Form1.myConnection.Close();
            Form1.disconnect();
        }
        //drop subject
        private void DropButton_Click(object sender, EventArgs e)
        {
            Form1.connect();
            SQLiteCommand command = new SQLiteCommand("DELETE FROM " + student + " WHERE courseCode='" + CourseCode.Text + "'", Form1.myConnection);
            command.ExecuteNonQuery();
            newN.Text = "New!";
            Form1.myConnection.Close();
            Form1.disconnect();
        }
        //to go to Dashboard page(Form2)
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 Dashboard = new Form2();
            this.Hide();
            Dashboard.ShowDialog();
            this.Close();
        }
        //to go to grades page(Form3)
        private void GGr_Click(object sender, EventArgs e)
        {
            Form3 Grades = new Form3();
            this.Hide();
            Grades.ShowDialog();
            this.Close();
        }
        //this will open the browser and redirect the user to ALMS system
        private void almsB_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://lms.uskudar.edu.tr/", UseShellExecute = true });
        }
        //social media
        private void Facebook_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.facebook.com/UskudarUniversitesi/", UseShellExecute = true });

        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://twitter.com/uskudaruni", UseShellExecute = true });

        }

        private void Pinterest_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://tr.pinterest.com/uskudaruni/_created/", UseShellExecute = true });

        }

        private void Instagram_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.instagram.com/uskudaruni/", UseShellExecute = true });

        }

        private void Whatsapp_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://api.whatsapp.com/send?phone=902164002222&text=&source=&data=", UseShellExecute = true });

        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.youtube.com/user/uskudaruniversitesi", UseShellExecute = true });

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
