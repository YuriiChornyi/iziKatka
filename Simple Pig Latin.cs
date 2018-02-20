//https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp

public static string PigIt(string str)
{
    return string.Join(" ",str.Split(' ')
                .Select(s => string.Concat(s.Substring(1), s[0], "ay")).ToArray());
}