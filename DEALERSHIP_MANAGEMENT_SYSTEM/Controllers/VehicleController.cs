using System.Numerics;
using DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.VehicleDTOs;
using DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using DEALERSHIP_MANAGEMENT_SYSTEM.Unit_Of_Workk;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IUnitOfWork _repo;
        public VehicleController(IUnitOfWork unitOfWork)
        {
            _repo = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        { 
          var x=_repo.vehicleCustom.GetAll();
            List<VehicleDTO> c = new List<VehicleDTO>();
            foreach (var v in x)
            {
                var veh = new VehicleDTO
                {
                    VehicleId = v.VehicleId,
                    Make = v.Make,
                    Model = v.Model,
                    Year = v.Year,
                    Color = v.Color,
                    Price = v.Price,
                    Mileage = v.Mileage,
                    VIN = v.VIN,
                    FuelType = v.FuelType,
                    Transmission = v.Transmission,
                    Status = v.Status,
                    CategoryId = v.CategoryId,


                };

                c.Add(veh);

            }

            return Ok(c);
        
        }

        [HttpGet("GetAllAvelable")]
        public IActionResult GetAllAvelable()
        {
            var x = _repo.vehicleCustom.GetAllVehicles();
            List<VehicleDTO> c = new List<VehicleDTO>();
            foreach (var v in x)
            {
                var veh = new VehicleDTO
                {
                    VehicleId = v.VehicleId,
                    Make = v.Make,
                    Model = v.Model,
                    Year = v.Year,
                    Color = v.Color,
                    Price = v.Price,
                    Mileage = v.Mileage,
                    VIN = v.VIN,
                    FuelType = v.FuelType,
                    Transmission = v.Transmission,
                    Status = v.Status,
                    CategoryId = v.CategoryId,


                };

                c.Add(veh);

            }

            return Ok(c);

        }

        [HttpPost]
        public IActionResult Post(CreateVehicleDTO DTO) 
        {
            if (DTO == null)
            {
                return BadRequest("NO valied data");
            }
            var x = new Vehicle
            {
                Make = DTO.Make,
                Model = DTO.Model,
                Year = DTO.Year,
                Color = DTO.Color,
                Price = DTO.Price,
                Mileage = DTO.Mileage,
                VIN = DTO.VIN,
                FuelType = DTO.FuelType,
                Transmission = DTO.Transmission,
                Status = DTO.Status,
                CategoryId = DTO.CategoryId,
            };
            _repo.vehicleCustom.Add(x);
            _repo.save();   
            return Ok();
        
        
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var x = _repo.vehicleCustom.getById(id);
            if (x == null)
            {
                return NotFound();
            }
            _repo.vehicleCustom.Delete(id);
            _repo.save();
            return Ok();
        }


        [HttpPut]
        public IActionResult Update(UpdateVehicleDTO DTO,int id)
        {
            var x = _repo.vehicleCustom.getById(id);
            if(x == null)
            {
                return NotFound();
            }
           
            x.Model = DTO.Model;
            x.Year = DTO.Year;
            x.Color = DTO.Color;
            x.Price = DTO.Price;
            x.Mileage = DTO.Mileage;
            x.VIN = DTO.VIN;
            x.FuelType = DTO.FuelType;
            x.CategoryId = DTO.CategoryId;
            x.Status = DTO.Status;
            x.Make=DTO.Make;


         
          
            _repo.save();
            return Ok();

        }


    }
}
