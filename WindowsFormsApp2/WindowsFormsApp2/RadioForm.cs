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
	public partial class RadioForm : Form
	{
		public RadioForm()
		{
			InitializeComponent();
		}

		private void onCheckedChange(object sender, EventArgs e)
		{
			RadioButton rb1 = xtGb.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
			RadioButton rb2 = hGb.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
			if(rb1!=null && rb2 != null)
			{
				tb.Text = "Xem theo " + rb1.Text + " hệ " + rb2.Text;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
	
}
