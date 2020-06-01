using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000027 RID: 39
[DefaultEvent("TextChanged")]
public class GControl15 : Control
{
	// Token: 0x1700004B RID: 75
	// (get) Token: 0x0600015D RID: 349 RVA: 0x002611B8 File Offset: 0x0025F3B8
	// (set) Token: 0x0600015E RID: 350 RVA: 0x002611CC File Offset: 0x0025F3CC
	[Category("Options")]
	public HorizontalAlignment HorizontalAlignment_0
	{
		get
		{
			return this.horizontalAlignment_0;
		}
		set
		{
			this.horizontalAlignment_0 = value;
			if (this.textBox_0 != null)
			{
				this.textBox_0.TextAlign = value;
			}
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x0600015F RID: 351 RVA: 0x002611F4 File Offset: 0x0025F3F4
	// (set) Token: 0x06000160 RID: 352 RVA: 0x00261208 File Offset: 0x0025F408
	[Category("Options")]
	public int Int32_0
	{
		get
		{
			return this.int_2;
		}
		set
		{
			this.int_2 = value;
			if (this.textBox_0 != null)
			{
				this.textBox_0.MaxLength = value;
			}
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000161 RID: 353 RVA: 0x00261230 File Offset: 0x0025F430
	// (set) Token: 0x06000162 RID: 354 RVA: 0x00261244 File Offset: 0x0025F444
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
			if (this.textBox_0 != null)
			{
				this.textBox_0.ReadOnly = value;
			}
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000163 RID: 355 RVA: 0x0026126C File Offset: 0x0025F46C
	// (set) Token: 0x06000164 RID: 356 RVA: 0x00261280 File Offset: 0x0025F480
	[Category("Options")]
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			if (this.textBox_0 != null)
			{
				this.textBox_0.UseSystemPasswordChar = value;
			}
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000165 RID: 357 RVA: 0x002612A8 File Offset: 0x0025F4A8
	// (set) Token: 0x06000166 RID: 358 RVA: 0x002612BC File Offset: 0x0025F4BC
	[Category("Options")]
	public bool Boolean_2
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
			if (this.textBox_0 != null)
			{
				this.textBox_0.Multiline = value;
				if (value)
				{
					this.textBox_0.Height = base.Height - 11;
					return;
				}
				base.Height = this.textBox_0.Height + 11;
			}
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000167 RID: 359 RVA: 0x00261310 File Offset: 0x0025F510
	// (set) Token: 0x06000168 RID: 360 RVA: 0x00261324 File Offset: 0x0025F524
	[Category("Options")]
	public bool Boolean_3
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000169 RID: 361 RVA: 0x00261338 File Offset: 0x0025F538
	// (set) Token: 0x0600016A RID: 362 RVA: 0x0026134C File Offset: 0x0025F54C
	[Category("Options")]
	public virtual string Text
	{
		get
		{
			return this.method_1();
		}
		set
		{
			this.method_2(value);
			if (this.textBox_0 != null)
			{
				this.textBox_0.Text = value;
			}
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x0600016B RID: 363 RVA: 0x00261374 File Offset: 0x0025F574
	// (set) Token: 0x0600016C RID: 364 RVA: 0x00261388 File Offset: 0x0025F588
	[Category("Options")]
	public virtual Font Font
	{
		get
		{
			return this.method_3();
		}
		set
		{
			this.method_4(value);
			if (this.textBox_0 != null)
			{
				this.textBox_0.Font = value;
				this.textBox_0.Location = new Point(3, 5);
				this.textBox_0.Width = base.Width - 6;
				if (!this.bool_2)
				{
					base.Height = this.textBox_0.Height + 11;
				}
			}
		}
	}

	// Token: 0x0600016D RID: 365 RVA: 0x002613F4 File Offset: 0x0025F5F4
	protected virtual void OnCreateControl()
	{
		base.OnCreateControl();
		if (!base.Controls.Contains(this.textBox_0))
		{
			base.Controls.Add(this.textBox_0);
		}
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0026142C File Offset: 0x0025F62C
	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		this.Text = this.textBox_0.Text;
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0026144C File Offset: 0x0025F64C
	private void textBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Control && e.KeyCode == Keys.A)
		{
			this.textBox_0.SelectAll();
			e.SuppressKeyPress = true;
		}
		if (e.Control && e.KeyCode == Keys.C)
		{
			this.textBox_0.Copy();
			e.SuppressKeyPress = true;
		}
	}

	// Token: 0x06000170 RID: 368 RVA: 0x002614A4 File Offset: 0x0025F6A4
	protected virtual void OnResize(EventArgs e)
	{
		this.textBox_0.Location = new Point(5, 5);
		this.textBox_0.Width = base.Width - 10;
		if (this.bool_2)
		{
			this.textBox_0.Height = base.Height - 11;
		}
		else
		{
			base.Height = this.textBox_0.Height + 11;
		}
		base.OnResize(e);
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000171 RID: 369 RVA: 0x00261510 File Offset: 0x0025F710
	// (set) Token: 0x06000172 RID: 370 RVA: 0x00261524 File Offset: 0x0025F724
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

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000173 RID: 371 RVA: 0x00261510 File Offset: 0x0025F710
	// (set) Token: 0x06000174 RID: 372 RVA: 0x00261524 File Offset: 0x0025F724
	public virtual Color ForeColor
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

	// Token: 0x06000175 RID: 373 RVA: 0x00261538 File Offset: 0x0025F738
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x06000176 RID: 374 RVA: 0x0026155C File Offset: 0x0025F75C
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		this.textBox_0.Focus();
		base.Invalidate();
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0026158C File Offset: 0x0025F78C
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		if (this.Boolean_3)
		{
			this.textBox_0.Focus();
		}
		base.Invalidate();
	}

	// Token: 0x06000178 RID: 376 RVA: 0x002615C4 File Offset: 0x0025F7C4
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x06000179 RID: 377 RVA: 0x002615E8 File Offset: 0x0025F7E8
	public GControl15()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.Transparent;
		this.textBox_0 = new TextBox();
		this.textBox_0.Font = new Font("Segoe UI", 10f);
		this.textBox_0.Text = this.Text;
		this.textBox_0.BackColor = this.color_0;
		this.textBox_0.ForeColor = this.color_1;
		this.textBox_0.MaxLength = this.int_2;
		this.textBox_0.Multiline = this.bool_2;
		this.textBox_0.ReadOnly = this.bool_0;
		this.textBox_0.UseSystemPasswordChar = this.bool_1;
		this.textBox_0.BorderStyle = BorderStyle.None;
		this.textBox_0.Location = new Point(5, 5);
		this.textBox_0.Width = base.Width - 10;
		this.textBox_0.Cursor = Cursors.IBeam;
		if (this.bool_2)
		{
			this.textBox_0.Height = base.Height - 11;
		}
		else
		{
			base.Height = this.textBox_0.Height + 11;
		}
		this.textBox_0.TextChanged += this.textBox_0_TextChanged;
		this.textBox_0.KeyDown += this.textBox_0_KeyDown;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00261798 File Offset: 0x0025F998
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_0();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		Rectangle rect = new Rectangle(0, 0, this.int_0, this.int_1);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics.Clear(this.BackColor);
		this.textBox_0.BackColor = this.color_0;
		this.textBox_0.ForeColor = this.color_1;
		graphics.FillRectangle(new SolidBrush(this.color_0), rect);
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00261878 File Offset: 0x0025FA78
	private void method_0()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_2 = gclass.color_0;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x0025CB10 File Offset: 0x0025AD10
	string method_1()
	{
		return base.Text;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0025CB24 File Offset: 0x0025AD24
	void method_2(string string_0)
	{
		base.Text = string_0;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00261898 File Offset: 0x0025FA98
	Font method_3()
	{
		return base.Font;
	}

	// Token: 0x0600017F RID: 383 RVA: 0x002618AC File Offset: 0x0025FAAC
	void method_4(Font font_0)
	{
		base.Font = font_0;
	}

	// Token: 0x040000B0 RID: 176
	private int int_0;

	// Token: 0x040000B1 RID: 177
	private int int_1;

	// Token: 0x040000B2 RID: 178
	private GEnum5 genum5_0;

	// Token: 0x040000B3 RID: 179
	private TextBox textBox_0;

	// Token: 0x040000B4 RID: 180
	private HorizontalAlignment horizontalAlignment_0;

	// Token: 0x040000B5 RID: 181
	private int int_2 = 32767;

	// Token: 0x040000B6 RID: 182
	private bool bool_0;

	// Token: 0x040000B7 RID: 183
	private bool bool_1;

	// Token: 0x040000B8 RID: 184
	private bool bool_2;

	// Token: 0x040000B9 RID: 185
	private bool bool_3;

	// Token: 0x040000BA RID: 186
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x040000BB RID: 187
	private Color color_1 = Color.FromArgb(192, 192, 192);

	// Token: 0x040000BC RID: 188
	private Color color_2 = GClass6.color_0;
}
