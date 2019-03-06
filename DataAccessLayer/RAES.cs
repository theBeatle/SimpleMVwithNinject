namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RAES : DbContext
    {
        public RAES()
            : base("name=RAES")
        {
            Database.SetInitializer<RAES>(new SomeVeryUsefullInit<RAES>());
        }

        
         public virtual DbSet<Employee> Employees { get; set; }

         public virtual DbSet<DateInterval> DateIntervals { get; set; }

    }


}