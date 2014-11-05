using System;

namespace ForLoops2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int age = 35;
			int newAge = ++age;
			Console.WriteLine ("age; {0}, newAge; {1}", age, newAge);

			newAge = age++;
			Console.WriteLine ("age; {0}, newAge; {1}", age, newAge);
		}
	}
}
