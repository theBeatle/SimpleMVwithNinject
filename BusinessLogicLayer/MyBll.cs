using System.Collections.Generic;
using DataAccessLayer;
using System.Linq;
using System;

namespace BusinessLogicLayer
{
    public class MyBll : IMyBll
    {
        private readonly IMyDal dal;         //MyDal dal = new MyDal();

        public MyBll(IMyDal dal)
        {
            this.dal = dal;
        }

        public string EmployessCount()
        {
            return $"Employess count = {dal.EmployeesCount()}";
        }

        public List<DateInterval> GetIntervals(DateInterval model)
        {
            DataAccessLayer.DateInterval dalModel = new DataAccessLayer.DateInterval()
            {
                 StartDate = model.StartDate,
                EndDate = model.EndDate,

            };
            var res = dal.GetIntervals(dalModel);
            return res.Select(r => new DateInterval { StartDate = r.StartDate, EndDate = r.EndDate }).ToList(); 
        }
    }
}
