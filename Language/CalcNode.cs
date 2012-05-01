using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightyCode
{
	enum Operator
	{
		Add,
		Subtract,
		Multiply,
		Divide
	}

	class CalcNode : Node
	{
		Operator mOperator;
		Node mLHS;
		Node mRHS;

		public CalcNode( string op, Node lhs, Node rhs ) : base( )
		{
			mLHS = lhs;
			mRHS = rhs;
			
			if ( op == "+" )
			{
				mOperator = Operator.Add;
			}

			if ( op == "-" )
			{
				mOperator = Operator.Subtract;
			}

			if ( op == "*" )
			{
				mOperator = Operator.Multiply;
			}

			if ( op == "/" )
			{
				mOperator = Operator.Divide;
			}
		}
		
		public override KnightyCodeObject Evaluate( Context context )
		{
			KnightyCodeObject obj = new KnightyCodeObject( );

			if ( mOperator == Operator.Add )
			{
				obj.AsDouble = mLHS.Evaluate( context ).AsDouble + mRHS.Evaluate( context ).AsDouble;
			}

			if ( mOperator == Operator.Subtract )
			{
				obj.AsDouble = mLHS.Evaluate( context ).AsDouble - mRHS.Evaluate( context ).AsDouble;
			}

			if ( mOperator == Operator.Multiply )
			{
				obj.AsDouble = mLHS.Evaluate( context ).AsDouble * mRHS.Evaluate( context ).AsDouble;
			}

			if ( mOperator == Operator.Divide )
			{
				obj.AsDouble = mLHS.Evaluate( context ).AsDouble / mRHS.Evaluate( context ).AsDouble;
			}

			return obj;
		}
	}
}
