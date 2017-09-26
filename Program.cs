using System;

namespace vowel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("enter any one char:");
			char ch = char.Parse (Console.ReadLine ());
			switch (Char.ToLower (ch)) {
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
				Console.WriteLine ("vowel..");
				break;
			default:
				Console.WriteLine ("not invalid");
				break;
			
			}
		}

		}
	
}
