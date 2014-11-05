using System;

namespace ClassesAndObjects
{
	class Employee
	{
		public int Age { get; set; }
		public string Name { get; set; }

	}

	class Program 
	{
		public static void Main (string[] args)
		{
			Employee Dave = new Employee();
			Dave.Age = 35;
			Console.WriteLine ("Dave's age is {0}", Dave.Age);

		}
	}
}
