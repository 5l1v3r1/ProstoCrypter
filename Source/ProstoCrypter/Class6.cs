using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000036 RID: 54
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[CompilerGenerated]
internal class Class6
{
	// Token: 0x060001E7 RID: 487 RVA: 0x0025B380 File Offset: 0x00259580
	internal Class6()
	{
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060001E8 RID: 488 RVA: 0x002676DC File Offset: 0x002658DC
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class6.resourceManager_0 == null)
			{
				Class6.resourceManager_0 = new ResourceManager("Class6", typeof(Class6).Assembly);
			}
			return Class6.resourceManager_0;
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060001E9 RID: 489 RVA: 0x00267714 File Offset: 0x00265914
	// (set) Token: 0x060001EA RID: 490 RVA: 0x00267728 File Offset: 0x00265928
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class6.cultureInfo_0;
		}
		set
		{
			Class6.cultureInfo_0 = value;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060001EB RID: 491 RVA: 0x0026773C File Offset: 0x0026593C
	internal static string String_0
	{
		get
		{
			return Class6.ResourceManager_0.GetString("config", Class6.cultureInfo_0);
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060001EC RID: 492 RVA: 0x00267760 File Offset: 0x00265960
	internal static byte[] Byte_0
	{
		get
		{
			return (byte[])Class6.ResourceManager_0.GetObject("ConfuserEx", Class6.cultureInfo_0);
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060001ED RID: 493 RVA: 0x00267788 File Offset: 0x00265988
	internal static Icon Icon_0
	{
		get
		{
			return (Icon)Class6.ResourceManager_0.GetObject("imageres_81", Class6.cultureInfo_0);
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060001EE RID: 494 RVA: 0x002677B0 File Offset: 0x002659B0
	internal static Icon Icon_1
	{
		get
		{
			return (Icon)Class6.ResourceManager_0.GetObject("imageres_84", Class6.cultureInfo_0);
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060001EF RID: 495 RVA: 0x002677D8 File Offset: 0x002659D8
	internal static Icon Icon_2
	{
		get
		{
			return (Icon)Class6.ResourceManager_0.GetObject("imageres_98", Class6.cultureInfo_0);
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060001F0 RID: 496 RVA: 0x00267800 File Offset: 0x00265A00
	internal static Icon Icon_3
	{
		get
		{
			return (Icon)Class6.ResourceManager_0.GetObject("imageres_99", Class6.cultureInfo_0);
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060001F1 RID: 497 RVA: 0x00267828 File Offset: 0x00265A28
	internal static string String_1
	{
		get
		{
			return Class6.ResourceManager_0.GetString("Loader", Class6.cultureInfo_0);
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060001F2 RID: 498 RVA: 0x0026784C File Offset: 0x00265A4C
	internal static string String_2
	{
		get
		{
			return Class6.ResourceManager_0.GetString("Stub", Class6.cultureInfo_0);
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060001F3 RID: 499 RVA: 0x00267870 File Offset: 0x00265A70
	internal static string String_3
	{
		get
		{
			return Class6.ResourceManager_0.GetString("stub2", Class6.cultureInfo_0);
		}
	}

	// Token: 0x04000133 RID: 307
	private static ResourceManager resourceManager_0;

	// Token: 0x04000134 RID: 308
	private static CultureInfo cultureInfo_0;
}
