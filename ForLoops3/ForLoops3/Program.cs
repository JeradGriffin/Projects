using System;

namespace ForLoops3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*int i = 0;
			for (;;) 
			{
				++i;
				if (i == 5) 
				{
					continue;
				}
				Console.Write ("Happy Birthday! {0}", i);

				if (i > 10) 
				{
					break;
				}*/
			for (int i = 0; i < 2000; i++) 
			{
				if (i % 100 == 0) 
				{
					Console.Write ("Happy Birthday! {0}", i);
				}
				}
		    }
		}
	}
