using System;

namespace Booleans
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool myFirstBoolean = 3 + 2 == 5;
			Console.WriteLine (myFirstBoolean.ToString ());
			bool mySecondBoolean = 3 + 2 > 5;
			Console.WriteLine (mySecondBoolean.ToString ());
			bool bothAreTrue = myFirstBoolean && mySecondBoolean;
			Console.WriteLine ("bothAreTrue evaluates" + bothAreTrue);
			bool oneIsTrue = myFirstBoolean || mySecondBoolean;
			Console.WriteLine ("oneIsTrue evaluates {0} because one expression is true", oneIsTrue);
			bool reverseMyFirstBoolean = !myFirstBoolean;
			Console.WriteLine ("myFirstBoolean is {0} but reverseMyFirstBoolean is {1}", myFirstBoolean, reverseMyFirstBoolean);



		}
	}
}
