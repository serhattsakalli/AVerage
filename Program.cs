using System.Security.Cryptography.X509Certificates;

namespace Ortalama;

class Program
{
    static void Main(string[] args)
    {
        Program Hesap=new Program();
        Console.WriteLine("fibonacci serisindeki rakamların ortalaması için kaçıncı seriye kadar hesaplansın :"); 
        Hesap.Hesaplama(int.Parse(Console.ReadLine()));  
        Console.ReadLine();
    }
    public void Hesaplama(int rakam)
    {
        double sonuc=0;
        int sayi1=1;
        int sayi2=1;
        int sayi3=1;
        double geneltop=0;
        int sayac=1;
        {
            for (int i = 2; i < rakam; i++)
            {
                if (sayac==1)
                {
                    sayi1=sayi2+sayi3;
                    geneltop+=sayi1;
                    sayac=2;
                }
                else if (sayac==2)
                {
                    sayi2=sayi3+sayi1;
                    geneltop+=sayi2;
                    sayac=3;
                }
                else if (sayac==3)
                {
                    sayi3=sayi1+sayi2;
                    geneltop+=sayi3;
                    sayac=1;
                }
            }
        }
        geneltop+=2;
        sonuc=geneltop/rakam;
        Console.WriteLine("toplamı: {0}. ortalaması: {1:F2}", geneltop, sonuc);
    }

}
