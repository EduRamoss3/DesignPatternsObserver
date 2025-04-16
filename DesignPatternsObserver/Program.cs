using DesignPatternsObserver.Entities;
using DesignPatternsObserver.Observer;
using DesignPatternsObserver.Observer.Subjects;
using System;

namespace DesignPatternsObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1,"Teclado",true);
            Product product2 = new Product(2, "Mouse", false);

            Schedules schedule1 = new Schedules(4, DateTime.Now);
            Schedules schedule2 = new Schedules(4, DateTime.Now);

            ScheduleConcrectObserver userOne = new ScheduleConcrectObserver(schedule1);
            ScheduleConcrectObserver userTwo = new ScheduleConcrectObserver(schedule2);

            UserConcretObserver userThree = new UserConcretObserver(product1);
            UserConcretObserver userFour = new UserConcretObserver(product2);

            Console.WriteLine("Press key to change something");
            Console.ReadKey();

            product1.SetDisponibility(false);
            product2.SetDisponibility(true);

            schedule1.ChangeDate(DateTime.UtcNow);

            Console.ReadKey();

        }
    }
}
