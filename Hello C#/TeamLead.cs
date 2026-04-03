using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__strart
{
    public class TeamLead : Employee
    {
        public const string ME = "TeamLead";

        public TeamLead(string name, int age, decimal salary) : base(name, age, salary)
        {
             
        }
    }
}
