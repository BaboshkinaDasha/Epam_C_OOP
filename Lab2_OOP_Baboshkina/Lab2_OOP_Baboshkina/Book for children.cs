using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_OOP_Baboshkina
{
    class Book_for_children<T> : Books
    {
        T age;
        int price;

        public Book_for_children (string name, string author, string publisher, int release, T age, int price) : base(name, author, "книга для детей", publisher, release)
        {
            this.age = age;
            this.price = price;
        }
    }
}
