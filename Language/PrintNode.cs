using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	class PrintNode : Node
	{
		Node mValue;

		public PrintNode( Node node ) : base( )
		{
			mValue = node;
		}
		
		public override KnightyCodeObject Evaluate( Context context )
		{
			context.Print( mValue.Evaluate( context ).Value.ToString( ) );

			KnightyCodeObject obj = new KnightyCodeObject( );
			obj.AsBool = true;

			return obj;
		}
	}
}
