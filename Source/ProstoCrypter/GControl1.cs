using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000010 RID: 16
public class GControl1 : Control
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000059 RID: 89 RVA: 0x0025CB38 File Offset: 0x0025AD38
	// (set) Token: 0x0600005A RID: 90 RVA: 0x0025CB4C File Offset: 0x0025AD4C
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

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600005B RID: 91 RVA: 0x0025CB60 File Offset: 0x0025AD60
	// (set) Token: 0x0600005C RID: 92 RVA: 0x0025CB74 File Offset: 0x0025AD74
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

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600005D RID: 93 RVA: 0x0025CB88 File Offset: 0x0025AD88
	// (set) Token: 0x0600005E RID: 94 RVA: 0x0025CB9C File Offset: 0x0025AD9C
	[Category("Options")]
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

	// Token: 0x0600005F RID: 95 RVA: 0x0025CBB0 File Offset: 0x0025ADB0
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0025CBD4 File Offset: 0x0025ADD4
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0025CBF8 File Offset: 0x0025ADF8
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000062 RID: 98 RVA: 0x0025CC1C File Offset: 0x0025AE1C
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0025CC40 File Offset: 0x0025AE40
	public GControl1()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		base.Size = new Size(106, 32);
		this.BackColor = Color.Transparent;
		this.Font = new Font("Segoe UI", 12f);
		this.Cursor = Cursors.Hand;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0025CCC8 File Offset: 0x0025AEC8
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_0();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		GraphicsPath path = new GraphicsPath();
		Rectangle rectangle = new Rectangle(0, 0, this.int_0, this.int_1);
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		switch (this.genum5_0)
		{
		case GEnum5.None:
			if (this.Boolean_0)
			{
				path = GClass6.smethod_0(rectangle, 6);
				graphics2.FillPath(new SolidBrush(this.color_0), path);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			else
			{
				graphics2.FillRectangle(new SolidBrush(this.color_0), rectangle);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			break;
		case GEnum5.Over:
			if (this.Boolean_0)
			{
				path = GClass6.smethod_0(rectangle, 6);
				graphics2.FillPath(new SolidBrush(this.color_0), path);
				graphics2.FillPath(new SolidBrush(Color.FromArgb(20, Color.White)), path);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			else
			{
				graphics2.FillRectangle(new SolidBrush(this.color_0), rectangle);
				graphics2.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), rectangle);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			break;
		case GEnum5.Down:
			if (this.Boolean_0)
			{
				path = GClass6.smethod_0(rectangle, 6);
				graphics2.FillPath(new SolidBrush(this.color_0), path);
				graphics2.FillPath(new SolidBrush(Color.FromArgb(20, Color.Black)), path);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			else
			{
				graphics2.FillRectangle(new SolidBrush(this.color_0), rectangle);
				graphics2.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Black)), rectangle);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			break;
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x06000065 RID: 101 RVA: 0x0025CFB4 File Offset: 0x0025B1B4
	private void method_0()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_0 = gclass.color_0;
	}

	// Token: 0x0400003F RID: 63
	private int int_0;

	// Token: 0x04000040 RID: 64
	private int int_1;

	// Token: 0x04000041 RID: 65
	private bool bool_0;

	// Token: 0x04000042 RID: 66
	private GEnum5 genum5_0;

	// Token: 0x04000043 RID: 67
	private Color color_0 = GClass6.color_0;

	// Token: 0x04000044 RID: 68
	private Color color_1 = Color.FromArgb(243, 243, 243);
}
