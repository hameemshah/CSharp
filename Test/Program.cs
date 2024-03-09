using System;

public class Program
{  
    static void Main(string[] args)
    {
        int[] luckyNumbers = {2,3,4};
        string s = string.Join(",",luckyNumbers);
        Console.WriteLine(s);
    }
}