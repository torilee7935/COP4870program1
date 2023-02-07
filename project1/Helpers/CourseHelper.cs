using System;
using program1.library.Module;
using project1.program1.library.Services;

namespace project1.Helpers
{
	public class CourseHelper
	{
        private CourseService courseService = new CourseService();

        public void CreateCourseRecord(Course? selectedCourse = null)
        {
            Console.WriteLine("What is the code of the course?");
            var code = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("What is the name of the course?");
            var name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("What is the description of the course?");
            var description = Console.ReadLine() ?? string.Empty;


            bool isNewCourse = false;
            if(selectedCourse == null)
            {
                isNewCourse = true;
                selectedCourse = new Course();
            }


            selectedCourse.Code = code;
            selectedCourse.Name = name;
            selectedCourse.Description = description;

            if (isNewCourse)
            {
                courseService.Add(selectedCourse);
            }

            courseService.Add(selectedCourse);

           
        }
        public void UpdateCourseRecord()
        {
            Console.WriteLine("Enter course code to update: ");
            ListCourses();

            var selection = Console.ReadLine();

            var selectedCourse = courseService.Courses.FirstOrDefault(s => s.Code.Equals(selection, StringComparison.InvariantCultureIgnoreCase));
            if (selectedCourse != null)
            {
                CreateCourseRecord(selectedCourse);
            }

        }

        public void ListCourses()
        {
            courseService.Courses.ForEach(Console.WriteLine);

        }

        public void SearchCourses()
        {
            Console.WriteLine("Enter a query: ");
            var query = Console.ReadLine() ?? string.Empty;

            courseService.Search(query).ToList().ForEach(Console.WriteLine);
        }
    }
}

