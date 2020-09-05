
using GradeBook.Enums;

   namespace GradeBook.GradeBooks
{
     public class StandardGradeBook : BaseGradeBook
    {
      public class  StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }  
    }
}

