/* Author: Nick Bove
   Date: 1/31/19
   Comments: This C# Console Application demosntrates the use of arrays
             without user input
*/
using System;

namespace ArraysExample
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

				foreach (int i in numbers)
				{
					Console.WriteLine(i + " ");
					Console.ReadKey(true);
				}


			}
			catch
			{
				Console.WriteLine("Press any key to exit the program and try again ...");
				Console.ReadKey(true);
			} 
		}
	}
}
