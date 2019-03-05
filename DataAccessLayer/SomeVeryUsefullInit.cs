using System.Data.Entity;

namespace DataAccessLayer
{
    internal class SomeVeryUsefullInit<T> : DropCreateDatabaseAlways<RAES>
    {
        protected override void Seed(RAES context)
        {
            context.Employees.Add(new Employee { Name = "First" });
            context.Employees.Add(new Employee { Name = "Second" });
            context.Employees.Add(new Employee { Name = "Third" });
            context.Employees.Add(new Employee { Name = "Fourth" });
            context.Employees.Add(new Employee { Name = "Fifth" });
            context.SaveChanges();
        }
    }
}