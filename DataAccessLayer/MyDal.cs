using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MyDal : IMyDal
    {
        private readonly DbContext ctx; // = new RAES();

        public MyDal(DbContext ctx)
        {
            this.ctx = ctx;
        }

        public int EmployeesCount()
        {
            return ctx.Set<Employee>().Count();  //    .Employees.Count();
        }

        public List<DateInterval> GetIntervals(DateInterval model)
        {
            var res = ctx.Set<DateInterval>().Where(d => (d.StartDate >= model.StartDate && d.StartDate <= model.EndDate)
             || (d.EndDate >= model.StartDate && d.EndDate <= model.EndDate));
            return res.ToList();
        }
    }
}
