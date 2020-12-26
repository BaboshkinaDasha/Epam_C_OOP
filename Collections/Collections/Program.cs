using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEdition edition = new PrintEdition("Журнал", "Vogue. Выпуск 1", "Eugenia de la Torriente", "мода", "Eugenia de la Torriente", 1892, 96.43);
            PrintEdition edition1 = new PrintEdition("Книга", "Преступление и наказание", "Достоевский Ф.М.", "роман", "АСТ", 2015, 250.74);
            PrintEdition edition2 = new PrintEdition("Журнал", "Vogue", "Eugenia de la Torriente", "мода", "Eugenia de la Torriente", 2020, 200.43);
            PrintEdition edition3 = new PrintEdition("Книга", "Собачье сердце", "Булгаков М.А.", "роман", "АСТ", 2019, 240.54);
            PrintEdition edition4 = new PrintEdition("Книга", "Щелкунчик и Мышиный король", "Гофман Э.", "книга для детей", "Феникс", 2019, 150.54);
            PrintEdition edition5 = new PrintEdition("Книга", "Винни-Пух и все-все-все", "Милн А.", "книга для детей", "РОСМЭН", 2022, 150.54);

            List<PrintEdition> coll = new List<PrintEdition>() {edition, edition1, edition2, edition3, edition4};

            List<PrintEdition> collnew = coll.Where(x => x.type == "Книга").ToList();

            Iskl();
        }
        static void Iskl()
        {
            try
            {
                string word;
                Console.WriteLine("Введите слово из 6 букв:");
                word = Console.ReadLine();
                if (Equals(word.Length, 6))
                {
                    Console.WriteLine("Вы ввели слово - {0}", word);
                }
                else
                {
                    throw new Exception("Длина строки не 6 букв");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nВ вашем слове не 6 букв!\nВведите другое слово!\n");
                Iskl();
            }
        }
    }
}
