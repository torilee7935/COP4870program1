using System;
using program1.library.Module;

namespace project1.program1.library.Services
{

	public class CourseService
	{
        private List<Course> courseList = new List<Course>();

        public void Add(Course course)
        {
            courseList.Add(course);
        }

        public List<Course> Courses
        {
            get
            {
                return courseList;
            }
        }
        public IEnumerable<Course> Search(string query)
        {
            return Courses.Where(s => s.Name.ToUpper().Contains(query.ToUpper())
                || s.Description.ToUpper().Contains(query.ToUpper())
                || s.Code.ToUpper().Contains(query.ToUpper()));
        }
    }
}

