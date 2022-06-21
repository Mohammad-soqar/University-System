using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohammadAhmadCome202Project
{
    public class StudentLoginInfo
    {
        public int studentNumber { get; set; }
        public string password { get; set; }
        public string name { get; set; }

        public StudentLoginInfo() { }
        public StudentLoginInfo(int studentNumber_, string password_, string name_)
        {
            this.studentNumber = studentNumber_;
            this.password = password_;
            this.name = name_;
        }

    }
}
