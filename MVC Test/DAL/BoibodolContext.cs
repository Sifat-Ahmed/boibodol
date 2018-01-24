using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MVC_Test.Models;

namespace MVC_Test.DAL
{

    // context Tutorial Can be found here 
    // https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application


    public class BoibodolContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Contact> Contacts { get; set;  }

        public BoibodolContext() : base("BoibodolContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            // The builder.Conventions.Remove statement in the OnModelCreating method prevents 
            // table names from being pluralized.
            // This means that there will tables with only one name with no copy 

            builder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}