using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_OOP_Baboshkina
{
    class Novel : Books
    {
        int price;

        public Novel(string name, string author, string publisher, int release, int price) : base(name, author, "роман", publisher, release)
        {
            this.price = price;
        }
    }
}
