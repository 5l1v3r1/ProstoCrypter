using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000024 RID: 36
public class GControl12 : Control
{
	// Token: 0x06000136 RID: 310 RVA: 0x002602EC File Offset: 0x0025E4EC
	protected virtual void CreateHandle()
	{
		base.CreateHandle();
		this.Dock = DockStyle.Bottom;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0025C2E0 File Offset: 0x0025A4E0
	protected virtual void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		base.Invalidate();
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06000138 RID: 312 RVA: 0x00260308 File Offset: 0x0025E508
	// (set) Token: 0x06000139 RID: 313 RVA: 0x0026031C File Offset: 0x0025E51C
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

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x0600013A RID: 314 RVA: 0x00260330 File Offset: 0x0025E530
	// (set) Token: 0x0600013B RID: 315 RVA: 0x00260344 File Offset: 0x0025E544
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

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x0600013C RID: 316 RVA: 0x00260358 File Offset: 0x0025E558
	// (set) Token: 0x0600013D RID: 317 RVA: 0x0026036C File Offset: 0x0025E56C
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

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x0600013E RID: 318 RVA: 0x00260380 File Offset: 0x0025E580
	// (set) Token: 0x0600013F RID: 319 RVA: 0x00260394 File Offset: 0x0025E594
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

	// Token: 0x06000140 RID: 320 RVA: 0x002603A8 File Offset: 0x0025E5A8
	public string method_0()
	{
		return string.Concat(new object[]
		{
			DateTime.Now.Date,
			" ",
			DateTime.Now.Hour,
			":",
			DateTime.Now.Minute
		});
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00260410 File Offset: 0x0025E610
	public GControl12()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.Font = new Font("Segoe UI", 8f);
		this.ForeColor = Color.White;
		base.Size = new Size(base.Width, 20);
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00260490 File Offset: 0x0025E690
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_1();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width;
		this.int_1 = base.Height;
		Rectangle rect = new Rectangle(0, 0, this.int_0, this.int_1);
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.Color_0);
		graphics2.FillRectangle(new SolidBrush(this.Color_0), rect);
		graphics2.DrawString(this.Text, this.Font, Brushes.White, new Rectangle(10, 4, this.int_0, this.int_1), GClass6.stringFormat_0);
		graphics2.FillRectangle(new SolidBrush(this.color_2), new Rectangle(4, 4, 4, 14));
		if (this.Boolean_0)
		{
			graphics2.DrawString(this.method_0(), this.Font, new SolidBrush(this.color_1), new Rectangle(-4, 2, this.int_0, this.int_1), new StringFormat
			{
				Alignment = StringAlignment.Far,
				LineAlignment = StringAlignment.Center
			});
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x06000143 RID: 323 RVA: 0x002605EC File Offset: 0x0025E7EC
	private void method_1()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_2 = gclass.color_0;
	}

	// Token: 0x0400009F RID: 159
	private int int_0;

	// Token: 0x040000A0 RID: 160
	private int int_1;

	// Token: 0x040000A1 RID: 161
	private bool bool_0;

	// Token: 0x040000A2 RID: 162
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x040000A3 RID: 163
	private Color color_1 = Color.White;

	// Token: 0x040000A4 RID: 164
	private Color color_2 = GClass6.color_0;
}
