// See https://aka.ms/new-console-template for more information
using System.Globalization;  // let access different cultures 

// Example file for parsing numerical data from strings

string[] NumStrs = { "  1 ", " 1.45  ", "-100", "5e+04 " };

int testint;
float testfloat;
bool result;

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
foreach (string str in NumStrs)
{
    try
    {
        testfloat = float.Parse(str); // loop through the array
        Console.WriteLine($"parsed number is {testfloat}");
        testint = int.Parse(str);
        Console.WriteLine($"parsed number is {testint}");
    }
    catch(FormatException e)
    {
        Console.WriteLine($"could not parse '{str}':{e.Message}");
    }
}

// TODO: The TryParse method returns 'true' if the parse is successful
///// rather than trying to catch examples! 
result = int.TryParse(NumStrs[0], out testint);
Console.WriteLine($"{result} -- '{NumStrs[0]}' : {testint}");

result = float.TryParse(NumStrs[1], out testfloat);
Console.WriteLine($"{result} -- '{NumStrs[1]}' : {testfloat}");

result = int.TryParse(NumStrs[1], out testint);
Console.WriteLine($"{result} -- '{NumStrs[1]}' : {testint}"); // it will be false! since it fails!
Console.Clear();
///////////////////////////////
/// formatting numerical data in .NET
int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 100000, 150000, 200000, 225000 };
double[] intlMixPct = { .386, .413, .421, .457 };
int val1 = 1234;
decimal val2 = 1234.5678m;

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
Console.WriteLine($"{val1:N},{val1:F},{val1:G}");
Console.WriteLine($"{val2:E},{val2:F},{val1:G}");

// TODO: Add a number after the format to specify precision


// TODO: Formatting with alignment and spacing
Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quarters[0],12} {quarters[1],12} {quarters[2],12} {quarters[3],12}");
Console.WriteLine($"{sales[0],12:C0} {sales[1],12:C0} {sales[2],12:C0} {sales[3],12:C0}");
Console.WriteLine("International Sales:");
Console.WriteLine($"{intlMixPct[0],12:P0} {intlMixPct[1],12:P0} {intlMixPct[2],12:P1} {intlMixPct[3],12:P2}");

Console.Clear();

// TODO: Use DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
Console.WriteLine(now);

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today;
Console.WriteLine(today);

// TODO: DateOnly and TimeOnly represent just dates and times
DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(dt);
Console.WriteLine(tm);

// TODO: Dates have properties that can be inspected
Console.WriteLine(today.DayOfWeek);

// TODO: Dates also have methods to change their values
now = now.AddDays(5);
now = now.AddHours(9);
Console.WriteLine(now);


// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);
TimeSpan interval = AprilFools - NewYears;
Console.WriteLine(interval);

// TODO: Dates can be compared using regular operators
Console.WriteLine($"{NewYears < AprilFools}");
Console.WriteLine($"{NewYears > AprilFools}");

Console.Clear();

// Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprilFools:d}");

// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprilFools:D}");


// TODO: 'f' Full date, short time
Console.WriteLine($"{AprilFools:f}");


// TODO: 'F' Full date, long time
Console.WriteLine($"{AprilFools:F}");


// TODO: 'g' General date and time
Console.WriteLine($"{AprilFools:g}");


// TODO: 'G' General date and time
Console.WriteLine($"{AprilFools:G}");


// TODO: Format using a specific CultureInfo
Console.WriteLine(AprilFools.ToString("d",CultureInfo.CreateSpecificCulture("de-DE")));


// TODO: Defining custom date and time formats
/// can customize it yourself
Console.Clear();

// Collection of various date string formats to attempt parsing
string[] sampleDateTimes = {
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

foreach (string datestr in sampleDateTimes)
{
    DateTime result2;
    // TODO: Use the static class function TryParse to try parsing the dates
    if(DateTime.TryParse(datestr, out result2))
    {
        Console.WriteLine($"{datestr, -25} gets parsed as : {result2}");
    }
    else
    {
        Console.WriteLine($"could not parse '{datestr}'");
    }
}

///
//// Write a program that accepts a date and computes
Console.WriteLine("Enter a date or write exit ");
string thedate = "";
DateTime today1 = DateTime.Today;
do
{
    Console.WriteLine("Which date (or exit)");
    thedate = Console.ReadLine();
    if (thedate == "exit")
    {
        break;
    }
    DateTime parseDate;
    TimeSpan ts;
    if (DateTime.TryParse(thedate, out parseDate))
    {
        if (parseDate < today1)
        {
            // if the date already went by, indidcate how many days ago
            ts = today1 - parseDate;
            Console.WriteLine($"That day went by {ts.Days} days ago");
        }
        else if (parseDate == today)
        {
            Console.WriteLine("That day is today");
        }
        else
        {
            // if the date hasnt passed yet indicate how many days until that date 
            ts = parseDate - today;
            Console.WriteLine($"that date will be in {ts.Days} days");
        }

    }
    else
    {
        // if hte user did not enter a valid date then print the error message
        Console.WriteLine("that date is not valid mate");
    }

} while (thedate != "exit");
