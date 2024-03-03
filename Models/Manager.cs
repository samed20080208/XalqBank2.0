using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XalqBank2._0.Models
{
    public class Manager : Person
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public void Organize()
        {
            Console.WriteLine($"Manager {Name} {Surname} is organizing tasks.");

            OrganizeTeamMeetings();
            AssignTasksToTeamMembers();
            ReviewTaskProgress();

            Console.WriteLine($"Manager {Name} {Surname} has completed organizing tasks.");
        }

        private void OrganizeTeamMeetings()
        {
            Console.WriteLine($"Organizing team meetings for Manager {Name} {Surname}.");
        }

        private void AssignTasksToTeamMembers()
        {
            Console.WriteLine($"Assigning tasks to team members for Manager {Name} {Surname}.");
        }

        private void ReviewTaskProgress()
        {
            Console.WriteLine($"Reviewing task progress for Manager {Name} {Surname}.");
        }
        public void CalculateSalaries()
        {
            Console.WriteLine($"Manager {Name} {Surname} is calculating salaries.");

            decimal bonusPercentage = 0.1m; 
            decimal bonus = Salary * bonusPercentage;

            Console.WriteLine($"Manager {Name} {Surname} will receive a bonus of {bonus:C}.");
            Console.WriteLine($"Total salary for Manager {Name} {Surname}: {Salary + bonus:C}");
        }
    }
}
