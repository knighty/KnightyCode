using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

using KnightyCode;

namespace KnightyCode
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string expression = "(12.5 + 56 / -7) * 0.5";
			//expression = "print";
			KnightyCodeParser.Run( expression );
			Console.Read( );
		}
	}
}
