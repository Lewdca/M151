using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeBeispiel
{
    public class File : FilesystemComponent
    {
        public string Owner { get; set; }

        public File(string name, string owner)
        {
            this.Name = name;
            this.Owner = owner;
        }

        public override void Print(string spacing)
        {
            Console.WriteLine(spacing + "Dateiname: {0} Besitzer {1}", Name, Owner);
        }
    }
}
