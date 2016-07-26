namespace Grade
{
    public class GradeStatistics
    {

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        // delegate keyword is keyword for referencing methods . the type definition looks like a method 
        // public delegate void Writer(string message)



    }
}