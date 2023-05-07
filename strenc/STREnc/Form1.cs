using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace STREnc
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		private void button1_Click(object sender, EventArgs e)
		{
			string text = "/*" + this.tbInput.Text + "*/ ";
			text += "StrEnc(";
			List<byte> list = new List<byte>();
			List<byte> list2 = new List<byte>();
			Random random = new Random();
			for (int i = 0; i < this.tbInput.Text.Length; i++)
			{
				byte b;
				byte b2;
				do
				{
					b = (byte)random.Next(0, 255);
					b2 = (byte)(this.tbInput.Text[i] ^ (char)b);
				}
				while (b2 < 32 || b2 > 126);
				if (b2 == 34 || b2 == 92)
				{
					list.Add(92);
				}
				list.Add(b2);
				list2.Add(b);
			}
			string text2 = "";
			for (int j = 0; j < list2.Count; j++)
			{
				text2 += "\\x";
				text2 += list2[j].ToString("X2");
			}
			text += "\"";
			text += Encoding.ASCII.GetString(list.ToArray());
			text = string.Concat(new string[]
			{
				text,
				"\", \"",
				text2,
				"\", ",
				this.tbInput.Text.Length.ToString(),
				").c_str();"
			});
			this.tbOutput.Text = text;
			this.tbOutput.Focus();
			this.tbOutput.SelectAll();
		}
	}
}
