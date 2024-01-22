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

namespace FoodNutritionWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FoodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        // GET: api/Foods
        [HttpGet]
        public async Task<IActionResult> GetFoods()
        {
            var foods = await _unitOfWork.Foods.GetAll();
            return Ok(foods);
        }



        // GET: api/Foods/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFoods(int id)
        {
            var foods = await _unitOfWork.Foods.Get(q => q.Id == id);

            if (foods == null)
            {
                return NotFound();
            }

            return Ok(foods);
        }



        // PUT: api/Foods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFood(int id, Food food)
        {
            if (id != food.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Foods.Update(food);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!await FoodExists(id))
                {
                    return NotFound();
                }
            }

            return NoContent();
        }





        // POST: api/Foods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Food>> PostFood(Food food)
        {


            await _unitOfWork.Foods.Insert(food);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFood", new { id = food.Id }, food);
        }



        // DELETE: api/Foods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(int id)
        {

            var user = await _unitOfWork.Foods.Get(q => q.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            await _unitOfWork.Foods.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> FoodExists(int id)
        {
            var user = await _unitOfWork.Usersssss.Get(q => q.Id == id);
            return (user != null);
        }


    }
}
