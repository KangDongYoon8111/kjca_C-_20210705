using System;

namespace ConsoleApp3
{
	class MainApp
	{
		static void LoopTest(int i)
        {
			if (i > 119) { return; }
			Console.WriteLine(i);
			LoopTest(++i);
        }

		static void LoopTest2(int i)
        {
			goto Loop;
		Loop:
			Console.WriteLine(i++);
			if (i <= 119) { goto Loop; }
        }

		static void Main(string[] args)
		{
			LoopTest(0);
			Console.WriteLine();

			LoopTest2(0);
		}
	}
}
