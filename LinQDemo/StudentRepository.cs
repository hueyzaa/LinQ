namespace LinQDemo;

public class StudentRepository
{
    public List<Student> GetStudents()
    {
        return new List<Student>
        {
            new Student { Id = 1, Name = "An", Score = 7.5 },
            new Student { Id = 2, Name = "Bình", Score = 9.0 },
            new Student { Id = 3, Name = "Chi", Score = 8.2 },
            new Student { Id = 4, Name = "Dũng", Score = 6.5 },
            new Student { Id = 5, Name = "Hà", Score = 9.5 }
        };
    }
}