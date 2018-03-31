using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Teacher
    {
        //properties

        //Teacher ID  id
        //Teacher Name name
       
       
        //Teacher salary    salary
        //Salary Earned by Teacher

        public int id { get; set; } //shld be unique
        public string name { get; set; }
        public float salary { get; set; }
        public int salaryEarned { get; set; }

    }
}
