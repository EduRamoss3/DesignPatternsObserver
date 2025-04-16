
using DesignPatternsObserver.Observer.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatternsObserver.Entities
{
    public sealed class Product : ISubject
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public bool Disponibility { get; set; }
        private List<IObserver> _observers = new List<IObserver>();

        public Product(int id, string name, bool disponibility)
        {
            Id = id;
            Name = name;
            Disponibility = disponibility;
        }
        public void SetDisponibility(bool disponibility)
        {
            Disponibility = disponibility;
            Console.WriteLine($"SUBJECT: The product {Name} disponibility was updated! Disponibility: {disponibility}");
            Notify();
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

      
    }
}
