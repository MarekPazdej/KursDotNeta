using System;
using System.Collections.Generic;
using System.Text;

namespace Freight_Forwarder_Assistant_FFA
{
    public class Clients : ContactDetails
    {
        public string TaxIdentificationNumber { get; set; }

        public string CompanyName { get; set; }

        public string ClientOrderNumber { get; set; } 
        
        public Clients (string taxIdentificatorNumber)
        {
            TaxIdentificationNumber = taxIdentificatorNumber;
        }

        public Clients (string taxIdentificatorNumber, string companyName)
        {
            TaxIdentificationNumber = taxIdentificatorNumber;
            CompanyName = companyName;
        }
    }
}
