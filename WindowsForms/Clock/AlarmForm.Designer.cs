namespace Clock
{
	partial class AlarmForm
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
			this.buttonSetAlarm = new System.Windows.Forms.Button();
			this.buttonAlarmOff = new System.Windows.Forms.Button();
			this.timerAlarm = new System.Windows.Forms.Timer(this.components);
			this.textBoxAlarmName = new System.Windows.Forms.TextBox();
			this.labelAlarmTime = new System.Windows.Forms.Label();
			this.maskedTextBoxUserAlarmTime = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// buttonSetAlarm
			// 
			this.buttonSetAlarm.Location = new System.Drawing.Point(12, 227);
			this.buttonSetAlarm.Name = "buttonSetAlarm";
			this.buttonSetAlarm.Size = new System.Drawing.Size(125, 22);
			this.buttonSetAlarm.TabIndex = 2;
			this.buttonSetAlarm.Text = "Set Alarm";
			this.buttonSetAlarm.UseVisualStyleBackColor = true;
			this.buttonSetAlarm.Click += new System.EventHandler(this.buttonSetAlarm_Click);
			// 
			// buttonAlarmOff
			// 
			this.buttonAlarmOff.Location = new System.Drawing.Point(477, 239);
			this.buttonAlarmOff.Name = "buttonAlarmOff";
			this.buttonAlarmOff.Size = new System.Drawing.Size(125, 23);
			this.buttonAlarmOff.TabIndex = 3;
			this.buttonAlarmOff.Text = "Alarm Off";
			this.buttonAlarmOff.UseVisualStyleBackColor = true;
			// 
			// timerAlarm
			// 
			this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
			// 
			// textBoxAlarmName
			// 
			this.textBoxAlarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxAlarmName.Location = new System.Drawing.Point(12, 103);
			this.textBoxAlarmName.Name = "textBoxAlarmName";
			this.textBoxAlarmName.Size = new System.Drawing.Size(283, 28);
			this.textBoxAlarmName.TabIndex = 4;
			this.textBoxAlarmName.Text = "Alarm name";
			this.textBoxAlarmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelAlarmTime
			// 
			this.labelAlarmTime.AutoSize = true;
			this.labelAlarmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAlarmTime.Location = new System.Drawing.Point(49, 9);
			this.labelAlarmTime.Name = "labelAlarmTime";
			this.labelAlarmTime.Size = new System.Drawing.Size(216, 91);
			this.labelAlarmTime.TabIndex = 5;
			this.labelAlarmTime.Text = "Time";
			// 
			// maskedTextBoxUserAlarmTime
			// 
			this.maskedTextBoxUserAlarmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.maskedTextBoxUserAlarmTime.Location = new System.Drawing.Point(12, 137);
			this.maskedTextBoxUserAlarmTime.Mask = "00:00";
			this.maskedTextBoxUserAlarmTime.Name = "maskedTextBoxUserAlarmTime";
			this.maskedTextBoxUserAlarmTime.Size = new System.Drawing.Size(283, 75);
			this.maskedTextBoxUserAlarmTime.TabIndex = 1;
			this.maskedTextBoxUserAlarmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.maskedTextBoxUserAlarmTime.ValidatingType = typeof(System.DateTime);
			// 
			// AlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 274);
			this.Controls.Add(this.labelAlarmTime);
			this.Controls.Add(this.textBoxAlarmName);
			this.Controls.Add(this.buttonAlarmOff);
			this.Controls.Add(this.buttonSetAlarm);
			this.Controls.Add(this.maskedTextBoxUserAlarmTime);
			this.Name = "AlarmForm";
			this.Text = "AlarmForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSetAlarm;
		private System.Windows.Forms.Button buttonAlarmOff;
		private System.Windows.Forms.Timer timerAlarm;
		private System.Windows.Forms.TextBox textBoxAlarmName;
		private System.Windows.Forms.Label labelAlarmTime;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxUserAlarmTime;
	}
}