using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	public class KnightyCodeObject
	{
		private object mValue;
		private bool mIsTrue = false;

		public KnightyCodeObject( )
		{
		}

		public KnightyCodeObject( object val )
		{
			mValue = val;
		}

		public object Value
		{
			get { return mValue; }
		}

		public override string ToString( )
		{
			return mValue.ToString( );
		}

		public double AsDouble
		{
			get { return (double)mValue; }
			set { mValue = value; mIsTrue = value != 0; }
		}

		public bool AsBool
		{
			get { return mIsTrue; }
			set {  mValue = value; mIsTrue = value; }
		}

		public static KnightyCodeObject Null = new KnightyCodeObject( null );
	}
}
