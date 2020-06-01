using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

// Token: 0x0200000D RID: 13
internal class Class2
{
	// Token: 0x06000041 RID: 65 RVA: 0x0025C0CC File Offset: 0x0025A2CC
	public static void smethod_0(string string_0)
	{
		string text = Path.GetTempPath() + "configconfuser.crproj";
		string text2 = Class6.String_0;
		string text3 = Path.GetTempPath() + "⁬⁯‌⁮‏‪‏⁭⁯​‌‍⁭⁮‬⁪‮‪⁪‪‪⁭⁫⁭‌‫‍​⁬⁪‍⁬‎‮‪⁪‎‫⁯⁯‮";
		string newValue = new FileInfo(string_0).Directory.ToString();
		text2 = text2.Replace("%path%", newValue).Replace("%basedir%", newValue).Replace("%stub%", string_0);
		File.WriteAllText(text, text2);
		File.WriteAllBytes(Path.GetTempPath() + "confuser.zip", Class6.Byte_0);
		if (Directory.Exists(text3))
		{
			Directory.Delete(text3, true);
		}
		Directory.CreateDirectory(text3);
		ZipFile.ExtractToDirectory(Path.GetTempPath() + "confuser.zip", text3);
		Process.Start(new ProcessStartInfo
		{
			FileName = text3 + "\\Confuser.CLI.exe",
			UseShellExecute = true,
			WindowStyle = ProcessWindowStyle.Hidden,
			Arguments = "-n " + text
		}).WaitForExit();
		File.Delete(Path.GetTempPath() + "confuser.zip");
		File.Delete(Path.GetTempPath() + "configconfuser.crproj");
		Directory.Delete(text3, true);
	}
}
