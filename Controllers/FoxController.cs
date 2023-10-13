using Amazon.DynamoDBv2.Model;
using Laboratorium8.Data;
using Laboratorium8.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoxController : ControllerBase
    {
        private readonly IFoxesRepository _repo;
        public FoxController(IFoxesRepository repository)
        {
            _repo = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Fox>> Get()
        {
            var foxes = _repo.GetAll();

            return Ok(foxes);
        }
        [HttpGet("{id}")]
        public ActionResult<Fox> Get(int id)
        {
            var fox = _repo.Get(id);
            if (fox == null)
            {
                return NotFound();
            }

            return Ok(fox);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Fox fox)
        {
            _repo.Add(fox);
            return CreatedAtAction(nameof(Get), new { id = fox.Id }, fox);
        }

    }
}
