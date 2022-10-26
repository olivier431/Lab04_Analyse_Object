using CollegeLib;

namespace CollegeDataLib;

public enum SortOrder
{
    Asc,
    Desc
}

public static class Sorting
{
    public static void SortPersonByName(List<Person> data, SortOrder sortOrder = SortOrder.Asc)
    {
        if (sortOrder == SortOrder.Asc)
        {
            data.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));    
        }
        else
        {
            data.Sort((x, y) => String.Compare(y.Name, x.Name, StringComparison.Ordinal));
        }

    }
    public static void SortPersonByDefault(List<Person> data, SortOrder sortOrder = SortOrder.Asc)
    {
        data.Sort();
        if (sortOrder != SortOrder.Asc)
        {
            data.Reverse();
        }
    }
    
    public static void SortPersonByDOB(List<Person> data, SortOrder sortOrder = SortOrder.Asc)
    {
        if (sortOrder == SortOrder.Asc)
        {
            data.Sort((x, y) => x.Dob.CompareTo(y.Dob));    
        }
        else
        {
            data.Sort((x, y) => y.Dob.CompareTo(x.Dob));
        }
    }
    
    public static void SortCourseByDefault(List<Course> data, SortOrder sortOrder = SortOrder.Asc)
    {
        data.Sort();
        if (sortOrder != SortOrder.Asc)
        {
            data.Reverse();
        }
    }
    
    public static void SortCourseByName(List<Course> data, SortOrder sortOrder = SortOrder.Asc)
    {
        if (sortOrder == SortOrder.Asc)
        {
            data.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));    
        }
        else
        {
            data.Sort((x, y) => String.Compare(y.Name, x.Name, StringComparison.Ordinal));
        }
    }
    
    public static void SortCourseOfferingByDefault(List<CourseOffering> data, SortOrder sortOrder = SortOrder.Asc)
    {
        data.Sort();
        if (sortOrder != SortOrder.Asc)
        {
            data.Reverse();
        }
    }
}