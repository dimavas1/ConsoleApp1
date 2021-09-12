using System;

namespace ConsoleApp1
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine(reverse("hellow!"));
		}

		static string reverse(string str)
		{
			string temp = "";
			for (int i = 0; i < str.Length; i++)
			{
				temp = temp + str[str.Length - 1 - i];
			}

			return temp;
		}

	}
}