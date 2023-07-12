using Encapsulation;

public class Program
{
    //  Encapsulation is the idea of hiding and restricting access to the implementation
    //  details of our objects.

    // Encapsulation protects the necessary data and functions from being accessed improperly outside our objects.

    //  In this example, we have a Person class with fields name and age.
    //  We encapsulated access to these fields by creating public Name and Age properties 

    public static void Main()
    {
        Person person = new Person();
        person.Name = "John";
        person.Age = 34;
        Console.WriteLine(person.Name); // Output: John
        Console.WriteLine(person.Age); // Output: 0
    }
}