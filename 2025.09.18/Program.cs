using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._09._16.hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void F1()
        {
            Console.WriteLine("Hello world!");
        }
        static void F2()
        {
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}");
        }
        static void F3()
        {
            Console.Write("Szám: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine(szam * 2);
        }
        static void F4()
        {
            Console.Write("Első szám: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Összeg: " + (a + b));
            Console.WriteLine("Különbség: " + (a - b));
            Console.WriteLine("Szorzat: " + (a * b));
            if (b != 0)
                Console.WriteLine("Hányados: " + (a / b));
            else
                Console.WriteLine("Nullával nem lehet osztani");
        }
        static void F5()
        {
            Console.WriteLine("Első szám: ");
            int elso = int.Parse(Console.ReadLine());
            Console.WriteLine("Második szám: ");
            int masodik = int.Parse(Console.ReadLine());

            if (elso > masodik)
            {
                Console.WriteLine($"A(z) {elso} a nagyobb");
            }
            else if (elso < masodik)
            {
                Console.WriteLine($"A(z) {masodik} a nagyobb");
            }
            else
            {
                Console.WriteLine("Egyenlőek");
            }
        }
        static void F6()
        {
            Console.WriteLine("Első szám: ");
            int elso = int.Parse(Console.ReadLine());
            Console.WriteLine("Második szám: ");
            int masodik = int.Parse(Console.ReadLine());
            Console.WriteLine("Harmadik szám: ");
            int harmadik = int.Parse(Console.ReadLine());

            if (elso < masodik && elso < harmadik)
            {
                Console.WriteLine($"{elso} a legkisebb");
            }
            if (elso > masodik && masodik < harmadik)
            {
                Console.WriteLine($"{masodik} a legkisebb");
            }
            if (elso > harmadik && harmadik < masodik)
            {
                Console.WriteLine($"{harmadik} a legkisebb");
            }
        }
        static void F7()
        {
            Console.Write("elso oldal: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("masodik oldal: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("harmadik oldal: ");
            int a3 = int.Parse(Console.ReadLine());

            if (a1 + a2 > a3 && a1 + a3 > a2 && a2 + a3 > a1)
            {
                Console.WriteLine("Szerkeszthető háromszög");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető háromszög");
            }

        }
        static void F8()
        {
            Console.Write("Elso szám: ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            int s2 = int.Parse(Console.ReadLine());
            double szamtani = (s1 + s2) / 2.0;
            double mertani = Math.Sqrt(s1 * s2);
            Console.WriteLine($"Számtani közép: {szamtani}");
            Console.WriteLine($"Mértani közép: {mertani}");
        }
        static void F9()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            double c = double.Parse(Console.ReadLine());

            double diszkr = b * b - 4 * a * c;
            if (diszkr < 0)
            {
                Console.WriteLine("Nincs megoldás");
            }
            else if (diszkr == 0)
            {
                Console.WriteLine("Egy megoldás van");
            }
            else
            {
                Console.WriteLine("Két megoldás van");
            }

        }
        static void F10()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            double c = double.Parse(Console.ReadLine());

            double diszkr = b * b - 4 * a * c;
            if (diszkr < 0)
            {
                Console.WriteLine("Nincs megoldás");
            }
            else if (diszkr == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Megoldás: {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(diszkr)) / (2 * a);
                double x2 = (-b - Math.Sqrt(diszkr)) / (2 * a);
                Console.WriteLine($"Megoldások: {x1} és {x2}");
            }

        }
        static void F11()
        {
            Console.WriteLine("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"c={Math.Sqrt(a * a + b * b)}");
        }
        static void F12()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Felszín = {2 * (a * b + a * c + b * c)}");
            Console.WriteLine($"Térfogat = {a * b * c}");
        }
        static void F13()
        {
            Console.WriteLine("Átmérő: ");
            double atmero = double.Parse(Console.ReadLine());

            Console.WriteLine($"kerület: {2 * (atmero / 2) * Math.PI}");
            Console.WriteLine($"terület: {(atmero / 2) * (atmero / 2) * Math.PI}");
        }
        static void F14()
        {
            Console.WriteLine("sugár: ");
            int sugar = int.Parse(Console.ReadLine());
            Console.WriteLine("szög: ");
            int szog = int.Parse(Console.ReadLine());

            Console.WriteLine($"Határoló ív: {(2 * sugar * Math.PI * szog) / 360}");
            Console.WriteLine($"Terület: {(sugar * sugar * szog) / 360}");
        }
        static void F15()
        {
            Console.WriteLine("Szám: ");
            int szam = int.Parse(Console.ReadLine());

            while (szam != 1)
            {
                szam--;
                Console.Write(szam + " ");
            }
        }
        static void F16()
        {
            Console.WriteLine("Szám: ");
            int szam = int.Parse(Console.ReadLine());

            while (szam != 1)
            {
                szam--;
                Console.WriteLine(szam);
            }
        }
        static void F17()
        {
            Console.WriteLine("Szám: ");
            int sz = int.Parse(Console.ReadLine());

            for (int i = 1; i < sz + 1; i++)
            {
                if (sz % i == 0)
                {
                    Console.Write(i + ";");
                }
            }
        }
        static void F18()
        {
            Console.WriteLine("Szám: ");
            int sz = int.Parse(Console.ReadLine());
            int ossz = 0;
            for (int i = 1; i < sz + 1; i++)
            {
                if (sz % i == 0)
                {
                    ossz += i;
                }
            }
            Console.WriteLine(ossz);
        }
        static void F19()
        {
            Console.WriteLine("Szám: ");
            int sz = int.Parse(Console.ReadLine());
            int ossz = 0;
            for (int i = 1; i < sz + 1; i++)
            {
                if (sz % i == 0)
                {
                    ossz += i;
                }
            }
            if (ossz == sz * 2)
            {
                Console.WriteLine("Tökéletes szám");
            }
            else
            {
                Console.WriteLine("Nem tökéletes szám");
            }

        }
        static void F20()
        {
            Console.WriteLine("Hatványalap: ");
            int hatvany = int.Parse(Console.ReadLine());
            Console.WriteLine("Kitevő: ");
            int kitevo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hatványérték: {Math.Pow(hatvany, kitevo)}");
        }
        static void F21()
        {
            Console.WriteLine("Pozitív szám: ");
            int pszam = int.Parse(Console.ReadLine());
            while (pszam < 0)
            {
                Console.WriteLine("Pozitív szám: ");
                pszam = int.Parse(Console.ReadLine());
            }
        }
        static void F22()
        {
            int ossz = 0;
            Console.WriteLine("Szám: ");
            int szam = int.Parse(Console.ReadLine());
            ossz += szam;
            while (szam < 10)
            {
                Console.WriteLine("Szám: ");
                szam = int.Parse(Console.ReadLine());
                ossz += szam;
            }
            Console.WriteLine(ossz);
        }
        static void F23()
        {
            Console.WriteLine("Szám: ");
            int szam = int.Parse(Console.ReadLine());
            while (szam % 2 == 0)
            {
                szam /= 2;
                Console.Write("2*");
            }
            Console.Write(szam);
        }
        static void F24() 
        {
            Console.WriteLine("Szó: ");
            string szo = Console.ReadLine();
            while (szo != "alma")
            {
                Console.WriteLine("Szó: ");
                szo = Console.ReadLine();
            }
            Console.WriteLine("Az alma gyümölcs!");
        }
        static void F25() 
        {
            Console.WriteLine("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            int db = 0;
            while (szam >= 3)
            {
                szam -= 3;
                db++;
            }
            Console.Write($"{db}*3+{szam}");
        }
        static bool F26(int szam) 
        {
            int db = 0;
            for (int i = 1; i <= szam; i++)
            {
                if(szam%i== 0)
                {
                    db++;
                }
            }
            if (db == 2)
            {
               return true;
            }
            else 
            {
                return false;
            }
        }
        static void F27() 
        {

            Console.WriteLine("Szám: ");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 1; i <= szam; i++) 
            {
                if (F26(i)) 
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
        static void F28()
        {
            Console.WriteLine("Szám: ");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 1; i <= szam; i++)
            {
                if (F26(i) && szam%i==0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
        static void F29() 
        {
            int i = 1;
            Console.WriteLine("Szám: ");
            int szam = int.Parse(Console.ReadLine());
            while (!F26(szam) && i <= szam) 
            {
                if (!F26(i) && szam % i == 0)
                {
                    Console.WriteLine($"{szam} | {i}");
                    szam /= i;
                }
                else 
                {
                    i++;
                }
            }
            Console.WriteLine($"{szam} |");
            //hibás
        }
        static void F30() 
        {
            Console.WriteLine("Szám1: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Szám2: ");
            int szam2 = int.Parse(Console.ReadLine());

            while(szam1 != szam2)
            {
                if (szam1 > szam2)
                {
                    szam1 = szam1 - szam2;
                }
                else 
                {
                    szam2=szam2 - szam1;
                }
            }
            Console.WriteLine(szam1);
           
        }
        static void F31() 
        {
            Console.WriteLine("Szám1: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Szám2: ");
            int szam2 = int.Parse(Console.ReadLine());


        }
    }
}
