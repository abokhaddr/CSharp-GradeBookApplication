using System;
using GradeBook.Enums;
namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
    }
}
