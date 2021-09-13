using System;

namespace ConsoleApp1
{
	class Program
	{

		static void Main(string[] args)
		{
			string play = "y";
			
			Console.WriteLine(Reverse("Hello World!"));
            
			double aSurface = CalculateRectangular();
            
			Calculatelabor(aSurface);
            Console.WriteLine("Guessing game");
			
			

            while(play=="y")
            {
				GuessTheNumber();
				Console.WriteLine("Do you want to play again y/n");
				play = Console.ReadLine().ToLower();
			}
			
			
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

		static void GuessTheNumber()
        {
			int nTrials = 10;
			string tHight = "Your guess is too hight";
			string hight = "Your guess is hight";
			string tLow = "Your guess is too low";
			string low = "Your guess is low";
			string gEnd = "You Lose";
			string yWin = "You Win";
			int tNum;

			Random rnd = new Random();

			int rNumber = rnd.Next(1, 100);

            for (int i = nTrials; i > 0; i--)
            {
				Console.WriteLine("Guess a number between 1 and 100");

				tNum = int.Parse(Console.ReadLine());

                if (tNum==rNumber)
                {
					Console.WriteLine(yWin);
					break;
				}
                else if(tNum - rNumber > 10) 
                {
					Console.WriteLine(tHight);
				}
				else if (tNum - rNumber < 10 && tNum-rNumber > 0)
				{
					Console.WriteLine(hight);
				}
				else if (tNum - rNumber > -10 && tNum - rNumber < 0)
				{
					Console.WriteLine(low);
				}
				else
                {
					Console.WriteLine(tLow);
				}
			}


		}

	}
}