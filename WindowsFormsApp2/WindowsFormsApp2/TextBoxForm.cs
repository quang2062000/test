using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class TextBoxForm : Form
	{
		public TextBoxForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void rbDefault_CheckedChanged(object sender, EventArgs e)
		{
			if (rbDefault.Checked)
			{
				tb1.SelectionStart = 0;
				tb1.Focus();
			}
		}

		private void rbLastLine_CheckedChanged(object sender, EventArgs e)
		{
			if (rbLastLine.Checked)
			{
				tb1.SelectionStart = tb1.Text.Length;
				tb1.Focus();
			}
		}

		private void rbAfter5Chars_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAfter5Chars.Checked)
			{
				tb1.SelectionStart = 5;
				tb1.Focus();
			}
		}

		private void rbSelectAll_CheckedChanged(object sender, EventArgs e)
		{
			if (rbSelectAll.Checked)
			{
				tb1.SelectAll();
				tb1.Focus();
			}
		}

		private void rbInsertText_CheckedChanged(object sender, EventArgs e)
		{
			if (rbInsertText.Checked)
			{
				tb1.SelectedText = "Hello";
				tb1.Focus();
			}
		}

		private void btnReinit_Click(object sender, EventArgs e)
		{
			tb1.SelectionStart = 0;
			tb1.SelectionLength = 0;
			tb1.Focus();
			tb1.Text = "Thuộc tính Multiline được thiết lập là false";
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
