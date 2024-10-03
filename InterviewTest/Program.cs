// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string Name = "JohnDoe";
int Age = 25;
bool IsAdmin = true;

Console.WriteLine($"My name is {Name},I am {25} years old,{IsAdmin}");

Console.WriteLine("Enter any number");
int numbers = int.Parse(Console.ReadLine()!);
if (numbers % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd");
}


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"number:{i}");
}

//Print the sum of all elements in the array to the console
int[] number = { 2, 4, 6, 8, 10 };
int sum = number.Sum();
Console.WriteLine($"The sum of all  number in the array are:{sum}");

//using Foreach to iterate of an array and print it to the console
int[] num = { 2, 4, 6, 8, 10 };
int add = 0;

foreach (var result in num)
{
    add += result;
}
Console.WriteLine($"add:{add}");


class program
{
    static void Greet(string Name)
    {
        Console.WriteLine("Hello, " + Name + "!");
    }
    static void Main(string[] args)
    {
        Greet("Alice");
    }



}


