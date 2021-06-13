using System;
using System.Collections.Generic;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> wordCounter = new Dictionary<string, string>();
            wordCounter.Add("txt", "notepad.exe");
            wordCounter.Add("bmp", "paint.exe");
            wordCounter.Add("dib", "paint.exe");
            wordCounter.Add("rtf", "wordpad.exe");
            Console.WriteLine(wordCounter);
            Console.WriteLine("Hello World!");
        }
    }
}
