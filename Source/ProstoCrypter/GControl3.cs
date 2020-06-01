using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000014 RID: 20
public class GControl3 : Control
{
	// Token: 0x0600007E RID: 126 RVA: 0x0025D604 File Offset: 0x0025B804
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0025D628 File Offset: 0x0025B828
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0025D64C File Offset: 0x0025B84C
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0025D670 File Offset: 0x0025B870
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0025D694 File Offset: 0x0025B894
	protected virtual void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		this.int_0 = e.X;
		base.Invalidate();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0025D6BC File Offset: 0x0025B8BC
	protected virtual void OnClick(EventArgs e)
	{
		base.OnClick(e);
		Environment.Exit(0);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0025D6D8 File Offset: 0x0025B8D8
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Size = new Size(18, 18);
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000085 RID: 133 RVA: 0x0025D6FC File Offset: 0x0025B8FC
	// (set) Token: 0x06000086 RID: 134 RVA: 0x0025D710 File Offset: 0x0025B910
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

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000087 RID: 135 RVA: 0x0025D724 File Offset: 0x0025B924
	// (set) Token: 0x06000088 RID: 136 RVA: 0x0025D738 File Offset: 0x0025B938
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

	// Token: 0x06000089 RID: 137 RVA: 0x0025D74C File Offset: 0x0025B94C
	public GControl3()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.White;
		base.Size = new Size(18, 18);
		this.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.Font = new Font("Marlett", 10f);
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0025D7D8 File Offset: 0x0025B9D8
	protected virtual void OnPaint(PaintEventArgs e)
	{
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		graphics2.FillRectangle(new SolidBrush(this.color_0), rect);
		graphics2.DrawString("r", this.Font, new SolidBrush(this.Color_1), new Rectangle(0, 0, base.Width, base.Height), GClass6.stringFormat_1);
		GEnum5 genum = this.genum5_0;
		if (genum != GEnum5.Over)
		{
			if (genum == GEnum5.Down)
			{
				graphics2.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
			}
		}
		else
		{
			graphics2.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.White)), rect);
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x04000051 RID: 81
	private GEnum5 genum5_0;

	// Token: 0x04000052 RID: 82
	private int int_0;

	// Token: 0x04000053 RID: 83
	private Color color_0 = Color.FromArgb(168, 35, 35);

	// Token: 0x04000054 RID: 84
	private Color color_1 = Color.FromArgb(243, 243, 243);
}
