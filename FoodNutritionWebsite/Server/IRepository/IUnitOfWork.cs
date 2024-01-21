using FoodNutritionWebsite.Server.IRepository;
using FoodNutritionWebsite.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<User> Usersssss { get; }
        IGenericRepository<FoodLog> FoodLogs { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Subscription> Subscriptions { get; }

    }
}