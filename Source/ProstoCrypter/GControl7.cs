using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x0200001D RID: 29
public class GControl7 : Control
{
	// Token: 0x060000E1 RID: 225 RVA: 0x0025ED1C File Offset: 0x0025CF1C
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0025ED40 File Offset: 0x0025CF40
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0025ED64 File Offset: 0x0025CF64
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0025ED88 File Offset: 0x0025CF88
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x0025EDAC File Offset: 0x0025CFAC
	protected virtual void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		this.int_0 = e.X;
		base.Invalidate();
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x0025EDD4 File Offset: 0x0025CFD4
	protected virtual void OnClick(EventArgs e)
	{
		base.OnClick(e);
		FormWindowState windowState = base.FindForm().WindowState;
		if (windowState == FormWindowState.Normal)
		{
			base.FindForm().WindowState = FormWindowState.Maximized;
		}
		else if (windowState == FormWindowState.Maximized)
		{
			base.FindForm().WindowState = FormWindowState.Normal;
			return;
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000E7 RID: 231 RVA: 0x0025EE18 File Offset: 0x0025D018
	// (set) Token: 0x060000E8 RID: 232 RVA: 0x0025EE2C File Offset: 0x0025D02C
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

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000E9 RID: 233 RVA: 0x0025EE40 File Offset: 0x0025D040
	// (set) Token: 0x060000EA RID: 234 RVA: 0x0025EE54 File Offset: 0x0025D054
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

	// Token: 0x060000EB RID: 235 RVA: 0x0025D6D8 File Offset: 0x0025B8D8
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Size = new Size(18, 18);
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0025EE68 File Offset: 0x0025D068
	public GControl7()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.White;
		base.Size = new Size(18, 18);
		this.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.Font = new Font("Marlett", 12f);
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0025EEF0 File Offset: 0x0025D0F0
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
		if (base.FindForm().WindowState == FormWindowState.Maximized)
		{
			graphics2.DrawString("1", this.Font, new SolidBrush(this.Color_1), new Rectangle(1, 1, base.Width, base.Height), GClass6.stringFormat_1);
		}
		else if (base.FindForm().WindowState == FormWindowState.Normal)
		{
			graphics2.DrawString("2", this.Font, new SolidBrush(this.Color_1), new Rectangle(1, 1, base.Width, base.Height), GClass6.stringFormat_1);
		}
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

	// Token: 0x04000076 RID: 118
	private GEnum5 genum5_0;

	// Token: 0x04000077 RID: 119
	private int int_0;

	// Token: 0x04000078 RID: 120
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x04000079 RID: 121
	private Color color_1 = Color.FromArgb(243, 243, 243);
}
