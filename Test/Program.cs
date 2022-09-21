using System.Collections.Generic;

namespace MTechSystems.Test.Stages
{
	internal class Stage1
	{
		static void Main(string[] args)
		{
			/*
				Reverse the elements in the list "hello"
	   
				Output:
				 H
				e
				l
				l
				o
				-
				M
				T
				e
				c
				h
				!!
			*/
			string[] hello = new string[] { "!!", "h", "c", "e", "T", "M", "-", "o", "l", "l", "e", "H" };

			string res = "";

			foreach (string s in hello.Reverse())
				res += s;
				

            Console.WriteLine(res);

			/*	
				Count matching elements in the list that contains 'ei'
				Expected Results: Count: 1
			*/
			var words = new List<string> { "believe", "relief", "receipt", "field" };

			int resInt = words.Count(x => x.Contains("ei"));

            Console.WriteLine(resInt);

		}
	}
}