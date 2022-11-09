using CollegeDataLib;

namespace CollegeLibDataTest;

public class CourseOfferingSortingTest
{
    private readonly MockCourseOfferingRepo _mock;

    public CourseOfferingSortingTest()
    {
        _mock = new MockCourseOfferingRepo();
    }
    
    [Fact]
    public void SortCourseOfferingByDefaultASCTest()
    {
        var data = _mock.Select();
        Sorting.SortCourseOfferingByDefault(data, SortOrder.Asc);
        
        Assert.Equal("A2022", data[3].Semester);
        Assert.Equal("A2021", data[2].Semester);
        Assert.Equal("A2020", data[1].Semester);
        Assert.Equal("A2019", data[0].Semester);
    }
    
    [Fact]
    public void SortCourseOfferingByDefaultASCTest2()
    {
        var data = _mock.Select();
        Sorting.SortCourseOfferingByDefault(data, SortOrder.Asc);
        
        for (int i = 1; i < data.Count; i++)
        {
            Assert.True(data[i-1].CompareTo(data[i]) < 0);
        }
        
    }
    
    [Fact]
    public void SortCourseOfferingByDefaultDESCTest()
    {
        var data = _mock.Select();
        Sorting.SortCourseOfferingByDefault(data, SortOrder.Desc);
        
        Assert.Equal("A2022", data[0].Semester);
        Assert.Equal("A2021", data[1].Semester);
        Assert.Equal("A2020", data[2].Semester);
        Assert.Equal("A2019", data[3].Semester);
    }
    
    [Fact]
    public void SortCourseOfferingByDefaultDESCTest2()
    {
        var data = _mock.Select();
        Sorting.SortCourseOfferingByDefault(data, SortOrder.Desc);
        
        for (int i = 1; i < data.Count; i++)
        {
            Assert.True(data[i-1].CompareTo(data[i]) > 0);
        }
        
    }
}