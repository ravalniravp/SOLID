using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ManagerAccounts : IAccounts
    {
        public Employee Create(IApplicantModel person)
        {
            Employee output = new();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.Email = $"{person.FirstName.Substring(0, 1)}{person.LastName}@abc.com";
            output.isManager = true;
            return output;
        }
    }
}
