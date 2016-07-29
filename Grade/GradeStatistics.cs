namespace Grade
{
    public class GradeStatistics
    {

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }


        public string Description// using a switch 
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Fail";
                        break;


                }
                return result;
            }
        }
        public string LetterGrade
        {
            get // branching using if else statements and 
            {
                string result;

                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }

                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        // delegate keyword is keyword for referencing methods . the type definition looks like a method 
        // public delegate void Writer(string message)



    }
}