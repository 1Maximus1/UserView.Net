namespace UserView.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public int YearAtUniversity { get; set; }
        public string Hobbies { get; set; }

        public Person() { }

        public Person(string name, string surname, string group, int yearAtUniversity, string hobbies)
        {
            Name = name;
            Surname = surname;
            Group = group;
            YearAtUniversity = yearAtUniversity;
            Hobbies = hobbies;
        }
    }

}
