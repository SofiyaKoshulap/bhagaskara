
using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace bhagaskara.Models
{
  
    public class Feedback_context : DbContext
    {
        public DbSet<Feedback> Feedback { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //   // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    Database.SetInitializer<Feedback_context>(null);
        //    base.OnModelCreating(modelBuilder);
        //}
        public static Feedback_context Create()
    {
        return new Feedback_context();
    }
    }
 
}