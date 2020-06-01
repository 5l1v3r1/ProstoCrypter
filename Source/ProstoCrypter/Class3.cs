using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;
using Microsoft.VisualBasic;

// Token: 0x02000032 RID: 50
internal class Class3
{
	// Token: 0x060001CB RID: 459 RVA: 0x002632D8 File Offset: 0x002614D8
	public static bool smethod_0(string string_0, string string_1, string[] string_2, string string_3, string string_4, string[] string_5, string[] string_6, string string_7, int int_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		string text;
		string text2;
		if (int_0 <= 30)
		{
			if (int_0 == 20)
			{
				string path = Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), "Microsoft.NET\\Framework\\v2.0.50727\\");
				text = Path.Combine(path, "mscorlib.dll");
				text2 = Path.Combine(path, "System.dll");
				goto IL_F1;
			}
			if (int_0 == 30)
			{
				string path = Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), "Microsoft.NET\\Framework\\v3.0\\");
				text = Path.Combine(path, "mscorlib.dll");
				text2 = Path.Combine(path, "System.dll");
				goto IL_F1;
			}
		}
		else
		{
			if (int_0 == 35)
			{
				string path = Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), "Microsoft.NET\\Framework\\v3.5\\");
				text = Path.Combine(path, "mscorlib.dll");
				text2 = Path.Combine(path, "System.dll");
				goto IL_F1;
			}
			if (int_0 == 40)
			{
				string path = Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), "Microsoft.NET\\Framework\\v4.0.30319\\");
				text = Path.Combine(path, "mscorlib.dll");
				text2 = Path.Combine(path, "System.dll");
				goto IL_F1;
			}
		}
		throw new Exception();
		IL_F1:
		CompilerParameters compilerParameters = new CompilerParameters();
		StringBuilder stringBuilder = new StringBuilder();
		compilerParameters.OutputAssembly = string_0;
		compilerParameters.ReferencedAssemblies.AddRange(new string[]
		{
			text,
			text2
		});
		if (string_5 != null && string_5.Length != 0)
		{
			foreach (string path2 in string_5)
			{
				string path;
				compilerParameters.ReferencedAssemblies.Add(Path.Combine(path, path2));
			}
		}
		compilerParameters.GenerateExecutable = true;
		compilerParameters.IncludeDebugInformation = false;
		string text3 = Path.Combine(Environment.CurrentDirectory, "temp");
		Directory.CreateDirectory(text3);
		compilerParameters.TempFiles = new TempFileCollection(text3, false);
		if (string_6 != null && string_6.Length != 0)
		{
			compilerParameters.EmbeddedResources.AddRange(string_6);
		}
		if (!string.IsNullOrEmpty(string_4))
		{
			stringBuilder.AppendFormat(" /define:{0} ", string_4);
		}
		stringBuilder.AppendFormat(" /target:{0} ", string_7);
		stringBuilder.Append(" /filealign:512 /platform:x86 /optimize+ /nostdlib /unsafe");
		if (!string.IsNullOrEmpty(string_3) && File.Exists(string_3))
		{
			stringBuilder.AppendFormat(" /win32icon:{0}", Convert.ToChar(34).ToString() + string_3 + Convert.ToChar(34).ToString());
		}
		compilerParameters.CompilerOptions = stringBuilder.ToString();
		CompilerResults compilerResults = null;
		CodeDomProvider codeDomProvider;
		if (string_1 == "cs")
		{
			codeDomProvider = new CSharpCodeProvider();
		}
		else
		{
			codeDomProvider = new VBCodeProvider();
		}
		compilerResults = codeDomProvider.CompileAssemblyFromSource(compilerParameters, string_2);
		if (string_6 != null && string_6.Length != 0)
		{
			foreach (string path3 in string_6)
			{
				try
				{
					File.Delete(path3);
				}
				catch (Exception)
				{
				}
			}
		}
		if (Directory.Exists("temp"))
		{
			Directory.Delete("temp", true);
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		if (compilerResults.Errors.HasErrors)
		{
			foreach (object obj in compilerResults.Errors)
			{
				CompilerError compilerError = (CompilerError)obj;
				if (!compilerError.IsWarning)
				{
					stringBuilder2.AppendLine(compilerError.ToString());
				}
			}
			return false;
		}
		return File.Exists(string_0);
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00263614 File Offset: 0x00261814
	public static bool smethod_1(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5 = null)
	{
		CompilerParameters compilerParameters = new CompilerParameters
		{
			GenerateExecutable = true,
			OutputAssembly = string_1
		};
		StringBuilder stringBuilder = new StringBuilder();
		if (!string.IsNullOrEmpty(string_4))
		{
			stringBuilder.AppendFormat(" /define:{0} ", string_4);
		}
		string text = "/optimize+ /platform:x86 /target:winexe /unsafe";
		if (string_5 != null)
		{
			text = text + " /win32icon:\"" + string_5 + "\"";
		}
		text += stringBuilder.ToString();
		compilerParameters.CompilerOptions = text;
		compilerParameters.ReferencedAssemblies.Add("System.dll");
		compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
		compilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
		compilerParameters.ReferencedAssemblies.Add("System.Management.dll");
		compilerParameters.EmbeddedResources.Add(string_3);
		CompilerResults compilerResults = new CSharpCodeProvider(new Dictionary<string, string>
		{
			{
				"CompilerVersion",
				string_2
			}
		}).CompileAssemblyFromSource(compilerParameters, new string[]
		{
			string_0
		});
		if (compilerResults.Errors.Count > 0)
		{
			MessageBox.Show(string.Format("Имеются {0} ошибок", compilerResults.Errors.Count), "Ошибка компиляции", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			foreach (object obj in compilerResults.Errors)
			{
				CompilerError compilerError = (CompilerError)obj;
				File.WriteAllText("Error_Compiler.txt", string.Format("Ошибка: {0} \r\nСтрока: {1}\r\n", compilerError.ToString(), compilerError.Line));
			}
			return false;
		}
		return true;
	}

	// Token: 0x060001CD RID: 461 RVA: 0x002637AC File Offset: 0x002619AC
	public static bool smethod_2(string string_0, string string_1, string string_2, string string_3, string string_4 = null)
	{
		CompilerParameters compilerParameters = new CompilerParameters
		{
			GenerateExecutable = false,
			OutputAssembly = string_1
		};
		string text = "/optimize+ /platform:x86 /target:library /nostdlib /unsafe /filealign:512";
		if (string_4 != null)
		{
			text = text + " /win32icon:\"" + string_4 + "\"";
		}
		compilerParameters.CompilerOptions = text;
		compilerParameters.ReferencedAssemblies.Add("System.dll");
		compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
		compilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
		if (string_3 != null)
		{
			compilerParameters.EmbeddedResources.Add(string_3);
		}
		CompilerResults compilerResults = new CSharpCodeProvider(new Dictionary<string, string>
		{
			{
				"CompilerVersion",
				string_2
			}
		}).CompileAssemblyFromSource(compilerParameters, new string[]
		{
			string_0
		});
		if (compilerResults.Errors.Count > 0)
		{
			MessageBox.Show(string.Format("Имеются {0} ошибок", compilerResults.Errors.Count), "Ошибка компиляции", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			foreach (object obj in compilerResults.Errors)
			{
				CompilerError compilerError = (CompilerError)obj;
				File.WriteAllText("Error_Compiler.txt", string.Format("Ошибка: {0} \r\nСтрока: {1}\r\n", compilerError.ToString(), compilerError.Line));
			}
			return false;
		}
		return true;
	}
}
