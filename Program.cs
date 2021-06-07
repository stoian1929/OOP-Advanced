using System;
class Program
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Person person = new Citizen(name, age);

        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
}