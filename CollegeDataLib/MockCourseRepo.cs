using CollegeLib;

namespace CollegeDataLib;

public class MockCourseRepo : IDataRepo<Course, int>
{
    private readonly List<Course> _course;
    public int Count => _course.Count;

    public MockCourseRepo()
    {
        _course = new List<Course>()
        {
            new("420-0Q5-SW", "Reseau"),
            new("420-0SW-SW","Programmation jeux"),
            new("420-3SU-SW","Web : Serveur 2"),
            new("420-1SY-SW","Analyse Objet")
        };
    }

    public List<Course> Select()
    {
        return _course;
    }

    public Course? Select(int id)
    {
        return _course[id];
    }

    public int Insert(Course data)
    {
        _course.Add(data);
        return 1;
    }

    public bool Update(Course data)
    {
        for (int i = 0; i < _course.Count; i++)
        {
            if (_course[i].Equals(data))
            {
                _course[i] = data;
                return true;
            }
        }

        return false;
    }

    public bool Delete(Course data)
    {
        for (int i = 0; i < _course.Count; i++)
        {
            if (_course[i].Equals(data))
            {
                return Delete(_course[i]);
            }
        }
        return false;
    }

    public bool Delete(int key)
    {
       _course.RemoveAt(key);
       return true;
    }
}