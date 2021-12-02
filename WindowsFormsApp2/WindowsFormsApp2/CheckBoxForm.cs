using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class CheckBoxForm : Form
	{
		public CheckBoxForm()
		{
			InitializeComponent();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void cbBold_CheckedChanged(object sender, EventArgs e)
		{
			tb.Font = new Font(tb.Font, tb.Font.Style ^ FontStyle.Bold);
		}

		private void cbItalic_CheckedChanged(object sender, EventArgs e)
		{
			tb.Font = new Font(tb.Font, tb.Font.Style ^ FontStyle.Italic);
		}

		private void cbUnderline_CheckedChanged(object sender, EventArgs e)
		{
			tb.Font = new Font(tb.Font, tb.Font.Style ^ FontStyle.Underline);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
