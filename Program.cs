using System;
namespace alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("dizi sayisini giriniz: ");
             int ar_nu = int.Parse(Console.ReadLine());
             string[] dizi = new string[ar_nu];
             for (int i=0; i<ar_nu; i++)
             {
                 Console.Write("{0}. kelimayi giriniz: ",i+1);
                 dizi[i] = Console.ReadLine();
             }
             Array.Sort(dizi);
             foreach (var kelima in dizi)
             {
             Console.WriteLine(kelima);
             }
        }
    }
    
}