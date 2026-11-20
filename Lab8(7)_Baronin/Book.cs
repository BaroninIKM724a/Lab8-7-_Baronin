namespace Lab8_7__Baronin
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"{Author} {Title}";
        }
    }
}


