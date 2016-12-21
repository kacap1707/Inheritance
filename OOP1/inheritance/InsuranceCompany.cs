using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FinancialInstitution
{
    class InsuranceCompany : FinancialInstitution
    {
        public InsuranceCompany(string name, string adress, long statutoryCapital, long insuranceProvided, string ceo) : base(name, adress, statutoryCapital)
        {
            InsuranceProvided = insuranceProvided;
            CEO = ceo;
        }
        public long InsuranceProvided { get; set; }
    }
}
