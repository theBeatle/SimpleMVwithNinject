using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class MyBll
    {
        private readonly MyDal dal = new MyDal();

        public string EmployessCount()
        {
            return $"Employess count = {dal.EmployeesCount()}";
        }

    }
}
