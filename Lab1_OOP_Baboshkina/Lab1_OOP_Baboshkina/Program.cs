using System;

namespace Lab1_OOP_Baboshkina
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEdition edition = new PrintEdition("Журнал", "Vogue", "Eugenia de la Torriente", 2020);
            Novel book = new Novel("Преступление и наказание", "Достоевский Ф.М.", "АСТ", 2015, 200);
        }
    }
}
