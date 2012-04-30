﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	class NumberNode : Node
	{
		KnightyCodeObject mValue;

		public NumberNode( string val ) : base( )
		{
			mValue = new KnightyCodeObject( );
			mValue.Value = val;
		}
		
		public override KnightyCodeObject Evaluate( Context context )
		{
			return mValue;
		}
	}
}
