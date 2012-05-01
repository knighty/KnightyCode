using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	public class Context
	{
		private Dictionary<string,KnightyCodeObject> mLocals;
		
		public KnightyCodeObject GetLocal( string name )
		{
			KnightyCodeObject obj = mLocals[ name ];
			if ( obj == null )
			{
				return KnightyCodeObject.Null;
			}
			return obj;
		}
		public void SetLocal( string name, KnightyCodeObject val )
		{
			mLocals.Add( name, val );
		}

		public delegate void PrintHandler(object sender, string text);
		public event PrintHandler ePrint;

		public void Print( string text )
		{
			if ( ePrint != null )
				ePrint.Invoke( this, text );
		}
	}
}
