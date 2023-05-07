

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Mohammad";
lastName = "Jabir";
//filePath = "C:\\Temp\\Demo";
filePath = @"C:\Temp\Demo";

//string interpolation
Console.WriteLine($"Hello {firstName} {lastName}");
Console.WriteLine(filePath);

string testString = $@"The file for {firstName} is at C:\SampleFiles";
Console.WriteLine(testString);

// ctrl + . to show smart tag
// ctrl + R + R  to rename variables
// $ is used for string interpolation
// @ is used for verbatim string literal