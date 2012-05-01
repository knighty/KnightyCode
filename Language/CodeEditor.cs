using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Antlr.Runtime;

namespace KnightyCode
{
	public partial class CodeEditor : Form
	{
		public CodeEditor( )
		{
			InitializeComponent( );
		}

		Context mContext;

		private void CodeEditor_Load( object sender, EventArgs e )
		{
			mContext = new Context( );
			mContext.ePrint += new Context.PrintHandler( mContext_ePrint );
		}

		void mContext_ePrint( object sender, string text )
		{
			textBoxOutputWindow.Text += text;
		}

		private void button1_Click( object sender, EventArgs e )
		{
			string expression = textBoxCodeWindow.Text;

			KnightyCodeLexer lex = new KnightyCodeLexer( new ANTLRStringStream( expression ) );
			CommonTokenStream tokens = new CommonTokenStream(lex);
 
			KnightyCodeParser parser = new KnightyCodeParser(tokens);

			parser.Run( expression, mContext );
		}
	}
}
