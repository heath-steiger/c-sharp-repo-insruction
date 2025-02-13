namespace _10_2_project.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string ToString(){
            return $"Name: {FirstName} {LastName}\n";
        }
        
    }
}
