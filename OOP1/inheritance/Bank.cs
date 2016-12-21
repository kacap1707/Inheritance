using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FinancialInstitution
{
    class Bank : FinancialInstitution
    {
        public Bank(string name, string adress, long statutoryCapital, long assets, long liabilities) : base(name, adress, statutoryCapital)
        {
            Assets = assets;
            Liabilities = liabilities;
        }
        public long Assets { get; set; }
        public long Liabilities { get; set; }

        public enum StatutoryCapitalMinimum : long
        {
            StatutroyCapitalMinimumOldVersion = 5000000000,
            StatutoryCapitalMinimumForArmeniaFrom010117 = 30000000000
        }
    }
}
