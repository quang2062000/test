namespace WindowsFormsApp2
{
	partial class RadioForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tb = new System.Windows.Forms.TextBox();
			this.xtGb = new System.Windows.Forms.GroupBox();
			this.hGb = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.xtGb.SuspendLayout();
			this.hGb.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(12, 12);
			this.tb.Name = "tb";
			this.tb.ReadOnly = true;
			this.tb.Size = new System.Drawing.Size(408, 22);
			this.tb.TabIndex = 0;
			// 
			// xtGb
			// 
			this.xtGb.Controls.Add(this.radioButton2);
			this.xtGb.Controls.Add(this.radioButton1);
			this.xtGb.Location = new System.Drawing.Point(12, 78);
			this.xtGb.Name = "xtGb";
			this.xtGb.Size = new System.Drawing.Size(200, 78);
			this.xtGb.TabIndex = 1;
			this.xtGb.TabStop = false;
			this.xtGb.Text = "Xem theo";
			// 
			// hGb
			// 
			this.hGb.Controls.Add(this.radioButton5);
			this.hGb.Controls.Add(this.radioButton3);
			this.hGb.Controls.Add(this.radioButton4);
			this.hGb.Location = new System.Drawing.Point(234, 60);
			this.hGb.Name = "hGb";
			this.hGb.Size = new System.Drawing.Size(186, 104);
			this.hGb.TabIndex = 0;
			this.hGb.TabStop = false;
			this.hGb.Text = "Hệ";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 21);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(110, 21);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "Số báo danh";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.onCheckedChange);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 48);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(71, 21);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Họ tên";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.onCheckedChange);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(23, 21);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(77, 21);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "Đại học";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.onCheckedChange);
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(23, 48);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(90, 21);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.Text = "Cao đẳng";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.onCheckedChange);
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(23, 75);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(96, 21);
			this.radioButton5.TabIndex = 2;
			this.radioButton5.Text = "Liên thông";
			this.radioButton5.UseVisualStyleBackColor = true;
			this.radioButton5.CheckedChanged += new System.EventHandler(this.onCheckedChange);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(167, 176);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "Đóng";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// RadioForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 220);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hGb);
			this.Controls.Add(this.xtGb);
			this.Controls.Add(this.tb);
			this.Name = "RadioForm";
			this.Text = "Nút lựa chọn";
			this.xtGb.ResumeLayout(false);
			this.xtGb.PerformLayout();
			this.hGb.ResumeLayout(false);
			this.hGb.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.GroupBox xtGb;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox hGb;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Button button1;
	}
}