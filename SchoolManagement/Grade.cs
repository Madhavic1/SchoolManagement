using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Grade
    {
        public int Grade_Number { get; set; }
        public int Student_Strength { get; set; }
        public string Assigned_Teacher { get; set; }
        public List<Student> Students { get; set;}
        public int AnnualFee { get; set; }
        public int Year { get; set; }
        public  int NoOfStudents = 0;

       
        

        public void addStudent(Student st)
        {
            Students.Add(st);
            NoOfStudents += 1;
        }



    }
}
