using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

			//Instanziierung
			//UserContext myContext = new UserContext(); nicht mehr moeglich, ctor ist private
			UserContext myContext = UserContext.Instance;
			UserContext2 userContext = UserContext2.Instance;

			//Instanzen vegleichen
			Console.WriteLine(myContext == UserContext.Instance);
			Console.WriteLine(userContext == UserContext2.Instance);

			Console.ReadKey();
        }
    }
}

//Vorteil
//Klasse kann nur einmal instanziiert werden

// Nachteil des Singleton
// Multi Threading Synchronisation muss durchdacht sein.
// https://www.youtube.com/watch?v=mhHcDqlrnp8&t=106s
