using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x0200001F RID: 31
public class GControl9 : Control
{
	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000FB RID: 251 RVA: 0x0025F350 File Offset: 0x0025D550
	// (set) Token: 0x060000FC RID: 252 RVA: 0x0025F364 File Offset: 0x0025D564
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			if (value <= this.long_2 & value >= this.long_1)
			{
				this.long_0 = value;
			}
			base.Invalidate();
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000FD RID: 253 RVA: 0x0025F39C File Offset: 0x0025D59C
	// (set) Token: 0x060000FE RID: 254 RVA: 0x0025F3B0 File Offset: 0x0025D5B0
	public long Int64_1
	{
		get
		{
			return this.long_2;
		}
		set
		{
			if (value > this.long_1)
			{
				this.long_2 = value;
			}
			if (this.long_0 > this.long_2)
			{
				this.long_0 = this.long_2;
			}
			base.Invalidate();
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000FF RID: 255 RVA: 0x0025F3F0 File Offset: 0x0025D5F0
	// (set) Token: 0x06000100 RID: 256 RVA: 0x0025F404 File Offset: 0x0025D604
	public long Int64_2
	{
		get
		{
			return this.long_1;
		}
		set
		{
			if (value < this.long_2)
			{
				this.long_1 = value;
			}
			if (this.long_0 < this.long_1)
			{
				this.long_0 = this.Int64_2;
			}
			base.Invalidate();
		}
	}

	// Token: 0x06000101 RID: 257 RVA: 0x0025F444 File Offset: 0x0025D644
	protected virtual void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		this.int_2 = e.Location.X;
		this.int_3 = e.Location.Y;
		base.Invalidate();
		if (e.X >= base.Width - 23)
		{
			this.Cursor = Cursors.Hand;
			return;
		}
		this.Cursor = Cursors.IBeam;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x0025F4B0 File Offset: 0x0025D6B0
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		if (this.int_2 > base.Width - 21 && this.int_2 < base.Width - 3)
		{
			if (this.int_3 >= 15)
			{
				if (this.Int64_0 - 1L >= this.long_1)
				{
					this.long_0 -= 1L;
				}
			}
			else if (this.Int64_0 + 1L <= this.long_2)
			{
				this.long_0 += 1L;
			}
		}
		else
		{
			this.bool_0 = !this.bool_0;
			base.Focus();
		}
		base.Invalidate();
	}

	// Token: 0x06000103 RID: 259 RVA: 0x0025F56C File Offset: 0x0025D76C
	protected virtual void OnKeyPress(KeyPressEventArgs e)
	{
		base.OnKeyPress(e);
		try
		{
			if (this.bool_0)
			{
				this.long_0 = Convert.ToInt64(this.long_0.ToString() + e.KeyChar.ToString());
			}
			if (this.long_0 > this.long_2)
			{
				this.long_0 = this.long_2;
			}
			base.Invalidate();
		}
		catch
		{
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0025F5E8 File Offset: 0x0025D7E8
	protected virtual void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (e.KeyCode == Keys.Back)
		{
			this.Int64_0 = 0L;
		}
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0025F618 File Offset: 0x0025D818
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Height = 30;
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000106 RID: 262 RVA: 0x0025F634 File Offset: 0x0025D834
	// (set) Token: 0x06000107 RID: 263 RVA: 0x0025F648 File Offset: 0x0025D848
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

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000108 RID: 264 RVA: 0x0025F65C File Offset: 0x0025D85C
	// (set) Token: 0x06000109 RID: 265 RVA: 0x0025F670 File Offset: 0x0025D870
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

	// Token: 0x0600010A RID: 266 RVA: 0x0025F684 File Offset: 0x0025D884
	public GControl9()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.Font = new Font("Segoe UI", 10f);
		this.BackColor = Color.FromArgb(60, 70, 73);
		this.ForeColor = Color.White;
		this.long_1 = 0L;
		this.long_2 = 9999999L;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0025F718 File Offset: 0x0025D918
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_0();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width;
		this.int_1 = base.Height;
		Rectangle rect = new Rectangle(0, 0, this.int_0, this.int_1);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics.Clear(this.BackColor);
		graphics.FillRectangle(new SolidBrush(this.color_0), rect);
		graphics.FillRectangle(new SolidBrush(this.color_1), new Rectangle(base.Width - 24, 0, 24, this.int_1));
		graphics.DrawString("+", new Font("Segoe UI", 12f), Brushes.White, new Point(base.Width - 12, 8), GClass6.stringFormat_1);
		graphics.DrawString("-", new Font("Segoe UI", 10f, FontStyle.Bold), Brushes.White, new Point(base.Width - 12, 22), GClass6.stringFormat_1);
		graphics.DrawString(this.Int64_0.ToString(), this.Font, Brushes.White, new Rectangle(5, 1, this.int_0, this.int_1), new StringFormat
		{
			LineAlignment = StringAlignment.Center
		});
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0025F8AC File Offset: 0x0025DAAC
	private void method_0()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_1 = gclass.color_0;
	}

	// Token: 0x0400007E RID: 126
	private int int_0;

	// Token: 0x0400007F RID: 127
	private int int_1;

	// Token: 0x04000080 RID: 128
	private GEnum5 genum5_0;

	// Token: 0x04000081 RID: 129
	private int int_2;

	// Token: 0x04000082 RID: 130
	private int int_3;

	// Token: 0x04000083 RID: 131
	private long long_0;

	// Token: 0x04000084 RID: 132
	private long long_1;

	// Token: 0x04000085 RID: 133
	private long long_2;

	// Token: 0x04000086 RID: 134
	private bool bool_0;

	// Token: 0x04000087 RID: 135
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x04000088 RID: 136
	private Color color_1 = GClass6.color_0;
}
