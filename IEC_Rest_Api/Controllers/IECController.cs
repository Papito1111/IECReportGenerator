using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IECReportGenerator.Models;
using IECReportGenerator.Infrastructure;
using IECReportGenerator;

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

            var generator = new IECReportGenerator1(new WindReader(),
                                       new IECWriter());
            generator.GeneratorReport("data.json", "iec.json");

            return result;
        }

    }
}
