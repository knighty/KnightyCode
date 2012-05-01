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
			string expression = "print 5 + 4 * 5 * 2";
			//expression = "print";
			KnightyCodeParser.Run( expression );
			Console.Read( );
		}
	}
}
