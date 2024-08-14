using System.Collections.Generic;
using System.Drawing;

internal class Program
{
    public static void Main(string[] args)
    {
        List<string> coffee = new List<string>();           //Kahve listesi oluşturuldu


        Console.WriteLine("Bir kahve içsek bize iyi gelecek!");
        Console.WriteLine("5 adet kahve ismi giriniz : ");
        int sayac = 1;
        string coffeeName = "";

        while(sayac<=5)      //kullanıcıdan 5 adet kahve ismi istendi Döngüye 5 kez girecek
        {
            Console.Write("Kahve " + sayac + ":" );
            coffeeName = Console.ReadLine();

            coffee.Add(coffeeName);         //listeye kahve isimleri eklendi

            sayac++;


        }

        Console.WriteLine("Girilen Kahve İsimleri: ");          

        foreach (string cof in coffee)          //Kahve listesi foreach döngüsüyle ekrana yazıldı
        {
            Console.WriteLine(cof);
        }
    }
}