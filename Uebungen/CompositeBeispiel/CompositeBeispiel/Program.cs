using System;

namespace CompositeBeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory videokurs = new Directory("Videokurs");

            File kursskript = new File("Kursskript", "Ineichen");
            Directory kursvideos = new Directory("Kursvideos");

            videokurs.Add(kursskript);
            videokurs.Add(kursvideos);

            Directory modul1 = new Directory("Modul 1");
            Directory modul2 = new Directory("Modul 2");

            kursvideos.Add(modul1);
            kursvideos.Add(modul2);

            File einfuerung = new File("Einführung", "Ineichen");
            File installation = new File("Installation", "Ineichen");
            File variablen = new File("Variablen", "Ineichen");

            modul1.Add(einfuerung);
            modul2.Add(installation);
            modul2.Add(variablen);

            videokurs.Print("");
            Console.ReadKey();
        }
    }
}
