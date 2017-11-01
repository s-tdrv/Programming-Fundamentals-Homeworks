using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average => Grades.Average();
    }

    class StartUp
    {
        static void Main()
        {
           List<Student> students = new List<Student>();
            var input = File.ReadAllLines("input.txt");
            int count = int.Parse(input[0]);

            for (int i = 1; i <= count; i++)
            {
                var inputArgs = input[i].Split(); 
                Student student = new Student();
                student.Name = inputArgs[0];
                student.Grades = inputArgs.Skip(1).Select(double.Parse)
                    .ToList();

                students.Add(student);
            }
                            

            foreach (var s in students.Where(s => s.Average >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Average)
                .ToList())
            {
                var output = $"{s.Name} -> {s.Average:f2}" + Environment.NewLine;
                File.AppendAllText("output.txt", output);
            }

                

        }
    }
}
