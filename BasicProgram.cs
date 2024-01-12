using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingPracticeFirstProgram
{
    public class BasicProgram
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RollNo { get; set; }
        public double Gpa { get; set; }

        public BasicProgram(int Id , string Name, string RollNo, double gpa)
        {
            this.Id = Id;
            this.Name = Name;
            this.RollNo = RollNo;
            this.Gpa = gpa;
        }

        public void DisplayInfo() { 
            Console.WriteLine("Basic Program Infro:" + " Id: " + this.Id + " Name: " + this.Name + " RollNo: " + this.RollNo + " " + this.Gpa);
        }
    }
}
