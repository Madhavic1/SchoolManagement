using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Student
    {
        //properties  or variables

        //Student ID     :   student_id
        //student name   :   student_name
        //Student Age    :   s_Age
        //class or grade :   grade
        //Student Fee paid   :   feesPaid
        //student's Addr :   S_Addr
        //total fee to be paid : feeTotal
       

        public int student_id { get; set; } //unique , can not be edited by others than School
        public string  S_Name { get; set; }
        public int s_Age { get; set; }
        public int grade { get; set; }
        public float feesPaid { get; set; }
        public float feeTotal { get; set; }


    }
}
