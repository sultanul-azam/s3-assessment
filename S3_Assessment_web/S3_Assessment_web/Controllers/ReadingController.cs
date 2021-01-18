using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.BLL.Services;
using S3_Assessment_Web.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace S3_Assessment_web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadingController : ControllerBase
    {
        private readonly IReadingService _readingService;

        public ReadingController(IReadingService readingService)
        {
            _readingService = readingService;
        }

        [HttpGet("GetData")]       
        public async Task<IActionResult> GetDataAsync([FromQuery] SearchModel searchCriteria)
        {      
            var result = await _readingService.GetReadingsAsync(searchCriteria);
           return Ok(result);
        }
    }
}
