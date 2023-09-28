// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

// String Interpolation is a feature that enables the easy insertion of data
// and expression values into a string variable

int a = 100;
float b = 250.0f;
string c = "CSharp";

// String output the old way - using placeholders
Console.WriteLine("The values are {0}, {1} and {2}", a, b, c);

// TODO: Using string interpolation, the code is much easier to read
Console.WriteLine($"The values are: {a},{b} and {c}");  ////////// same!!!!!!! 

// TODO: Interpolated strings can contain expressions as well
Console.WriteLine($"(a+b)/b is {(a + b) / b}");   //////////////////// can use expressions within the writeline
Console.WriteLine($"{c} in upper case: {c.ToUpper()}"); ////////////////// can call a function on the string as well 

// TODO: Complex objects can be embedded in strings this way as well
DateTime now = DateTime.Now;
Console.WriteLine($"Today is {now}");
Console.Clear();

///  formatting ->
///  
float f1 = 123.4f;
int i1 = 2000;

// TODO: Spacing and Alignment: Indexes
Console.WriteLine("{0, -15}{1,10}", "Float Val", "Int Val");
Console.WriteLine("{0, -15}{1,10}", f1,i1);

// TODO: Spacing and Alignment: Interpolation
Console.WriteLine("{0, -15}{1,10}", "Float Val", "Int Val");
Console.WriteLine($"{f1, -15}{i1,10}");
//////////
///
string str2 = "this is a string";
string str3 = "this is a string2";

bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);