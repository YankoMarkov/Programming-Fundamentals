using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AverageGrade { get; set; }
}

class AverageGrades
{
    static void Main(string[] args)
    {
        var students = AddStudents();
        students = students.Where(s => s.AverageGrade >= 5.0).OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade).ToList();

        foreach (var item in students)
        {
            Console.WriteLine($"{item.Name} -> {item.AverageGrade:f2}");
        }
    }

    private static List<Student> AddStudents()
    {
        var n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split().ToArray();
            students.Add(new Student()
            {
                Name = input[0],
                Grades = StudentGrades(input),
                AverageGrade = AverageGrade(StudentGrades(input))
            });
        }
        return students;
    }

    private static double AverageGrade(List<double> grades)
    {
        double average = 0.0;
        double sum = 0.0;

        for (int i = 0; i < grades.Count; i++)
        {
            sum += grades[i];
        }
        return average = sum / grades.Count;
    }

    private static List<double> StudentGrades(string[] input)
    {
        var grades = new List<double>();

        for (int i = 1; i < input.Length; i++)
        {
            grades.Add(double.Parse(input[i]));
        }
        return grades;
    }
}

