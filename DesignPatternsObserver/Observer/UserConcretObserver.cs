

using DesignPatternsObserver.Observer.Interfaces;
using System;

namespace DesignPatternsObserver.Entities
{
    public class UserConcretObserver : IObserver
    {
        public UserConcretObserver(ISubject subject)
        {
            subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            if(subject is Product prod)
            {
                Console.WriteLine(string.Format("Hello! The product {0} change the disponibility for: {1}", prod.Name, prod.Disponibility));
            }  
        }
    }
}
