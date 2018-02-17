using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Omgtitb.Learning.AspNetCore.AppModel;
using Omgtitb.Learning.AspNetCore.AppCore;

namespace Omgtitb.Learning.AspNetCore.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class PoseController : Controller
    {
        // Verb     API             Description     Request Body    Response Body
        // GET      /api/pose       Get all         None            array of items
        // GET      /api/pose/{id}  Get an item     None            item
        // POST     /api/pose       Add new item    item            item
        // PUT      /api/pose/{id}  Update item     item            none
        // DELETE   /api/pose/{id}  Delete item     none            none

        private readonly PoseContext _context;

        public PoseController(PoseContext context)
        {
            _context = context;

            if (_context.PoseItems.Count() == 0)
            {
                _context.PoseItems.Add(new Pose(1, "Warrior One"));
                _context.PoseItems.Add(new Pose(2, "Warrior Two"));
                _context.SaveChanges();
            }
        }

        // GET api/pose
        [HttpGet]
        public IEnumerable<Pose> Get()
        {
            return _context.PoseItems.ToList();
        }

        // GET api/pose/5
        [HttpGet("{id}", Name = "GetPose")]
        public IActionResult Get(int id)
        {
            var item = _context.PoseItems.FirstOrDefault(p => p.Id == id);

            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST api/pose
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/pose/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/pose/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
