using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        string name;
        List<Author> authors;
        Publisher publ;

        public string Name { get => name; set => name = value.Trim(); }
        public List<Author> Authors { get => authors; set => authors = value; }
        public Publisher Publ { get => publ; set => publ = value; }

        public Book(string bookname, string authors, string publ)
        {
            Name = bookname;

            string[] A = authors.Split(new char[] { ';', ',' });
            Authors = new List<Author>();
            foreach (var item in A)
                Authors.Add(new Author(item));

            Publ = new Publisher(publ);
        }

        public override string ToString()
        {
            string result = "";

            result = $"Книга \"{name}\"\n";

            foreach (var item in authors)
            {
                result += item + "\n";
            }

            result += Publ;

            return result;
        }
    }
}
