using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebScraper
{
    class Person
    {
        public string _ssn = "SSN";
        public string _passportData = "Data";
        public string _driversLicenseNumber = "More Data";

        public bool HasProperDocuments
        {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _driversLicenseNumber.Length > 0;
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
