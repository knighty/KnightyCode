using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	public class Node
	{
		public Node( ) { }

		public virtual KnightyCodeObject Evaluate( Context context ) { return null; }
	}
}
