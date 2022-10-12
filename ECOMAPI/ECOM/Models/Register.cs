using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
// Bhanu -- 16/09/2022 -- UserProfileModel table with all props
/// </summary>
namespace ECOM.Models
{
    public class Register
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Bhanu -- 17/09/2022-- added more fields to gather info from user during registration.
        public DateTime dob { get; set; }

        public string Address { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
        public string PhoneNumber { get; set; }
        public string role { get; set; }


    }
}
