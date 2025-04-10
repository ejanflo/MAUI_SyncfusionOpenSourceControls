using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMAUIProject.Models
{
    public class Employee
    {
        public int id { get; set; }
        public int empId { get; set; }
        public string firstName { get; set; }
        public string? midName { get; set; }
        public string lastName { get; set; }
        public int jobLevel { get; set; }
        public string jobTitle { get; set; }
        public string? phoneNumber { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
    }
}
