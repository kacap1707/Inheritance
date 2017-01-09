﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialOrganizations
{
   public class InsuranceCompany : FinancialInstitution
    {
        public InsuranceCompany(string name, string adress, long statutoryCapital, long insuranceProvided, string ceo)
        {
            this.name = name;
            this.adress = adress;
            this.statutoryCapital = statutoryCapital;
            InsuranceProvided = insuranceProvided;
            CEO = ceo;
        }
        public long InsuranceProvided { get; set; }
    }
}
