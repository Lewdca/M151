using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    // Konkrete Observer Klasse
    public class Person : INewsletterObserver
    {
        private string name;
        private Newsletter currentNewsletter;

        public Person(string name)
        {
            this.name = name;
        }

        public void Update(Newsletter newsletter)
        {
            currentNewsletter = newsletter;
            Console.WriteLine(name + " hat den neuen Newsletter zum Thema " + currentNewsletter.Topic + " erhalten");
        }
    }
}
