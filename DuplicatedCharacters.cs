using System.IO;
using System;

class Program
{
    public static bool isUniqueChars2(String str) {
        // assuming char_set is ASCII
        bool[] char_set = new bool[256];
        for (int i = 0; i < str.Length; i++) {
            int val = str[i];
            if (char_set[val]) return false;
            char_set[val] = true;
        }
        return true;
    }
    
    static void Main()
    {
        if (isUniqueChars2("Sample Input String.")) {
            Console.WriteLine("The string does not have duplicated chars.");
        }
        else Console.WriteLine("The string has duplicated chars.");
    }
}
