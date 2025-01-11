using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class ColorPickForm : Form
	{
		public ColorPickForm(byte red, byte green, byte blue)
		{
			InitializeComponent();
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			RedBar.Value = red;
			GreenBar.Value = green;
			BlueBar.Value = blue;
			RedLabel.Text = $"R:{RedBar.Value.ToString()}";
			GreenLabel.Text = $"G:{GreenBar.Value.ToString()}";
			BlueLabel.Text = $"B:{BlueBar.Value.ToString()}";
			PreviewBox.BackColor = Color.FromArgb(red, green, blue);
		}

		public int Red
			{ get { return RedBar.Value; }}
		public int Green
			{ get { return GreenBar.Value; }}
		public int Blue
			{ get { return BlueBar.Value; }}


		private void ApplyButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void RedBar_ValueChanged(object sender, EventArgs e)
		{
			RedLabel.Text = $"R:{RedBar.Value.ToString()}";
			PreviewBox.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
		}

		private void GreenBar_ValueChanged(object sender, EventArgs e)
		{
			GreenLabel.Text = $"G:{GreenBar.Value.ToString()}";
			PreviewBox.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
		}

		private void BlueBar_ValueChanged(object sender, EventArgs e)
		{
			BlueLabel.Text = $"B:{BlueBar.Value.ToString()}";
			PreviewBox.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value);
		}

		private void DeclineButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
