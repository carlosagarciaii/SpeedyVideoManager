using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpeedyVideoManager.Models;
using System.Data.Entity;

namespace SpeedyVideoManager.DB_Context
{
    public class CustomContext : DbContext
    {

        DbSet<Customer> Customer;
        DbSet<Movie> Movie;
        DbSet<MembershipTypes> MembershipTypes;

    }
}