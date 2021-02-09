using System;
using System.Linq;
using System.Collections.Generic;

namespace PesanRahasiaConsoleApp
{
    class Program
    {
		public static void Main(string[] args)
		{
			string userInput;
			int valOfK;

			Console.Write("Enter integer value of K: ");
			userInput = Console.ReadLine();
			valOfK = Convert.ToInt32(userInput);

			int maxChar = valOfK * valOfK;

			string textInput;
			Console.Write("Enter Text Max " + maxChar + " Char: ");
			textInput = Console.ReadLine();
			if (textInput.Length < maxChar)
			{
				int charEmpty = maxChar - textInput.Length;
				string fillCharEmpty = "";
				for (int i = 0; i < charEmpty; i++)
				{
					fillCharEmpty = fillCharEmpty + "*";
				}
				textInput = textInput + fillCharEmpty;
			}
			Console.WriteLine("Your Text BEFORE Rotation: " + textInput.Substring(0, maxChar));

			List<string> objList = new List<string>();
			for (int i = 0; i < maxChar;)
			{
				string textSplit = textInput.Substring(i, valOfK);
				objList.Add(textSplit);
				i = i + valOfK;
			}

			string textAfterRotation = "";

			for (int ii = 0; ii < valOfK; ii++)
			{
				for (int i = objList.Count(); i > 0;)
				{
					char[] arrayTemp = objList[i - 1].ToCharArray();
					char letter = arrayTemp[ii];
					textAfterRotation = textAfterRotation + letter;
					i = i - 1;
				}
			}

			Console.WriteLine("Your Text AFTER Rotation: " + textAfterRotation.Replace("*", ""));
		}
	}
}
