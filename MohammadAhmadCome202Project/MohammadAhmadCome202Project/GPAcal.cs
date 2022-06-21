using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;
using System.Data;

namespace MohammadAhmadCome202Project
{
    public class GPAcal
    {

        string student = Form2.Name2;
        public static  string SubjectName;
        public static double Grades;
        public static int ECTS;
        public static double ClassGpa ;
        public static int numberOfCourses = 0;
        public static double ClassCGPA;
        private double GPA;
        public double weight { get; set; }
        public double Grade { get; set; }


        //calculate the number of courses
        public void numberOfCoursesCounter()
        {
            Form1.connect();
            SQLiteCommand command = new SQLiteCommand("select count(courseCode) from " + student + ";", Form1.myConnection);
            command.Connection = Form1.myConnection;
            
            numberOfCourses = Convert.ToInt32(command.ExecuteScalar());
            Form1.disconnect();
        }


        //calculating GPA
        public string GpaCal(int termInfo)
        {
            

            numberOfCoursesCounter();

            double[] Marks = new double[numberOfCourses];
            double[] credithours = new double[numberOfCourses];
            double[] TGPA = new double[numberOfCourses];
            Form1.connect();
            SQLiteCommand command = new SQLiteCommand("select grade,ECTS from " + student + "  where term = '" + termInfo + "';", Form1.myConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {

                Grades = (double)reader.GetValue(reader.GetOrdinal("grade"));
                Marks[i] = Grades;
                ECTS = (int)(long)reader.GetValue(reader.GetOrdinal("ECTS"));
                credithours[i] = ECTS;
                i++;


            }
            for (int j = 0; j < i; j++)
            {
                if (Marks[j] >= 90 && Marks[j] <= 100)
                {
                    TGPA[j] = 4.00 * credithours[j];
                }
                else if (Marks[j] >= 85 && Marks[j] <= 89.99)
                {
                    TGPA[j] = 3.50 * credithours[j];
                }
                else if (Marks[j] >= 80 && Marks[j] <= 84.99)
                {
                    TGPA[j] = 3.00 * credithours[j];
                }
                else if (Marks[j] >= 75 && Marks[j] <= 79.99)
                {
                    TGPA[j] = 2.50 * credithours[j];
                }
                else if (Marks[j] >= 70 && Marks[j] <= 74.99)
                {
                    TGPA[j] = 2.00 * credithours[j];
                }
                else if (Marks[j] >= 65 && Marks[j] <= 69.99)
                {
                    TGPA[j] = 1.50 * credithours[j];
                }
                else if (Marks[j] >= 60 && Marks[j] <= 64.99)
                {
                    TGPA[j] = 1.00 * credithours[j];
                }
                else if (Marks[j] >= 50 && Marks[j] <= 59.99)
                {
                    TGPA[j] = 0.50 * credithours[j];
                }
                else if (Marks[j] > 0.00 && Marks[j] <= 49.99)
                {
                    TGPA[j] = 0.00 * credithours[j];
                }
                else
                {

                }

            }
            double GPA = 0;
            double TC = 0;
            for (int x = 0; x < i; x++)
            {
                GPA = GPA + TGPA[x];
                TC = TC + credithours[x];
                ClassGpa = GPA / TC;
            }

            return String.Format("{0:0.00}", ClassGpa);


        }

        //calculating CGPA
        public string CGPACal()
        {
            

            numberOfCoursesCounter();
            
            double[] Marks = new double[numberOfCourses];
            double[] credithours = new double[numberOfCourses];
            double[] TGPA = new double[numberOfCourses];

            Form1.connect();
            SQLiteCommand command = new SQLiteCommand("select * from " + student + ";", Form1.myConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                Grades = (double)reader.GetValue(reader.GetOrdinal("grade"));
                Marks[i] = Grades;
                ECTS = (int)(long)reader.GetValue(reader.GetOrdinal("ECTS"));
                credithours[i] = ECTS;
                i++;


            }
            for (int j = 0; j < numberOfCourses; j++)
            {
                if (Marks[j] >= 90 && Marks[j] <= 100)
                {
                    TGPA[j] = 4.00 * credithours[j];
                }
                else if (Marks[j] >= 85 && Marks[j] <= 89.99)
                {
                    TGPA[j] = 3.50 * credithours[j];
                }
                else if (Marks[j] >= 80 && Marks[j] <= 84.99)
                {
                    TGPA[j] = 3.00 * credithours[j];
                }
                else if (Marks[j] >= 75 && Marks[j] <= 79.99)
                {
                    TGPA[j] = 2.50 * credithours[j];
                }
                else if (Marks[j] >= 70 && Marks[j] <= 74.99)
                {
                    TGPA[j] = 2.00 * credithours[j];
                }
                else if (Marks[j] >= 65 && Marks[j] <= 69.99)
                {
                    TGPA[j] = 1.50 * credithours[j];
                }
                else if (Marks[j] >= 60 && Marks[j] <= 64.99)
                {
                    TGPA[j] = 1.00 * credithours[j];
                }
                else if (Marks[j] >= 50 && Marks[j] <= 59.99)
                {
                    TGPA[j] = 0.50 * credithours[j];
                }
                else if (Marks[j] > 0.00 && Marks[j] <= 49.99)
                {
                    TGPA[j] = 0.00 * credithours[j];
                }
                else
                {

                }

            }
            double GPA = 0;
            double TC = 0;
            for (int x = 0; x < numberOfCourses; x++)
            {
                GPA = GPA + TGPA[x];
                TC = TC + credithours[x];
                ClassCGPA = GPA / TC;
            }

            return String.Format("{0:0.00}", ClassCGPA);

            Form1.disconnect();
        }

     
       
    }
}
