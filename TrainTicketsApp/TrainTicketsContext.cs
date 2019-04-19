namespace TrainTicketsApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TrainTicketsApp.Models;

    public class TrainTicketsContext : DbContext
    {
        public TrainTicketsContext()
            : base("name=TrainTicketsContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Train> Trains { get; set; }
        public DbSet<Route> Routes{ get; set; }
        public DbSet<Timetable> Timetable { get; set; }
    }
}