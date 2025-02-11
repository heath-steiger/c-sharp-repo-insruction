using System.Diagnostics;

namespace _07_2_project
{
    public class Grade
    {
        public int getNumber { get; set; }
        public string getLetter(int grade) {
            if (grade >= 88) return "A";
            else if (grade >= 80) return "B";
            else if (grade >= 67) return "C";
            else if (grade >= 60) return "D";
            else return "F";


        }
    }
}
