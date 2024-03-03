using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XalqBank2._0.Models
{
    public class Worker : Person
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Operation> Operations { get; set; }

        public void AddOperation(Operation operation)
        {
            Operations.Add(operation);
        }
    }
}
