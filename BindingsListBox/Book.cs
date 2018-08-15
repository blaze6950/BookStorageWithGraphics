namespace BindingsListBox
{
    public class Book
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Cost { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return Name + "\t" + Author + "\t " + Cost.ToString() + "\t" + Year.ToString();
        }

        public string GetName()
        {
            if (Name.Length < 10)
            {
                return Name;
            }
            else
            {
                return Name.Substring(0, 8) + "..";
            }
        }
    }
}