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
    public class DatafieldController : ControllerBase
    {
        private readonly IDataFieldService _dataFieldService;
        public DatafieldController(IDataFieldService dataFieldService)
        {
            _dataFieldService = dataFieldService;
        }

        [HttpGet("GetDatafields")]
        public async Task<IActionResult> GetObjectsAsync()
        {
            var result = await _dataFieldService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost("AddDatafield")]
        public IActionResult AddObject([FromBody] DatafieldModel model)
        {
            var datafieldEntity = new DataField();

            datafieldEntity.Name = model.Name;

            _dataFieldService.Add(datafieldEntity);

            return Ok();
        }
    }
}
