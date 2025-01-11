namespace Clock
{
	partial class ColorPickForm
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
			this.RedBar = new System.Windows.Forms.TrackBar();
			this.GreenBar = new System.Windows.Forms.TrackBar();
			this.BlueBar = new System.Windows.Forms.TrackBar();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.RedText = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.DeclineButton = new System.Windows.Forms.Button();
			this.RedLabel = new System.Windows.Forms.Label();
			this.GreenLabel = new System.Windows.Forms.Label();
			this.BlueLabel = new System.Windows.Forms.Label();
			this.PreviewBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
			this.SuspendLayout();
			// 
			// RedBar
			// 
			this.RedBar.Location = new System.Drawing.Point(39, 10);
			this.RedBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.RedBar.Maximum = 255;
			this.RedBar.Name = "RedBar";
			this.RedBar.Size = new System.Drawing.Size(340, 45);
			this.RedBar.TabIndex = 1;
			this.RedBar.ValueChanged += new System.EventHandler(this.RedBar_ValueChanged);
			// 
			// GreenBar
			// 
			this.GreenBar.Location = new System.Drawing.Point(39, 51);
			this.GreenBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.GreenBar.Maximum = 255;
			this.GreenBar.Name = "GreenBar";
			this.GreenBar.Size = new System.Drawing.Size(340, 45);
			this.GreenBar.TabIndex = 2;
			this.GreenBar.ValueChanged += new System.EventHandler(this.GreenBar_ValueChanged);
			// 
			// BlueBar
			// 
			this.BlueBar.Location = new System.Drawing.Point(39, 93);
			this.BlueBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BlueBar.Maximum = 255;
			this.BlueBar.Name = "BlueBar";
			this.BlueBar.Size = new System.Drawing.Size(340, 45);
			this.BlueBar.TabIndex = 3;
			this.BlueBar.ValueChanged += new System.EventHandler(this.BlueBar_ValueChanged);
			// 
			// ApplyButton
			// 
			this.ApplyButton.Location = new System.Drawing.Point(262, 134);
			this.ApplyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(56, 19);
			this.ApplyButton.TabIndex = 4;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// RedText
			// 
			this.RedText.AutoSize = true;
			this.RedText.Location = new System.Drawing.Point(10, 10);
			this.RedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.RedText.Name = "RedText";
			this.RedText.Size = new System.Drawing.Size(27, 13);
			this.RedText.TabIndex = 5;
			this.RedText.Text = "Red";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Green";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 93);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Blue";
			// 
			// DeclineButton
			// 
			this.DeclineButton.Location = new System.Drawing.Point(322, 134);
			this.DeclineButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.DeclineButton.Name = "DeclineButton";
			this.DeclineButton.Size = new System.Drawing.Size(56, 19);
			this.DeclineButton.TabIndex = 8;
			this.DeclineButton.Text = "Decline";
			this.DeclineButton.UseVisualStyleBackColor = true;
			this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
			// 
			// RedLabel
			// 
			this.RedLabel.AutoSize = true;
			this.RedLabel.Location = new System.Drawing.Point(10, 136);
			this.RedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.RedLabel.Name = "RedLabel";
			this.RedLabel.Size = new System.Drawing.Size(35, 13);
			this.RedLabel.TabIndex = 9;
			this.RedLabel.Text = "label3";
			// 
			// GreenLabel
			// 
			this.GreenLabel.AutoSize = true;
			this.GreenLabel.Location = new System.Drawing.Point(59, 136);
			this.GreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.GreenLabel.Name = "GreenLabel";
			this.GreenLabel.Size = new System.Drawing.Size(35, 13);
			this.GreenLabel.TabIndex = 10;
			this.GreenLabel.Text = "label3";
			// 
			// BlueLabel
			// 
			this.BlueLabel.AutoSize = true;
			this.BlueLabel.Location = new System.Drawing.Point(111, 136);
			this.BlueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BlueLabel.Name = "BlueLabel";
			this.BlueLabel.Size = new System.Drawing.Size(35, 13);
			this.BlueLabel.TabIndex = 11;
			this.BlueLabel.Text = "label3";
			// 
			// PreviewBox
			// 
			this.PreviewBox.Location = new System.Drawing.Point(158, 134);
			this.PreviewBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PreviewBox.Name = "PreviewBox";
			this.PreviewBox.Size = new System.Drawing.Size(83, 18);
			this.PreviewBox.TabIndex = 12;
			this.PreviewBox.TabStop = false;
			// 
			// ColorPickForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 200);
			this.ControlBox = false;
			this.Controls.Add(this.PreviewBox);
			this.Controls.Add(this.BlueLabel);
			this.Controls.Add(this.GreenLabel);
			this.Controls.Add(this.RedLabel);
			this.Controls.Add(this.DeclineButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.RedText);
			this.Controls.Add(this.ApplyButton);
			this.Controls.Add(this.BlueBar);
			this.Controls.Add(this.GreenBar);
			this.Controls.Add(this.RedBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ColorPickForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "ColorPickForm";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TrackBar RedBar;
		private System.Windows.Forms.TrackBar GreenBar;
		private System.Windows.Forms.TrackBar BlueBar;
		private System.Windows.Forms.Button ApplyButton;
		private System.Windows.Forms.Label RedText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button DeclineButton;
		private System.Windows.Forms.Label RedLabel;
		private System.Windows.Forms.Label GreenLabel;
		private System.Windows.Forms.Label BlueLabel;
		private System.Windows.Forms.PictureBox PreviewBox;
	}
}