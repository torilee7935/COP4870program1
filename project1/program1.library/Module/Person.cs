namespace program1.library.Module
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, double> Grades { get; set; }
        public PersonClassification Classification { get; set; }

        public Person()
        {
            Name = string.Empty;
            Grades = new Dictionary<int, double>();
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public enum PersonClassification
    {
        Freshman, Sophmore, Junior, Senior
    }
}
