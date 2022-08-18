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
        Console.WriteLine(MaxVal(5, 10, 15));
        //if Statement
        bool isMale = false;
        bool isDark = true;
        bool isNigerian = true;
        bool isUite = true;
        bool isAgesite = true;
        if (isMale && isDark && isNigerian)
        {
            Console.WriteLine("You are male, dark in complexion and are a Nigerian.");
        }
        else
        {
            Console.WriteLine("You are female.");    
        }
        if (isAgesite || isUite)
        {
            Console.WriteLine("You are an alumnus of University of ibadan \nand You studied agricultural economic");
        }
        else if (!isAgesite && isMale || !isUite)
        {
            Console.WriteLine("Sorry, we observed that you are a male prospective student \ntrying to gain admittance to what department?");
        }
        else
        {
            Console.WriteLine("You are a prospective student");
        }
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
    //If Statement for Comparison
    //Here, I wanna create a method for comparison between two numbers
    //N.B: "==" means comparison between two numbers while "=" means assignment operator.
    static int MaxVal(int numero1, int numero2, int numero3)
    {
        int result;
        if (numero1 >= numero2 && numero1 >= numero3)
        {
            result = numero1;
        }
        else if (numero2 >= numero1 && numero2 >= numero3)
        {
            result = numero2;
        }
        else 
        {
            result = numero3;
        }
        return result;

    }
}




