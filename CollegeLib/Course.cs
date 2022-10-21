namespace CollegeLib;

public class Course : IComparable<Course>
{
    public string Code { get; set; }
    public string Name { get; set; }

    public Course(string code, string name)
    {
        Code = code;
        Name = name;
    }

    public int CompareTo(Course? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return String.Compare(Code, other.Code, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{Code}: {Name}";
    }
}