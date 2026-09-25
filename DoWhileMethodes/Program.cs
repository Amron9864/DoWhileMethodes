using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileMethodes
{
    internal class Program
    {
        
        static void Koszon()
        {
            Console.WriteLine("Hello! Szia! Szevasz!");
        }
        /*
        static void Koszon(string nev)
        {
            Console.WriteLine($"Szia {nev}");
        }
        static void Bemutatkozas(string nev, int eletkor)
        {
            Console.WriteLine($" Szia {nev}");
            Console.WriteLine($"A te életkorod : {eletkor}");
        }
        static  int Osszeadas (int szam1, int szam2)
        {
            /*
            int osszeg = szam1 + szam2;
            return osszeg;
            
            return szam1 + szam2;
        }
        static int Kivonas(int szam1, int szam2)
        { 
            if ( szam1 > szam2)
                return szam1 - szam2;
            else
                return szam2 -szam2;
        }
        static int Szorzas(int szam1, int szam2)
        {
            return szam1 * szam2;
        }
        static int Osztas(int szam1, int szam2)
        {
            return szam1 % szam2;
        }
        static void Koszsones( string nev = " Vendég")
        {
            Console.WriteLine($" Szia {nev}"); 
        }
        static void Koszones (string nev, int eletkor = 16)
        {
            
        }
        static bool NagykoruE(int eletkor) //bool - van visszatérési érték, true vagy false
        {
            if (eletkor >= 18)
                return true;
            else
                return false;
        }
        {
            /*
            if (eletkor >= 18)
                return true;
            else
                return false;
            
            return eletkor >= 18;
        }
        */
        static void Main(string[] args)
        {
            /*
            Koszon();
            Console.Write("Add meg a neved:");
            string nev = Console.ReadLine();
            //Koszon(nev);
            Console.Write("Add meg az életkorod:");
            int kor = Convert.ToInt32(Console.ReadLine());
            Bemutatkozas(nev, kor);
            int osszeg = Osszeg(2, 5);
            Console.WriteLine(osszeg);
            Console.WriteLine(Osszeg(2,5));
            */
            /*
            Console.Write("Első szam:");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("második szam");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            /*
            Console.WriteLine($"összeadás: {Osszeadas(szam1, szam2)}");
            Console.WriteLine($"összeadás: {Kivonas(szam1, szam2)}");
            Console.WriteLine($"összeadás: {Szorzas(szam1, szam2)}");
            Console.WriteLine($"összeadás: {Osztas(szam1, szam2)}");
            

            string nagykoruE = "";
            if (NagykoruE(16))
                nagykoruE = "Nagykorú";
            else
                nagykoruE = "Kiskorú";
            nagykoruE = NagykoruE(19) ? "nagykorú" : "kiskorú";

            Console.WriteLine($" A te életszakaszod: {nagykoruE}");
            */
            int szam = 1;
            do
            {
                Console.WriteLine(szam);
                /*
                szam = szam + 1;
                szam += 1;
                szam++;
                szam = szam - 1;
                szam--;
                */
                szam++;
            }
            while (szam <= 5);

            int valasztas;
            do
            {
                Console.Clear();
                Console.WriteLine("==MENÜ==");
                Console.WriteLine("1) Köszsönés");
                Console.WriteLine("2) Név bekérés");
                Console.WriteLine("3) kilépés");
                Console.Write("Válaszátás");
                valasztas= Convert.ToInt32(Console.ReadLine());
                switch(valasztas)
                {
                    case 1:
                        Koszon();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Mi a neved:");
                        string nev = Console.ReadLine();
                        Console.WriteLine($"Szia {nev}");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("kilépés");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("nincs ilyen menüpont");
                        Console.ReadLine();
                        break;



                }
            } while(valasztas != 3);

            Console.ReadLine();
        }
    }
}
