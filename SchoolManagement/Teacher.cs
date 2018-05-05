using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        
        public int Id { get; set; } //shld be unique
        
        public string Name { get; set; }
        public decimal Totalsalary { get; set; }
        public int SalaryEarned { get; set; }
        public long ContactNumber { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }





    }
}
