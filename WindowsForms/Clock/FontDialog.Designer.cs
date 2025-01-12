namespace Clock
{
	partial class FontDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontDialog));
			this.cb_font = new System.Windows.Forms.ComboBox();
			this.labelChooseFont = new System.Windows.Forms.Label();
			this.labelChooseSize = new System.Windows.Forms.Label();
			this.nud_fontSize = new System.Windows.Forms.NumericUpDown();
			this.l_exampleFont = new System.Windows.Forms.Label();
			this.b_ok = new System.Windows.Forms.Button();
			this.b_cancel = new System.Windows.Forms.Button();
			this.b_apply = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nud_fontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_font
			// 
			this.cb_font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cb_font.FormattingEnabled = true;
			this.cb_font.Location = new System.Drawing.Point(16, 36);
			this.cb_font.Name = "cb_font";
			this.cb_font.Size = new System.Drawing.Size(588, 32);
			this.cb_font.TabIndex = 0;
			this.cb_font.SelectedIndexChanged += new System.EventHandler(this.cb_font_SelectedIndexChanged);
			// 
			// labelChooseFont
			// 
			this.labelChooseFont.AutoSize = true;
			this.labelChooseFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelChooseFont.Location = new System.Drawing.Point(12, 9);
			this.labelChooseFont.Name = "labelChooseFont";
			this.labelChooseFont.Size = new System.Drawing.Size(111, 24);
			this.labelChooseFont.TabIndex = 1;
			this.labelChooseFont.Text = "Choose font";
			// 
			// labelChooseSize
			// 
			this.labelChooseSize.AutoSize = true;
			this.labelChooseSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelChooseSize.Location = new System.Drawing.Point(634, 9);
			this.labelChooseSize.Name = "labelChooseSize";
			this.labelChooseSize.Size = new System.Drawing.Size(86, 24);
			this.labelChooseSize.TabIndex = 2;
			this.labelChooseSize.Text = "Font size";
			// 
			// nud_fontSize
			// 
			this.nud_fontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nud_fontSize.Location = new System.Drawing.Point(638, 37);
			this.nud_fontSize.Maximum = new decimal(new int[] {
            58,
            0,
            0,
            0});
			this.nud_fontSize.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.nud_fontSize.Name = "nud_fontSize";
			this.nud_fontSize.Size = new System.Drawing.Size(150, 29);
			this.nud_fontSize.TabIndex = 3;
			this.nud_fontSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// l_exampleFont
			// 
			this.l_exampleFont.AutoSize = true;
			this.l_exampleFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_exampleFont.Location = new System.Drawing.Point(12, 107);
			this.l_exampleFont.Name = "l_exampleFont";
			this.l_exampleFont.Size = new System.Drawing.Size(191, 51);
			this.l_exampleFont.TabIndex = 4;
			this.l_exampleFont.Text = "Example";
			// 
			// b_ok
			// 
			this.b_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.b_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.b_ok.Location = new System.Drawing.Point(571, 147);
			this.b_ok.Name = "b_ok";
			this.b_ok.Size = new System.Drawing.Size(96, 40);
			this.b_ok.TabIndex = 5;
			this.b_ok.Text = "OK";
			this.b_ok.UseVisualStyleBackColor = true;
			this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
			// 
			// b_cancel
			// 
			this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.b_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.b_cancel.Location = new System.Drawing.Point(673, 147);
			this.b_cancel.Name = "b_cancel";
			this.b_cancel.Size = new System.Drawing.Size(115, 40);
			this.b_cancel.TabIndex = 6;
			this.b_cancel.Text = "Cancel";
			this.b_cancel.UseVisualStyleBackColor = true;
			// 
			// b_apply
			// 
			this.b_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.b_apply.Location = new System.Drawing.Point(638, 85);
			this.b_apply.Name = "b_apply";
			this.b_apply.Size = new System.Drawing.Size(150, 31);
			this.b_apply.TabIndex = 7;
			this.b_apply.Text = "Apply";
			this.b_apply.UseVisualStyleBackColor = true;
			this.b_apply.Click += new System.EventHandler(this.b_apply_Click);
			// 
			// FontDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 199);
			this.Controls.Add(this.b_apply);
			this.Controls.Add(this.b_cancel);
			this.Controls.Add(this.b_ok);
			this.Controls.Add(this.l_exampleFont);
			this.Controls.Add(this.nud_fontSize);
			this.Controls.Add(this.labelChooseSize);
			this.Controls.Add(this.labelChooseFont);
			this.Controls.Add(this.cb_font);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FontDialog";
			this.Text = "Choose clock font";
			((System.ComponentModel.ISupportInitialize)(this.nud_fontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_font;
		private System.Windows.Forms.Label labelChooseFont;
		private System.Windows.Forms.Label labelChooseSize;
		private System.Windows.Forms.NumericUpDown nud_fontSize;
		private System.Windows.Forms.Label l_exampleFont;
		private System.Windows.Forms.Button b_ok;
		private System.Windows.Forms.Button b_cancel;
		private System.Windows.Forms.Button b_apply;
	}
}