using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_OOP_Baboshkina
{
    class Novel : Books
    {
        int price;

        public Novel(string name, string author, string publisher, int release, int price) : base(name, author, "роман", publisher, release)
        {
            this.price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Novel novel &&
                   price == novel.price;
        }
    }
}
