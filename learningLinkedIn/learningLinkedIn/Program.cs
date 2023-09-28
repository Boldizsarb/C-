// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string response;
Console.WriteLine("this is running in the terminal, what is your name?");
response = Console.ReadLine();
Console.WriteLine($"f string {response}");
// terminal prompt: dotnet run
OperatingSystem thisOs = Environment.OSVersion;
Console.WriteLine(thisOs.Platform);
Console.WriteLine(thisOs.VersionString);
// outputs the platform wooow 
Console.Clear(); ///////////////////////////////////// CLEAR CLEAR 
// Declare some types with values
int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");
Console.WriteLine($"{(char)(c+a)}"); // c+a executes and it gets covnverted to a character

Console.Clear();
// TODO: Create an object instance of a class (which is a reference type)
s s1;
s1.a = 5;
s1.b = false;


void StructOp(s theStruct)
{
    // Modify the struct properties inside the function
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

Console.WriteLine("Structs are passed by copy, since they are value types:");
Console.WriteLine($"{s1.a}, {s1.b}");
StructOp(s1);
Console.WriteLine($"{s1.a}, {s1.b}");

MyClass cl = new MyClass { a = 5, b = false };

Console.WriteLine("Objects are passed by reference, since they are reference types:");
Console.WriteLine($"{cl.a}, {cl.b}");
ClassOp(cl);
Console.WriteLine($"{cl.a}, {cl.b}");

void ClassOp(MyClass theClass)
{
    // Modify some of the properties of the class inside the function
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}

class MyClass
{
    public int a;
    public bool b;
}

struct s
{
    public int a;
    public bool b;
}