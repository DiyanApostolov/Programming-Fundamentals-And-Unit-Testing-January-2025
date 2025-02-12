using System;

namespace TestApp;

public class StringReverse
{
    public static string Reverse(string inputString)
    {
        char[] charArray = inputString.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
