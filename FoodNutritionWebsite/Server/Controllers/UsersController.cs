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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.Identity;
using FoodNutritionWebsite.Server.Models;
using Microsoft.AspNetCore.Authorization;




namespace FoodNutritionWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

		// GET: api/Users
		[Authorize(Roles = "User")]
		[HttpGet]
        public async Task<IActionResult> GetUsersssss()
        {
            var usersssss = await _unitOfWork.Usersssss.GetAll();
            return Ok(usersssss);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsersssss(int id)
        {
            var user = await _unitOfWork.Usersssss.Get(q => q.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Usersssss.Update(user);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!await UserExists(id))
                {
                    return NotFound();
                }
            }

            return NoContent();
        }


        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {


            await _unitOfWork.Usersssss.Insert(user);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {

            var user = await _unitOfWork.Usersssss.Get(q => q.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            await _unitOfWork.Usersssss.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> UserExists(int id)
        {
            var user = await _unitOfWork.Usersssss.Get(q => q.Id == id);
            return (user != null);
        }




        

    }
}
