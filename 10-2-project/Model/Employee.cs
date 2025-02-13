namespace _10_2_project.Model
{
    internal class Employee : Person
    {
        public string SSN { get; set; }


        public Employee(string firstName, string lastName, string ssn) :
            base(firstName, lastName)
        {
            this.SSN = ssn;
        }

        public override string ToString()
        {

            string ssnMasked = "xxx-xx-" + SSN.Substring(7);
            return $"{base.ToString()}SSN: ({ssnMasked})";
        }

    }
}
