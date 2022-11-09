using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> result = Enumerable.Range(1, 10);
			IEnumerable<int> result2 = Enumerable.Range(10, 6);
			foreach (int i in result)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine();
			foreach (int i in result2)
			{
				Console.WriteLine(i);
			}
		}
	}
}
