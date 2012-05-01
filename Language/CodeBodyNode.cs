using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	class CodeBodyNode : Node
	{
		private NodeCollection mNodes = new NodeCollection( );
		public NodeCollection Nodes
		{
			get { return mNodes; }
		}

		public CodeBodyNode( ) : base( )
		{
		}

		public override KnightyCodeObject Evaluate( Context context )
		{
			foreach( Node node in mNodes )
			{
				KnightyCodeObject e = node.Evaluate( context );
				if ( e.GetType( ) == typeof( ReturnNode ) )
				{
					return e; 
				}
			}

			return KnightyCodeObject.Null;
		}
	}
}
