using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IEC_Rest_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IECController : ControllerBase
    {
        IEnumerable<IECModel> Get()
        {
            var result = new List<IECModel>();
        }

    }
}
