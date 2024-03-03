using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XalqBank2._0.Models
{
    public class Credit
    {
        public Guid ID { get; set; }
        public Client Client { get; set; }
        public decimal Amount { get; set; }
        public decimal Percent { get; set; }
        public int Months { get; set; }

        public decimal PaidAmount { get; private set; }

        public decimal CalculatePrecent() 
        {
            decimal interestRate = 0.05m;
            Percent = Amount * interestRate;
            return Percent;
        }
        public void Payment(decimal money)
        {
            
            PaidAmount += money;
        }

        public static explicit operator Credit(Operation v)
        {
            throw new NotImplementedException();
        }
    }
}
