using System;
using System.IO;

namespace RetrieveStudentDataAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String filepath = @"C:\Users\GANI HARSHA SREE\source\repos\RetrieveStudentDataAssignment\RetrieveStudentDataAssignment\StudentRetrieveData.txt"; 

                string[] file_data = File.ReadAllLines(filepath);
                foreach (var line in file_data)
                {
                    Console.WriteLine(line);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
