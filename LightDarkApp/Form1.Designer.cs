namespace LightDarkApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			label1 = new Label();
			button2 = new Button();
			button3 = new Button();
			checkBox2 = new CheckBox();
			panel1 = new Panel();
			customCheckBox1 = new CustomCheckBox();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.AutoSize = true;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(25, 20);
			button1.Name = "button1";
			button1.Size = new Size(117, 32);
			button1.TabIndex = 0;
			button1.Text = "Change theme";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(222, 20);
			label1.Name = "label1";
			label1.Size = new Size(352, 41);
			label1.TabIndex = 1;
			label1.Text = "Test message to show up";
			// 
			// button2
			// 
			button2.FlatStyle = FlatStyle.Flat;
			button2.Location = new Point(233, 86);
			button2.Name = "button2";
			button2.Size = new Size(163, 29);
			button2.TabIndex = 3;
			button2.Text = "No use button 1";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.FlatStyle = FlatStyle.Flat;
			button3.Location = new Point(233, 138);
			button3.Name = "button3";
			button3.Size = new Size(163, 29);
			button3.TabIndex = 4;
			button3.Text = "No use button 2";
			button3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(233, 198);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(222, 24);
			checkBox2.TabIndex = 5;
			checkBox2.Text = "Original WinForms Checkbox";
			checkBox2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			panel1.Controls.Add(customCheckBox1);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(checkBox2);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button2);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(744, 410);
			panel1.TabIndex = 6;
			// 
			// customCheckBox1
			// 
			customCheckBox1.AutoSize = true;
			customCheckBox1.Location = new Point(233, 238);
			customCheckBox1.Name = "customCheckBox1";
			customCheckBox1.Size = new Size(338, 24);
			customCheckBox1.TabIndex = 6;
			customCheckBox1.Text = "Custom Check box - ShowFocusCues overriden";
			customCheckBox1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Light Dark test app";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private Label label1;
		private Button button2;
		private Button button3;
		private CheckBox checkBox2;
		private Panel panel1;
		private CustomCheckBox customCheckBox1;
	}
}