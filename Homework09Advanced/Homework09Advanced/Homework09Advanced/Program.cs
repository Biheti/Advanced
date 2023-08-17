using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System.Xml;
using System;
using Homework09Advanced.classPerson;
using Homework09Advanced.Classes;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.IO;
using Formatting = Newtonsoft.Json.Formatting;

namespace Homework09Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appDocPath = "C:\\Users\\Biljana\\Desktop\\Homeworks\\Advanced\\Homework09Advanced\\Homework09Advanced\\Homework09Advanced\\Documents";
            string onePersonFile = appDocPath + "\\OnePerson.json";

            if (File.Exists(onePersonFile) == false)
                File.Create(onePersonFile).Close();

            Person person01Test = new Person()
            {
                Name = "Nikola",
                Surname = "Nikolov",
                Age = 25,
                Courses  = new List<Course> 
                {
                    new Course { Name = "Math", Grade = 10},
                    new Course { Name = "Science", Grade = 9},
                    new Course { Name = "History", Grade = 8},
                }
            };

            Console.WriteLine($"Name: {person01Test.Name} {person01Test.Surname}");
            Console.WriteLine($"Age: {person01Test.Age}");
            Console.WriteLine("Courses:");
            foreach (Course course in person01Test.Courses)
                Console.WriteLine($"- {course.Name}: {course.Grade}");
        
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("_________________________________________________________");

            string serializedPerson = JsonConvert.SerializeObject(person01Test, Formatting.Indented);
            File.WriteAllText(onePersonFile, serializedPerson);
            Console.WriteLine($"Serialized Person:");
            Console.WriteLine(serializedPerson);

            string jsonFromFile = File.ReadAllText(onePersonFile);
            Person deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonFromFile);

            Console.WriteLine($"Deserialized Person:");
            Console.WriteLine($"Name: {deserializedPerson.Name} {deserializedPerson.Surname}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");

            Console.WriteLine("Courses:");
            foreach (Course course in deserializedPerson.Courses)
                Console.WriteLine($"- {course.Name}: {course.Grade}");

            //        Create a C# console application that serialize and deserialize objects in JSON format. To
            //        do this, you can use the JsonConvert class included in the Newtonsoft.Json namespace.
            //        1. First, implement the Person class with properties(Name, Surname, Age and
            //        Courses). Course class has two properties(Name and Grade). Create a person
            //        object with all assigned properties and minimum three courses.
            //        2.Use JsonConvert.SerializeObject(p, Formatting.Indented) to serialize the person
            //        object and save the resulting string in the OnePerson.json file.
            //        3.Deserialize the OnePerson.json file using JsonConvert.DeserializeObject and print
            //        the contents of the deserialized object to the console.
            //        4.With the help of a text editor, analyze the content of the OnePerson.json file.
        }
    }
}