using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Student
    {
        private static int lastStudentId = 0;


        #region Properties

        public  int StudentId { get; private set; } //unique , can not be edited by others than School
        public string  Name { get; private set; }
        public int Age { get; set; }
        public int StudentGrade { get; set; }
        public int FeesPaid { get; private set; }
        public string Father_Name { get; private set; }


        #endregion



        public Student()
        {
            FeesPaid = 0;
            StudentId = ++lastStudentId;

        }

        //overlaoded constructor : Takes student ID, Student Name and his grade




        public Student(string name,int age ,int grade,string fatherName) : this()
        {
           // this.student_id = id;
            Name = name;
            Age = age;
            StudentGrade = grade;
            Father_Name = fatherName;


        }

        //method to update feesPaid : student will be paying his monthly fee and so the property should get updated

       

    }
}
