using System;

namespace Lab2_OOP_Baboshkina
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEdition edition = new PrintEdition("Журнал", "Vogue. Выпуск 1", "Eugenia de la Torriente", 1892);
            PrintEdition edition1 = new PrintEdition("Журнал", "Vogue", "Eugenia de la Torriente", 2020);
            Novel book = new Novel("Преступление и наказание", "Достоевский Ф.М.", "АСТ", 2015, 200);
            Novel book1 = new Novel("Собачье сердце", "Булгаков М.А.", "АСТ", 2019, 200);
            Novel book2 = new Novel("Преступление и наказание", "Достоевский Ф.М.", "АСТ", 2015, 230);
            Book_for_children<int> book3 = new Book_for_children<int>("Винни-Пух и все-все-все", "Милн А.", "РОСМЭН", 2017, 3, 200);
            Book_for_children<string> book4 = new Book_for_children<string>("Щелкунчик и Мышиный король", "Гофман Э.", "Феникс", 2019, "3-4 года", 200);

            Console.WriteLine(edition.ToString());
            Console.WriteLine("price of book = price of book1:");
            Console.WriteLine(book.Equals(book1));
            Console.WriteLine("price of book = price of book2:");
            Console.WriteLine(book.Equals(book2));
            Console.WriteLine("name of edition1 in name of edition:");
            Console.WriteLine(edition.Equals(edition1));
            Console.WriteLine("name of edition in name of edition1:");
            Console.WriteLine(edition1.Equals(edition));
        }
    }
}
