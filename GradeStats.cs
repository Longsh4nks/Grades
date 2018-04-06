using System;
namespace Grades
{
    public class GradeStats
    {
        public GradeStats()
        {
            HighestGrade = float.MinValue;
            LowestGrade = float.MaxValue;
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
