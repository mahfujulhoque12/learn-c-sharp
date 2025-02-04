

class Car 
{
    // Using nullable types for model and color to avoid uninitialized warnings.
    public string? model;
    public string? color;
    public int year;
}

class Person 
{
    // Made name nullable to avoid warnings about uninitialized non-nullable fields.
    public string? name;
    public int age;
    public int roll;
}

class Program 
{
    public static void Main(string[] args)
    {
        // Car example
        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        Car Opel = new Car();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine("Car Models and Details:");
        Console.WriteLine($"Ford Model: {Ford.model}");
        Console.WriteLine($"Opel Model: {Opel.model}");
        Console.WriteLine($"Opel Year: {Opel.year}");
        Console.WriteLine($"Ford Color: {Ford.color}");
        Console.WriteLine();

        // Person example
        Person Badon = new Person();
        Badon.age = 24;
        Badon.name = "mahfuj";
        Badon.roll = 25025;

        Person Arif = new Person();
        Arif.age = 32;
        Arif.roll = 1;
        Arif.name = "arif";

        Console.WriteLine("Person Details:");
        Console.WriteLine($"Arif's Name: {Arif.name}");
        Console.WriteLine($"Badon's Name: {Badon.name}");
        Console.WriteLine($"Badon's Age: {Badon.age}");
        Console.WriteLine($"Badon's Roll: {Badon.roll}");
        Console.WriteLine($"Arif's Age: {Arif.age}");
        Console.WriteLine($"Arif's Roll: {Arif.roll}");
    }
}
