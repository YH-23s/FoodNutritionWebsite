using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodNutritionWebsite.Server.Data;
using FoodNutritionWebsite.Shared.Domain;
using FoodNutritionWebsite.Server.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http.HttpResults;
using FoodNutritionWebsite.Server.Models;
using System.Security.Claims;
using Duende.IdentityServer.Test;

namespace FoodNutritionWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public PersonnelController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        // GET: api/Staffs
        [HttpGet]
        public async Task<ActionResult?> GetPersonnel()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            var roles = await _userManager.GetRolesAsync(user);
            return Ok(new { id = user.Id, firstName = user.FirstName, email = user.Email, roles = roles[0] });
        }
    }
}
