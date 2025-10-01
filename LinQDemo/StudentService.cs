namespace LinQDemo;

public class StudentService
{
    private readonly List<Student> _students;

    public StudentService(List<Student> students)
    {
        _students = students;
    }

    // LINQ Query Syntax
    public IEnumerable<object> GetExcellentStudents_QuerySyntax()
    {
        var query = from s in _students
            where s.Score >= 8
            orderby s.Name
            select new { s.Name, s.Score };
        return query;
    }

    // LINQ Method Syntax
    public IEnumerable<object> GetExcellentStudents_MethodSyntax()
    {
        var query = _students
            .Where(s => s.Score >= 8)
            .OrderBy(s => s.Name)
            .Select(s => new { s.Name, s.Score });
        return query;
    }

    // Hiển thị kết quả
    public void PrintResult(IEnumerable<object> results, string title)
    {
        Console.WriteLine($"===== {title} =====");
        foreach (var r in results)
            Console.WriteLine(r);
    }
}