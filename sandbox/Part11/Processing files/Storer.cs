namespace sandbox
{
    using System;
    using System.IO;

    public class Storer
    {
        public void WriteToFile(string filename, string text)
        {
            try
            {
                StreamWriter writer = new StreamWriter(filename, true);
                writer.WriteLine(text);
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}