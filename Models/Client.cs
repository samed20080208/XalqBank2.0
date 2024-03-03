using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XalqBank2._0.Models
{
    public class Client : Person
    {   

        public string LiveAddress { get; set; }
        public string WorkAddress { get; set; }
        public decimal Salary { get; set; }
    }
}
