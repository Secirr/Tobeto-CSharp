using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Brands.Commends.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BrandsController : ControllerBase
    {
        IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand) //FromBody yazdığımız swagger'ı CreateBrandCommand' a map'liyor.
        {
            //dbye eklenecek
            CreatedBrandResponse response = await _mediator.Send(createBrandCommand); //createBrandCommand'ı çalıştır diyoruz. Aslında burada  createBrandCommandHandler'ı çalıştır diyoruz. Çünkü Mediatr görevi olan Commandları Handlerlar ile eşleştirdı
            return Ok(response);                                                      //createBrandCommand'ın handler'ını getiriyor.
        }
    }
}

