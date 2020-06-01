using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000011 RID: 17
[DefaultEvent("CheckedChanged")]
public class GControl2 : Control
{
	// Token: 0x06000066 RID: 102 RVA: 0x0025C2E0 File Offset: 0x0025A4E0
	protected virtual void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		base.Invalidate();
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000067 RID: 103 RVA: 0x0025CFD4 File Offset: 0x0025B1D4
	// (set) Token: 0x06000068 RID: 104 RVA: 0x0025CFE8 File Offset: 0x0025B1E8
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.Invalidate();
		}
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000069 RID: 105 RVA: 0x0025D004 File Offset: 0x0025B204
	// (remove) Token: 0x0600006A RID: 106 RVA: 0x0025D03C File Offset: 0x0025B23C
	public event GControl2.GDelegate0 Event_0
	{
		[CompilerGenerated]
		add
		{
			GControl2.GDelegate0 gdelegate = this.gdelegate0_0;
			GControl2.GDelegate0 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GControl2.GDelegate0 value2 = (GControl2.GDelegate0)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GControl2.GDelegate0>(ref this.gdelegate0_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GControl2.GDelegate0 gdelegate = this.gdelegate0_0;
			GControl2.GDelegate0 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GControl2.GDelegate0 value2 = (GControl2.GDelegate0)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GControl2.GDelegate0>(ref this.gdelegate0_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x0025D074 File Offset: 0x0025B274
	protected virtual void OnClick(EventArgs e)
	{
		this.bool_0 = !this.bool_0;
		if (this.gdelegate0_0 != null)
		{
			this.gdelegate0_0(this);
		}
		base.OnClick(e);
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600006C RID: 108 RVA: 0x0025D0AC File Offset: 0x0025B2AC
	// (set) Token: 0x0600006D RID: 109 RVA: 0x0025D0C0 File Offset: 0x0025B2C0
	[Category("Options")]
	public GControl2.GEnum1 GEnum1_0
	{
		get
		{
			return this.genum1_0;
		}
		set
		{
			this.genum1_0 = value;
		}
	}

	// Token: 0x0600006E RID: 110 RVA: 0x0025D0D4 File Offset: 0x0025B2D4
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Height = 22;
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600006F RID: 111 RVA: 0x0025D0F0 File Offset: 0x0025B2F0
	// (set) Token: 0x06000070 RID: 112 RVA: 0x0025D104 File Offset: 0x0025B304
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

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000071 RID: 113 RVA: 0x0025D118 File Offset: 0x0025B318
	// (set) Token: 0x06000072 RID: 114 RVA: 0x0025D12C File Offset: 0x0025B32C
	[Category("Colors")]
	public Color Color_1
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

	// Token: 0x06000073 RID: 115 RVA: 0x0025D140 File Offset: 0x0025B340
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0025D164 File Offset: 0x0025B364
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000075 RID: 117 RVA: 0x0025D188 File Offset: 0x0025B388
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0025D1AC File Offset: 0x0025B3AC
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0025D1D0 File Offset: 0x0025B3D0
	public GControl2()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.FromArgb(60, 70, 73);
		this.Cursor = Cursors.Hand;
		this.Font = new Font("Segoe UI", 10f);
		base.Size = new Size(112, 22);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0025D26C File Offset: 0x0025B46C
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_0();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		Rectangle rect = new Rectangle(0, 2, base.Height - 5, base.Height - 5);
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		GControl2.GEnum1 genum = this.genum1_0;
		if (genum != GControl2.GEnum1.Style1)
		{
			if (genum == GControl2.GEnum1.Style2)
			{
				graphics2.FillRectangle(new SolidBrush(this.color_0), rect);
				GEnum5 genum2 = this.genum5_0;
				if (genum2 != GEnum5.Over)
				{
					if (genum2 == GEnum5.Down)
					{
						graphics2.DrawRectangle(new Pen(this.color_2), rect);
						graphics2.FillRectangle(new SolidBrush(Color.FromArgb(118, 213, 170)), rect);
					}
				}
				else
				{
					graphics2.DrawRectangle(new Pen(this.color_2), rect);
					graphics2.FillRectangle(new SolidBrush(Color.FromArgb(118, 213, 170)), rect);
				}
				if (this.Boolean_0)
				{
					graphics2.DrawString("ü", new Font("Wingdings", 18f), new SolidBrush(this.color_2), new Rectangle(5, 7, this.int_1 - 9, this.int_1 - 9), GClass6.stringFormat_1);
				}
				if (!base.Enabled)
				{
					graphics2.FillRectangle(new SolidBrush(Color.FromArgb(54, 58, 61)), rect);
					graphics2.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(48, 119, 91)), new Rectangle(20, 2, this.int_0, this.int_1), GClass6.stringFormat_0);
				}
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), new Rectangle(20, 2, this.int_0, this.int_1), GClass6.stringFormat_0);
			}
		}
		else
		{
			graphics2.FillRectangle(new SolidBrush(this.color_0), rect);
			GEnum5 genum2 = this.genum5_0;
			if (genum2 != GEnum5.Over)
			{
				if (genum2 == GEnum5.Down)
				{
					graphics2.DrawRectangle(new Pen(this.color_2), rect);
				}
			}
			else
			{
				graphics2.DrawRectangle(new Pen(this.color_2), rect);
			}
			if (this.Boolean_0)
			{
				graphics2.DrawString("ü", new Font("Wingdings", 18f), new SolidBrush(this.color_2), new Rectangle(5, 7, this.int_1 - 9, this.int_1 - 9), GClass6.stringFormat_1);
			}
			if (!base.Enabled)
			{
				graphics2.FillRectangle(new SolidBrush(Color.FromArgb(54, 58, 61)), rect);
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(140, 142, 143)), new Rectangle(20, 2, this.int_0, this.int_1), GClass6.stringFormat_0);
			}
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), new Rectangle(20, 2, this.int_0, this.int_1), GClass6.stringFormat_0);
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x06000079 RID: 121 RVA: 0x0025D5E4 File Offset: 0x0025B7E4
	private void method_0()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_2 = gclass.color_0;
	}

	// Token: 0x04000045 RID: 69
	private int int_0;

	// Token: 0x04000046 RID: 70
	private int int_1;

	// Token: 0x04000047 RID: 71
	private GEnum5 genum5_0;

	// Token: 0x04000048 RID: 72
	private GControl2.GEnum1 genum1_0;

	// Token: 0x04000049 RID: 73
	private bool bool_0;

	// Token: 0x0400004A RID: 74
	[CompilerGenerated]
	private GControl2.GDelegate0 gdelegate0_0;

	// Token: 0x0400004B RID: 75
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x0400004C RID: 76
	private Color color_1 = Color.FromArgb(243, 243, 243);

	// Token: 0x0400004D RID: 77
	private Color color_2 = GClass6.color_0;

	// Token: 0x02000012 RID: 18
	// (Invoke) Token: 0x0600007B RID: 123
	public delegate void GDelegate0(object sender);

	// Token: 0x02000013 RID: 19
	[Flags]
	public enum GEnum1
	{
		// Token: 0x0400004F RID: 79
		Style1 = 0,
		// Token: 0x04000050 RID: 80
		Style2 = 1
	}
}
