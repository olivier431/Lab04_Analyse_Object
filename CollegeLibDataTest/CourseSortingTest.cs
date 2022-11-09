using CollegeDataLib;
using CollegeLib;

namespace CollegeLibDataTest;

public class CourseSortingTest
{
    private readonly MockCourseRepo _mock;

    public CourseSortingTest()
    {
        _mock = new MockCourseRepo();
    }
    
    [Fact]
    public void SortCourseByDefaultASCTest()
    {
        var data = _mock.Select();
        Sorting.SortCourseByDefault(data, SortOrder.Asc);
        
        Assert.Equal("Reseau", data[0].Name);
        Assert.Equal("Programmation jeux", data[1].Name);
        Assert.Equal("Analyse Objet", data[2].Name);
        Assert.Equal("Web : Serveur 2", data[3].Name);
    }
    
    [Fact]
    public void SortCourseByDefaultASCTest2()
    {
        var data = _mock.Select();
        Sorting.SortCourseByDefault(data, SortOrder.Asc);
        
        for (int i = 1; i < data.Count; i++)
        {
            Assert.True(data[i-1].CompareTo(data[i]) < 0);
        }
        
    }
    
    [Fact]
    public void SortCourseByDefaultDESCTest()
    {
        var data = _mock.Select();
        Sorting.SortCourseByDefault(data, SortOrder.Desc);
        
        Assert.Equal("Reseau", data[3].Name);
        Assert.Equal("Programmation jeux", data[2].Name);
        Assert.Equal("Analyse Objet", data[1].Name);
        Assert.Equal("Web : Serveur 2", data[0].Name);
    }
    
    [Fact]
    public void SortCourseByDefaultDESCTest2()
    {
        var data = _mock.Select();
        Sorting.SortCourseByDefault(data, SortOrder.Desc);
        
        for (int i = 1; i < data.Count; i++)
        {
            Assert.True(data[i-1].CompareTo(data[i]) > 0);
        }
        
    }
    
    [Fact]
    public void SortCourseByNameASCTest()
    {
        var data = _mock.Select();
        Sorting.SortCourseByName(data, SortOrder.Asc);
        
        Assert.Equal("Reseau", data[2].Name);
        Assert.Equal("Programmation jeux", data[1].Name);
        Assert.Equal("Analyse Objet", data[0].Name);
        Assert.Equal("Web : Serveur 2", data[3].Name);
    }
    
    [Fact]
    public void SortCourseByNameASCTest2()
    {
        var data = _mock.Select();
        Sorting.SortCourseByName(data, SortOrder.Asc);
        
        for (int i = 1; i < data.Count; i++)
        {
            Assert.True(String.Compare(data[i - 1].Name, data[i].Name, StringComparison.Ordinal) < 0);
        }
        
    }
    
    [Fact]
    public void SortCourseByNameDESCTest()
    {
        var data = _mock.Select();
        Sorting.SortCourseByName(data, SortOrder.Desc);
        
        Assert.Equal("Reseau", data[1].Name);
        Assert.Equal("Programmation jeux", data[2].Name);
        Assert.Equal("Analyse Objet", data[3].Name);
        Assert.Equal("Web : Serveur 2", data[0].Name);
    }
    
    [Fact]
    public void SortCourseByNameDESCTest2()
    {
        var data = _mock.Select();
        Sorting.SortCourseByName(data, SortOrder.Desc);
        
        for (int i = 1; i < data.Count; i++)
        {
            Assert.True(String.Compare(data[i - 1].Name, data[i].Name, StringComparison.Ordinal) > 0);
        }
        
    }
}