using DesignPatternsObserver.Observer.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatternsObserver.Observer.Subjects
{
    public sealed class Schedules : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();   
        public int Id { get; set; }
        public DateTime Date { get; private set; }  

        public Schedules(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        public void ChangeDate(DateTime date)
        {
            Date = date;
            Notify();
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
           foreach(var observer in _observers)
           {
                observer.Update(this);
           }
        }
    }
}
