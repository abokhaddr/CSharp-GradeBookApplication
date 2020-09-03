using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook: BaseGradeBook
    {
        public StandardGradeBook(string name): base (name) // We're calling the constructore of the base class.
        {
            Type = GradeBookType.Standard;
        }
    }
}
