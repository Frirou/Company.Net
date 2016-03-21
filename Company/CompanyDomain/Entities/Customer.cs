using System;
using System.Collections.Generic;

namespace CompanyDomain.Entities
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Age { get; set; }
        public string DaytimePhone { get; set; }
        public string EmailAddress { get; set; }
        public string CompanyName { get; set; }
        public string CompanyManager { get; set; }
        public Nullable<bool> IsCompany { get; set; }
    }
}
