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

namespace MealPlanNutritionWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealPlansController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MealPlansController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        // GET: api/MealPlans
        [HttpGet]
        public async Task<IActionResult> GetMealPlans()
        {
            var mealplans = await _unitOfWork.MealPlans.GetAll();
            return Ok(mealplans);
        }



        // GET: api/MealPlans/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMealPlans(int id)
        {
            var mealplans = await _unitOfWork.MealPlans.Get(q => q.Id == id);

            if (mealplans == null)
            {
                return NotFound();
            }

            return Ok(mealplans);
        }



        // PUT: api/MealPlans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMealPlan(int id, MealPlan mealplan)
        {
            if (id != mealplan.Id)
            {
                return BadRequest();
            }

            _unitOfWork.MealPlans.Update(mealplan);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!await MealPlanExists(id))
                {
                    return NotFound();
                }
            }

            return NoContent();
        }





        // POST: api/MealPlans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MealPlan>> PostMealPlan(MealPlan mealplan)
        {


            await _unitOfWork.MealPlans.Insert(mealplan);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMealPlan", new { id = mealplan.Id }, mealplan);
        }



        // DELETE: api/MealPlans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMealPlan(int id)
        {

            var user = await _unitOfWork.MealPlans.Get(q => q.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            await _unitOfWork.MealPlans.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> MealPlanExists(int id)
        {
            var user = await _unitOfWork.Usersssss.Get(q => q.Id == id);
            return (user != null);
        }


    }
}
