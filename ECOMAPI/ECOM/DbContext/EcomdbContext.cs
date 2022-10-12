
using ECOM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOM.DbContext
{
    public class EcomdbContext:IdentityDbContext
    {
        public EcomdbContext(DbContextOptions<EcomdbContext>options):base(options)
        {

        }
        // Bhanu -- 16/09/2022-- UserProfile table with all props
        public DbSet<UserProfile> userProfiles { get; set; }
  
     

        // Akshay -- 16/09/2022-- Support table with all props
        public DbSet<Support> supports { get; set; }

        public DbSet<Feedback> feedbacks { get; set; }

        public DbSet<Models.ProductInfo> ProductInfo { get; set; }

        public DbSet<ProductCategory> ProductCategory { get; set; }

        public DbSet<Orders> orders { get; set; }

        public DbSet<ProductSubCategory> SubCategories { get; set; }


    }
}
