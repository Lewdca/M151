using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeBeispiel
{
    public class Directory : FilesystemComponent
    {
        private List<FilesystemComponent> includedFiles = new List<FilesystemComponent>();

        public Directory(string name)
        {
            this.Name = name;
        }

        public override void Print(string spacing)
        {
            Console.WriteLine(spacing + "Verzeichnis: " + Name);

            // Reklursiver Aufruf wird so oft aufgerufen, bis alle Dateien im Baum sich geprintet haben.
            // File Name und Owner wird geprintet, Directory ruft weitere FilesystemComponent auf.
            foreach(FilesystemComponent component in includedFiles)
            {
                component.Print(spacing + "     ");
            }
        }

        // Helfermethoden
        public void Add(FilesystemComponent component)
        {
            includedFiles.Add(component);
        }

        public void Remove(FilesystemComponent component)
        {
            includedFiles.Remove(component);
        }

        public FilesystemComponent GetFilesystemComponent(int index)
        {
            return includedFiles[index];
        }
    }
}
