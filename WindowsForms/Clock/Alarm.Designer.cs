namespace Clock
{
	partial class Alarm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
			this.lb_Alarms = new System.Windows.Forms.ListBox();
			this.lbl_AlarmInfo = new System.Windows.Forms.Label();
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_Cansel = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_Alarms
			// 
			this.lb_Alarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_Alarms.FormattingEnabled = true;
			this.lb_Alarms.Location = new System.Drawing.Point(13, 13);
			this.lb_Alarms.MultiColumn = true;
			this.lb_Alarms.Name = "lb_Alarms";
			this.lb_Alarms.Size = new System.Drawing.Size(509, 186);
			this.lb_Alarms.TabIndex = 0;
			this.lb_Alarms.SelectedIndexChanged += new System.EventHandler(this.lb_Alarms_SelectedIndexChanged);
			this.lb_Alarms.DoubleClick += new System.EventHandler(this.lb_Alarms_DoubleClick);
			// 
			// lbl_AlarmInfo
			// 
			this.lbl_AlarmInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_AlarmInfo.AutoSize = true;
			this.lbl_AlarmInfo.Location = new System.Drawing.Point(13, 206);
			this.lbl_AlarmInfo.Name = "lbl_AlarmInfo";
			this.lbl_AlarmInfo.Size = new System.Drawing.Size(35, 13);
			this.lbl_AlarmInfo.TabIndex = 1;
			this.lbl_AlarmInfo.Text = "label1";
			// 
			// btn_Add
			// 
			this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Add.Location = new System.Drawing.Point(16, 236);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(75, 23);
			this.btn_Add.TabIndex = 2;
			this.btn_Add.Text = "Add";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// btn_Cansel
			// 
			this.btn_Cansel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cansel.Location = new System.Drawing.Point(447, 236);
			this.btn_Cansel.Name = "btn_Cansel";
			this.btn_Cansel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cansel.TabIndex = 3;
			this.btn_Cansel.Text = "Cancel";
			this.btn_Cansel.UseVisualStyleBackColor = true;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(97, 236);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 23);
			this.btn_Delete.TabIndex = 4;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.UseVisualStyleBackColor = true;
			// 
			// Alarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 271);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Cansel);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.lbl_AlarmInfo);
			this.Controls.Add(this.lb_Alarms);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Alarm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Alarm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lb_Alarms;
		private System.Windows.Forms.Label lbl_AlarmInfo;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_Cansel;
		private System.Windows.Forms.Button btn_Delete;
	}
}