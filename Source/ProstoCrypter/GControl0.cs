using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x0200000E RID: 14
public class GControl0 : Control
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000043 RID: 67 RVA: 0x0025C1EC File Offset: 0x0025A3EC
	// (set) Token: 0x06000044 RID: 68 RVA: 0x0025C200 File Offset: 0x0025A400
	private Timer Timer_0
	{
		get
		{
			return this.timer_0;
		}
		set
		{
			if (this.timer_0 != null)
			{
				this.timer_0.Tick -= this.timer_0_Tick;
			}
			this.timer_0 = value;
			if (this.timer_0 != null)
			{
				this.timer_0.Tick += this.timer_0_Tick;
			}
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000045 RID: 69 RVA: 0x0025C254 File Offset: 0x0025A454
	// (set) Token: 0x06000046 RID: 70 RVA: 0x0025C268 File Offset: 0x0025A468
	[Category("Options")]
	public GControl0.GEnum0 GEnum0_0
	{
		get
		{
			return this.genum0_0;
		}
		set
		{
			this.genum0_0 = value;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000047 RID: 71 RVA: 0x0025C27C File Offset: 0x0025A47C
	// (set) Token: 0x06000048 RID: 72 RVA: 0x0025C290 File Offset: 0x0025A490
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
			if (this.string_0 != null)
			{
				this.string_0 = value;
			}
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000049 RID: 73 RVA: 0x0025C2B4 File Offset: 0x0025A4B4
	// (set) Token: 0x0600004A RID: 74 RVA: 0x0025C2CC File Offset: 0x0025A4CC
	[Category("Options")]
	public bool Boolean_0
	{
		get
		{
			return !base.Visible;
		}
		set
		{
			base.Visible = value;
		}
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0025C2E0 File Offset: 0x0025A4E0
	protected virtual void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		base.Invalidate();
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0025C2FC File Offset: 0x0025A4FC
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Height = 42;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0025C318 File Offset: 0x0025A518
	public void method_0(GControl0.GEnum0 genum0_1, string string_1, int int_3)
	{
		this.genum0_0 = genum0_1;
		this.Text = string_1;
		this.Boolean_0 = true;
		this.Timer_0 = new Timer();
		this.Timer_0.Interval = int_3;
		this.Timer_0.Enabled = true;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0025C360 File Offset: 0x0025A560
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.Boolean_0 = false;
		this.Timer_0.Enabled = false;
		this.Timer_0.Dispose();
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0025C38C File Offset: 0x0025A58C
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0025C3B0 File Offset: 0x0025A5B0
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0025C3D4 File Offset: 0x0025A5D4
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0025C3F8 File Offset: 0x0025A5F8
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0025C41C File Offset: 0x0025A61C
	protected virtual void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		this.int_2 = e.X;
		base.Invalidate();
	}

	// Token: 0x06000054 RID: 84 RVA: 0x0025C444 File Offset: 0x0025A644
	protected virtual void OnClick(EventArgs e)
	{
		base.OnClick(e);
		this.Boolean_0 = false;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x0025C460 File Offset: 0x0025A660
	public GControl0()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.FromArgb(60, 70, 73);
		base.Size = new Size(576, 42);
		base.Location = new Point(10, 61);
		this.Font = new Font("Segoe UI", 10f);
		this.Cursor = Cursors.Hand;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x0025C550 File Offset: 0x0025A750
	protected virtual void OnPaint(PaintEventArgs e)
	{
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		Rectangle rect = new Rectangle(0, 0, this.int_0, this.int_1);
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		switch (this.genum0_0)
		{
		case GControl0.GEnum0.Success:
			graphics2.FillRectangle(new SolidBrush(this.color_0), rect);
			graphics2.FillEllipse(new SolidBrush(this.color_1), new Rectangle(8, 9, 24, 24));
			graphics2.FillEllipse(new SolidBrush(this.color_0), new Rectangle(10, 11, 20, 20));
			graphics2.DrawString("ü", new Font("Wingdings", 22f), new SolidBrush(this.color_1), new Rectangle(7, 7, this.int_0, this.int_1), GClass6.stringFormat_0);
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_1), new Rectangle(48, 12, this.int_0, this.int_1), GClass6.stringFormat_0);
			graphics2.FillEllipse(new SolidBrush(Color.FromArgb(35, Color.Black)), new Rectangle(this.int_0 - 30, this.int_1 - 29, 17, 17));
			graphics2.DrawString("r", new Font("Marlett", 8f), new SolidBrush(this.color_0), new Rectangle(this.int_0 - 28, 16, this.int_0, this.int_1), GClass6.stringFormat_0);
			if (this.genum5_0 == GEnum5.Over)
			{
				graphics2.DrawString("r", new Font("Marlett", 8f), new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(this.int_0 - 28, 16, this.int_0, this.int_1), GClass6.stringFormat_0);
			}
			break;
		case GControl0.GEnum0.Error:
			graphics2.FillRectangle(new SolidBrush(this.color_2), rect);
			graphics2.FillEllipse(new SolidBrush(this.color_3), new Rectangle(8, 9, 24, 24));
			graphics2.FillEllipse(new SolidBrush(this.color_2), new Rectangle(10, 11, 20, 20));
			graphics2.DrawString("r", new Font("Marlett", 16f), new SolidBrush(this.color_3), new Rectangle(6, 11, this.int_0, this.int_1), GClass6.stringFormat_0);
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_3), new Rectangle(48, 12, this.int_0, this.int_1), GClass6.stringFormat_0);
			graphics2.FillEllipse(new SolidBrush(Color.FromArgb(35, Color.Black)), new Rectangle(this.int_0 - 32, this.int_1 - 29, 17, 17));
			graphics2.DrawString("r", new Font("Marlett", 8f), new SolidBrush(this.color_2), new Rectangle(this.int_0 - 30, 17, this.int_0, this.int_1), GClass6.stringFormat_0);
			if (this.genum5_0 == GEnum5.Over)
			{
				graphics2.DrawString("r", new Font("Marlett", 8f), new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(this.int_0 - 30, 15, this.int_0, this.int_1), GClass6.stringFormat_0);
			}
			break;
		case GControl0.GEnum0.Info:
			graphics2.FillRectangle(new SolidBrush(this.color_4), rect);
			graphics2.FillEllipse(new SolidBrush(this.color_5), new Rectangle(8, 9, 24, 24));
			graphics2.FillEllipse(new SolidBrush(this.color_4), new Rectangle(10, 11, 20, 20));
			graphics2.DrawString("¡", new Font("Segoe UI", 20f, FontStyle.Bold), new SolidBrush(this.color_5), new Rectangle(12, -4, this.int_0, this.int_1), GClass6.stringFormat_0);
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_5), new Rectangle(48, 12, this.int_0, this.int_1), GClass6.stringFormat_0);
			graphics2.FillEllipse(new SolidBrush(Color.FromArgb(35, Color.Black)), new Rectangle(this.int_0 - 32, this.int_1 - 29, 17, 17));
			graphics2.DrawString("r", new Font("Marlett", 8f), new SolidBrush(this.color_4), new Rectangle(this.int_0 - 30, 17, this.int_0, this.int_1), GClass6.stringFormat_0);
			if (this.genum5_0 == GEnum5.Over)
			{
				graphics2.DrawString("r", new Font("Marlett", 8f), new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(this.int_0 - 30, 17, this.int_0, this.int_1), GClass6.stringFormat_0);
			}
			break;
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x06000057 RID: 87 RVA: 0x0025CB10 File Offset: 0x0025AD10
	string method_1()
	{
		return base.Text;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x0025CB24 File Offset: 0x0025AD24
	void method_2(string string_1)
	{
		base.Text = string_1;
	}

	// Token: 0x0400002E RID: 46
	private int int_0;

	// Token: 0x0400002F RID: 47
	private int int_1;

	// Token: 0x04000030 RID: 48
	private GControl0.GEnum0 genum0_0;

	// Token: 0x04000031 RID: 49
	private string string_0;

	// Token: 0x04000032 RID: 50
	private GEnum5 genum5_0;

	// Token: 0x04000033 RID: 51
	private int int_2;

	// Token: 0x04000034 RID: 52
	private Timer timer_0;

	// Token: 0x04000035 RID: 53
	private Color color_0 = Color.FromArgb(60, 85, 79);

	// Token: 0x04000036 RID: 54
	private Color color_1 = Color.FromArgb(35, 169, 110);

	// Token: 0x04000037 RID: 55
	private Color color_2 = Color.FromArgb(87, 71, 71);

	// Token: 0x04000038 RID: 56
	private Color color_3 = Color.FromArgb(254, 142, 122);

	// Token: 0x04000039 RID: 57
	private Color color_4 = Color.FromArgb(70, 91, 94);

	// Token: 0x0400003A RID: 58
	private Color color_5 = Color.FromArgb(97, 185, 186);

	// Token: 0x0200000F RID: 15
	[Flags]
	public enum GEnum0
	{
		// Token: 0x0400003C RID: 60
		Success = 0,
		// Token: 0x0400003D RID: 61
		Error = 1,
		// Token: 0x0400003E RID: 62
		Info = 2
	}
}
