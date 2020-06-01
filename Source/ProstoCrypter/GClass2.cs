using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000018 RID: 24
public class GClass2 : ContextMenuStrip
{
	// Token: 0x060000B1 RID: 177 RVA: 0x0025C2E0 File Offset: 0x0025A4E0
	protected virtual void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		base.Invalidate();
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0025E300 File Offset: 0x0025C500
	public GClass2()
	{
		base.Renderer = new ToolStripProfessionalRenderer(new GClass2.GClass3());
		base.ShowImageMargin = false;
		base.ForeColor = Color.White;
		this.Font = new Font("Segoe UI", 8f);
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x0025E34C File Offset: 0x0025C54C
	protected virtual void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
	}

	// Token: 0x02000019 RID: 25
	public class GClass3 : ProfessionalColorTable
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0025E36C File Offset: 0x0025C56C
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0025E380 File Offset: 0x0025C580
		[Category("Colors")]
		public Color Color_0
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0025E394 File Offset: 0x0025C594
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0025E3A8 File Offset: 0x0025C5A8
		[Category("Colors")]
		public Color Color_1
		{
			get
			{
				return this.color_1;
			}
			set
			{
				this.color_1 = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0025E3BC File Offset: 0x0025C5BC
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0025E3D0 File Offset: 0x0025C5D0
		[Category("Colors")]
		public Color Color_2
		{
			get
			{
				return this.color_2;
			}
			set
			{
				this.color_2 = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0025E36C File Offset: 0x0025C56C
		public virtual Color ButtonSelectedBorder
		{
			get
			{
				return this.color_0;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0025E394 File Offset: 0x0025C594
		public virtual Color CheckBackground
		{
			get
			{
				return this.color_1;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0025E394 File Offset: 0x0025C594
		public virtual Color CheckPressedBackground
		{
			get
			{
				return this.color_1;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0025E394 File Offset: 0x0025C594
		public virtual Color CheckSelectedBackground
		{
			get
			{
				return this.color_1;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0025E394 File Offset: 0x0025C594
		public virtual Color ImageMarginGradientBegin
		{
			get
			{
				return this.color_1;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0025E394 File Offset: 0x0025C594
		public virtual Color ImageMarginGradientEnd
		{
			get
			{
				return this.color_1;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0025E394 File Offset: 0x0025C594
		public virtual Color ImageMarginGradientMiddle
		{
			get
			{
				return this.color_1;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0025E3BC File Offset: 0x0025C5BC
		public virtual Color MenuBorder
		{
			get
			{
				return this.color_2;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0025E3BC File Offset: 0x0025C5BC
		public virtual Color MenuItemBorder
		{
			get
			{
				return this.color_2;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0025E394 File Offset: 0x0025C594
		public virtual Color MenuItemSelected
		{
			get
			{
				return this.color_1;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0025E3BC File Offset: 0x0025C5BC
		public virtual Color SeparatorDark
		{
			get
			{
				return this.color_2;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0025E36C File Offset: 0x0025C56C
		public virtual Color ToolStripDropDownBackground
		{
			get
			{
				return this.color_0;
			}
		}

		// Token: 0x0400006A RID: 106
		private Color color_0 = Color.FromArgb(45, 47, 49);

		// Token: 0x0400006B RID: 107
		private Color color_1 = GClass6.color_0;

		// Token: 0x0400006C RID: 108
		private Color color_2 = Color.FromArgb(53, 58, 60);
	}
}
