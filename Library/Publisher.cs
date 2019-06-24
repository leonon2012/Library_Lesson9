
namespace Library
{
    class Publisher
    {
        string name;
        public string Name { get => name; set => name = value.Trim(); }

        public Publisher() : this("noname")
        {
        }

        public Publisher(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Издательство \"{name}\"";
        }
    }
}
