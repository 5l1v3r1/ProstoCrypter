using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000025 RID: 37
public class GControl13 : Control
{
	// Token: 0x06000144 RID: 324 RVA: 0x0026060C File Offset: 0x0025E80C
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00260630 File Offset: 0x0025E830
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00260654 File Offset: 0x0025E854
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00260678 File Offset: 0x0025E878
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0026069C File Offset: 0x0025E89C
	private bool[] method_0()
	{
		bool[] array = new bool[4];
		foreach (object obj in base.Parent.Controls)
		{
			Control control = (Control)obj;
			if (control is GControl13 && control != this && this.Rectangle_0.IntersectsWith(this.Rectangle_0))
			{
				double num = Math.Atan2((double)(base.Left - control.Left), (double)(base.Top - control.Top)) * 2.0 / 3.1415926535897931;
				if (num / 1.0 == num)
				{
					array[(int)num + 1] = true;
				}
			}
		}
		return array;
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000149 RID: 329 RVA: 0x00260774 File Offset: 0x0025E974
	private Rectangle Rectangle_0
	{
		get
		{
			return new Rectangle(base.Left, base.Top, base.Width, base.Height);
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x0600014A RID: 330 RVA: 0x002607A0 File Offset: 0x0025E9A0
	// (set) Token: 0x0600014B RID: 331 RVA: 0x002607B4 File Offset: 0x0025E9B4
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

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x0600014C RID: 332 RVA: 0x002607C8 File Offset: 0x0025E9C8
	// (set) Token: 0x0600014D RID: 333 RVA: 0x002607DC File Offset: 0x0025E9DC
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

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600014E RID: 334 RVA: 0x002607F0 File Offset: 0x0025E9F0
	// (set) Token: 0x0600014F RID: 335 RVA: 0x00260804 File Offset: 0x0025EA04
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

	// Token: 0x06000150 RID: 336 RVA: 0x00260818 File Offset: 0x0025EA18
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0026082C File Offset: 0x0025EA2C
	protected virtual void OnCreateControl()
	{
		base.OnCreateControl();
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00260840 File Offset: 0x0025EA40
	public GControl13()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		base.Size = new Size(106, 32);
		this.BackColor = Color.Transparent;
		this.Font = new Font("Segoe UI", 12f);
		this.Cursor = Cursors.Hand;
	}

	// Token: 0x06000153 RID: 339 RVA: 0x002608C8 File Offset: 0x0025EAC8
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_1();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width;
		this.int_1 = base.Height;
		GraphicsPath path = new GraphicsPath();
		bool[] array = this.method_0();
		GraphicsPath graphicsPath = GClass6.smethod_1(0f, 0f, (float)this.int_0, (float)this.int_1, 0.3, !array[2] && !array[1], !array[1] && !array[0], !array[3] && !array[0], !array[3] && !array[2]);
		Rectangle rectangle = new Rectangle(0, 0, this.int_0, this.int_1);
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		switch (this.genum5_0)
		{
		case GEnum5.None:
			if (!this.Boolean_0)
			{
				graphics2.FillRectangle(new SolidBrush(this.color_0), rectangle);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			else
			{
				path = graphicsPath;
				graphics2.FillPath(new SolidBrush(this.color_0), path);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			break;
		case GEnum5.Over:
			if (!this.Boolean_0)
			{
				graphics2.FillRectangle(new SolidBrush(this.color_0), rectangle);
				graphics2.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), rectangle);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			else
			{
				path = graphicsPath;
				graphics2.FillPath(new SolidBrush(this.color_0), path);
				graphics2.FillPath(new SolidBrush(Color.FromArgb(20, Color.White)), path);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			break;
		case GEnum5.Down:
			if (!this.Boolean_0)
			{
				graphics2.FillRectangle(new SolidBrush(this.color_0), rectangle);
				graphics2.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Black)), rectangle);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), rectangle, GClass6.stringFormat_1);
			}
			else
			{
				path = graphicsPath;
				graphics2.FillPath(new SolidBrush(this.color_0), path);
				graphics2.FillPath(new SolidBrush(Color.FromArgb(20, Color.Black)), path);
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

	// Token: 0x06000154 RID: 340 RVA: 0x00260C14 File Offset: 0x0025EE14
	private void method_1()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_0 = gclass.color_0;
	}

	// Token: 0x040000A5 RID: 165
	private int int_0;

	// Token: 0x040000A6 RID: 166
	private int int_1;

	// Token: 0x040000A7 RID: 167
	private GEnum5 genum5_0;

	// Token: 0x040000A8 RID: 168
	private bool bool_0;

	// Token: 0x040000A9 RID: 169
	private Color color_0 = GClass6.color_0;

	// Token: 0x040000AA RID: 170
	private Color color_1 = Color.FromArgb(243, 243, 243);
}
