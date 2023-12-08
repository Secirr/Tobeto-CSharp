using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseEducatorsController : Controller
    {
        ICourseEducatorService _courseEducatorService;

        public CourseEducatorsController(ICourseEducatorService courseEducatorService)
        {
            _courseEducatorService = courseEducatorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _courseEducatorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _courseEducatorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(CourseEducator courseEducator)
        {
            var result = _courseEducatorService.Add(courseEducator);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CourseEducator courseEducator)
        {
            var result = _courseEducatorService.Update(courseEducator);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(CourseEducator courseEducator)
        {
            var result = _courseEducatorService.Delete(courseEducator);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

