using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_patch_RESTful.Context;
using E_patch_RESTful.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_patch_RESTful.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientContext _clientContext;
        internal string dbConnection;

        public ClientController()
        {
            _clientContext = new ClientContext(dbConnection);
        }

        [HttpGet()]
        public async Task<object> GetWarmthPreference()
        {
            System.Diagnostics.Debug.WriteLine("Success");
            return null;
        }

        [HttpPost]
        public void CreateWarmthPreference([FromBody] string value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }

        [HttpPut("{id}")]
        public async Task<object> UpdateWarmthPreference(int id, [FromBody] string value)
        {
            object result = await _clientContext.UpdateWarmthPreference(new object());
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<object> DeleteWarmthPreference(int id)
        {
            object result = await _clientContext.DeleteWarmthPreference(new object());
            return result;
        }
    }
}
