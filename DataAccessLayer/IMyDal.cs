using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IMyDal
    {
        int EmployeesCount();
        List<DateInterval> GetIntervals(DateInterval dalModel);
    }
}