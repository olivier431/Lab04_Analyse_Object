namespace CollegeLib;

public class CourseOffering : IComparable<CourseOffering>
{
    public int Year { get; set; }
    public string Semester { get; set; }
    public Course Course { get; set; }
    public Teacher? Teacher { get; set; }

    public CourseOffering(int year, string semester, 
        Course course, Teacher? teacher = null)
    {
        Year = year;
        Semester = semester;
        Course = course;
        Teacher = teacher;
    }

    public int CompareTo(CourseOffering? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        if (Year.CompareTo(other.Year) != 0)
        {
            return Year.CompareTo(other.Year);
        }
        
        if (String.Compare(Semester, other.Semester, StringComparison.Ordinal) != 0)
        {
            return String.Compare(Semester, other.Semester, StringComparison.Ordinal);
        }

        return string.Compare(Course.Code, other.Course.Code, StringComparison.Ordinal);
    }
}