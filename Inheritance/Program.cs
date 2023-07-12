using Inheritance;

public class Program
{
    // Inheritance involves a child class inheritting functionality from a parent class.
    // Inheritance makes our code more DRY.

    public static void Main()
    {
        Dog dog = new Dog();
        dog.Eat();  // Output: The animal is eating.
        dog.Bark(); // Output: The dog is barking.
    }
}