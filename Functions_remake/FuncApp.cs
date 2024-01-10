using Microsoft.Win32.SafeHandles;
using System.ComponentModel.Design;

namespace Functions_remake;

internal class FuncApp
{
    public void Run()
    {
        Console.WriteLine(TextLength("test"));
        Console.WriteLine(Squared(2));
        PrintHappyBirthday(true);
        Console.WriteLine(IsOdd(5));
        Counter(10);
        Console.WriteLine(ReturnLonger("text_a", "text_ab"));
        Console.WriteLine(Minus(5, 3));
        Console.WriteLine(Plus(1, 1));
        Console.WriteLine(Soucet(1, 9));
        Jump(2, 10, 2);
    }


    //1
    public int TextLength(string a) { return a.Length; }

    //2
    public int Squared(int a) { return a * a; }

    //3
    public void PrintHappyBirthday(bool b)
    {
        if (b) { Console.WriteLine("vše nejlepší"); }
    }

    //4
    public bool IsOdd(int b)
    {
        if (b % 2 == 0) { return false; }

        else { return true; }
    }

    //5
    public void Counter(int p1)
    {
        for (int i = p1; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }

    //6
    public string ReturnLonger(string str1, string str2)
    {
        if (str1.Length > str2.Length) { return str1; }

        else if (str1.Length < str2.Length) { return str2; }

        else { return "jsou stejné"; }
    }

    //7
    public int Minus(int a, int b) { return a - b; }

    //8
    public int Plus(int a, int b) { return a + b; }

    //9
    public int Soucet(int a, int b)
    {
        int soucet = 0;
        for (int i = a + 1; i < b; i++) { soucet += i; }
        return soucet;
    }

    //10

    public void Jump(int start, int end, int jump)
    {
        for (int i = start; i < end; i += jump ) { Console.WriteLine(i); }
    }

}





















