using System;

namespace PrimaryDictionaryAttemp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> nameAge = new MyDictionary<string, int>();

            nameAge.Add("Ali", 54);
            nameAge.Add("Veli", 12);
            nameAge.Add("Hakkı", 71);
            nameAge.Add("Osman", 26);

            for (int i = 0; i < nameAge.Keys.Length; i++)
            {
                Console.Write("["+nameAge.Keys[i] + ", ");
                Console.Write(nameAge.Values[i] + "]");
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Eleman Sayısı: " + nameAge.Length);







        }
    }
}
