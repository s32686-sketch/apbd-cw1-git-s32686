// See https://aka.ms/new-console-template for more information
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