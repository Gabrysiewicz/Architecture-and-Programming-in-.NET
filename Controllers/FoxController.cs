using Amazon.DynamoDBv2.Model;
using Laboratorium8.Data;
using Laboratorium8.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Laboratorium8.Controllers
{
    [Route("api/fox")] // Note: It worked well for Postman with lowercased without that change
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
            var foxes = _repo.GetAll()
                .OrderByDescending(x => x.Loves)
                .ThenBy(x => x.Hates);

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
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public IActionResult Post([FromBody] Fox fox)
        {
            _repo.Add(fox);
            return CreatedAtAction(nameof(Get), new { id = fox.Id }, fox);
        }

        [HttpPut("love/{id}")]
        public IActionResult Love(int id)
        {
            var fox = _repo.Get(id);
            if (fox == null)
                return NotFound();
            fox.Loves++;
            _repo.Update(id, fox);
            return Ok(fox);
        }
        [HttpPut("hate/{id}")]
        public IActionResult Hate(int id)
        {
            var fox = _repo.Get(id);
            if (fox == null)
                return NotFound();
            fox.Hates++;
            _repo.Update(id, fox);
            return Ok(fox);
        }
    }
}
