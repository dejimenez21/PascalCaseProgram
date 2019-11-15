using System;

namespace PascalCaseProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line;
            string result = string.Empty;

            line = Console.ReadLine();

            foreach(var item in line.Split(' '))
            {
                result += CapitalizarPalabra(item) + " ";
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string CapitalizarPalabra(string word)
        {
            if(string.IsNullOrEmpty(word))
                return string.Empty;
            
            char[] caraceteres = word.ToCharArray();
            caraceteres[0] = char.ToUpper(caraceteres[0]);

            for(int i=1; i<word.Length; i++)
            {
                caraceteres[i] = char.ToLower(caraceteres[i]);
            }

            return new string(caraceteres);
        }
    }
}
