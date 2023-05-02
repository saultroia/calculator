using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string value;
			do
			{
				int res;
				Console.Write("Enter first number:");
				int a = Convert.ToInt32(Console.ReadLine());
				Console.Write("Enter second number:");
				int b = Convert.ToInt32(Console.ReadLine());
				Console.Write("Enter symbol:");
				string symbol = Console.ReadLine();

				switch (symbol)
				{
					case "+":
						res = a + b;
						Console.WriteLine("Addition:" + res);
						break;
					case "-":
						res = a - b;
						Console.WriteLine("Subtraction:" + res);
						break;
					case "*":
						res = a * b;
						Console.WriteLine("Multiplication:" + res);
						break;
					case "/":
						res = a / b;
						Console.WriteLine("Division:" + res);
						break;
					default:
						Console.WriteLine("Wrong input.");
						break;
				}
				Console.ReadLine();
				Console.Write("Continue? Enter Y for yes, N for no.");
				value = Console.ReadLine();
			}
			while (value=="y" || value=="Y");
		}
	}

}
