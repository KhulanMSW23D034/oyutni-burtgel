namespace oyutni_burtgel;

public class Student
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string Department { get; set; }
    public bool HasScholarship { get; set; }
    public bool IsDaytime { get; set; }
    public List<string> Courses { get; set; } = new();
    public string Language { get; set; }
}