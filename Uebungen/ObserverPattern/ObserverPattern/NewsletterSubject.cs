using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class NewsletterSubject
    {
        private List<INewsletterObserver> observers = new List<INewsletterObserver>();

        public void Subscribe(INewsletterObserver observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unsubscribe(INewsletterObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void SendNewsletter(Newsletter newNewsletter)
        {
            foreach(INewsletterObserver o in observers)
            {
                o.Update(newNewsletter);
            }
        }
    }
}
