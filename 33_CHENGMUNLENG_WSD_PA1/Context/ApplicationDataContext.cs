using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _33_CHENGMUNLENG_WSD_PA1.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace _33_CHENGMUNLENG_WSD_PA1.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}