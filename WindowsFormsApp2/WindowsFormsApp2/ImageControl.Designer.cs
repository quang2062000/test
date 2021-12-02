namespace WindowsFormsApp2
{
	partial class ImageControl
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
			this.upBtn = new System.Windows.Forms.Button();
			this.downBtn = new System.Windows.Forms.Button();
			this.rightBtn = new System.Windows.Forms.Button();
			this.leftBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.closeBtn = new System.Windows.Forms.Button();
			this.tb = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// upBtn
			// 
			this.upBtn.AccessibleName = "Mũi tên lên";
			this.upBtn.Image = global::WindowsFormsApp2.Properties.Resources.up_arrow_alt_regular_60__1_;
			this.upBtn.Location = new System.Drawing.Point(21, 22);
			this.upBtn.Name = "upBtn";
			this.upBtn.Size = new System.Drawing.Size(75, 80);
			this.upBtn.TabIndex = 0;
			this.upBtn.TabStop = false;
			this.upBtn.UseVisualStyleBackColor = true;
			this.upBtn.Click += new System.EventHandler(this.onBtnClick);
			// 
			// downBtn
			// 
			this.downBtn.AccessibleName = "Mũi tên xuống";
			this.downBtn.Image = global::WindowsFormsApp2.Properties.Resources.up_arrow_alt_regular_60__3_;
			this.downBtn.Location = new System.Drawing.Point(125, 22);
			this.downBtn.Name = "downBtn";
			this.downBtn.Size = new System.Drawing.Size(75, 80);
			this.downBtn.TabIndex = 1;
			this.downBtn.TabStop = false;
			this.downBtn.UseVisualStyleBackColor = true;
			this.downBtn.Click += new System.EventHandler(this.onBtnClick);
			// 
			// rightBtn
			// 
			this.rightBtn.AccessibleName = "Mũi tên phải";
			this.rightBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.rightBtn.Image = global::WindowsFormsApp2.Properties.Resources.up_arrow_alt_regular_60__2_;
			this.rightBtn.Location = new System.Drawing.Point(229, 22);
			this.rightBtn.Name = "rightBtn";
			this.rightBtn.Size = new System.Drawing.Size(75, 80);
			this.rightBtn.TabIndex = 2;
			this.rightBtn.TabStop = false;
			this.rightBtn.UseVisualStyleBackColor = true;
			this.rightBtn.Click += new System.EventHandler(this.onBtnClick);
			// 
			// leftBtn
			// 
			this.leftBtn.AccessibleName = "Mũi tên trái";
			this.leftBtn.Image = global::WindowsFormsApp2.Properties.Resources.up_arrow_alt_regular_60;
			this.leftBtn.Location = new System.Drawing.Point(333, 22);
			this.leftBtn.Name = "leftBtn";
			this.leftBtn.Size = new System.Drawing.Size(75, 80);
			this.leftBtn.TabIndex = 3;
			this.leftBtn.TabStop = false;
			this.leftBtn.UseVisualStyleBackColor = true;
			this.leftBtn.Click += new System.EventHandler(this.onBtnClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(18, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(345, 27);
			this.label1.TabIndex = 4;
			this.label1.Text = "Chọn các mũi tên và xem những gì xuất hiện";
			// 
			// closeBtn
			// 
			this.closeBtn.Location = new System.Drawing.Point(165, 152);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(75, 34);
			this.closeBtn.TabIndex = 5;
			this.closeBtn.Text = "Đóng";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(21, 204);
			this.tb.Name = "tb";
			this.tb.ReadOnly = true;
			this.tb.Size = new System.Drawing.Size(387, 22);
			this.tb.TabIndex = 6;
			this.tb.Text = "Không có mũi tên nào đuợc chọn";
			// 
			// ImageControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 247);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.leftBtn);
			this.Controls.Add(this.rightBtn);
			this.Controls.Add(this.downBtn);
			this.Controls.Add(this.upBtn);
			this.Name = "ImageControl";
			this.Text = "Điều khiển ảnh";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button upBtn;
		private System.Windows.Forms.Button downBtn;
		private System.Windows.Forms.Button rightBtn;
		private System.Windows.Forms.Button leftBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.TextBox tb;
	}
}