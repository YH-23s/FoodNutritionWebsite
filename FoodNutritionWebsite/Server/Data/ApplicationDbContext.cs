using Duende.IdentityServer.EntityFramework.Options;
using FoodNutritionWebsite.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FoodNutritionWebsite.Shared.Domain;
using FoodNutritionWebsite.Server.Configurations.Entities;


namespace FoodNutritionWebsite.Server.Data
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}
		public DbSet<AddNutrition> AddNutritions { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<User> Usersssss { get; set; }
        public DbSet<FoodAddedL> FoodAddedLs { get; set; }
        public DbSet<FoodAddedMP> FoodAddedMPs { get; set; }
        public DbSet<FoodLog> FoodLogs { get; set; }
        public DbSet<FoodNutrition> FoodNutritions { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserSeedConfiguration());
        }
    }
}