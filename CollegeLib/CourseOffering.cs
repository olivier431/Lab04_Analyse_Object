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
        throw new NotImplementedException();
    }
}