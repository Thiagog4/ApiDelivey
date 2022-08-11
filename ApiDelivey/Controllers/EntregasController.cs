using ApiDelivey.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDelivey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntregasController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Entregas>>> Get()
        {
           var entregas = new List<Entregas>
            {
                new Entregas
                {
                    id = 1,
                    nrEntrega = "01",
                    dataDaEntrega = DateTime.Now
                }
                
            };
            return Ok(entregas);
        }
    }
}
