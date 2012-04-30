using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	class PrintNode : Node
	{
		KnightyCodeObject mValue;

		public PrintNode( string val ) : base( )
		{
			mValue = new KnightyCodeObject( );
			mValue.Value = val;
		}
		
		public override KnightyCodeObject Evaluate( Context context )
		{
			Console.Write( mValue.Value );

			KnightyCodeObject obj = new KnightyCodeObject( );
			obj.Value = true;

			return obj;
		}
	}
}
