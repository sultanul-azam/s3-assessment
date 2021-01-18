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
    public class ObjectController : ControllerBase
    {
        private readonly IObjectsService _objectsService;
        public ObjectController(IObjectsService objectsService)
        {
            _objectsService = objectsService;
        }

        [HttpGet("GetObjects")]
        public async Task<IActionResult> GetObjectsAsync()
        {
            var result = await _objectsService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost("AddObject")]
        public IActionResult AddObject([FromBody] ObjectModel model)
        {
            var objectEntity = new Objects();

            objectEntity.Name = model.Name;

            _objectsService.Add(objectEntity);

            return Ok();
        }
    }
}
