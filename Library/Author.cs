using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Author
    {
        string name;
        public string Name { get => name; set => name = value.Trim(); }

        public Author() : this("noname")
        {
        }

        public Author(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Автор \"{name}\"";
        }
    }
}
