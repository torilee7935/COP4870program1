using System;
using program1.library.Module;

namespace project1.program1.library.Services
{

	public class CourseService
	{
        public List<Course> courseList = new List<Course>();

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
    }
}

