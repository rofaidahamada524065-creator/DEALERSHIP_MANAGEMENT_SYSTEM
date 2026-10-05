using DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.CategoryDTOs;
using DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.VehicleDTOs;
using DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using DEALERSHIP_MANAGEMENT_SYSTEM.Unit_Of_Workk;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _repo;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _repo   = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var x = _repo.catigory.count();
            return Ok(x);
        }


        [HttpPost]
        public IActionResult Post(CreateCatigoryDTO DTO)
        {
            if (DTO == null)
            {
                return BadRequest("NO valied data");
            }
            var x = new Category
            {
                CategoryName = DTO.CategoryName,
                Description = DTO.Description
            };
            _repo.catigory.Add(x);
            _repo.save();
            return Ok();


        }


        [HttpPut]
        public IActionResult Update(UpdateCatigoryDTO updateCatigoryDTO,int id)
        {
            var x=_repo.catigory.getById(id);
            if (x == null) 
            { 
                return NotFound();
            
            
            }
            updateCatigoryDTO.CategoryName = x.CategoryName;
            updateCatigoryDTO.Description = x.Description;

            _repo.save();
            return Ok();
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var x = _repo.catigory.getById(id);
            if (x == null)
            {
                return NotFound();
            }
            _repo.catigory.Delete(id);
            _repo.save();
            return Ok();
        }


    }
}
