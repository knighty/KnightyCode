using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	public class KnightyCodeObject
	{
		public object mValue;

		public object Value
		{
			get { return mValue; }
			set { mValue = value; }
		}

		public override string ToString( )
		{
			return mValue.ToString( );
		}

		public Double AsDouble
		{
			get { return (Double)mValue; }
		}
	}
}
