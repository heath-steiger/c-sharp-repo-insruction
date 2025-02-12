namespace _07_2_project
{
    public class Grade
    {
        public int GetNumber { get; set; }

        public Grade(int GetNumber)
        {
            this.GetNumber = GetNumber;
        }

        public string GetLetter() {
            if (GetNumber >= 88) return "A";
            else if (GetNumber >= 80) return "B";
            else if (GetNumber >= 67) return "C";
            else if (GetNumber >= 60) return "D";
            else return "F";
            

        }
    }
}
