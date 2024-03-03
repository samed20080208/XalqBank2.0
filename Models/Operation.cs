using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XalqBank2._0.Models
{
    public class Operation
    {
        public Guid ID { get; set; }
        public string ProcessName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
