using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Clock
{
	public partial class FontDialog : Form
	{
		string exePath = "";
		string fontsPath = "";
		public Font Font{ get; set; }
		public FontDialog()
		{
			InitializeComponent();
			exePath = Path.GetDirectoryName(Application.ExecutablePath);
			fontsPath = $"{exePath}\\..\\..\\Fonts";
			LoadFonts();
		}
		void LoadFonts()
		{
			//Directory.SetCurrentDirectory(fontsPath);
            //Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(exePath);

			
			cb_font.Items.AddRange(GetFontsFromDirectory(fontsPath, "*.ttf"));
			cb_font.Items.AddRange(GetFontsFromDirectory(fontsPath, "*.otf"));
			cb_font.SelectedIndex = 0;
		}
		string[] GetFontsFromDirectory(string directory, string format)
		{
			string[] fonts = Directory.GetFiles(directory, format);
			for (int i = 0; i < fonts.Length; i++)
			{
				fonts[i] = Path.GetFileName(fonts[i]);
			}
			return fonts;
		}

		void SetFont()
		{
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile($"{fontsPath}\\{cb_font.SelectedItem}");
			l_exampleFont.Font = new Font(pfc.Families[0], Convert.ToInt32(nud_fontSize.Value));
		}

		private void cb_font_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetFont();
		}

		private void b_ok_Click(object sender, EventArgs e)
		{
			Font = l_exampleFont.Font;
		}

		private void b_apply_Click(object sender, EventArgs e)
		{
			SetFont();
		}
	}
}
