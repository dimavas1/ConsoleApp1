using System;

namespace ConsoleApp1
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine(Reverse("Hello World!"));
            double aSurface = CalculateRectangular();
			Calculatelabor(aSurface);
		}

        static string Reverse(string str)
		{
			string temp = "";
			
			for (int i = 0; i < str.Length; i++)
			{
				temp = temp + str[str.Length - 1 - i];
			}

			return temp;
		}

		static double CalculateRectangular()
        {
			double width = 0;
			double lenght = 0;

			try
            {
				Console.WriteLine("Enter Width in Centimiters");
				width = double.Parse(Console.ReadLine()) /30.48; // convert to feet
				Console.WriteLine("Enter Lenght in Centimiters");
				lenght = double.Parse(Console.ReadLine()) / 30.48; //convert to feet
			}
            catch (Exception)
            {
				Console.WriteLine("Only numbers allowed");
            }

			return width * lenght;
		}

		static void Calculatelabor(double aSurface)
		{
			Console.WriteLine("Labor Estimation 20 sqf/h for 86$ ");
			Console.WriteLine($"Estimated labour cost is: {Math.Round((aSurface/20)*86,2)} $");
			Console.WriteLine($"Estimated labour hours is: {Math.Round(aSurface/20,2)} h");
		}

	}
}