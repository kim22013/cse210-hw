using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int lagestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > lagestNumber)
            {
                lagestNumber = number;
            }
        }
        Console.WriteLine($"The largest number: {lagestNumber}");
    }
}