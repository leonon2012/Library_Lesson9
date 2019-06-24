using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, Book> Lib = new Dictionary<int, Book>();

            Lib.Add(0, new Book("Книга требований", "Столяр, Бородкина, Бровко, Онуприенко", "Питер Пен, Солантек"));
            Lib.Add(1, new Book("Discovery", "Dasha, Iren, Alexandra", "Питер Пен, Солантек"));
            Lib.Add(2, new Book("Overview Debit", "Borodkina, Bondarenko", "VOSTOK"));

            foreach (var item in Lib)
            {
                Console.WriteLine(item.Value);
                Console.WriteLine("\n\n");
            }            
        }
    }
}
