using DataAccessLayer;

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

    }
}
