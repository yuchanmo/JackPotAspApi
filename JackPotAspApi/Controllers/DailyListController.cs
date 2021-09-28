using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JackPotAspApi.Controllers
{
    //[EnableCors(origins: "https://jackpotman.z22.web.core.windows.net/", headers: "*", methods: "*")]

    public class DailyListController : ApiController
    {
        private RichBoyEntities _Dc = new RichBoyEntities();
        public DailyListController()
        {

        }

        [HttpGet]
        public IEnumerable<GetSummmary_Result> Get(DateTime from, DateTime to)
        {
            return _Dc.GetSummmary(from, to);

        }
    }
}
