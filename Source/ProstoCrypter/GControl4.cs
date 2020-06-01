using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000015 RID: 21
public class GControl4 : Control
{
	// Token: 0x0600008B RID: 139 RVA: 0x0025D8F4 File Offset: 0x0025BAF4
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Width = 180;
		base.Height = 80;
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600008C RID: 140 RVA: 0x0025D91C File Offset: 0x0025BB1C
	// (set) Token: 0x0600008D RID: 141 RVA: 0x0025D930 File Offset: 0x0025BB30
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

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600008E RID: 142 RVA: 0x0025D944 File Offset: 0x0025BB44
	// (set) Token: 0x0600008F RID: 143 RVA: 0x0025D958 File Offset: 0x0025BB58
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

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000090 RID: 144 RVA: 0x0025D96C File Offset: 0x0025BB6C
	// (set) Token: 0x06000091 RID: 145 RVA: 0x0025D980 File Offset: 0x0025BB80
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

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000092 RID: 146 RVA: 0x0025D994 File Offset: 0x0025BB94
	// (set) Token: 0x06000093 RID: 147 RVA: 0x0025D9A8 File Offset: 0x0025BBA8
	[Category("Colors")]
	public Color Color_3
	{
		get
		{
			return this.color_3;
		}
		set
		{
			this.color_3 = value;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000094 RID: 148 RVA: 0x0025D9BC File Offset: 0x0025BBBC
	// (set) Token: 0x06000095 RID: 149 RVA: 0x0025D9D0 File Offset: 0x0025BBD0
	[Category("Colors")]
	public Color Color_4
	{
		get
		{
			return this.color_4;
		}
		set
		{
			this.color_4 = value;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000096 RID: 150 RVA: 0x0025D9E4 File Offset: 0x0025BBE4
	// (set) Token: 0x06000097 RID: 151 RVA: 0x0025D9F8 File Offset: 0x0025BBF8
	[Category("Colors")]
	public Color Color_5
	{
		get
		{
			return this.color_5;
		}
		set
		{
			this.color_5 = value;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000098 RID: 152 RVA: 0x0025DA0C File Offset: 0x0025BC0C
	// (set) Token: 0x06000099 RID: 153 RVA: 0x0025DA20 File Offset: 0x0025BC20
	[Category("Colors")]
	public Color Color_6
	{
		get
		{
			return this.color_6;
		}
		set
		{
			this.color_6 = value;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600009A RID: 154 RVA: 0x0025DA34 File Offset: 0x0025BC34
	// (set) Token: 0x0600009B RID: 155 RVA: 0x0025DA48 File Offset: 0x0025BC48
	[Category("Colors")]
	public Color Color_7
	{
		get
		{
			return this.color_7;
		}
		set
		{
			this.color_7 = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600009C RID: 156 RVA: 0x0025DA5C File Offset: 0x0025BC5C
	// (set) Token: 0x0600009D RID: 157 RVA: 0x0025DA70 File Offset: 0x0025BC70
	[Category("Colors")]
	public Color Color_8
	{
		get
		{
			return this.color_8;
		}
		set
		{
			this.color_8 = value;
		}
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0025DA84 File Offset: 0x0025BC84
	public GControl4()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.FromArgb(60, 70, 73);
		base.Size = new Size(160, 80);
		this.Font = new Font("Segoe UI", 12f);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0025DBA4 File Offset: 0x0025BDA4
	protected virtual void OnPaint(PaintEventArgs e)
	{
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics.Clear(this.BackColor);
		graphics.FillRectangle(new SolidBrush(this.color_0), new Rectangle(0, 0, 20, 40));
		graphics.FillRectangle(new SolidBrush(this.color_1), new Rectangle(20, 0, 20, 40));
		graphics.FillRectangle(new SolidBrush(this.color_2), new Rectangle(40, 0, 20, 40));
		graphics.FillRectangle(new SolidBrush(this.color_3), new Rectangle(60, 0, 20, 40));
		graphics.FillRectangle(new SolidBrush(this.color_4), new Rectangle(80, 0, 20, 40));
		graphics.FillRectangle(new SolidBrush(this.color_5), new Rectangle(100, 0, 20, 40));
		graphics.FillRectangle(new SolidBrush(this.color_6), new Rectangle(120, 0, 20, 40));
		graphics.FillRectangle(new SolidBrush(this.color_7), new Rectangle(140, 0, 20, 40));
		graphics.FillRectangle(new SolidBrush(this.color_8), new Rectangle(160, 0, 20, 40));
		graphics.DrawString("Color Palette", this.Font, new SolidBrush(this.color_8), new Rectangle(0, 22, this.int_0, this.int_1), GClass6.stringFormat_1);
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x04000055 RID: 85
	private int int_0;

	// Token: 0x04000056 RID: 86
	private int int_1;

	// Token: 0x04000057 RID: 87
	private Color color_0 = Color.FromArgb(220, 85, 96);

	// Token: 0x04000058 RID: 88
	private Color color_1 = Color.FromArgb(10, 154, 157);

	// Token: 0x04000059 RID: 89
	private Color color_2 = Color.FromArgb(0, 128, 255);

	// Token: 0x0400005A RID: 90
	private Color color_3 = Color.FromArgb(35, 168, 109);

	// Token: 0x0400005B RID: 91
	private Color color_4 = Color.FromArgb(253, 181, 63);

	// Token: 0x0400005C RID: 92
	private Color color_5 = Color.FromArgb(155, 88, 181);

	// Token: 0x0400005D RID: 93
	private Color color_6 = Color.FromArgb(45, 47, 49);

	// Token: 0x0400005E RID: 94
	private Color color_7 = Color.FromArgb(63, 70, 73);

	// Token: 0x0400005F RID: 95
	private Color color_8 = Color.FromArgb(243, 243, 243);
}
