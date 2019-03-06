using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public interface IMyBll
    {
        string EmployessCount();
        List<DateInterval> GetIntervals(DateInterval model);
    }
}