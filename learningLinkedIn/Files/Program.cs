// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
//using(StreamWriter sw = File.CreateText(filename))
//{
//    sw.WriteLine("This is a text file.");
//    /* So, this construct right here. The using construct, 
//     * automatically disposes of the output stream and 
//     * the associated file reference when this Using context block 
//     * completes. So Files are one of those operating system resources 
//     * that the garbage collector can automatically close for us. 
//     * So we need to make sure that we don't leave open file references 
//     * laying around. And this type of construct, the using construct makes that
//     * pretty easy. So, when the file is created it returns a streamwriter object 
//     * which we can use to write output into the Filestream.*/
//}

// TODO: Determine if a file exists
/*
Console.WriteLine(File.Exists(filename));
if (File.Exists(filename))
{
    File.Delete(filename);
}
else
{
    using (StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine("This is a text file.");
       
    }
}
*/
// Make sure the example file exists

// TODO 1: WriteAllText overwrites a file with the given content

if (!File.Exists(filename))
{
    File.WriteAllText(filename, "this is text file.");
}

// TODO 3: AppendAllText adds text to an existing file
File.AppendAllText(filename, "this text gets appended to the file");


// TODO 4: A FileStream can be opened and written to until closed
using (StreamWriter sw = File.AppendText(filename))
{
    sw.WriteLine("line1");
    sw.WriteLine("line1");
    sw.WriteLine("line1");
    sw.WriteLine("line1");
}

    // TODO 2: ReadAllText reads all the content from a file

    string content;
content = File.ReadAllText(filename);
Console.WriteLine(content);

Console.Clear();

// Working with file information

// Make sure the example file exists

if (!File.Exists(filename))
{
    using (StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));

//File.SetAttributes(filename, FileAttributes.ReadOnly);
Console.WriteLine(File.GetAttributes(filename));

// TODO: We can also get general information using a FileInfo 
//try
//{
//    FileInfo fi = new FileInfo(filename);
//    Console.WriteLine($"{fi.Length}");
//    //Console.WriteLine($"{fi.Directory}");
//    Console.WriteLine($"{fi.IsReadOnly}");
//}
// catch (Exception e)
//{
//    Console.WriteLine($"Exception {e}");
//}

// TODO: File information can also be manipulated
DateTime dt = new DateTime(2023, 7, 1);
File.SetCreationTime(filename, dt);
Console.WriteLine(File.GetCreationTime(filename));
