using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
            int x=3;
            int y=6;
            y=y+3;
            Console.WriteLine(y);
            y+=3;
            Console.WriteLine(y);
            y/=2;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);
            //mantıksal operatörler
            bool isSucces=true;
            bool isCompleted=false;
            if(isSucces || isCompleted)
            {
             Console.WriteLine("perfect");
            }
            //ilişkisel operatörler
            int a=2;
            int b=9;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);
            //aritmetik operatörler
            int sayi1=36;
            int sayi2=2;
            int sonuc2=sayi1/sayi2;
            Console.WriteLine(sonuc2);
            sonuc2=sonuc2++; //sayıyı bir arttırmak;
            int sonuc3=sayi1%2;
            Console.WriteLine(sonuc3);
           sonuc2=sayi1++;



            

        }

    }
}

