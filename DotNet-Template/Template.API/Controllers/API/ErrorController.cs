using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;

namespace Template.API.Controllers.API
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        [Route("/error")]
        public IActionResult Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            if (context.Error is UnauthorizedAccessException) 
                return Problem(title: context.Error.Message, statusCode: (int)HttpStatusCode.Unauthorized);
            else if (context.Error is FileNotFoundException)
                return Problem(title: context.Error.Message, statusCode: (int)HttpStatusCode.NotFound);

            return Problem(title: context.Error.Message);
        }
    }
}
