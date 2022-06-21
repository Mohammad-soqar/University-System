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
    public partial class Form3 : Form
    {
        int termInfo = Form2.termInfo;
        string student = Form2.Name2;
        public  GPAcal CAL = new GPAcal();
        public SQLiteConnection myConnection;
        public static int numberOfCourses;

        public Form3()
        {

            InitializeComponent();
            gradestable();

            label1.Text = CAL.GpaCal(termInfo);
            label2.Text = CAL.CGPACal().ToString();
         

        }
      
        public void gradestable()
        {
            Form1.connect();
            SQLiteCommand command = new SQLiteCommand("Select * From " + student + " where term='" + termInfo + "'", Form1.myConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                
                data1.Rows.Add(new object[] {

            
            reader.GetValue(reader.GetOrdinal("courseCode")),
            reader.GetValue(reader.GetOrdinal("grade")),
            reader.GetValue(reader.GetOrdinal("letterGrade")),
            reader.GetValue(reader.GetOrdinal("weight")),
            reader.GetValue(reader.GetOrdinal("ECTS"))
            
            });
                numberOfCourses++;

            }
            Form1.myConnection.Close();
            Form1.disconnect();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        //open Form4 = add and drop
        private void add_Click(object sender, EventArgs e)
        {
            Form4 addAndDrop = new Form4();
            this.Hide();
            addAndDrop.ShowDialog();
            this.Close();
        }
        //to go to Dashboard page(Form2)
        private void homepage_Click(object sender, EventArgs e)
        {
            Form2 Dashboard = new Form2();
            this.Hide();
            Dashboard.ShowDialog();
            this.Close();
        }
        //this will change term information to display courses taken in that term
        private void term1_Click(object sender, EventArgs e)
        {
            termInfo = 1;
            data1.Rows.Clear();
            gradestable();


            label1.Text = CAL.GpaCal(termInfo);
        }

        private void term2_Click(object sender, EventArgs e)
        {
            termInfo = 2;
            data1.Rows.Clear();
            gradestable();
            label1.Text = CAL.GpaCal(termInfo);
        }

        private void term3_Click(object sender, EventArgs e)
        {
            termInfo = 3;
            data1.Rows.Clear();
            gradestable();
            label1.Text = CAL.GpaCal(termInfo);
        }

        private void term4_Click(object sender, EventArgs e)
        {
            termInfo = 4;
            data1.Rows.Clear();
            gradestable();
            label1.Text = CAL.GpaCal(termInfo);
        }

        private void term5_Click(object sender, EventArgs e)
        {
            termInfo = 5;
            data1.Rows.Clear();
            gradestable();
            label1.Text = CAL.GpaCal(termInfo);
        }

        private void term6_Click(object sender, EventArgs e)
        {
            termInfo = 6;
            data1.Rows.Clear();
            gradestable();
            label1.Text = CAL.GpaCal(termInfo);
        }

        private void term7_Click(object sender, EventArgs e)
        {
            termInfo = 7;
            data1.Rows.Clear();
            gradestable();
            label1.Text = CAL.GpaCal(termInfo);
        }

        private void term8_Click(object sender, EventArgs e)
        {
            termInfo = 8;
            data1.Rows.Clear();
            gradestable();
            label1.Text = CAL.GpaCal(termInfo);
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
       
    }
}

