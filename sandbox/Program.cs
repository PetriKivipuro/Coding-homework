using System;
using System.IO;
using System.Collections.Generic;

namespace sandbox
{
    class Program
    {
        public static void Main(string[] args)
        {

            string diary = "uusi2.txt";
            string[] lines = File.ReadAllLines(diary);
            StreamWriter sw = new StreamWriter(diary);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (lines[i].Contains("taitaa alkaa"))
                {
                    line = "Kyllä vain se tästä alkaa.";
                }
                sw.WriteLine(line);
            }
            sw.Close();
        }

    }
}
