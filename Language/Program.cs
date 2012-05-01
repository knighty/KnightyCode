using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

using KnightyCode;
using System.Windows.Forms;

namespace KnightyCode
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.EnableVisualStyles();
			CodeEditor ce = new CodeEditor( );
			Application.Run( ce );
		}
	}
}
