using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x0200001A RID: 26
public class GControl5 : ContainerControl
{
	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000C7 RID: 199 RVA: 0x0025E424 File Offset: 0x0025C624
	// (set) Token: 0x060000C8 RID: 200 RVA: 0x0025E438 File Offset: 0x0025C638
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

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000C9 RID: 201 RVA: 0x0025E44C File Offset: 0x0025C64C
	// (set) Token: 0x060000CA RID: 202 RVA: 0x0025E460 File Offset: 0x0025C660
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

	// Token: 0x060000CB RID: 203 RVA: 0x0025E474 File Offset: 0x0025C674
	public GControl5()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.Transparent;
		base.Size = new Size(240, 180);
		this.Font = new Font("Segoe ui", 10f);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x0025E4F4 File Offset: 0x0025C6F4
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_0();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		GraphicsPath path = new GraphicsPath();
		GraphicsPath path2 = new GraphicsPath();
		GraphicsPath path3 = new GraphicsPath();
		Rectangle rectangle_ = new Rectangle(8, 8, this.int_0 - 16, this.int_1 - 16);
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		path = GClass6.smethod_0(rectangle_, 8);
		graphics2.FillPath(new SolidBrush(this.color_0), path);
		path2 = GClass6.smethod_2(28, 2, false);
		graphics2.FillPath(new SolidBrush(this.color_0), path2);
		path3 = GClass6.smethod_2(28, 8, true);
		graphics2.FillPath(new SolidBrush(Color.FromArgb(60, 70, 73)), path3);
		if (this.Boolean_0)
		{
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), new Rectangle(16, 16, this.int_0, this.int_1), GClass6.stringFormat_0);
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0025E65C File Offset: 0x0025C85C
	private void method_0()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_1 = gclass.color_0;
	}

	// Token: 0x0400006D RID: 109
	private int int_0;

	// Token: 0x0400006E RID: 110
	private int int_1;

	// Token: 0x0400006F RID: 111
	private bool bool_0 = true;

	// Token: 0x04000070 RID: 112
	private Color color_0 = Color.FromArgb(60, 70, 73);

	// Token: 0x04000071 RID: 113
	private Color color_1 = GClass6.color_0;
}
