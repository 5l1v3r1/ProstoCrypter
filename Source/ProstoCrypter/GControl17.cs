using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x0200002B RID: 43
[DefaultEvent("Scroll")]
public class GControl17 : Control
{
	// Token: 0x06000194 RID: 404 RVA: 0x002620D8 File Offset: 0x002602D8
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		if (e.Button == MouseButtons.Left)
		{
			this.int_2 = Convert.ToInt32((float)(this.int_5 - this.int_3) / (float)(this.int_4 - this.int_3) * (float)(base.Width - 11));
			this.rectangle_0 = new Rectangle(this.int_2, 0, 10, 20);
			this.bool_0 = this.rectangle_0.Contains(e.Location);
		}
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0026215C File Offset: 0x0026035C
	protected virtual void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (this.bool_0 && e.X > -1 && e.X < base.Width + 1)
		{
			this.Int32_2 = this.int_3 + Convert.ToInt32((float)(this.int_4 - this.int_3) * ((float)e.X / (float)base.Width));
		}
	}

	// Token: 0x06000196 RID: 406 RVA: 0x002621C4 File Offset: 0x002603C4
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.bool_0 = false;
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000197 RID: 407 RVA: 0x002621E0 File Offset: 0x002603E0
	// (set) Token: 0x06000198 RID: 408 RVA: 0x002621F4 File Offset: 0x002603F4
	public GControl17.GEnum4 GEnum4_0
	{
		get
		{
			return this.genum4_0;
		}
		set
		{
			this.genum4_0 = value;
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000199 RID: 409 RVA: 0x00262208 File Offset: 0x00260408
	// (set) Token: 0x0600019A RID: 410 RVA: 0x0026221C File Offset: 0x0026041C
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

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x0600019B RID: 411 RVA: 0x00262230 File Offset: 0x00260430
	// (set) Token: 0x0600019C RID: 412 RVA: 0x00262244 File Offset: 0x00260444
	[Category("Colors")]
	public Color Color_1
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

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x0600019D RID: 413 RVA: 0x00262258 File Offset: 0x00260458
	// (remove) Token: 0x0600019E RID: 414 RVA: 0x00262290 File Offset: 0x00260490
	public event GControl17.GDelegate3 Event_0
	{
		[CompilerGenerated]
		add
		{
			GControl17.GDelegate3 gdelegate = this.gdelegate3_0;
			GControl17.GDelegate3 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GControl17.GDelegate3 value2 = (GControl17.GDelegate3)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GControl17.GDelegate3>(ref this.gdelegate3_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GControl17.GDelegate3 gdelegate = this.gdelegate3_0;
			GControl17.GDelegate3 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GControl17.GDelegate3 value2 = (GControl17.GDelegate3)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GControl17.GDelegate3>(ref this.gdelegate3_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x0600019F RID: 415 RVA: 0x002622CC File Offset: 0x002604CC
	// (set) Token: 0x060001A0 RID: 416 RVA: 0x002622DC File Offset: 0x002604DC
	public int Int32_0
	{
		get
		{
			return 0;
		}
		set
		{
			this.int_3 = value;
			if (value > this.int_5)
			{
				this.int_5 = value;
			}
			if (value > this.int_4)
			{
				this.int_4 = value;
			}
			base.Invalidate();
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060001A1 RID: 417 RVA: 0x00262318 File Offset: 0x00260518
	// (set) Token: 0x060001A2 RID: 418 RVA: 0x0026232C File Offset: 0x0026052C
	public int Int32_1
	{
		get
		{
			return this.int_4;
		}
		set
		{
			this.int_4 = value;
			if (value < this.int_5)
			{
				this.int_5 = value;
			}
			if (value < this.int_3)
			{
				this.int_3 = value;
			}
			base.Invalidate();
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060001A3 RID: 419 RVA: 0x00262368 File Offset: 0x00260568
	// (set) Token: 0x060001A4 RID: 420 RVA: 0x0026237C File Offset: 0x0026057C
	public int Int32_2
	{
		get
		{
			return this.int_5;
		}
		set
		{
			if (value == this.int_5)
			{
				return;
			}
			if (value > this.int_4)
			{
			}
			this.int_5 = value;
			base.Invalidate();
			if (this.gdelegate3_0 != null)
			{
				this.gdelegate3_0(this);
			}
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060001A5 RID: 421 RVA: 0x002623C0 File Offset: 0x002605C0
	// (set) Token: 0x060001A6 RID: 422 RVA: 0x002623D4 File Offset: 0x002605D4
	public bool Boolean_0
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

	// Token: 0x060001A7 RID: 423 RVA: 0x002623E8 File Offset: 0x002605E8
	protected virtual void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (e.KeyCode != Keys.Subtract)
		{
			if (e.KeyCode == Keys.Add)
			{
				if (this.Int32_2 == this.int_4)
				{
					return;
				}
				this.Int32_2++;
			}
			return;
		}
		if (this.Int32_2 == 0)
		{
			return;
		}
		this.Int32_2--;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0025C2E0 File Offset: 0x0025A4E0
	protected virtual void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		base.Invalidate();
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00262448 File Offset: 0x00260648
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Height = 23;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00262464 File Offset: 0x00260664
	public GControl17()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		base.Height = 18;
		this.BackColor = Color.FromArgb(60, 70, 73);
	}

	// Token: 0x060001AB RID: 427 RVA: 0x002624EC File Offset: 0x002606EC
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_0();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		Rectangle rect = new Rectangle(1, 6, this.int_0 - 2, 8);
		GraphicsPath graphicsPath = new GraphicsPath();
		GraphicsPath graphicsPath2 = new GraphicsPath();
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		this.int_2 = Convert.ToInt32((float)(this.int_5 - this.int_3) / (float)(this.int_4 - this.int_3) * (float)(this.int_0 - 10));
		this.rectangle_0 = new Rectangle(this.int_2, 0, 10, 20);
		this.rectangle_1 = new Rectangle(this.int_2, 4, 11, 14);
		graphicsPath.AddRectangle(rect);
		graphics2.SetClip(graphicsPath);
		graphics2.FillRectangle(new SolidBrush(this.color_0), new Rectangle(0, 7, this.int_0, 8));
		graphics2.FillRectangle(new SolidBrush(this.color_1), new Rectangle(0, 7, this.rectangle_0.X + this.rectangle_0.Width, 8));
		graphics2.ResetClip();
		HatchBrush brush = new HatchBrush(HatchStyle.Plaid, this.Color_1, this.color_1);
		graphics2.FillRectangle(brush, new Rectangle(-10, 7, this.rectangle_0.X + this.rectangle_0.Width, 8));
		GControl17.GEnum4 genum = this.GEnum4_0;
		if (genum == GControl17.GEnum4.Slider)
		{
			graphicsPath2.AddRectangle(this.rectangle_0);
			graphics2.FillPath(new SolidBrush(this.color_2), graphicsPath2);
		}
		else if (genum == GControl17.GEnum4.Knob)
		{
			graphicsPath2.AddEllipse(this.rectangle_1);
			graphics2.FillPath(new SolidBrush(this.color_2), graphicsPath2);
		}
		if (this.Boolean_0)
		{
			graphics2.DrawString(this.Int32_2.ToString(), new Font("Segoe UI", 8f), Brushes.White, new Rectangle(1, 6, this.int_0, this.int_1), new StringFormat
			{
				Alignment = StringAlignment.Far,
				LineAlignment = StringAlignment.Far
			});
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00262760 File Offset: 0x00260960
	private void method_0()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_1 = gclass.color_0;
	}

	// Token: 0x040000CE RID: 206
	private int int_0;

	// Token: 0x040000CF RID: 207
	private int int_1;

	// Token: 0x040000D0 RID: 208
	private int int_2;

	// Token: 0x040000D1 RID: 209
	private bool bool_0;

	// Token: 0x040000D2 RID: 210
	private Rectangle rectangle_0;

	// Token: 0x040000D3 RID: 211
	private Rectangle rectangle_1;

	// Token: 0x040000D4 RID: 212
	private GControl17.GEnum4 genum4_0;

	// Token: 0x040000D5 RID: 213
	[CompilerGenerated]
	private GControl17.GDelegate3 gdelegate3_0;

	// Token: 0x040000D6 RID: 214
	private int int_3;

	// Token: 0x040000D7 RID: 215
	private int int_4 = 10;

	// Token: 0x040000D8 RID: 216
	private int int_5;

	// Token: 0x040000D9 RID: 217
	private bool bool_1;

	// Token: 0x040000DA RID: 218
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x040000DB RID: 219
	private Color color_1 = GClass6.color_0;

	// Token: 0x040000DC RID: 220
	private Color color_2 = Color.FromArgb(25, 27, 29);

	// Token: 0x040000DD RID: 221
	private Color color_3 = Color.FromArgb(23, 148, 92);

	// Token: 0x0200002C RID: 44
	[Flags]
	public enum GEnum4
	{
		// Token: 0x040000DF RID: 223
		Slider = 0,
		// Token: 0x040000E0 RID: 224
		Knob = 1
	}

	// Token: 0x0200002D RID: 45
	// (Invoke) Token: 0x060001AE RID: 430
	public delegate void GDelegate3(object sender);
}
