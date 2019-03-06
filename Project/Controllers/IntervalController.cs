using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Controllers
{
    public class IntervalController : ApiController
    {
        private readonly IMyBll bll; // MyBll bll = new MyBll();

       
        public IntervalController(IMyBll bll)
        {
            this.bll = bll;
        }

        // GET api/<controller>
        public IEnumerable<DateInterval> Get(string from, string to)
        {
            var dateStart = DateTime.Parse(from);
            var dateEnd = DateTime.Parse(from);

            var model = new DateInterval
            {
                StartDate = dateStart,
                EndDate = dateEnd,
            };

            IEnumerable<DateInterval> results = bll.GetIntervals(model);
            return results.ToArray();
        }


        // POST api/<controller>
        [HttpPost]
        public void AddInterval([FromBody]string from,[FromBody] string to)
        {
            var x = 1;

        }

    }
}