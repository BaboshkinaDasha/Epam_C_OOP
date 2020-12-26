using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class PrintEdition
    {
        public string type;
        public string name;
        public string author;
        public string theme_genre;
        public string publisher;
        public int release;
        public double price;

        public PrintEdition(string type, string name, string author, string theme_genre, string publisher, int release, double price)
        {
            this.type = type;
            this.name = name;
            this.author = author;
            this.theme_genre = theme_genre;
            this.publisher = publisher;
            this.release = release;
            this.price = price;
        }
    }
}
