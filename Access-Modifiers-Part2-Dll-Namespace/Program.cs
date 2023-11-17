using Access_Modifiers_Part2_Dll_Namespace.Models;
using System.Text.RegularExpressions;
#region Task-1
//Regex ve Math tiplerini arashdirib example yazin(hansi methodlari var ve.s)
#region Regex
/*//Matching a Pattern
string input = "The cat chased the mouse around the house.";
string pattern = @"\b[a-z]{5}\b";
MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
{
    Console.WriteLine($"Match found: {match.Value}");
}*/
/*//Replacement
string input = "The cat chased the mouse around the house.";
string pattern = @"\bcat\b";
string replacement = "dog";
string result = Regex.Replace(input, pattern, replacement);
Console.WriteLine($"Result: {result}");*/
/*//Splitting
string input = "orange,apple,pear";
string pattern = ",";

string[] splitStrings = Regex.Split(input, pattern);

foreach (string str in splitStrings)
{
    Console.WriteLine($"Fruit: {str}");
}*/
/*//Is Matching
string input = "The cat chased the mouse around the house.";
string pattern = @"\b[a-z]{5}\b";
bool isMatch = Regex.IsMatch(input, pattern);
if (isMatch)
{
    Console.WriteLine(isMatch);
}
else
{
    Console.WriteLine(isMatch);
}*/
#endregion
#region Math
//Mostly used:
/*//Finding max and min ==>Math.Max(x,y); , Min(x,y);
int x = 8;
double y = 12.5;
int z = 9;
var resMax = Math.Max(x, y);
var resMin = Math.Min(x, z);    
var resMinOf3 = Math.Min(x, Math.Min(y,z));
var resMaxOf3 = Math.Max(x, Math.Max(y, z));
Console.WriteLine($"Max is {resMax}, Min is {resMin}, Max of 3 is {resMaxOf3}, Min of 3 is {resMinOf3}");*/
/*//Finding square root of number ==> Math.Sqrt(x);
int num = 16;
var res = Math.Sqrt(num);
Console.WriteLine(res);*/
/*//Negative num turns into positive ==>Math.Abs(x);
var num = -.6;
Console.WriteLine(Math.Abs(num));*/
/*//Rounds a number to the nearest whole number ==>Math.Round(x);
var num = 45.3;
Console.WriteLine(Math.Round(num));*/
/*//Power of number ==>Math.Pow(x);
int num = 5;
Console.WriteLine(Math.Pow(num,3));*/
#endregion
#endregion
#region Task-2
//Avtomat simulyasiyası yaratmaq.(daraq,tektek ve avtomat rejimde atis,daragin doldurulmasi)
/*Gun shooter = new();
Console.WriteLine("Please Enter Shooting Mode : Single or Multi");
shooter.ShooterMode = Console.ReadLine().ToLower();
Console.WriteLine("Please Fill Clip With Bullets:");
shooter.Bullet = int.Parse(Console.ReadLine());*/
#endregion