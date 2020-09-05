namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
         public StandardGradeBook(string name) : base(name)
        {
            Name = name;
            Type = Enums.GradeBookType.Standard;
        }
    }
}
