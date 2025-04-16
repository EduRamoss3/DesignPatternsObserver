using DesignPatternsObserver.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsObserver.Observer.Interfaces
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
