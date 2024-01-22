using FoodNutritionWebsite.Server.Data;
using FoodNutritionWebsite.Server.IRepository;
using FoodNutritionWebsite.Server.Models;
using FoodNutritionWebsite.Shared.Domain;
using FoodNutritionWebsite.Server.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoodNutritionWebsite.Server.Configurations.Entities;

namespace FoodNutritionWebsite.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IGenericRepository<User> _Usersssss;
        private IGenericRepository<FoodLog> _FoodLogs;
        private IGenericRepository<Payment> _Payments;
        private IGenericRepository<Subscription> _Subscriptions;
        private IGenericRepository<Food> _Foods;
        private IGenericRepository<Staff> _Staffs;
        private IGenericRepository<MealPlan> _MealPlans;


        private UserManager<ApplicationUser> _userManager;

        

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        

        public IGenericRepository<User> Usersssss 
            => _Usersssss ??= new GenericRepository<User>(_context);

        public IGenericRepository<FoodLog> FoodLogs 
            => _FoodLogs ??= new GenericRepository<FoodLog>(_context);

        public IGenericRepository<Payment> Payments 
            => _Payments ??= new GenericRepository<Payment>(_context);

        public IGenericRepository<Subscription> Subscriptions 
            => _Subscriptions ??= new GenericRepository<Subscription>(_context);
		public IGenericRepository<Food> Foods
			=> _Foods ??= new GenericRepository<Food>(_context);
        public IGenericRepository<Staff> Staffs
            => _Staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<MealPlan> MealPlans
            => _MealPlans ??= new GenericRepository<MealPlan>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }




       





    }
}