using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;


namespace MohammadAhmadCome202Project
{
    public partial class Form2 : Form
    {
        public static int termInfo;
        public static string Name2;
        public static string Surname;
        string s1 = Form1.StudentNum;

        public Form2()
        {

            InitializeComponent();
            date.Text = DateTime.Now.ToString("dd MMM yyyy, dddd ");
            Sdate.Text = DateTime.Now.ToString("dd MMM \n ddd");
            getInfo();


        }
        //I am getting this info to display the student name and to let the system which courses table to open
        public void getInfo()
        {
            
            Form1.connect();
            SQLiteCommand command = new SQLiteCommand("select * from login  where studentNumber='" + s1 + "'", Form1.myConnection);
            command.Connection = Form1.myConnection;
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                termInfo = (int)(long)reader["term"];
                Name2 = reader["name"].ToString();
                Surname = reader["surname"].ToString();
                WelName.Text = Name2 + " !";
                label1.Text = Name2 +" "+ Surname;
            }

            Form1.myConnection.Close();
            Form1.disconnect();

        }
        
        private void circleprogressBar1_Load(object sender, EventArgs e)
        {

        }

        //open Form4 = add and drop
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form4 addAndDrop = new Form4();
            this.Hide();
            addAndDrop.ShowDialog();
            this.Close();
        }
        //this will open the browser and redirect the user to ALMS system
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://lms.uskudar.edu.tr/", UseShellExecute = true });
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.ShowDialog();
            this.Close();
           
        }
        //to go back to logIn screen (Form1)
        private void LogoutIcon_Click(object sender, EventArgs e)
        {
            Form1 LogIn = new Form1();
            this.Hide();
            LogIn.ShowDialog();
            this.Close();
        }
        //to go back to logIn screen (Form1)
        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 LogIn = new Form1();
            this.Hide();
            LogIn.ShowDialog();
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

        private void Whatsapp_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://api.whatsapp.com/send?phone=902164002222&text=&source=&data=", UseShellExecute = true });

        }

        private void Instagram_Click(object sender, EventArgs e)
        {
           
            Process.Start(new ProcessStartInfo { FileName = @"https://www.instagram.com/uskudaruni/", UseShellExecute = true });

        }
        private void Youtube_Click(object sender, EventArgs e)
        {
           
            Process.Start(new ProcessStartInfo { FileName = @"https://www.youtube.com/user/uskudaruniversitesi", UseShellExecute = true });
        }
        private void an1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://uskudar.edu.tr/mdbf/tr/etkinlik/706/uskudar-universitesi-arastirmacilari-g20-n20-konferansinda-calismalarini-anlatti", UseShellExecute = true });

        }

        private void an2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://uskudar.edu.tr/mdbf/tr/etkinlik/722/covid-19-hayata-tutunmak-ile-dijital-donusume-adaptasyon-arasinda-yeni-donem", UseShellExecute = true });

        }

        private void an3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://uskudar.edu.tr/mdbf/tr/etkinlik/709/whatsapp-kisisel-veri-kullanimini-yasal-zemine-tasimak-istiyor", UseShellExecute = true });

        }

        private void WelName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
