namespace Abstraction
{
    //  Abstraction can be defined as:
    //  hiding internal implementation and only revealing the required features or set of services
    //  that are offered.

    //  


    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.MakeNoise();
            cat.MakeNoise();
        }
    }
}
