namespace Homework07Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an list of integers, write a linq query that process that list and print list of numbers
            //greater than 40 and less than 70.
            //Input: [79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100]

            List<int> numbers = new List<int> { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };
            var resultList = numbers.Where(n => n > 40 && n < 70).ToList();
            foreach (var result in resultList)
                Console.WriteLine(result);

            // Create list of animals. Write a linq query for process that list and print names that is at least 6
            //characters long and make them uppercase.
            //Input: "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            //"sheep", "tiger", "wolf"
            //Expected output: "ELEPHANT", "KANGAROO

            List<string> animals = new List<string> { "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion", "sheep", "tiger", "wolf" };

            var animalsWithUppercase = animals.Where(a => a.Length >= 6).Select(a => a.ToUpper()).ToList();
            foreach (var animal in animalsWithUppercase)
                Console.WriteLine(animal);

            // Write a linq query for process list of animals and print names of animal starting with letter 'h'
            //and ending with letter 'e'.
            // Input: "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            //"sheep", "tiger", "wolf"
            //Expected output:"horse", "hare"

            List<string> animals01 = new List<string> { "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion", "sheep", "tiger", "wolf" };
            var animalsThatStartWithH = animals01.Where(a => a.StartsWith("h") == true).ToList();
            foreach (var animal in animalsThatStartWithH)
                Console.WriteLine(animal);

            //Write a linq query that process list of integers and print top 5 numbers in descending order.
            //Input: [79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100]
            //Expected output: 100 86 82 81 79

            List<int> numbers01 = new List<int> { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };
            var numbersOrderdByDescending = numbers01.OrderByDescending(a => a).Take(5).ToList();
            foreach (int number in numbersOrderdByDescending)
                Console.WriteLine(number);

            // Write a linq query that from list of integers print list of numbers and their squares only if square
            //is greater than 7000
            //Input: [79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100]
            //Expected output: 86 - 7396, 100 - 10000

            var squaresGreaterThan7000 = numbers01.Where(n => n * n > 7000).ToList();
            foreach (int n in squaresGreaterThan7000)
                Console.WriteLine($"{n}-{n * n}");

            //Write a linq query for process list of animals and print names of animal with replaced 'an'
            //substring with asterisk(*).
            //Input: "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            //"sheep", "tiger", "wolf"
            //Expected output: "*t", "cat", "cow", "dog", "eleph*t", "horse", "k*garoo",
            //"hare", "sheep", "tiger", "wolf"
            Console.WriteLine("___________________________________");
            List<string> animals02 = new List<string> { "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion", "sheep", "tiger", "wolf" };
            var animalsWithReplecedAn = animals02.Select(a => a.Replace("an", "*"));
            foreach (var animal in animalsWithReplecedAn)
                Console.WriteLine(animal);

            //Write a linq query for process list of animals wich sort list alphabetically and print last name
            //that contains letter 'e'.
            //Input: "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            //"sheep", "tiger", "wolf"
            //Expected output:"tiger

            var animalsOrderedAlphabetically = animals02.OrderBy(a => a.Contains("e") == true).LastOrDefault();
            Console.WriteLine(animalsOrderedAlphabetically);


            // Write a linq query that shuffles sorted array or list and print result.
            //Input: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
            //Expected output: 9 11 12 10 3 6 1 14 8 5 4 15 13 2 7(Each time different
            //order...)
            Console.WriteLine("___________________________________");
            Console.WriteLine("___________________________________");

            List<int> numbers03 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var rnd = new Random();
            var shuffledArray = numbers03.OrderBy(i => rnd.Next());

            foreach (var item in shuffledArray)
                Console.Write(item + " ");
        }
    }
}