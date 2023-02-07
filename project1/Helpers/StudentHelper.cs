using System;
using program1.library.Module;
using project1.program1.library.program1.library.Services;

namespace project1.Helpers
{
	internal class StudentHelper
	{

        private StudentServices studentService = new StudentServices();
        public void CreateStudentRecord()
        {
            
            Console.WriteLine("What is the name of the student?");
            var name = Console.ReadLine();
            Console.WriteLine("What is the ID of the student?");
            var id = Console.ReadLine();
            Console.WriteLine("What is the classification of the student?[(F)reshman, S(o)phmore, (J)unior, (S)enior]");
            var classification = Console.ReadLine() ?? string.Empty;

            PersonClassification classEnum = PersonClassification.Freshman;

            if (classification.Equals("o", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Sophmore;
            }
            else if (classification.Equals("J", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Junior;
            }
            else if (classification.Equals("S", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Senior;
            }

            var student = new Person
            {
                Id = int.Parse(id ?? "0"),
                Name = name ?? string.Empty,
                Classification = classEnum
            };

            studentService.Add(student);

            studentService.studentList.ForEach(student => Console.WriteLine());
        }

        public void ListStudents()
        {
            studentService.Students.ForEach(Console.WriteLine);


        }
	}
}

