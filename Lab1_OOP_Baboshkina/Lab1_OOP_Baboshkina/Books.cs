using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_OOP_Baboshkina
{
    abstract class Books : PrintEdition
    {
        string author;
        string genre;

        public Books(string name, string author, string genre, string publisher, int release) : base("Книга", name, publisher, release)
        {
            this.author = author;
            this.genre = genre;
        }
    }
}
