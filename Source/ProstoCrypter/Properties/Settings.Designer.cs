using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ProstoCrypter.Properties
{
	// Token: 0x02000037 RID: 55
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00267894 File Offset: 0x00265A94
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x04000135 RID: 309
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
