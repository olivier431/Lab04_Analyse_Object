using CollegeLib;

namespace CollegeDataLib;

public class MockCourseOfferingRepo : IDataRepo<CourseOffering, int>
{
    private readonly List<CourseOffering> _courseOfferings;
    public int Count => _courseOfferings.Count;

    public MockCourseOfferingRepo()
    {
        Course c1 = new("420-0Q5-SW", "Reseau");
        Course c2 = new("420-0SW-SW", "Programmation jeux");
        Course c3 = new("420-1SY-SW","Analyse Objet");
        Course c4 = new("420-3SU-SW","Web : Serveur 2");
        
        Teacher t1 = new ("Ti-paul", DateOnly.FromDateTime(new DateTime(2022, 10, 27)), 1, "info", true, "teacher");
        Teacher t2 = new ("Ti-paulo", DateOnly.FromDateTime(new DateTime(2022, 10, 27)), 2, "info", true, "teacher");
        Teacher t3 = new ("Ti-paule", DateOnly.FromDateTime(new DateTime(2022, 10, 27)), 3, "info", true, "teacher");
        Teacher t4 = new ("Ti-paula", DateOnly.FromDateTime(new DateTime(2022, 10, 27)), 4, "info", true, "teacher");
        
        _courseOfferings = new List<CourseOffering>()
        {
            new(2022, "A2022", c1, t1),
            new(2022, "A2022", c2, t2),
            new(2022, "A2022", c3, t3),
            new(2022, "A2022", c4, t4)
            
        };
    }

    public List<CourseOffering> Select()
    {
        return _courseOfferings;
    }

    public CourseOffering? Select(int id)
    {
        return _courseOfferings[id];
    }

    public int Insert(CourseOffering data)
    {
        _courseOfferings.Add(data);
        return 1;
    }

    public bool Update(CourseOffering data)
    {
        for (int i = 0; i < _courseOfferings.Count; i++)
        {
            if (_courseOfferings[i].Equals(data))
            {
                _courseOfferings[i] = data;
                return true;
            }
        }

        return false;
    }

    public bool Delete(CourseOffering data)
    {
        for (int i = 0; i < _courseOfferings.Count; i++)
        {
            if (_courseOfferings[i].Equals(data))
            {
                return Delete(_courseOfferings[i]);
            }
        }
        return false;
    }

    public bool Delete(int key)
    {
        _courseOfferings.RemoveAt(key);
        return false;
    }
}