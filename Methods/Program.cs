// See https://aka.ms/new-console-template for more information
namespace ahmadMethod;
class Program
{
    static void Main(string[] args)
    {
        SayHi("Ahmad", 32);
        //Here I want to create a method
        //its task is to say hi to the user.

        Console.WriteLine(Cube(5));
        
        Console.ReadLine();

    }
    static void SayHi(string name, int age)
    {
        Console.WriteLine("Hi! " + name + " you're welcome to G-Land Computing academy. You are " + age + " years old.");
    }
    //RETURN STATEMENTS
    static int Cube(int num)
    {
        int result = num * num * num;
        return result;
    }
}




