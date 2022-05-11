using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SportNewsletter sn = new SportNewsletter(new Newsletter("Tipps für dein Training", "Inhalt ..."));

            Person person1 = new Person("Thomas");
            Person person2 = new Person("Alina");
            Person person3 = new Person("Ed");

            sn.Subscribe(person1);
            sn.Subscribe(person2);

            sn.SetNewsletter(new Newsletter("Olympische Spiele", "Inhalt..."));

            sn.Unsubscribe(person1);
            sn.Subscribe(person3);

            sn.SetNewsletter(new Newsletter("Championsleague", "Inhalt..."));

            Console.ReadKey();
        }
    }
}
