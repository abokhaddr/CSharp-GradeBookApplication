using System;
using System.Linq;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(string name): base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {

            if (Students.Count< 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work)");
            }

            var threshold = (int) Math.Ceiling (Students.Count * 0.2); // Get the 20% 
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();


            //return base.GetLetterGrade(averageGrade);
            return 'F';
        }
    }
}
