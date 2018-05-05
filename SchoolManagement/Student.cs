using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement
{

   public  enum Arts
    {
        Music,
        Dance,
        Drawing,
        Drama
    }

        public class Student
    {
        private static int lastStudentId = 0;


        #region Properties
        [Key]
        public  int StudentId { get; private set; } 
        [Required]
        public string  Name { get; private set; }
        [Required]
        public int Age { get; set; }
        public int StudentGrade { get; set; }
        public decimal FeesPaid { get; private set; }
        [Required]
        public string Father_Name { get; private set; }
        public Arts ArtSubjectTaken { get; set; }


        #endregion



        public Student()
        {
            FeesPaid = 0;
            StudentId = ++lastStudentId;

        }

        //overlaoded constructor : Takes student ID, Student Name and his grade




        public Student(string name,int age ,int grade,string fatherName,Arts artSubject) : this()
        {
           // this.student_id = id;
            Name = name;
            Age = age;
            StudentGrade = grade;
            Father_Name = fatherName;
            ArtSubjectTaken = artSubject;


        }

        //method to update feesPaid : student will be paying his monthly fee and so the property should get updated

       public void payFee(int amount)
        {
            FeesPaid += amount;

        }

        public decimal CheckAmountDue(decimal feeTotal)
        {
           
                return (feeTotal - FeesPaid);
        }


    }
}
