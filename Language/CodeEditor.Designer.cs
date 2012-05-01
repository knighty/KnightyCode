namespace KnightyCode
{
	partial class CodeEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			this.textBoxCodeWindow = new System.Windows.Forms.TextBox( );
			this.textBoxOutputWindow = new System.Windows.Forms.TextBox( );
			this.splitContainer1 = new System.Windows.Forms.SplitContainer( );
			this.button1 = new System.Windows.Forms.Button( );
			this.label1 = new System.Windows.Forms.Label( );
			this.label2 = new System.Windows.Forms.Label( );
			( ( System.ComponentModel.ISupportInitialize )( this.splitContainer1 ) ).BeginInit( );
			this.splitContainer1.Panel1.SuspendLayout( );
			this.splitContainer1.Panel2.SuspendLayout( );
			this.splitContainer1.SuspendLayout( );
			this.SuspendLayout( );
			// 
			// textBoxCodeWindow
			// 
			this.textBoxCodeWindow.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.textBoxCodeWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCodeWindow.Font = new System.Drawing.Font( "Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
			this.textBoxCodeWindow.Location = new System.Drawing.Point( 0, 27 );
			this.textBoxCodeWindow.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
			this.textBoxCodeWindow.Multiline = true;
			this.textBoxCodeWindow.Name = "textBoxCodeWindow";
			this.textBoxCodeWindow.Size = new System.Drawing.Size( 857, 297 );
			this.textBoxCodeWindow.TabIndex = 0;
			// 
			// textBoxOutputWindow
			// 
			this.textBoxOutputWindow.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.textBoxOutputWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxOutputWindow.Font = new System.Drawing.Font( "Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
			this.textBoxOutputWindow.Location = new System.Drawing.Point( 0, 28 );
			this.textBoxOutputWindow.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
			this.textBoxOutputWindow.Multiline = true;
			this.textBoxOutputWindow.Name = "textBoxOutputWindow";
			this.textBoxOutputWindow.Size = new System.Drawing.Size( 857, 297 );
			this.textBoxOutputWindow.TabIndex = 1;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.splitContainer1.Location = new System.Drawing.Point( 14, 16 );
			this.splitContainer1.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add( this.label1 );
			this.splitContainer1.Panel1.Controls.Add( this.textBoxCodeWindow );
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add( this.label2 );
			this.splitContainer1.Panel2.Controls.Add( this.textBoxOutputWindow );
			this.splitContainer1.Size = new System.Drawing.Size( 857, 659 );
			this.splitContainer1.SplitterDistance = 329;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.button1.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
			this.button1.ForeColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 32 ) ) ) ), ( ( int )( ( ( byte )( 32 ) ) ) ), ( ( int )( ( ( byte )( 32 ) ) ) ) );
			this.button1.Image = global::KnightyCode.Properties.Resources._46;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point( 757, 683 );
			this.button1.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size( 114, 44 );
			this.button1.TabIndex = 3;
			this.button1.Text = "Execute Code";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler( this.button1_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 5, 5 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 90, 17 );
			this.label1.TabIndex = 1;
			this.label1.Text = "Code Window";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 5, 5 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 99, 17 );
			this.label2.TabIndex = 2;
			this.label2.Text = "Output Window";
			// 
			// CodeEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 17F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 885, 743 );
			this.Controls.Add( this.button1 );
			this.Controls.Add( this.splitContainer1 );
			this.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
			this.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
			this.Name = "CodeEditor";
			this.Text = "KnightyCode Editor";
			this.Load += new System.EventHandler( this.CodeEditor_Load );
			this.splitContainer1.Panel1.ResumeLayout( false );
			this.splitContainer1.Panel1.PerformLayout( );
			this.splitContainer1.Panel2.ResumeLayout( false );
			this.splitContainer1.Panel2.PerformLayout( );
			( ( System.ComponentModel.ISupportInitialize )( this.splitContainer1 ) ).EndInit( );
			this.splitContainer1.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxCodeWindow;
		private System.Windows.Forms.TextBox textBoxOutputWindow;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}