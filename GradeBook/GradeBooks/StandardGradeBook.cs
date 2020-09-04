using GradeBook.Enums
namespace GradeBook.GradeBooks.StandardGradeBook
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
