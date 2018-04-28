using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //put everything inside a while(true) loop so that everything appears again n again to the user untill he hits quit option

            Console.WriteLine("Welcome to our School");
            Console.WriteLine("***********************");

            while (true)
            {


                Console.WriteLine("0 : Quit");
                Console.WriteLine("1 : Register for School");
                Console.WriteLine("2: View Student Information");
                Console.WriteLine("3: Pay Tuition Fee");
                Console.WriteLine("4: View Balance Due");


                Console.WriteLine("Please Select an option from Above..");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting ");
                        return;
                    case "1":
                        //Enrolling a student .. Collecting  Student's Data 
                        Console.Write("Student Name :");
                        var name = Console.ReadLine();

                        Console.Write("Student Age: ");
                        var age = Convert.ToInt32(Console.ReadLine());


                        Console.Write(" Grade: ");
                        var grade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Father Name :");
                        var fatherName = Console.ReadLine();

                        Console.WriteLine("Art Subject ?");
                        var artSubjects = Enum.GetNames(typeof(Arts));

                        for (int i = 0; i < artSubjects.Length; i++)
                        {
                            Console.WriteLine($"{i}.{artSubjects[i]}");
                        }
                        Console.Write("Your choice");
                        var artSubject = (Arts)Enum.Parse(typeof(Arts), Console.ReadLine());

                        var student = School.EnrollStudent(name, age, grade, fatherName, artSubject);
                        Console.WriteLine($"N Name: {student.Name} Age: {student.Age} Grade : {student.StudentGrade} Father: {student.Father_Name} Art : {student.ArtSubjectTaken}");

                        Console.ReadKey();




                        break;
                    case "2":
                        Console.Write("Student Name :");
                        name = Console.ReadLine();
                        Console.WriteLine("Father Name :");
                        fatherName = Console.ReadLine();
                        var students = School.GetStudentInformation(name, fatherName);
                        foreach (var std in students)
                        {
                            Console.WriteLine($"N Name: {std.Name} Age: {std.Age} Grade : {std.StudentGrade} Father: {std.Father_Name} Art : {std.ArtSubjectTaken}");
                        }

                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }

            }

        }
    }
}
