using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XalqBank2._0.Models
{
    public class CEO : Person
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public void Control() 
        {
            string fullName = $"{Name} {Surname}";
            Console.WriteLine($"CEO {fullName} is overseeing and ensuring the smooth operation of the company.");
        }
        public void Organize()
        {
            Console.WriteLine($"CEO {Name} {Surname} is organizing company-wide tasks.");
        }
        public void MakeMeeting()
        {
            Console.WriteLine($"CEO {Name} {Surname} is conducting a meeting.");
        }
    }


}
