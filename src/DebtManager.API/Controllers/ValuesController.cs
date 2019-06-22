using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebtManager.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace DebtManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly DebtManagerContext _context;

        public ValuesController(DebtManagerContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var testes = _context.Testes.ToList();
                      

            return new string[] { testes[0].Id.ToString(), testes[0].Nome };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
