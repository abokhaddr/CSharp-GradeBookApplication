using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWheighted) : base(name , isWheighted)
        {   

            Type = GradeBookType.Standard;
        }
    }
}

