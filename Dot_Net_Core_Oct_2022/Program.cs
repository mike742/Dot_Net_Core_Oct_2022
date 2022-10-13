/*
 phone numbers
 204 123-4567
 255 222-3344
 
emails
lucy@mycompany.ca
john.smith@gmail.com
mike@robertsoncolleage.ca
 */
/*
string file_path = "c:\\projects\\dot_net\\hw1";
string file_path2 = @"c:\projects\dot_net\hw1";

Console.WriteLine($"file path is {file_path}");
Console.WriteLine($"file path 2 is {file_path2}");
*/

using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using Dot_Net_Core_Oct_2022;

// PrintIsValid("aaaaa", @"^a{5}$");
// PrintIsValid("nnn", @"^n{3}$");
// book|door|room
// PrintIsValid("cake", @"^[a-z]oo[a-z]$");
// PrintIsValid("cake", @"^[a-z]{4}$");
// PrintIsValid("Cucumberss", @"^[A-Z][a-z]{5,8}$");
/*
 phone numbers
 204 123-4567
 255 222-3344
*/
/*
PrintIsValid("255 222-3344", @"^[0-9]{3} [0-9]{3}-[0-9]{4}$");
PrintIsValid("255 222-3344", @"^\d{3} \d{3}-\d{4}$");

PrintIsValid("john-smith", @"^\w{3,}$");
PrintIsValid("john-smith", @"^[a-zA-Z0-9_-]{3,}$");
PrintIsValid("                     ", @"^\s{1,}$");
PrintIsValid("                     ", @"^\s+$");

// cat|at
PrintIsValid("ccccccccccccccccccccat", @"^c*at$");

PrintIsValid("gogogoo", @"^(go)+$");


ConsoleKeyInfo cki = Console.ReadKey(true);

if (cki.Key == ConsoleKey.Escape)
{
    Console.WriteLine("Escape has pressed");
}
if (cki.Key == ConsoleKey.Enter)
{
    Console.WriteLine("Enter has pressed");
}
*/

/*
    string str = "hello world";
    str = "hello .Net Core";
 */

StringBuilder sb = new StringBuilder("Hello");

sb.Append(" ");
sb.Append(".Net Core");

sb = new StringBuilder("Total amout is: ");
sb.AppendFormat("{0:C}", 50);

sb.Insert(6, "test substring ");
sb.Remove(6, 5);
// Console.WriteLine(sb.ToString());

string str = @"I do not like them
In a house.
I do not like them
With a mouse.
I do not like them
Here or there.
I do not like them
Anywhere.
I do not like green eggs and ham.
I do not like them, Sam-I-am.";

sb = new StringBuilder(str);
sb.Replace("not", "");
sb.Replace("  ", " ");

// Console.WriteLine(sb.ToString());

// Tuple
// id: int, fullName: string, email: string
var t1 = Tuple.Create(101, "Mark Smith", "mark@gmail.com");
Console.WriteLine(t1.ToString());
Console.WriteLine($"full name is {t1.Item2}");
Console.WriteLine($"email is {t1.Item3}");

(double, int) t2 = (4.5, 123);
Console.WriteLine(t2.Item1 + " " + t2.Item2);

(int id, string fullName, string email) t3 = (102, "Lucy Swanson", "lucy@gmail.com");
Console.WriteLine(t3.fullName);

int id = 103; 
string fullName = "Tracy Johnson"; 
string email = "tracy@gmail.com";
var t4 = (id, fullName, email);
Console.WriteLine(t4.email);

var t5 = (id: 102, name: "John Doe", email: "john@gmail.com", salary: 2120.55);

(int a, byte b) l = (5, 10);
(long a, int b) r = (5, 10);
Console.WriteLine(l == r);
Console.WriteLine(l != r);

var l1 = (A: 5, B: 10);
var r1 = (B: 5, A: 10);
Console.WriteLine(l1 == r1);


var user = new { 
    Id = 108, 
    Name = "Mark", 
    Email = "mark@gmsil.com", 
    Salary = 12345} ;

var arrUsers = new[] 
    { 
        new { Name = "Adam", Id = 111, Salary = 1350 }, 
        new { Name = "Mary", Id = 112, Salary = 1500 } 
    };


string str3 = "hello extension methods";
// str3.FlipFirstLetterCase();
string res = str3.FlipFirstLetterCase();
Console.WriteLine(res);
// Console.WriteLine( StringHelper.FlipFirstLetterCase(str3));



Console.WriteLine(ulong.MaxValue);

ulong dig = ulong.MaxValue;
dig++;
dig++;
dig++;

// Console.WriteLine("dig = " + dig);

BigInteger bin = ulong.MaxValue;
bin++;
bin++;
bin++;

// Console.WriteLine("bin = " + bin);


BigInteger bi = BigInteger.Parse("18499000000000000000");
string strNum = bi.ToString("N0");

var numberParts =  strNum.Split(",");
Console.WriteLine(numberParts.Length);

foreach (var part in numberParts)
{
    PartToWord(part);   
}



static void PartToWord(string number)
{ 
    number = number.Trim().PadLeft(3, '0');
    int index = -1;
    string res = string.Empty;
    var unitsMap = new[] {
        "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
        "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
        "seventeen", "eighteen", "nineteen"
    };

    var tensMap = new[] { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty"  };

    Console.WriteLine($"number = {number}");
    if (number[0] != '0')
    {
        index = Convert.ToInt32(number[0].ToString());
        res += unitsMap[index] + " hundred";
    }

    if (number[1] == '1')
    {
        index = Convert.ToInt32(number[1].ToString() + number[2].ToString());
        res += string.IsNullOrEmpty(res) ? "" : " ";
        res += unitsMap[index];
    }
    else
    {
        index = Convert.ToInt32(number[1].ToString());
        res += string.IsNullOrEmpty(res) ? "" : " ";
        res += tensMap[index];
        index = Convert.ToInt32(number[2].ToString());
        res += string.IsNullOrEmpty(res) ? "" : " ";
        res += unitsMap[index];
    }

    Console.WriteLine(res);
}


static void PrintIsValid(string input, string re)
{ 
    Console.WriteLine( $" {input} and {re} is match: { Regex.IsMatch(input, re)}" );
}