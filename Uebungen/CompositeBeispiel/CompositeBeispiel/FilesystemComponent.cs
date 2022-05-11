using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeBeispiel
{
    public abstract class FilesystemComponent
    {
        public string Name { get; set; }

        public abstract void Print(string spacing);
    }
}
