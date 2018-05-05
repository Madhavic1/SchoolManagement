using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
  static  class School
    {

         private static MySchoolDB db = new MySchoolDB();

        //duty is to enroll a student
        /// <summary>
        /// This creates a new student
        /// </summary>
        /// <param name="name">Name of the student</param>
        /// <param name="age">Age of student</param>
        /// <param name="grade">Grdae in which he is studying</param>
        /// <param name="fatherName">Student's Father name</param>
        /// <param name="artSubject">the special art subject taken by a student</param>
        /// <returns></returns>
       

        public static Student EnrollStudent(string name,int age,int grade,string fatherName,Arts artSubject)
        {
            var student = new Student(name, age, grade, fatherName, artSubject);
            db.Students.Add(student);
            db.SaveChanges();

            return student;
        }

        public static IEnumerable<Student> GetStudentInformation(string studentName, string fatherName)
        {
            return db.Students.Where(st => st.Name == studentName)
                .Where(st => st.Father_Name == fatherName);
        }

        public static Teacher AddTeacher(string name, string address,long contactNumber, int grade,decimal totalSalary)
        {
            var teacher = new Teacher { Name = name,
                                        Address = address,
                            ContactNumber=contactNumber,
                            Grade = grade,
                            Totalsalary = totalSalary
            };
            db.Teachers.Add(teacher);
            db.SaveChanges();

            return teacher;
        }
    }
}
