using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	class WhileNode : Node
	{
		Node mConditional = null;
		Node mBody = null;

		public Node Body
		{
			set { mBody = value; }
		}
				
		public WhileNode( Node conditional ) : base( )
		{
			mConditional = conditional;
		}
		
		public override KnightyCodeObject Evaluate( Context context )
		{
			while ( mConditional.Evaluate( context ).AsBool )
			{
				mBody.Evaluate( context );
			}

			return KnightyCodeObject.Null;
		}
	}
}
