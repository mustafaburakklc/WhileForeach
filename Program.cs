using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak girilen sayiya kadar sayilarin ortalamasını hesaplayan kod
            /*System.Console.Write("Lütfen sayi girin: ");
            int sayi= int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }

            Console.WriteLine(toplam/sayi);*/

            /*char character='a';
            while (character<='z')
            {
                Console.Write(character + " ");
                character++;
            }*/
    string [] arabalar = {"BMW","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                System.Console.WriteLine(araba);
            }
        }
    }
}
