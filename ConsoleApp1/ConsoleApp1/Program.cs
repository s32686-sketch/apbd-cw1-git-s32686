// See https://aka.ms/new-console-template for more information
static double CalculateAverage(int[] values)
{
    double sum = 0;
    for (int i = 0; i < values.Length; i++)
    {
       sum += values[i]; 
    }
    double average = sum / values.Length;
    Console.WriteLine($"Operation successfull, calculated average: {average}");
    return average;
}

CalculateMax(int[] values)
{
    int max = values[0];
    for (int i = 0; i < values.Length; i++){
        if(values[i] > max){
            max = values[i]
        }
    }
    return max
}

using System.Linq;

public int CalculateMin(int[] values)
{
    if (values == null || values.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or empty.");
    }

    return values.Min();
}

Console.Write("Enter your name: ");
string name = Console.ReadLine();

if (name != "" && !int.TryParse(name, out int nameInt))
{
    Console.WriteLine($"Hello, {name}!");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid name.");
    Environment.Exit(0);
}

Console.Write("Enter your age: ");
string age = Console.ReadLine();

if (int.TryParse(age, out int ageInt)) {
    Console.WriteLine($"You are {ageInt} years old.");
} else {
    Console.WriteLine("Invalid age. Please enter a number.");
    Environment.Exit(0);
}