using CollegeDataLib;
using CollegeLib;

namespace CollegeLibDataTest;

public class PersonSortingTests
{
    private readonly MockPersonRepo _mock;

    public PersonSortingTests()
    {
        _mock = new MockPersonRepo();
    }
    
    // test avec connaissance des données du mock
    [Fact]
    public void SortByNameAscTest()
    {
        // var mock = new MockPersonRepo();
        var data = _mock.Select();
        Sorting.SortPersonByName(data);

        Assert.Equal("Alice", data[0].Name);
        Assert.Equal("Bob", data[1].Name);
        Assert.Equal("Catherine", data[2].Name);
        Assert.Equal("Denis", data[3].Name);
    }

    // test sans connaissance des données du mock
    [Fact]
    public void SortByNameAscTest2()
    {
        // var mock = new MockPersonRepo();
        var data1 = _mock.Select();
        var data = new List<Person>(data1);
        Sorting.SortPersonByName(data);

        for (int i = 1; i < data.Count; i++)
        {
            Assert.Equal(-1, String.Compare(data[i - 1].Name, data[i].Name, StringComparison.Ordinal));
        }
    }

    // test avec connaissance des données du mock
    [Fact]
    public void SortByNameDescTest()
    {
        // var mock = new MockPersonRepo();
        var data = _mock.Select();
        Sorting.SortPersonByName(data, SortOrder.Desc);

        Assert.Equal("Alice", data[3].Name);
        Assert.Equal("Bob", data[2].Name);
        Assert.Equal("Catherine", data[1].Name);
        Assert.Equal("Denis", data[0].Name);
    }

    // test sans connaissance des données du mock
    [Fact]
    public void SortByNameDescTest2()
    {
        var data = _mock.Select();
        Sorting.SortPersonByName(data, SortOrder.Desc);

        for (int i = 1; i < data.Count; i++)
        {
            Assert.Equal(1, String.Compare(data[i - 1].Name, data[i].Name, StringComparison.Ordinal));
        }
    }
    
    [Fact]
    public void SortByDefaultASCTest()
    {
        var data = _mock.Select();
        Sorting.SortPersonByDefault(data, SortOrder.Asc);
        
        Assert.Equal("Alice", data[2].Name);
        Assert.Equal("Bob", data[3].Name);
        Assert.Equal("Catherine", data[0].Name);
        Assert.Equal("Denis", data[1].Name);
    }
    
    [Fact]
    public void SortByDefaultAscTest2()
    {
        var data = _mock.Select();
        Sorting.SortPersonByDefault(data, SortOrder.Asc);

        for (int i = 1; i < data.Count; i++)
        {
            Assert.Equal(-1, data[i-1].CompareTo(data[i]));
        }
    }
    
    [Fact]
    public void SortByDefaultDESCTest()
    {
        var data = _mock.Select();
        Sorting.SortPersonByDefault(data, SortOrder.Desc);
        
        Assert.Equal("Alice", data[1].Name);
        Assert.Equal("Bob", data[0].Name);
        Assert.Equal("Catherine", data[3].Name);
        Assert.Equal("Denis", data[2].Name);
    }
    
    [Fact]
    public void SortByDefaultDescTest2()
    {
        var data = _mock.Select();
        Sorting.SortPersonByDefault(data, SortOrder.Desc);

        for (int i = 1; i < data.Count; i++)
        {
            Assert.Equal(1, data[i-1].CompareTo(data[i]));
        }
    }
    
    [Fact]
    public void SortByDOBASCTest()
    {
        var data = _mock.Select();
        Sorting.SortPersonByDOB(data, SortOrder.Asc);
        
        Assert.Equal("Alice", data[3].Name);
        Assert.Equal("Bob", data[0].Name);
        Assert.Equal("Catherine", data[2].Name);
        Assert.Equal("Denis", data[1].Name);
        
    }
    
    [Fact]
    public void SortByDOBASCTest2()
    {
        var data = _mock.Select();
        Sorting.SortPersonByDOB(data, SortOrder.Asc);
        
        for (int i = 1; i < data.Count; i++)
        {
            Assert.Equal(-1, data[i-1].Dob.CompareTo(data[i].Dob));
        }
        
    }
    
    [Fact]
    public void SortByDOBDESCTest()
    {
        var data = _mock.Select();
        Sorting.SortPersonByDOB(data, SortOrder.Desc);
        
        Assert.Equal("Alice", data[0].Name);
        Assert.Equal("Bob", data[3].Name);
        Assert.Equal("Catherine", data[1].Name);
        Assert.Equal("Denis", data[2].Name);
        
    }
    
    [Fact]
    public void SortByDOBDESCTest2()
    {
        var data = _mock.Select();
        Sorting.SortPersonByDOB(data, SortOrder.Desc);
        
        for (int i = 1; i < data.Count; i++)
        {
            Assert.Equal(1, data[i-1].Dob.CompareTo(data[i].Dob));
        }
        
    }
}