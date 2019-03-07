using System.IO;
using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document");
            Console.WriteLine("What would you like to name your document");
            string name = Console.ReadLine();
            Console.WriteLine("Please make the most out of this document, lend me your knowledge");
            string info = Console.ReadLine();
            try
            {
                StreamWriter bigboy = new StreamWriter("Document.txt");
                bigboy.WriteLine(name + " " + info);
                bigboy.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }
            finally
            {
                Console.WriteLine("{0} Has been saved, but wait the document contains\nCharacters: {1}", name, info.Length);
            }
        }
    }
}