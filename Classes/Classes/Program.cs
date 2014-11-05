using System;

namespace Classes
{
	class Employee
	{
		public int Age { get; set; }
		public string Name { get; set; }
		public double Salary { get; set; }
		public DateTime StartingDate { get; set; }
		public string PhoneNumber { get; set; }
	}

	class Program 
	{
		static void Main (string[] args)
		{
			Employee Dave = new Employee()
			{
				Age = 35,
				Name = "David Smith",
				Salary = 50000.00,
				StartingDate = new DateTime(2012, 7, 10),
				PhoneNumber = "617-555-1212"
			};
			Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}",
				Dave.Age, Dave.StartingDate, Dave.Salary);

		}
	}
}
