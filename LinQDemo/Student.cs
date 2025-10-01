namespace LinQDemo;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Name} - {Score}";
    }  
}