using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialOrganizations
{
    public abstract class FinancialInstitution
    {
        public string name = string.Empty;
        public string adress = string.Empty;
        public long statutoryCapital;  // statutory capital = կանոնադրական կապիտալ
        public int branchCount;
        public int totalEmployeeCount;
        public int totalClients;
        protected string CEO = string.Empty;
    }
}
