using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IECReportGenerator.Models;

namespace IEC_Rest_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IECController : ControllerBase

    {
        [HttpGet]
        public IEnumerable<IECModel> Get()
        {
            var result = new List<IECModel>();
            return result;
        }

    }
}
