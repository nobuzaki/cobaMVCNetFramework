using CobaMVCNetFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobaMVCNetFramework.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}