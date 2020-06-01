using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000021 RID: 33
[DefaultEvent("CheckedChanged")]
public class GControl11 : Control
{
	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000121 RID: 289 RVA: 0x0025FDCC File Offset: 0x0025DFCC
	// (set) Token: 0x06000122 RID: 290 RVA: 0x0025FDE0 File Offset: 0x0025DFE0
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			this.method_0();
			if (this.gdelegate1_0 != null)
			{
				this.gdelegate1_0(this);
			}
			base.Invalidate();
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000123 RID: 291 RVA: 0x0025FE14 File Offset: 0x0025E014
	// (remove) Token: 0x06000124 RID: 292 RVA: 0x0025FE4C File Offset: 0x0025E04C
	public event GControl11.GDelegate1 Event_0
	{
		[CompilerGenerated]
		add
		{
			GControl11.GDelegate1 gdelegate = this.gdelegate1_0;
			GControl11.GDelegate1 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GControl11.GDelegate1 value2 = (GControl11.GDelegate1)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GControl11.GDelegate1>(ref this.gdelegate1_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GControl11.GDelegate1 gdelegate = this.gdelegate1_0;
			GControl11.GDelegate1 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GControl11.GDelegate1 value2 = (GControl11.GDelegate1)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GControl11.GDelegate1>(ref this.gdelegate1_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x06000125 RID: 293 RVA: 0x0025FE84 File Offset: 0x0025E084
	protected virtual void OnClick(EventArgs e)
	{
		if (!this.bool_0)
		{
			this.Boolean_0 = true;
		}
		base.OnClick(e);
	}

	// Token: 0x06000126 RID: 294 RVA: 0x0025FEA8 File Offset: 0x0025E0A8
	private void method_0()
	{
		if (base.IsHandleCreated && this.bool_0)
		{
			foreach (object obj in base.Parent.Controls)
			{
				Control control = (Control)obj;
				if (control != this && control is GControl11)
				{
					((GControl11)control).Boolean_0 = false;
					base.Invalidate();
				}
			}
			return;
		}
	}

	// Token: 0x06000127 RID: 295 RVA: 0x0025FF30 File Offset: 0x0025E130
	protected virtual void OnCreateControl()
	{
		base.OnCreateControl();
		this.method_0();
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000128 RID: 296 RVA: 0x0025FF4C File Offset: 0x0025E14C
	// (set) Token: 0x06000129 RID: 297 RVA: 0x0025FF60 File Offset: 0x0025E160
	[Category("Options")]
	public GControl11.GEnum2 GEnum2_0
	{
		get
		{
			return this.genum2_0;
		}
		set
		{
			this.genum2_0 = value;
		}
	}

	// Token: 0x0600012A RID: 298 RVA: 0x0025D0D4 File Offset: 0x0025B2D4
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Height = 22;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x0025FF74 File Offset: 0x0025E174
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0025FF98 File Offset: 0x0025E198
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0025FFBC File Offset: 0x0025E1BC
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x0600012E RID: 302 RVA: 0x0025FFE0 File Offset: 0x0025E1E0
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00260004 File Offset: 0x0025E204
	public GControl11()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.Cursor = Cursors.Hand;
		base.Size = new Size(100, 22);
		this.BackColor = Color.FromArgb(60, 70, 73);
		this.Font = new Font("Segoe UI", 10f);
	}

	// Token: 0x06000130 RID: 304 RVA: 0x002600A0 File Offset: 0x0025E2A0
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_1();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		Rectangle rect = new Rectangle(0, 2, base.Height - 5, base.Height - 5);
		Rectangle rect2 = new Rectangle(4, 6, this.int_1 - 12, this.int_1 - 12);
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		GControl11.GEnum2 genum = this.genum2_0;
		if (genum != GControl11.GEnum2.Style1)
		{
			if (genum == GControl11.GEnum2.Style2)
			{
				graphics2.FillEllipse(new SolidBrush(this.color_0), rect);
				GEnum5 genum2 = this.genum5_0;
				if (genum2 == GEnum5.Over)
				{
					graphics2.DrawEllipse(new Pen(this.color_1), rect);
					graphics2.FillEllipse(new SolidBrush(Color.FromArgb(118, 213, 170)), rect);
				}
				else if (genum2 == GEnum5.Down)
				{
					graphics2.DrawEllipse(new Pen(this.color_1), rect);
					graphics2.FillEllipse(new SolidBrush(Color.FromArgb(118, 213, 170)), rect);
				}
				if (this.Boolean_0)
				{
					graphics2.FillEllipse(new SolidBrush(this.color_1), rect2);
				}
			}
		}
		else
		{
			graphics2.FillEllipse(new SolidBrush(this.color_0), rect);
			GEnum5 genum2 = this.genum5_0;
			if (genum2 != GEnum5.Over)
			{
				if (genum2 == GEnum5.Down)
				{
					graphics2.DrawEllipse(new Pen(this.color_1), rect);
				}
			}
			else
			{
				graphics2.DrawEllipse(new Pen(this.color_1), rect);
			}
			if (this.Boolean_0)
			{
				graphics2.FillEllipse(new SolidBrush(this.color_1), rect2);
			}
		}
		graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.color_2), new Rectangle(20, 2, this.int_0, this.int_1), GClass6.stringFormat_0);
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x06000131 RID: 305 RVA: 0x002602CC File Offset: 0x0025E4CC
	private void method_1()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_1 = gclass.color_0;
	}

	// Token: 0x04000093 RID: 147
	private GEnum5 genum5_0;

	// Token: 0x04000094 RID: 148
	private int int_0;

	// Token: 0x04000095 RID: 149
	private int int_1;

	// Token: 0x04000096 RID: 150
	private GControl11.GEnum2 genum2_0;

	// Token: 0x04000097 RID: 151
	private bool bool_0;

	// Token: 0x04000098 RID: 152
	[CompilerGenerated]
	private GControl11.GDelegate1 gdelegate1_0;

	// Token: 0x04000099 RID: 153
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x0400009A RID: 154
	private Color color_1 = GClass6.color_0;

	// Token: 0x0400009B RID: 155
	private Color color_2 = Color.FromArgb(243, 243, 243);

	// Token: 0x02000022 RID: 34
	// (Invoke) Token: 0x06000133 RID: 307
	public delegate void GDelegate1(object sender);

	// Token: 0x02000023 RID: 35
	[Flags]
	public enum GEnum2
	{
		// Token: 0x0400009D RID: 157
		Style1 = 0,
		// Token: 0x0400009E RID: 158
		Style2 = 1
	}
}
