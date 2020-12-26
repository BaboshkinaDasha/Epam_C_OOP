using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_OOP_Baboshkina
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
    }
}
