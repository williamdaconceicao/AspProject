using System;
using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

namespace AspCore.Models
{
    public class Services
    {
        public static List<Person> PersonsList = new List<Person>();
    }

/*    public class MyContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public MyContext(DbContextOptions<MyContext> options):base(options) {}
    }*/
}