namespace Clock
{
	partial class AddAlarmDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlarmDialog));
			this.chkbx_UseDate = new System.Windows.Forms.CheckBox();
			this.dtp_Date = new System.Windows.Forms.DateTimePicker();
			this.dtp_Time = new System.Windows.Forms.DateTimePicker();
			this.chklb_WeekDays = new System.Windows.Forms.CheckedListBox();
			this.lbl_FileName = new System.Windows.Forms.Label();
			this.btn_Ok = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.lbl_Message = new System.Windows.Forms.Label();
			this.tb_UserMessage = new System.Windows.Forms.TextBox();
			this.btn_ChooseSignal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// chkbx_UseDate
			// 
			this.chkbx_UseDate.AutoSize = true;
			this.chkbx_UseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chkbx_UseDate.Location = new System.Drawing.Point(223, 149);
			this.chkbx_UseDate.Margin = new System.Windows.Forms.Padding(4);
			this.chkbx_UseDate.Name = "chkbx_UseDate";
			this.chkbx_UseDate.Size = new System.Drawing.Size(145, 35);
			this.chkbx_UseDate.TabIndex = 0;
			this.chkbx_UseDate.Text = "Use date";
			this.chkbx_UseDate.UseVisualStyleBackColor = true;
			this.chkbx_UseDate.CheckedChanged += new System.EventHandler(this.chkbx_UseDate_CheckedChanged);
			// 
			// dtp_Date
			// 
			this.dtp_Date.CustomFormat = "yyyy.MM.dd";
			this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Date.Location = new System.Drawing.Point(20, 145);
			this.dtp_Date.Margin = new System.Windows.Forms.Padding(4);
			this.dtp_Date.Name = "dtp_Date";
			this.dtp_Date.Size = new System.Drawing.Size(195, 37);
			this.dtp_Date.TabIndex = 1;
			// 
			// dtp_Time
			// 
			this.dtp_Time.CustomFormat = "HH:mm";
			this.dtp_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Time.Location = new System.Drawing.Point(20, 13);
			this.dtp_Time.Margin = new System.Windows.Forms.Padding(4);
			this.dtp_Time.Name = "dtp_Time";
			this.dtp_Time.ShowUpDown = true;
			this.dtp_Time.Size = new System.Drawing.Size(93, 37);
			this.dtp_Time.TabIndex = 2;
			// 
			// chklb_WeekDays
			// 
			this.chklb_WeekDays.CheckOnClick = true;
			this.chklb_WeekDays.FormattingEnabled = true;
			this.chklb_WeekDays.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
			this.chklb_WeekDays.Location = new System.Drawing.Point(121, 13);
			this.chklb_WeekDays.Margin = new System.Windows.Forms.Padding(4);
			this.chklb_WeekDays.MultiColumn = true;
			this.chklb_WeekDays.Name = "chklb_WeekDays";
			this.chklb_WeekDays.Size = new System.Drawing.Size(341, 106);
			this.chklb_WeekDays.TabIndex = 3;
			// 
			// lbl_FileName
			// 
			this.lbl_FileName.AutoSize = true;
			this.lbl_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_FileName.Location = new System.Drawing.Point(14, 231);
			this.lbl_FileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_FileName.Name = "lbl_FileName";
			this.lbl_FileName.Size = new System.Drawing.Size(82, 20);
			this.lbl_FileName.TabIndex = 4;
			this.lbl_FileName.Text = "File name";
			// 
			// btn_Ok
			// 
			this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_Ok.Location = new System.Drawing.Point(253, 273);
			this.btn_Ok.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Ok.Name = "btn_Ok";
			this.btn_Ok.Size = new System.Drawing.Size(100, 28);
			this.btn_Ok.TabIndex = 5;
			this.btn_Ok.Text = "OK";
			this.btn_Ok.UseVisualStyleBackColor = true;
			this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(361, 273);
			this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(100, 28);
			this.btn_Cancel.TabIndex = 6;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// lbl_Message
			// 
			this.lbl_Message.AutoSize = true;
			this.lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_Message.Location = new System.Drawing.Point(14, 195);
			this.lbl_Message.Name = "lbl_Message";
			this.lbl_Message.Size = new System.Drawing.Size(137, 32);
			this.lbl_Message.TabIndex = 7;
			this.lbl_Message.Text = "Message:";
			// 
			// tb_UserMessage
			// 
			this.tb_UserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_UserMessage.Location = new System.Drawing.Point(157, 192);
			this.tb_UserMessage.Name = "tb_UserMessage";
			this.tb_UserMessage.Size = new System.Drawing.Size(270, 38);
			this.tb_UserMessage.TabIndex = 8;
			// 
			// btn_ChooseSignal
			// 
			this.btn_ChooseSignal.Location = new System.Drawing.Point(20, 272);
			this.btn_ChooseSignal.Name = "btn_ChooseSignal";
			this.btn_ChooseSignal.Size = new System.Drawing.Size(128, 28);
			this.btn_ChooseSignal.TabIndex = 9;
			this.btn_ChooseSignal.Text = "Choose signal";
			this.btn_ChooseSignal.UseVisualStyleBackColor = true;
			this.btn_ChooseSignal.Click += new System.EventHandler(this.btn_ChooseSignal_Click);
			// 
			// AddAlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 314);
			this.Controls.Add(this.btn_ChooseSignal);
			this.Controls.Add(this.tb_UserMessage);
			this.Controls.Add(this.lbl_Message);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Ok);
			this.Controls.Add(this.lbl_FileName);
			this.Controls.Add(this.chklb_WeekDays);
			this.Controls.Add(this.dtp_Time);
			this.Controls.Add(this.dtp_Date);
			this.Controls.Add(this.chkbx_UseDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddAlarmDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Alarm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkbx_UseDate;
		private System.Windows.Forms.DateTimePicker dtp_Date;
		private System.Windows.Forms.DateTimePicker dtp_Time;
		private System.Windows.Forms.CheckedListBox chklb_WeekDays;
		private System.Windows.Forms.Label lbl_FileName;
		private System.Windows.Forms.Button btn_Ok;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Label lbl_Message;
		private System.Windows.Forms.TextBox tb_UserMessage;
		private System.Windows.Forms.Button btn_ChooseSignal;
	}
}