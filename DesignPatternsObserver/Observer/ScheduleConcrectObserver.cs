

using DesignPatternsObserver.Entities;
using DesignPatternsObserver.Observer.Interfaces;
using DesignPatternsObserver.Observer.Subjects;
using System;
using System.Collections.Generic;

namespace DesignPatternsObserver.Observer
{
    public class ScheduleConcrectObserver : IObserver
    {
        public ScheduleConcrectObserver(ISubject subject)
        {
            subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            if(subject is Schedules schedule)
            {
                Console.WriteLine($"Changes in your schedules! new date: {schedule.Date.ToString("dd/MM/yyyy HH:mm")}");
            }
        }
    }
}
