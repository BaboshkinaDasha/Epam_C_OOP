using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_OOP_Baboshkina
{
    class PrintEdition
    {
        string type;
        string name;
        string publisher;
        int release;

        public PrintEdition(string type, string name, string publisher, int release)
        {
            this.type = type;
            this.name = name;
            this.publisher = publisher;
            this.release = release;
        }

        public override string ToString()
        {
            return String.Format("В {0} году издательство {1} произвело публикацию - {2} '{3}' \n", this.release, this.publisher, this.type, this.name);
        }

        public override bool Equals(object obj)
        {
            return obj is PrintEdition printEdition &&
                   name.Contains(printEdition.name);
        }
    }
}
