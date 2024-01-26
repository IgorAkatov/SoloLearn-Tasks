using System.Text.RegularExpressions;

string str = Console.ReadLine()!.Replace("x","");
string signal = "quiet";
string[] v = { @"\$T", @"T\$" };
for (int i = 0; i < 2; i++)
{
    if (Regex.IsMatch(str, v[i]))
        signal = "ALARM";
}

Console.WriteLine(signal);
