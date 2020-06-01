using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x0200001E RID: 30
public class GControl8 : Control
{
	// Token: 0x060000EE RID: 238 RVA: 0x0025F060 File Offset: 0x0025D260
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0025F084 File Offset: 0x0025D284
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0025F0A8 File Offset: 0x0025D2A8
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0025F0CC File Offset: 0x0025D2CC
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x0025F0F0 File Offset: 0x0025D2F0
	protected virtual void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		this.int_0 = e.X;
		base.Invalidate();
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0025F118 File Offset: 0x0025D318
	protected virtual void OnClick(EventArgs e)
	{
		base.OnClick(e);
		FormWindowState windowState = base.FindForm().WindowState;
		if (windowState == FormWindowState.Normal)
		{
			base.FindForm().WindowState = FormWindowState.Minimized;
			return;
		}
		if (windowState == FormWindowState.Maximized)
		{
			base.FindForm().WindowState = FormWindowState.Minimized;
			return;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x0025F15C File Offset: 0x0025D35C
	// (set) Token: 0x060000F5 RID: 245 RVA: 0x0025F170 File Offset: 0x0025D370
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

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x0025F184 File Offset: 0x0025D384
	// (set) Token: 0x060000F7 RID: 247 RVA: 0x0025F198 File Offset: 0x0025D398
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

	// Token: 0x060000F8 RID: 248 RVA: 0x0025D6D8 File Offset: 0x0025B8D8
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Size = new Size(18, 18);
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x0025F1AC File Offset: 0x0025D3AC
	public GControl8()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.White;
		base.Size = new Size(18, 18);
		this.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.Font = new Font("Marlett", 12f);
	}

	// Token: 0x060000FA RID: 250 RVA: 0x0025F234 File Offset: 0x0025D434
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
		graphics2.DrawString("0", this.Font, new SolidBrush(this.Color_1), new Rectangle(2, 1, base.Width, base.Height), GClass6.stringFormat_1);
		GEnum5 genum = this.genum5_0;
		if (genum == GEnum5.Over)
		{
			graphics2.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.White)), rect);
		}
		else if (genum == GEnum5.Down)
		{
			graphics2.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x0400007A RID: 122
	private GEnum5 genum5_0;

	// Token: 0x0400007B RID: 123
	private int int_0;

	// Token: 0x0400007C RID: 124
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x0400007D RID: 125
	private Color color_1 = Color.FromArgb(243, 243, 243);
}
