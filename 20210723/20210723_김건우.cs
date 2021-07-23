using System;

namespace ConsoleApp3
{
	class MainApp
	{
		static void LoopTest(int i)
        {
			if (i > 119) { return; }
			Console.Write(i + " ");
			LoopTest(++i);
        }

		static void LoopTest2(int i)
        {
		Loop:
			Console.Write(i++ + " ");
			if (i <= 119) { goto Loop; }
        }

		static void Main(string[] args)
		{
			LoopTest(1);
			Console.WriteLine();

			LoopTest2(1);
		}
	}
}
