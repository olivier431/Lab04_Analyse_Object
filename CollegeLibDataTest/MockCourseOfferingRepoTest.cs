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
        //var actual = _mock.Select(0);
        //Assert.Equal("420-0Q5-SW", actual.Code);
        //Assert.True(_mock.Update(new("421-0Q5-SW", "Reseaux")));
        //var course = _mock.Select(0);
        //Assert.Equal("421-0Q5-SW", course.Code);
    }
    
    [Fact]
    public void DeleteTest()
    {
        Assert.Equal(4, _mock.Count);
        Assert.True(_mock.Delete(1));
        Assert.Equal(3, _mock.Count);
    }
}