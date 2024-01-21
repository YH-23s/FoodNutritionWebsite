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
    public class FoodLogsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FoodLogsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/FoodLogs
        [HttpGet]
        public async Task<IActionResult> GetFoodLogs()
        {
            var fodlogs = await _unitOfWork.FoodLogs.GetAll(includes: q => q.Include(x => x.Food).Include(x => x.User));
            return Ok(fodlogs);
        }


        // GET: api/FoodLogs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFoodLogs(int id)
        {
            var fodlog = await _unitOfWork.FoodLogs.Get(q => q.Id == id);

            if (fodlog == null)
            {
                return NotFound();
            }

            return Ok(fodlog);
        }

        // PUT: api/FoodLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodLog(int id, FoodLog foodlog)
        {
            if (id != foodlog.Id)
            {
                return BadRequest();
            }

            _unitOfWork.FoodLogs.Update(foodlog);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!await FoodLogExists(id))
                {
                    return NotFound();
                }
            }

            return NoContent();
        }

        

        // POST: api/FoodLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FoodLog>> PostUser(FoodLog foodlog)
        {


            await _unitOfWork.FoodLogs.Insert(foodlog);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetUser", new { id = foodlog.Id }, foodlog);
        }

        // DELETE: api/FoodLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodLog(int id)
        {

            var foodlog = await _unitOfWork.FoodLogs.Get(q => q.Id == id);
            if (foodlog == null)
            {
                return NotFound();
            }

            await _unitOfWork.FoodLogs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> FoodLogExists(int id)
        {
            var user = await _unitOfWork.Usersssss.Get(q => q.Id == id);
            return (user != null);
        }


    }
}
