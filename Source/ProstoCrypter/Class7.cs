using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000038 RID: 56
[CompilerGenerated]
internal static class Class7
{
	// Token: 0x060001F7 RID: 503 RVA: 0x002678E0 File Offset: 0x00265AE0
	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return "";
		}
		return cultureInfo_0.Name;
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x002678FC File Offset: 0x00265AFC
	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
		{
			AssemblyName name = assembly.GetName();
			if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(Class7.smethod_0(name.CultureInfo), Class7.smethod_0(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
			{
				return assembly;
			}
		}
		return null;
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00267964 File Offset: 0x00265B64
	private static void smethod_2(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00267998 File Offset: 0x00265B98
	private static Stream smethod_3(string string_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (string_0.EndsWith(".compressed"))
		{
			Stream result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(string_0))
			{
				using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
				{
					MemoryStream memoryStream = new MemoryStream();
					Class7.smethod_2(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					result = memoryStream;
				}
			}
			return result;
		}
		return executingAssembly.GetManifestResourceStream(string_0);
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00267A24 File Offset: 0x00265C24
	private static Stream smethod_4(Dictionary<string, string> dictionary_3, string string_0)
	{
		string string_;
		if (dictionary_3.TryGetValue(string_0, out string_))
		{
			return Class7.smethod_3(string_);
		}
		return null;
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00267A44 File Offset: 0x00265C44
	private static byte[] smethod_5(Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, array.Length);
		return array;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00267A6C File Offset: 0x00265C6C
	private static Assembly smethod_6(Dictionary<string, string> dictionary_3, Dictionary<string, string> dictionary_4, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		byte[] rawAssembly;
		using (Stream stream = Class7.smethod_4(dictionary_3, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = Class7.smethod_5(stream);
		}
		using (Stream stream2 = Class7.smethod_4(dictionary_4, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = Class7.smethod_5(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00267B2C File Offset: 0x00265D2C
	public static Assembly smethod_7(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		object obj = Class7.object_0;
		lock (obj)
		{
			if (Class7.dictionary_0.ContainsKey(resolveEventArgs_0.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
		Assembly assembly = Class7.smethod_1(assemblyName);
		if (assembly != null)
		{
			return assembly;
		}
		assembly = Class7.smethod_6(Class7.dictionary_1, Class7.dictionary_2, assemblyName);
		if (assembly == null)
		{
			obj = Class7.object_0;
			lock (obj)
			{
				Class7.dictionary_0[resolveEventArgs_0.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00267C0C File Offset: 0x00265E0C
	// Note: this type is marked as 'beforefieldinit'.
	static Class7()
	{
		Class7.dictionary_1.Add("costura", "costura.costura.dll.compressed");
		Class7.dictionary_1.Add("system.io.compression", "costura.system.io.compression.dll.compressed");
		Class7.dictionary_1.Add("system.io.compression.filesystem", "costura.system.io.compression.filesystem.dll.compressed");
		Class7.dictionary_1.Add("system.shim", "costura.system.shim.dll.compressed");
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00267C94 File Offset: 0x00265E94
	public static void smethod_8()
	{
		if (Interlocked.Exchange(ref Class7.int_0, 1) == 1)
		{
			return;
		}
		AppDomain.CurrentDomain.AssemblyResolve += Class7.smethod_7;
	}

	// Token: 0x04000136 RID: 310
	private static object object_0 = new object();

	// Token: 0x04000137 RID: 311
	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	// Token: 0x04000138 RID: 312
	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	// Token: 0x04000139 RID: 313
	private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	// Token: 0x0400013A RID: 314
	private static int int_0;
}
