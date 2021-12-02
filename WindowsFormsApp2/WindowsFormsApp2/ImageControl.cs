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
	public partial class ImageControl : Form
	{
		public ImageControl()
		{
			InitializeComponent();
		}
		private void onBtnClick(object sender,EventArgs e)
		{
			Button btn = sender as Button;
			btn.Focus();
			tb.Text = btn.AccessibleName + " được chọn";
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
