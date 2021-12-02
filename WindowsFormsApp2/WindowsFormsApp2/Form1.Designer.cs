namespace WindowsFormsApp2
{
	partial class Form1
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
			this.btnTextBox = new System.Windows.Forms.Button();
			this.btnImageControl = new System.Windows.Forms.Button();
			this.end = new System.Windows.Forms.Button();
			this.btnRadio = new System.Windows.Forms.Button();
			this.btnCheckBox = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnTextBox
			// 
			this.btnTextBox.Location = new System.Drawing.Point(63, 39);
			this.btnTextBox.Name = "btnTextBox";
			this.btnTextBox.Size = new System.Drawing.Size(131, 32);
			this.btnTextBox.TabIndex = 0;
			this.btnTextBox.Text = "Hộp văn &bản";
			this.btnTextBox.UseVisualStyleBackColor = true;
			this.btnTextBox.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnImageControl
			// 
			this.btnImageControl.Location = new System.Drawing.Point(63, 83);
			this.btnImageControl.Name = "btnImageControl";
			this.btnImageControl.Size = new System.Drawing.Size(131, 32);
			this.btnImageControl.TabIndex = 1;
			this.btnImageControl.Text = "Điều k&hiển ảnh";
			this.btnImageControl.UseVisualStyleBackColor = true;
			this.btnImageControl.Click += new System.EventHandler(this.button2_Click);
			// 
			// end
			// 
			this.end.Location = new System.Drawing.Point(209, 126);
			this.end.Name = "end";
			this.end.Size = new System.Drawing.Size(131, 32);
			this.end.TabIndex = 2;
			this.end.Text = "&Kết thúc";
			this.end.UseVisualStyleBackColor = true;
			this.end.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnRadio
			// 
			this.btnRadio.Location = new System.Drawing.Point(209, 83);
			this.btnRadio.Name = "btnRadio";
			this.btnRadio.Size = new System.Drawing.Size(131, 32);
			this.btnRadio.TabIndex = 3;
			this.btnRadio.Text = "Nút lựa &chọn";
			this.btnRadio.UseVisualStyleBackColor = true;
			this.btnRadio.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnCheckBox
			// 
			this.btnCheckBox.Location = new System.Drawing.Point(209, 39);
			this.btnCheckBox.Name = "btnCheckBox";
			this.btnCheckBox.Size = new System.Drawing.Size(131, 32);
			this.btnCheckBox.TabIndex = 4;
			this.btnCheckBox.Text = "Hộp kiểm &tra";
			this.btnCheckBox.UseVisualStyleBackColor = true;
			this.btnCheckBox.Click += new System.EventHandler(this.button5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 204);
			this.Controls.Add(this.btnCheckBox);
			this.Controls.Add(this.btnRadio);
			this.Controls.Add(this.end);
			this.Controls.Add(this.btnImageControl);
			this.Controls.Add(this.btnTextBox);
			this.Name = "Form1";
			this.Text = "Các điều khiển";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTextBox;
		private System.Windows.Forms.Button btnImageControl;
		private System.Windows.Forms.Button end;
		private System.Windows.Forms.Button btnRadio;
		private System.Windows.Forms.Button btnCheckBox;
	}
}

