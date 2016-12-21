using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialInstitution
{
    class CreditOrganization : FinancialInstitution
    {
        public CreditOrganization(string name, string adress, long statutoryCapital) : base(name,adress,statutoryCapital)
        {
            
        }
        public long CreditPortfolio { get; set; }
    }
}
