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
}