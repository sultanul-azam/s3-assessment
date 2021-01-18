using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.BLL.Services;
using S3_Assessment_Web.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S3_Assessment_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _buildingService;
        public BuildingController(IBuildingService buildingService)
        {
            _buildingService = buildingService;
        }

        [HttpGet("GetBuildings")]
        public async Task<IActionResult> GetBuildingsAsync()
        {
            var result = await _buildingService.GetAllBuildingsAsync();
            return Ok(result);
        }

        [HttpPost("AddBuilding")]
        public IActionResult AddBuilding([FromBody] BuildingModel model)
        {
            var buildingEntity = new Building();

            buildingEntity.Name = model.Name;
            buildingEntity.Location = model.Location;

            _buildingService.AddBuilding(buildingEntity);

            return Ok();
        }
    }
}
