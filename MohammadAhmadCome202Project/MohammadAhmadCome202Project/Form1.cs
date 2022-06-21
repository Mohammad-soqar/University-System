using System.Data.SQLite;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MohammadAhmadCome202Project
{
    
    public partial class Form1 : Form
    {
        
        public static string StudentNum = "";
        public static SQLiteConnection myConnection;
        public Form1()
        {
            
            InitializeComponent();
            
        }
        public static void connect()
        {
            //please change the location (the database is in the project file)
            myConnection = new SQLiteConnection("Data Source = C:\\Users\\Mohammad Ahmad\\source\\repos\\MohammadAhmadCome202Project\\MohammadAhmadCome202Project\\uniproj.db");
            myConnection.Open();

        }
        public static void disconnect()
        {
            //please change the location (the database is in the project file)
            myConnection = new SQLiteConnection("Data Source = C:\\Users\\Mohammad Ahmad\\source\\repos\\MohammadAhmadCome202Project\\MohammadAhmadCome202Project\\uniproj.db");
            myConnection.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
           //here we are checking if
           //the user filled all the information
           if (studentNumber.Text == string.Empty && Password.Text == string.Empty) 
            {
                studentNumber.PlaceholderText = "Please enter your student number";
                Password.PlaceholderText = "Please enter your password ";
            }

           else if (studentNumber.Text == string.Empty && Password.Text != string.Empty)
            {
                studentNumber.PlaceholderText = "Please enter your student number first";
            }

            else if (studentNumber.Text != string.Empty && Password.Text == string.Empty)
            {
                Password.PlaceholderText = "Please enter your password first";
            }

            else if (studentNumber.Text != string.Empty && Password.Text != string.Empty)
            {
                connect();
                SQLiteCommand command = new SQLiteCommand("select * from login where studentNumber='" + studentNumber.Text + "' and password='" + Password.Text + "'", myConnection);
                command.Connection = myConnection;
                SQLiteDataReader sQLiteDataReader = command.ExecuteReader();

                if (sQLiteDataReader.Read())
                {
                   
                    int SN = Int32.Parse(studentNumber.Text);
                    StudentNum = studentNumber.Text;
                    sQLiteDataReader.Close();
                    Form2 home = new Form2();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();

                }

                else
                {
                    //if the login info is wrong this message will appear
                    sQLiteDataReader.Close();
                    MessageBox.Show("No Account available with this student id and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            disconnect();

          
        }
        public string MyVar { get { return studentNumber.Text; } }
 
        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.MaxLength = 14;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }
        //social media links
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