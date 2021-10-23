using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> product = new MyDictionary<string, int>();

            product.Add("Kitap", 70);
            product.Add("Defter", 20);
            product.Add("Silgi", 7);

        
        }
    }
}
