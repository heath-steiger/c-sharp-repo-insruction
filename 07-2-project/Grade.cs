namespace _07_2_project
{
    public class Grade
    {
        public int GetNumber { get; set; }

        public Grade()
        {
            this.GetNumber = 0;
        }
        public Grade(int GetNumber)
        {
            this.GetNumber = GetNumber;
        }

        public string GetLetter() {
            string letterGrade = "F";
            if (GetNumber >= 88) return letterGrade = "A";
            else if (GetNumber >= 80) return letterGrade = "B";
            else if (GetNumber >= 68) return letterGrade = "C";
            else if (GetNumber >= 60) return letterGrade = "D";
            return letterGrade;
        }
    }
}
