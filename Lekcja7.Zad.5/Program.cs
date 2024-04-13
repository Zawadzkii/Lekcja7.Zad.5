using System;

class Program
{
	static void Main()
	{
		Console.Write("Podaj swój wiek: ");

		// Pobranie wieku od użytkownika i konwersja na typ int
		int wiek = Convert.ToInt32(Console.ReadLine());

		// Sprawdzenie warunków dla różnych stanowisk
		if (wiek >= 21)
		{
			Console.WriteLine("Możesz zostać posłem.");
		}
		if (wiek >= 35)
		{
			Console.WriteLine("Możesz zostać premierem lub senatorem.");
		}
		if (wiek >= 35)
		{
			Console.WriteLine("Możesz zostać prezydentem.");
		}

		Console.ReadLine();
	}
}