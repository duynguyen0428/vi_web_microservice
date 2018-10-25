using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using customer.service.DAL;
using customer.service.Model;
using customer.service.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace customer.service.Controllers {
    [Route ("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CustomerController : ControllerBase {
        private readonly ICustomerRepo _repo;
        public CustomerController (ICustomerRepo repo) {
            this._repo = repo;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> Get () {
            var custs = await this._repo.GetCustomers ();
            return Ok (custs);
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<CustomerModel>> Get (string id) {
            var cust = await this._repo.GetDetails (id);
            return Ok (cust);
        }

        // POST api/values
        [HttpPost]
        public async Task < ActionResult> Post ([FromBody] CustomerModel value) {
            await this._repo.Add (value);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}