using AdessoRideShare.Repository.Context.Abstract;
using AdessoRideShare.Repository.EntityModel.Concerete;
using Microsoft.EntityFrameworkCore;
using System;

namespace AdessoRideShare.Repository.Context.Concerete
{
    public class RideShareDbContext : DbContext,IDbContext
    {
        public RideShareDbContext(DbContextOptions<RideShareDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name="İstanbul"},
                new City { Id = 2, Name = "Bursa" }
            );
            modelBuilder.Entity<TravelPlan>().HasData(
                new TravelPlan { Id = 1, FromId = 1, ToId = 2, Date = DateTime.UtcNow, Description = "Medeniyet Yolculugu", MaxChair = 50,Status=1 }
            );
            modelBuilder.Entity<User>().HasData(
                new User { Id=1,Name="Barış Can",Surname="Tanrıverdi"},
                new User { Id = 2, Name = "Anıl Dursun", Surname = "Şenel" }
            );
            modelBuilder.Entity<TravelPlanUsers>().HasData(
                new TravelPlanUsers { Id = 1, TravelPlanId=1, UserId=2 , Status=1, ChairCount=1 },
                new TravelPlanUsers { Id = 2, TravelPlanId=1, UserId=1 , Status=1 , ChairCount=6}
            );

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<TravelPlan> TravelPlans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<TravelPlanUsers> TravelPlanUsers { get; set; }

    }
}
