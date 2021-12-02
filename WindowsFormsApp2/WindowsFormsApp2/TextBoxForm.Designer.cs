namespace WindowsFormsApp2
{
	partial class TextBoxForm
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
			this.components = new System.ComponentModel.Container();
			this.tb1 = new System.Windows.Forms.TextBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tb2 = new System.Windows.Forms.TextBox();
			this.gbCursorPos = new System.Windows.Forms.GroupBox();
			this.rbDefault = new System.Windows.Forms.RadioButton();
			this.rbLastLine = new System.Windows.Forms.RadioButton();
			this.rbAfter5Chars = new System.Windows.Forms.RadioButton();
			this.rbSelectAll = new System.Windows.Forms.RadioButton();
			this.rbInsertText = new System.Windows.Forms.RadioButton();
			this.btnReinit = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.gbCursorPos.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb1
			// 
			this.tb1.Location = new System.Drawing.Point(47, 75);
			this.tb1.Name = "tb1";
			this.tb1.Size = new System.Drawing.Size(200, 22);
			this.tb1.TabIndex = 0;
			this.tb1.Text = "Thuộc tính Multiline được thiết lập là false";
			// 
			// tb2
			// 
			this.tb2.Location = new System.Drawing.Point(283, 51);
			this.tb2.Multiline = true;
			this.tb2.Name = "tb2";
			this.tb2.Size = new System.Drawing.Size(160, 63);
			this.tb2.TabIndex = 1;
			this.tb2.Text = "Thuộc tính Multiline được thiết lập là true";
			// 
			// gbCursorPos
			// 
			this.gbCursorPos.Controls.Add(this.rbLastLine);
			this.gbCursorPos.Controls.Add(this.rbDefault);
			this.gbCursorPos.Controls.Add(this.rbSelectAll);
			this.gbCursorPos.Controls.Add(this.rbAfter5Chars);
			this.gbCursorPos.Controls.Add(this.rbInsertText);
			this.gbCursorPos.Location = new System.Drawing.Point(47, 112);
			this.gbCursorPos.Name = "gbCursorPos";
			this.gbCursorPos.Size = new System.Drawing.Size(200, 159);
			this.gbCursorPos.TabIndex = 2;
			this.gbCursorPos.TabStop = false;
			this.gbCursorPos.Text = "Vị trí con trỏ";
			// 
			// rbDefault
			// 
			this.rbDefault.AutoSize = true;
			this.rbDefault.Checked = true;
			this.rbDefault.Location = new System.Drawing.Point(19, 21);
			this.rbDefault.Name = "rbDefault";
			this.rbDefault.Size = new System.Drawing.Size(86, 21);
			this.rbDefault.TabIndex = 0;
			this.rbDefault.TabStop = true;
			this.rbDefault.Text = "Mặc định";
			this.rbDefault.UseVisualStyleBackColor = true;
			this.rbDefault.CheckedChanged += new System.EventHandler(this.rbDefault_CheckedChanged);
			// 
			// rbLastLine
			// 
			this.rbLastLine.AutoSize = true;
			this.rbLastLine.Location = new System.Drawing.Point(19, 48);
			this.rbLastLine.Name = "rbLastLine";
			this.rbLastLine.Size = new System.Drawing.Size(93, 21);
			this.rbLastLine.TabIndex = 1;
			this.rbLastLine.Text = "Cuối dòng";
			this.rbLastLine.UseVisualStyleBackColor = true;
			this.rbLastLine.CheckedChanged += new System.EventHandler(this.rbLastLine_CheckedChanged);
			// 
			// rbAfter5Chars
			// 
			this.rbAfter5Chars.AutoSize = true;
			this.rbAfter5Chars.Location = new System.Drawing.Point(19, 75);
			this.rbAfter5Chars.Name = "rbAfter5Chars";
			this.rbAfter5Chars.Size = new System.Drawing.Size(100, 21);
			this.rbAfter5Chars.TabIndex = 2;
			this.rbAfter5Chars.Text = "Sau 5 ký tự";
			this.rbAfter5Chars.UseVisualStyleBackColor = true;
			this.rbAfter5Chars.CheckedChanged += new System.EventHandler(this.rbAfter5Chars_CheckedChanged);
			// 
			// rbSelectAll
			// 
			this.rbSelectAll.AutoSize = true;
			this.rbSelectAll.Location = new System.Drawing.Point(19, 102);
			this.rbSelectAll.Name = "rbSelectAll";
			this.rbSelectAll.Size = new System.Drawing.Size(169, 21);
			this.rbSelectAll.TabIndex = 3;
			this.rbSelectAll.Text = "Chọn toàn bộ văn bản";
			this.rbSelectAll.UseVisualStyleBackColor = true;
			this.rbSelectAll.CheckedChanged += new System.EventHandler(this.rbSelectAll_CheckedChanged);
			// 
			// rbInsertText
			// 
			this.rbInsertText.AutoSize = true;
			this.rbInsertText.Location = new System.Drawing.Point(19, 129);
			this.rbInsertText.Name = "rbInsertText";
			this.rbInsertText.Size = new System.Drawing.Size(117, 21);
			this.rbInsertText.TabIndex = 4;
			this.rbInsertText.Text = "Chèn văn bản";
			this.rbInsertText.UseVisualStyleBackColor = true;
			this.rbInsertText.CheckedChanged += new System.EventHandler(this.rbInsertText_CheckedChanged);
			// 
			// btnReinit
			// 
			this.btnReinit.Location = new System.Drawing.Point(109, 292);
			this.btnReinit.Name = "btnReinit";
			this.btnReinit.Size = new System.Drawing.Size(104, 38);
			this.btnReinit.TabIndex = 5;
			this.btnReinit.Text = "Khởi tạo lại";
			this.btnReinit.UseVisualStyleBackColor = true;
			this.btnReinit.Click += new System.EventHandler(this.btnReinit_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(303, 292);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(104, 38);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Đóng";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(280, 175);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 66);
			this.label1.TabIndex = 7;
			this.label1.Text = "Chọn vị trí con trỏ và xem kết quả trên hộp văn bản đầu tiên";
			// 
			// TextBoxForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 398);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnReinit);
			this.Controls.Add(this.gbCursorPos);
			this.Controls.Add(this.tb2);
			this.Controls.Add(this.tb1);
			this.Name = "TextBoxForm";
			this.Text = "Hộp văn bản";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.gbCursorPos.ResumeLayout(false);
			this.gbCursorPos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.TextBox tb2;
		private System.Windows.Forms.GroupBox gbCursorPos;
		private System.Windows.Forms.RadioButton rbLastLine;
		private System.Windows.Forms.RadioButton rbDefault;
		private System.Windows.Forms.RadioButton rbSelectAll;
		private System.Windows.Forms.RadioButton rbInsertText;
		private System.Windows.Forms.RadioButton rbAfter5Chars;
		private System.Windows.Forms.Button btnReinit;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
	}
}