﻿using System;
using program1.library.Module;

namespace project1.program1.library.program1.library.Services
{
	public class StudentServices
	{
        public List<Person> studentList = new List<Person>();

        public void Add(Person student)
        {
            studentList.Add(student);
        }

        public List<Person> Students
        {
            get
            {
                return studentList;
            }
        }
    }
}
