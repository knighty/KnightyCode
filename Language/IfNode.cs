using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	class IfNode : Node
	{
		Node mIf = null;
		Node mTrue = null;
		Node mFalse = null;

		public Node True
		{
			set { mTrue = value; }
		}

		public Node False
		{
			set { mFalse = value; }
		}

		public IfNode( Node if_node ) : base( )
		{
			mIf = if_node;
		}
		
		public override KnightyCodeObject Evaluate( Context context )
		{
			if ( mIf.Evaluate( context ).AsBool )
			{
				mTrue.Evaluate( context );
			}
			else if ( mFalse != null )
			{
				mFalse.Evaluate( context );
			}

			return KnightyCodeObject.Null;
		}
	}
}
