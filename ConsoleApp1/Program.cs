using System;

namespace ConsoleApp1
{
	class Program
	{

		static void Main(string[] args)
		{
			string playAgain = "y";

            Console.WriteLine(Reverse("Hello World!"));
            CalculateLabor(InputRectangulareArea());
			CalculateLabor(InputRoundlArea());
            
			Console.WriteLine("Guessing game");

            while(playAgain == "y")
            {
				GuessTheNumber();
				Console.WriteLine("Do you want to play again y/n");
				playAgain = Console.ReadLine().ToLower();
			}
			
			
		}

		/// <summary>
		/// Reversing a string
		/// </summary>
		/// <param name="str">String to reverce</param>
		/// <returns>Reversed string</returns>
        static string Reverse(string str)
		{
			string temp = "";
			
			for (int i = 0; i < str.Length; i++)
			{
				temp = temp + str[str.Length - 1 - i];
			}

			return temp;
		}

		/// <summary>
		/// Receiving 2 doubles from user (width and lenght)
		/// and calculating surface in feets
		/// </summary>
		/// <returns>surface infeets</returns>
		static double InputRectangulareArea()
        {
			double WidthNum, LenghtNum;
			string WidthStr,LenghtStr;

            do
            {
				Console.WriteLine("Enter Width in Centimiters");
				WidthStr = Console.ReadLine();
				Console.WriteLine("Enter Lenght in Centimiters");
				LenghtStr = Console.ReadLine();

			} while (!double.TryParse(WidthStr, out WidthNum) || !double.TryParse(LenghtStr, out LenghtNum));

			WidthNum = double.Parse(WidthStr) /30.48; // convert to feet
			LenghtNum = double.Parse(LenghtStr) / 30.48; //convert to feet

			return WidthNum * LenghtNum;
		}

		/// <summary>
		/// Receiving 1 doubles from user (radius)
		/// and calculating surface in feets
		/// </summary>
		/// <returns>surface in feets</returns>
		static double InputRoundlArea()
		{
			double radius;
			double pi = Math.PI;
			string temp;

            do
            {
				Console.WriteLine("Enter Radius in Centimiters");
				temp = Console.ReadLine();
			} while (!double.TryParse(temp, out radius));

			radius = radius/30.48; //convert to feet

			return Math.Round(pi*radius*radius,2);
		}

		/// <summary>
		/// Calculate cost of labor and estimate labor time
		/// </summary>
		/// <param name="Surface">surface in sqr feet</param>
		static void CalculateLabor(double Surface)
		{
			Console.WriteLine("Labor Estimation 20 sqf/h for 86$ ");
			Console.WriteLine($"Estimated labour cost is: {Math.Round((Surface/20)*86,2)} $");
			Console.WriteLine($"Estimated labour hours is: {Math.Round(Surface/20,2)} h");
		}

		/// <summary>
		/// Guessing Number game.
		/// Randomly piking a number between 1 to 100.
		/// User should guess the number with 10 triles
		/// </summary>
		static void GuessTheNumber()
        {
			int i;
			int numOfTrials = 10;
			string tooHightPrint = "Your guess is too hight";
			string hightPrint = "Your guess is hight";
			string tooLowPrint = "Your guess is too low";
			string lowPrint = "Your guess is low";
            string gameLosePrint = "You Lose";
			string gameWinPrint = "You Win";
			string youClosePrint = "You're close!";
			int tempNumumeric;
			string tempString;
			int trialsCounter = 0;

			Random rnd = new Random();

			int randomNumber = rnd.Next(1, 100);

            for (i = numOfTrials; i > 0; i--)
            {
				
				do
                {
					Console.WriteLine("Pick a number between 1 and 100");
					tempString = Console.ReadLine();
                } while (!ValidInput(tempString));

				tempNumumeric = int.Parse(tempString);

				if (tempNumumeric==randomNumber)
                {
					Console.WriteLine(gameWinPrint);
					break;
				}

				trialsCounter++;

				if (tempNumumeric - randomNumber > 10) 
                {
					Console.WriteLine(tooHightPrint);
				}
				
				if (tempNumumeric - randomNumber < 10 && tempNumumeric-randomNumber > 0)
				{
					Console.WriteLine(hightPrint);
				}
				
				if (tempNumumeric - randomNumber > -10 && tempNumumeric - randomNumber < 0)
				{
					Console.WriteLine(lowPrint);
				}
				
				if (tempNumumeric - randomNumber < -10 )
				{
					Console.WriteLine(tooLowPrint);
				}
				
				if (trialsCounter == 5)
				{
					Console.WriteLine(youClosePrint);
				}
			}

			if (trialsCounter == numOfTrials)
			{
				Console.WriteLine(gameLosePrint);
			}

		}

		/// <summary>
		/// Validate that string can be parse to double and it's between 1 and 100
		/// </summary>
		/// <param name="str">string representing double</param>
		/// <returns></returns>
		static bool ValidInput(string str)
        {
            return int.TryParse(str, out int res) && res > 0 && res < 101;
        }

	}
}