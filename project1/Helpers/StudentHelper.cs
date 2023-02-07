using System;
using System.Xml.Linq;
using program1.library.Module;
using project1.program1.library.Services;

namespace project1.Helpers
{
	internal class StudentHelper
	{

        private StudentServices studentService = new StudentServices();
        public void CreateStudentRecord(Person? selectedStudent = null)
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

            bool isCreate = false;
            if(selectedStudent == null)
            {
                selectedStudent = new Person();
            }

            selectedStudent.Id = int.Parse(id ?? "0");
            selectedStudent.Name = name ?? string.Empty;
            selectedStudent.Classification = classEnum;

            if (isCreate)
            {
                studentService.Add(selectedStudent);
            }

         
        }

        public void UpdateStudentRecord()
        {
            Console.WriteLine("Select student to update: ");
            ListStudents();

            var selectionStr = Console.ReadLine();

            if (int.TryParse(selectionStr, out int selectionInt))
            {
                var selectedStudent = studentService.Students.FirstOrDefault(s => s.Id == selectionInt);
                if (selectedStudent != null)
                {
                    CreateStudentRecord(selectedStudent);
                }
            }

        }

        public void ListStudents()
        {
            studentService.Students.ForEach(Console.WriteLine);


        }

        public void SearchStudents()
        {
            Console.WriteLine("Enter a query: ");
            var query = Console.ReadLine() ?? string.Empty;

            studentService.Search(query).ToList().ForEach(Console.WriteLine);
        }

       
	}
}

