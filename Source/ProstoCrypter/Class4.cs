using System;
using System.Drawing;
using System.IO;

// Token: 0x02000034 RID: 52
internal class Class4
{
	// Token: 0x060001E0 RID: 480 RVA: 0x0026745C File Offset: 0x0026565C
	public static Bitmap smethod_0(string string_0)
	{
		if (string_0 == "")
		{
			return null;
		}
		byte[] array = File.ReadAllBytes(string_0);
		int num = (int)Math.Sqrt((double)(array.Length / 4 + 2)) + 1;
		int num2 = 0;
		Bitmap bitmap = new Bitmap(num, num);
		byte[] array2 = new byte[num * num * 4];
		Buffer.BlockCopy(BitConverter.GetBytes(array.Length), 0, array2, 0, 4);
		Buffer.BlockCopy(array, 0, array2, 4, array.Length);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				int argb = BitConverter.ToInt32(array2, num2);
				num2 += 4;
				Color color = Color.FromArgb(argb);
				bitmap.SetPixel(i, j, color);
			}
		}
		return bitmap;
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00267508 File Offset: 0x00265708
	public static Bitmap smethod_1(string string_0)
	{
		if (string_0 == "")
		{
			return null;
		}
		Random random = new Random();
		char[] array = Convert.ToBase64String(File.ReadAllBytes(string_0)).ToCharArray();
		int num = (int)Math.Sqrt((double)array.Length) + 10;
		Bitmap bitmap = new Bitmap(num, num);
		Graphics.FromImage(bitmap);
		int i = 0;
		while (i <= array.Length - 1)
		{
			for (int j = 1; j <= bitmap.Height - 1; j++)
			{
				for (int k = 1; k <= bitmap.Width - 1; k++)
				{
					if (i <= array.Length - 1)
					{
						random.Next(0, 255);
						random.Next(0, 255);
						int red = (int)array[i];
						bitmap.SetPixel(k, j, Color.FromArgb(red, 100, 0));
						i++;
					}
				}
			}
		}
		return bitmap;
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x002675D0 File Offset: 0x002657D0
	public static string smethod_2(int int_0)
	{
		string text = "ﮱﯤﭲﮚﺹﺼﮕﮱﻁﺹﭫﯤﺖﮢﯔﭲﮚﺹﺼﮕﭫﯤﺖﮢﯔﭫﮱﻁﺹﺼﮕﭫﻱﯤﺖﮢلخدماشغالكمنقدملكمك";
		string text2 = text[Class4.random_0.Next(10, text.Length)].ToString();
		for (int i = 1; i < int_0; i++)
		{
			text2 += text[Class4.random_0.Next(text.Length)].ToString();
		}
		return text2;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00267638 File Offset: 0x00265838
	public static string smethod_3(int int_0)
	{
		string text = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
		string text2 = text[Class4.random_0.Next(10, text.Length)].ToString();
		for (int i = 1; i < int_0; i++)
		{
			text2 += text[Class4.random_0.Next(text.Length)].ToString();
		}
		return text2;
	}

	// Token: 0x04000132 RID: 306
	private static Random random_0 = new Random();
}
