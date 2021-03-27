using System;
using StackADT;

namespace ReversingString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string mystr = "bruh";
            Console.WriteLine(ReverseStr(mystr));

        }

        static public string ReverseStr(string input)
        {
            Stack s = new Stack(input.Length);
            char[] characters = input.ToCharArray();
            for(int i=0; i<characters.Length; i++)
            {
                s.Push(characters[i]);
            }
            s.PrintStack();
            for (int j = 0; j < s.GetSize(); j++)
            {
                characters[j] = s.Pop();
            }
            string output = new string(characters);
            return output;
        }
    }
}
