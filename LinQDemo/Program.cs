namespace LinQDemo;

class Program
{
    static void Main(string[] args)
    {
        var repo = new StudentRepository();
        var service = new StudentService(repo.GetStudents());

        // Query Syntax
        var resultQuery = service.GetExcellentStudents_QuerySyntax();
        service.PrintResult(resultQuery, "Query Syntax");

        // Method Syntax
        var resultMethod = service.GetExcellentStudents_MethodSyntax();
        service.PrintResult(resultMethod, "Method Syntax");
    }
}