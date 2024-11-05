namespace metodusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Koszonto();
            Console.WriteLine(Osszeadas(10,90));
			int a = 5;
            Console.WriteLine(Duplaz(a));
            Console.WriteLine(a);
			int duplazott = Duplaz(a);
            Console.WriteLine(duplazott);
            Console.WriteLine(Osszeg(10,7));
			int elso = 5;
			int masodik = 10;
			Csere(elso,masodik);
            Console.ReadLine();
		}
		static void Koszonto()
		{
			Console.WriteLine("Helló világ!");
        }

		static int Osszeadas(int a, int b)
		{
			/*
			int osszeg = a + b;
			return osszeg;
			*/
			return a + b;
		}

		static int Duplaz(int szam)
		{
			return szam*2;
		}

		static int Osszeg(int a, int b=5, int c = 2)
		{
			return a + b + c;
		}

		static void Csere(int a, int b)
		{
			int temp = a;
			a = b;
			b = temp;
			Console.WriteLine(a + " " + b);
		}
	}
}
