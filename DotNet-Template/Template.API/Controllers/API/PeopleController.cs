using Microsoft.AspNetCore.Mvc;
using System;
using Template.Models.ViewModels;
using Template.Services.People;

namespace Template.API.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPeople(Guid id)
        {
            PeopleViewModel people = _peopleService.GetPeople(id);
            return Ok(people);
        }

        [HttpPost]
        public IActionResult AddPeople(PeopleViewModel people)
        {
            _peopleService.AddPeople(people);
            return Ok();
        }
    }
}
