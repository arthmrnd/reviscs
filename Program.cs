using System;

namespace reviscs
{
    class Program
    {
        static void Main(string[] args)
        {
            student[] students = new student[5];
            int iStudent = 0;
            string userOption = takeUserOption();

            while (userOption.ToUpper() != "X")
            {

                //Test with ifs
                /*
                if (userOption == "1")
                {
                    
                }
                else if (userOption == "2")
                {
                    
                }
                else if (userOption == "3")
                {
                    
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                */

                //Test with switch
                switch (userOption)
                {
                    case "1":
                        // Add Student
                        Console.WriteLine("Name of the student");
                        student student = new student();
                        student.name = Console.ReadLine();

                        Console.WriteLine("Grade of the student");

                        var grade = decimal.Parse(Console.ReadLine());

                        student.grade = grade;

                        //Include the student in array
                        students[iStudent] = student;
                        iStudent++;

                        break;
                    case "2":
                        // List Student
                        foreach (var stu in students)
                        {
                            if (!string.IsNullOrEmpty(stu.name))
                            {
                                Console.WriteLine($"Student: {stu.name} | Grade: {stu.grade}");
                            }

                            //Console.WriteLine($"Student: {stu.name} | Grade: {stu.grade}");
                        }

                        break;
                    case "3":
                        // Calculate mean
                        decimal totalGrades = 0;
                        var nStudents = 0;
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(students[i].name))
                            {
                                totalGrades += students[i].grade;
                                nStudents++;
                            }
                        }

                        //mean
                        var mean = totalGrades / nStudents;

                        concept overall;

                        if (mean < 2)
                        {
                            overall = concept.E;
                        }
                        else if (mean < 4)
                        {
                            overall = concept.D;
                        }
                        else if (mean < 6)
                        {
                            overall = concept.C;
                        }
                        else if (mean < 8)
                        {
                            overall = concept.B;
                        }
                        else
                        { 
                            overall = concept.A;
                        }

                        Console.WriteLine($"The average grade is {mean} | Concept {overall}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = takeUserOption();
            }
        }

        private static string takeUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Select a option:");
            Console.WriteLine("1 - Insert a new student");
            Console.WriteLine("2 - List the students");
            Console.WriteLine("3 - Calculate the average grade");
            Console.WriteLine("X - Exit");
            Console.WriteLine();

            string userOption = Console.ReadLine();
            Console.WriteLine();
            return userOption;
        }
    }
}
