namespace Homework08Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________________");
            List<string> lines = new List<string>();

            string appPathHomework = "C:\\Users\\Biljana\\Desktop\\Homeworks\\Advanced\\Homework07Advanced\\Homework08Advanced\\Homework08Advanced\\Homework08Advanced\\Documents";

            string homeworkDir = appPathHomework + "\\Homework08";

            string filePath = homeworkDir + "\\Homework.txt";


            if (Directory.Exists(homeworkDir) == false)
            {
                Directory.CreateDirectory(homeworkDir);
            }
            if (File.Exists(filePath) == false)
            {
                File.Create(filePath).Close();
            }

            StreamWriter streamWriterHomework = new StreamWriter(filePath);
            using (streamWriterHomework)
            {
                streamWriterHomework.WriteLine("Hello");
                streamWriterHomework.WriteLine("World");
                streamWriterHomework.WriteLine("Yes");
                streamWriterHomework.WriteLine("Cat");
                streamWriterHomework.WriteLine("Dog");
                streamWriterHomework.WriteLine("Hello again");
            }

            {
                StreamReader reader = new StreamReader(filePath);
                using (reader)
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                string searchText;
                do
                {
                    Console.Write("Search: ");
                    searchText = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(searchText))
                    {
                        bool found = false;
                        Console.WriteLine("Lines containing '{0}':", searchText);
                        foreach (string line in lines)
                        {
                            if (line.Contains(searchText))
                            {
                                Console.WriteLine(line);
                                found = true;
                            }
                        }
                        if (!found)
                            Console.WriteLine($"\"{searchText}\" is not exisisting in any lines from the file.");
                    }
                } while (!string.IsNullOrWhiteSpace(searchText));

            }
        }
    }
}