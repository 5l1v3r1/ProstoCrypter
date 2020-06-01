using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000020 RID: 32
public class GControl10 : Control
{
	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600010D RID: 269 RVA: 0x0025F8CC File Offset: 0x0025DACC
	// (set) Token: 0x0600010E RID: 270 RVA: 0x0025F8E0 File Offset: 0x0025DAE0
	[Category("Control")]
	public int Int32_0
	{
		get
		{
			return this.int_3;
		}
		set
		{
			if (value < this.int_2)
			{
				this.int_2 = value;
			}
			this.int_3 = value;
			base.Invalidate();
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600010F RID: 271 RVA: 0x0025F90C File Offset: 0x0025DB0C
	// (set) Token: 0x06000110 RID: 272 RVA: 0x0025F920 File Offset: 0x0025DB20
	[Category("Control")]
	public int Int32_1
	{
		get
		{
			return this.int_2;
		}
		set
		{
			if (value > this.int_3)
			{
				value = this.int_3;
				base.Invalidate();
			}
			this.int_2 = value;
			base.Invalidate();
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000111 RID: 273 RVA: 0x0025F954 File Offset: 0x0025DB54
	// (set) Token: 0x06000112 RID: 274 RVA: 0x0025F968 File Offset: 0x0025DB68
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000113 RID: 275 RVA: 0x0025F97C File Offset: 0x0025DB7C
	// (set) Token: 0x06000114 RID: 276 RVA: 0x0025F990 File Offset: 0x0025DB90
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000115 RID: 277 RVA: 0x0025F9A4 File Offset: 0x0025DBA4
	// (set) Token: 0x06000116 RID: 278 RVA: 0x0025F9B8 File Offset: 0x0025DBB8
	public bool Boolean_2
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000117 RID: 279 RVA: 0x0025F9CC File Offset: 0x0025DBCC
	// (set) Token: 0x06000118 RID: 280 RVA: 0x0025F9E0 File Offset: 0x0025DBE0
	[Category("Colors")]
	public Color Color_0
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

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000119 RID: 281 RVA: 0x0025F9F4 File Offset: 0x0025DBF4
	// (set) Token: 0x0600011A RID: 282 RVA: 0x0025FA08 File Offset: 0x0025DC08
	[Category("Colors")]
	public Color Color_1
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

	// Token: 0x0600011B RID: 283 RVA: 0x0025C2FC File Offset: 0x0025A4FC
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Height = 42;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0025FA1C File Offset: 0x0025DC1C
	protected virtual void CreateHandle()
	{
		base.CreateHandle();
		base.Height = 42;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0025FA38 File Offset: 0x0025DC38
	public void method_0(int int_4)
	{
		this.Int32_1 += int_4;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0025FA54 File Offset: 0x0025DC54
	public GControl10()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.FromArgb(60, 70, 73);
		base.Height = 42;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x0025FADC File Offset: 0x0025DCDC
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_1();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		Rectangle rect = new Rectangle(0, 24, this.int_0, this.int_1);
		GraphicsPath graphicsPath = new GraphicsPath();
		GraphicsPath path = new GraphicsPath();
		GraphicsPath path2 = new GraphicsPath();
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		int num = (int)((float)this.int_2 / (float)this.int_3 * (float)base.Width);
		int int32_ = this.Int32_1;
		if (int32_ == 0)
		{
			graphics2.FillRectangle(new SolidBrush(this.color_0), rect);
			graphics2.FillRectangle(new SolidBrush(this.color_1), new Rectangle(0, 24, num - 1, this.int_1 - 1));
		}
		else if (int32_ == 100)
		{
			graphics2.FillRectangle(new SolidBrush(this.color_0), rect);
			graphics2.FillRectangle(new SolidBrush(this.color_1), new Rectangle(0, 24, num - 1, this.int_1 - 1));
		}
		else
		{
			graphics2.FillRectangle(new SolidBrush(this.color_0), rect);
			graphicsPath.AddRectangle(new Rectangle(0, 24, num - 1, this.int_1 - 1));
			graphics2.FillPath(new SolidBrush(this.color_1), graphicsPath);
			if (this.bool_0)
			{
				HatchBrush brush = new HatchBrush(HatchStyle.Plaid, this.color_2, this.color_1);
				graphics2.FillRectangle(brush, new Rectangle(0, 24, num - 1, this.int_1 - 1));
			}
			if (this.bool_1)
			{
				path = GClass6.smethod_0(new Rectangle(num - 18, 0, 34, 16), 4);
				graphics2.FillPath(new SolidBrush(this.color_0), path);
				path2 = GClass6.smethod_2(num - 9, 16, true);
				graphics2.FillPath(new SolidBrush(this.color_0), path2);
				string s = this.bool_2 ? (this.Int32_1.ToString() + "%") : this.Int32_1.ToString();
				int x = this.bool_2 ? (num - 15) : (num - 11);
				graphics2.DrawString(s, new Font("Segoe UI", 10f), new SolidBrush(this.color_1), new Rectangle(x, -2, this.int_0, this.int_1), GClass6.stringFormat_0);
			}
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0025FDAC File Offset: 0x0025DFAC
	private void method_1()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_1 = gclass.color_0;
	}

	// Token: 0x04000089 RID: 137
	private int int_0;

	// Token: 0x0400008A RID: 138
	private int int_1;

	// Token: 0x0400008B RID: 139
	private int int_2;

	// Token: 0x0400008C RID: 140
	private int int_3 = 100;

	// Token: 0x0400008D RID: 141
	private bool bool_0 = true;

	// Token: 0x0400008E RID: 142
	private bool bool_1 = true;

	// Token: 0x0400008F RID: 143
	private bool bool_2;

	// Token: 0x04000090 RID: 144
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x04000091 RID: 145
	private Color color_1 = GClass6.color_0;

	// Token: 0x04000092 RID: 146
	private Color color_2 = Color.FromArgb(23, 148, 92);
}
