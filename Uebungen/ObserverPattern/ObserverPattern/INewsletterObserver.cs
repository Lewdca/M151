using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface INewsletterObserver
    {
        void Update(Newsletter newsletter);
    }
}
