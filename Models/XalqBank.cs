using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XalqBank2._0.Models
{
    public class XalqBank
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public decimal Profit { get; set; }
        public CEO CEO { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Client> Clients { get; set; }

        public void PayCredit(Client client, decimal money)
        {
            Worker foundWorker = Workers.FirstOrDefault(w => w.ID == client.ID);

            if (foundWorker != null)
            {
                IEnumerable<Credit> workerCredits = foundWorker.Operations
                    .Where(operation => operation is Credit)
                    .Cast<Credit>();

                foreach (Credit credit in workerCredits)
                {
                    decimal remainingAmount = credit.Amount - credit.PaidAmount;

                    if (remainingAmount >= money)
                    {
                        credit.Payment(money);
                        Console.WriteLine($"Payment of {money} successfully applied to Credit ID {credit.ID} for {client.Name} {client.Surname}.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Insufficient remaining amount on Credit ID {credit.ID} for {client.Name} {client.Surname}.");
                    }
                }

                Console.WriteLine($"No credit found for {client.Name} {client.Surname} associated with worker {foundWorker.Name} {foundWorker.Surname}.");
            }
            else
            {
                Console.WriteLine($"Worker not found in the bank for client {client.Name} {client.Surname}.");
            }
        }


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
      

        public void ShowClientCredits(string fullName)
        {
            string[] names = fullName.Split(' ');

            string firstName = names[0];
            string lastName = names.Length > 1 ? names[1] : string.Empty;

            Worker worker = Workers.FirstOrDefault(w => w.Name.Equals(firstName, StringComparison.OrdinalIgnoreCase) && w.Surname.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (worker != null)
            {
                Console.WriteLine($"Credits for {fullName}:");

                var creditOperations = worker.Operations
                    .Where(operation => operation is Credit);

                foreach (Operation operation in creditOperations)
                {
                    Credit credit = (Credit)operation;
                    Console.WriteLine($"Credit ID: {credit.ID}");
                    Console.WriteLine($"Amount: {credit.Amount}");
                    Console.WriteLine($"Interest Percent: {credit.Percent}");
                    Console.WriteLine($"Months: {credit.Months}");
                    Console.WriteLine("=============================");
                }
            }
            else
            {
                Console.WriteLine($"Worker {fullName} not found in the bank.");
            }
        }
    }
}
