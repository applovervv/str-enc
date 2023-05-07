using System;
using System.Windows.Forms;

namespace STREnc
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000023E7 File Offset: 0x000005E7
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
