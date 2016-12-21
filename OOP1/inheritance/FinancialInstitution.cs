using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialInstitution
{
    class FinancialInstitution
    {
        public FinancialInstitution(string name, string adress, long statutoryCapital)
        {
            this.name = name;
            this.adress = adress;
            this.statutoryCapital = statutoryCapital;
        }

        public FinancialInstitution()
        {
        }

        public string name = string.Empty;
        public string adress = string.Empty;
        public long statutoryCapital;
        public int branchCount;
        public int totalEmployeeCount;
        public int totalClients;
        protected string CEO = string.Empty;
    }
}
