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
    }
}
