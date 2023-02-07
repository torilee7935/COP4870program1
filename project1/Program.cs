﻿using System.Runtime.Intrinsics.X86;
using program1.library.Module;
using project1.Helpers;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentHelper = new StudentHelper();
            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. List all enrolled students");
                Console.WriteLine("3. Search for student");
                Console.WriteLine("4. Exit");

                var input = Console.ReadLine();

                if (int.TryParse(input, out int result)) { 

                    if (result == 1)
                    {
                        studentHelper.CreateStudentRecord();

                    }else if(result == 2)
                    {
                        studentHelper.ListStudents();
                    }else if (result == 3)
                    {
                        studentHelper.SearchStudents();
                    }else if (result == 4)
                    {
                        cont = false;
                    }


                }

            }

        }
    }
}


