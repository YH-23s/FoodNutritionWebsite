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
    public class StaffsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StaffsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        // GET: api/Staffs
        [HttpGet]
        public async Task<IActionResult> GetStaffs()
        {
            var staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(staffs);
        }



        // GET: api/Staffs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaffs(int id)
        {
            var staffs = await _unitOfWork.Staffs.Get(q => q.Id == id);

            if (staffs == null)
            {
                return NotFound();
            }

            return Ok(staffs);
        }



        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            if (id != staff.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Staffs.Update(staff);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!await StaffExists(id))
                {
                    return NotFound();
                }
            }

            return NoContent();
        }





        // POST: api/Staffs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {


            await _unitOfWork.Staffs.Insert(staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = staff.Id }, staff);
        }



        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {

            var user = await _unitOfWork.Staffs.Get(q => q.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        private async Task<bool> StaffExists(int id)
        {
            var user = await _unitOfWork.Usersssss.Get(q => q.Id == id);
            return (user != null);
        }


    }
}
