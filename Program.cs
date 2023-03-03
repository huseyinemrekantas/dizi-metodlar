using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort  
            int [] sayiDizisi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("***** Sirasiz dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("***** Sirali dizi *****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Clear 
            Console.WriteLine("***** Array clear *****");
            // sayiDizisi elemanlarını kullanarak 2. indexten itibaren 0 yapar.
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Reverse 
            Console.WriteLine("***** Array reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //IndexOf
            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            
            //Resize 
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi,12);
            sayiDizisi [8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}