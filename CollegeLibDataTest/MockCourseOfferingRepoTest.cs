using CollegeDataLib;
using CollegeLib;

namespace CollegeLibDataTest;

public class MockCourseOfferingRepoTest
{
    private readonly MockCourseOfferingRepo _mock;
    
    public MockCourseOfferingRepoTest()
    {
        _mock = new MockCourseOfferingRepo();
    } 
    
    [Fact]
    public void SelectTest()
    {
        var actual = _mock.Select();
        Assert.Equal(4, actual.Count);
    }
    
    [Fact]
    public void SelectIdTest()
    {
        var actual = _mock.Select(0);
        Assert.Equal("Ti-paul", actual.Teacher.Name);
        
        actual = _mock.Select(1);
        Assert.Equal("Programmation jeux", actual.Course.Name);
    }
    
    [Fact]
    public void InsertTest()
    {
        Course c5 = new("420-1W2-SW", "Ordinateur");
        Teacher t5 = new ("Ti-pauly", DateOnly.FromDateTime(new DateTime(2022, 10, 28)), 5, "info", true, "teacher");
        Assert.Equal(4, _mock.Count);
        Assert.Equal(1, _mock.Insert(new(2022, "A2022", c5, t5)));
        Assert.Equal(5, _mock.Count);
    }
    
    [Fact]
    public void UpdateTest()
    {
        Course c1 = new("420-0Q5-SW", "Reseau");
        Course c2 = new("420-0SW-SW", "Programmation jeux");
        
        Teacher t1 = new (18,"Ti-paul", DateOnly.FromDateTime(new DateTime(2022, 10, 27)), 1, "info", true, "teacher");
        Teacher t2 = new ("Ti-paulo", DateOnly.FromDateTime(new DateTime(2022, 10, 27)), 2, "info", true, "teacher");
        var actual = _mock.Select(0);
        Assert.Equal(c1, actual.Course);
        Assert.Equal(t1, actual.Teacher);
        Assert.Equal("A2022", actual.Semester);
        Assert.Equal(2022, actual.Year);
        
        Assert.True(_mock.Update(new(2022, "H2023", c2, t2)));
        var course = _mock.Select(0);
        Assert.Equal(c2, course.Course);
        Assert.Equal(t2, course.Teacher);
        Assert.Equal("H2023", course.Semester);
        Assert.Equal(2022, course.Year);
    }
    
    [Fact]
    public void DeleteTest()
    {
        Assert.Equal(4, _mock.Count);
        Assert.True(_mock.Delete(1));
        Assert.Equal(3, _mock.Count);
    }
}