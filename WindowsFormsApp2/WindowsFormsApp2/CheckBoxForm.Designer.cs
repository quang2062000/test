namespace WindowsFormsApp2
{
	partial class CheckBoxForm
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
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbUnderline = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(26, 23);
            this.tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(161, 20);
            this.tb.TabIndex = 0;
            this.tb.Text = "Đại học Công nghiệp Hà Nội";
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBold.Location = new System.Drawing.Point(26, 60);
            this.cbBold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(51, 17);
            this.cbBold.TabIndex = 1;
            this.cbBold.Text = "Đậm";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItalic.Location = new System.Drawing.Point(26, 102);
            this.cbItalic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(66, 17);
            this.cbItalic.TabIndex = 2;
            this.cbItalic.Text = "Nghiêng";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnderline.Location = new System.Drawing.Point(26, 145);
            this.cbUnderline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(75, 17);
            this.cbUnderline.TabIndex = 3;
            this.cbUnderline.Text = "Gạch dưới";
            this.cbUnderline.UseVisualStyleBackColor = true;
            this.cbUnderline.CheckedChanged += new System.EventHandler(this.cbUnderline_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(117, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn hộp kiểm tra để thay đổi kiểu chữ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(83, 177);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CheckBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 220);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUnderline);
            this.Controls.Add(this.cbItalic);
            this.Controls.Add(this.cbBold);
            this.Controls.Add(this.tb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckBoxForm";
            this.Text = "Hộp kiểm tra";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.CheckBox cbBold;
		private System.Windows.Forms.CheckBox cbItalic;
		private System.Windows.Forms.CheckBox cbUnderline;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
	}
}