using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
// Bhanu -- 16/09/2022 -- UserProfile table with all props
/// </summary>
namespace ECOM.Models
{
    public class UserProfile:IdentityUser
    {
        
        public DateTime dob { get; set; }

        public string Address { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

      

       
    }
}
