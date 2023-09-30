// See https://aka.ms/new-console-template for more information

// Example file for using Regex to find patterns
using System.Diagnostics;
using System.Text.RegularExpressions;


string teststr1 = "The quick brown Fox jumps over the lazy Dog";
string teststr2 = "the quick brown fox jumps over the lazy dog";

// TODO: The IsMatch function is used to determine if the content of a string
// results in a match with the given Regex
Regex CapWords = new Regex(@"[A-Z]\w+");
Console.WriteLine(CapWords.IsMatch(teststr1));
Console.WriteLine(CapWords.IsMatch(teststr2));
// TODO: The RegexOptions argument can be used to perform
// case-insensitive searches
Regex NoCase = new Regex(@"fox", RegexOptions.IgnoreCase);
Console.WriteLine(NoCase.IsMatch(teststr1));

// Use the Match and Matches methods to get information about
// specific Regex matches for a given pattern

// TODO: The Match method returns a single match at a time
Match m = CapWords.Match(teststr1);
while (m.Success)
{
    Console.WriteLine($"{m.Value} found at position {m.Index}");
    m = m.NextMatch();
}

// TODO: The Matches method returns a collection of Match objects
MatchCollection mc = CapWords.Matches(teststr1);
Console.WriteLine($"found {mc.Count} matches:");
foreach(Match match in mc)
{
    Console.WriteLine($"{match.Value} found at position {match.Index}");
}

///////////////////
Console.Clear();

// TODO: Regular expressions can be used to replace content in strings
// in addition to just searching for content
string result = CapWords.Replace(teststr1, "***"); // it replaces the capital words to ****
Console.WriteLine(teststr1);
Console.WriteLine(result);

// TODO: Replacement text can be generated on the fly using MatchEvaluator
// This is a delegate that computes the new value of the replacement
string makeUpper(Match m)
{
    string s = m.ToString();
    if(m.Index == 0)
    {
        return s;
    }
    return s.ToUpper();
}

string upperstr = CapWords.Replace(teststr1, new MatchEvaluator(makeUpper));
Console.WriteLine(teststr1);
Console.WriteLine(result);
//////////////////////////
Console.Clear();


const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

// Use a Stopwatch to show elapsed time
Stopwatch sw;

// TODO: Use a Timeout value when executing RegEx to guard against bad input
const int MAX_REGEX_TIME = 1000;
TimeSpan timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);


// Run the expression and output the result
try
{
    sw = Stopwatch.StartNew();
    Regex CapWords1 = new Regex(@"(a+a+)+b", RegexOptions.None, timeout);
    MatchCollection mc1 = CapWords1.Matches(thestr);
    sw.Stop();
    Console.WriteLine($"Found {mc1.Count} matches in {sw.Elapsed} time:");
    foreach (Match match in mc1)
    {
        Console.WriteLine($"'{match.Value}' found at position {match.Index}");
    }
}
catch (RegexMatchTimeoutException e)
{
    Console.WriteLine($"the regex took too long to execute! {e.MatchTimeout}");
}