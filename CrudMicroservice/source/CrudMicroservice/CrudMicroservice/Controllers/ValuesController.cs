using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FyrSoft.WaaS.ConfigManRepository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrudMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var sccmUser = new SccmUser();
            string json = JsonConvert.SerializeObject(sccmUser);

            return new string[] { json };
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
