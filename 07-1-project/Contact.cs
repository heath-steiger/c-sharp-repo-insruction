namespace _07_1_project
{
    public class Contact
    {
            public string FirstName {  get; set; }
            public string LastName {  get; set; }
            public string Email { get; set; }
            public string Phone {  get; set; }
            
            public Contact() {
        }
            public Contact(string FirstName, string LastName, string Email, string Phone )
        {
            this.FirstName = FirstName;
            this.LastName = LastName;  
            this.Email = Email;
            this.Phone = Phone;
        }
        public string ToString()
        {
            return $"Contact({FirstName}): {LastName}, {Email}, {Phone}";
        }

    }
}
