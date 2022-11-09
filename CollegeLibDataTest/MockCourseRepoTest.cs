using CollegeDataLib;
using CollegeLib;

namespace CollegeLibDataTest;

public class MockCourseRepoTest
{
    private readonly MockCourseRepo _mock;
    
    public MockCourseRepoTest()
    {
        _mock = new MockCourseRepo();
    }

    [Fact]
    public void SelectTest()
    {
        var actual = _mock.Select();
        Assert.Equal(4, actual.Count);
    }

    [Fact]
    public void SelectByIdTest()
    {
        var actual = _mock.Select(0);
        Assert.Equal("Reseau", actual.Name);
        
        actual = _mock.Select(1);
        Assert.Equal("420-0SW-SW", actual.Code);
    }

    [Fact]
    public void InsertTest()
    {
        Assert.Equal(4, _mock.Count);
        Assert.Equal(1, _mock.Insert(new("420-2SS-SW", "Developpement : Sujet speciaux")));
        Assert.Equal(5, _mock.Count);
    }

    [Fact]
    public void UpdateTest()
    {
        var actual = _mock.Select(0);
        Assert.Equal("Reseau", actual.Name);
        Assert.True(_mock.Update(new Course("420-0Q5-SW", "Reseaux" )));
        var course = _mock.Select(0);
        Assert.Equal("Reseaux", course.Name);
    }

    [Fact]
    public void DeleteTest()
    {
        Assert.Equal(4, _mock.Count);
        Assert.True(_mock.Delete(1));
        Assert.Equal(3, _mock.Count);
    }
}