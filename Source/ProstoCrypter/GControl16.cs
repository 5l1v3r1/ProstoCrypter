using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000028 RID: 40
[DefaultEvent("CheckedChanged")]
public class GControl16 : Control
{
	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000180 RID: 384 RVA: 0x002618C0 File Offset: 0x0025FAC0
	// (remove) Token: 0x06000181 RID: 385 RVA: 0x002618FC File Offset: 0x0025FAFC
	public event GControl16.GDelegate2 Event_0
	{
		[CompilerGenerated]
		add
		{
			GControl16.GDelegate2 gdelegate = this.gdelegate2_0;
			GControl16.GDelegate2 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GControl16.GDelegate2 value2 = (GControl16.GDelegate2)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GControl16.GDelegate2>(ref this.gdelegate2_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GControl16.GDelegate2 gdelegate = this.gdelegate2_0;
			GControl16.GDelegate2 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GControl16.GDelegate2 value2 = (GControl16.GDelegate2)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GControl16.GDelegate2>(ref this.gdelegate2_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000182 RID: 386 RVA: 0x00261938 File Offset: 0x0025FB38
	// (set) Token: 0x06000183 RID: 387 RVA: 0x0026194C File Offset: 0x0025FB4C
	[Category("Options")]
	public GControl16.GEnum3 GEnum3_0
	{
		get
		{
			return this.genum3_0;
		}
		set
		{
			this.genum3_0 = value;
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000184 RID: 388 RVA: 0x00261960 File Offset: 0x0025FB60
	// (set) Token: 0x06000185 RID: 389 RVA: 0x00261974 File Offset: 0x0025FB74
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

	// Token: 0x06000186 RID: 390 RVA: 0x0025C2E0 File Offset: 0x0025A4E0
	protected virtual void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		base.Invalidate();
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00261988 File Offset: 0x0025FB88
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Width = 76;
		base.Height = 33;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x002619AC File Offset: 0x0025FBAC
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x06000189 RID: 393 RVA: 0x002619D0 File Offset: 0x0025FBD0
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x0600018A RID: 394 RVA: 0x002619F4 File Offset: 0x0025FBF4
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00261A18 File Offset: 0x0025FC18
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00261A3C File Offset: 0x0025FC3C
	protected virtual void OnClick(EventArgs e)
	{
		base.OnClick(e);
		this.bool_0 = !this.bool_0;
		if (this.gdelegate2_0 != null)
		{
			this.gdelegate2_0(this);
		}
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00261A74 File Offset: 0x0025FC74
	public GControl16()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.Transparent;
		base.Size = new Size(44, base.Height + 1);
		this.Cursor = Cursors.Hand;
		this.Font = new Font("Segoe UI", 10f);
		base.Size = new Size(76, 33);
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00261B44 File Offset: 0x0025FD44
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_0();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		GraphicsPath path = new GraphicsPath();
		GraphicsPath graphicsPath = new GraphicsPath();
		Rectangle rectangle_ = new Rectangle(0, 0, this.int_0, this.int_1);
		Rectangle rectangle = new Rectangle(Convert.ToInt32(this.int_0 / 2), 0, 38, this.int_1);
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.BackColor);
		switch (this.genum3_0)
		{
		case GControl16.GEnum3.Style1:
			path = GClass6.smethod_0(rectangle_, 6);
			graphicsPath = GClass6.smethod_0(rectangle, 6);
			graphics2.FillPath(new SolidBrush(this.color_2), path);
			graphics2.FillPath(new SolidBrush(this.color_3), graphicsPath);
			graphics2.DrawString("OFF", this.Font, new SolidBrush(this.color_2), new Rectangle(19, 1, this.int_0, this.int_1), GClass6.stringFormat_1);
			if (this.Boolean_0)
			{
				path = GClass6.smethod_0(rectangle_, 6);
				graphicsPath = GClass6.smethod_0(new Rectangle(Convert.ToInt32(this.int_0 / 2), 0, 38, this.int_1), 6);
				graphics2.FillPath(new SolidBrush(this.color_3), path);
				graphics2.FillPath(new SolidBrush(this.color_0), graphicsPath);
				graphics2.DrawString("ON", this.Font, new SolidBrush(this.color_0), new Rectangle(8, 7, this.int_0, this.int_1), GClass6.stringFormat_0);
			}
			break;
		case GControl16.GEnum3.Style2:
			path = GClass6.smethod_0(rectangle_, 6);
			rectangle = new Rectangle(4, 4, 36, this.int_1 - 8);
			graphicsPath = GClass6.smethod_0(rectangle, 4);
			graphics2.FillPath(new SolidBrush(this.color_1), path);
			graphics2.FillPath(new SolidBrush(this.color_3), graphicsPath);
			graphics2.DrawLine(new Pen(this.color_2), 18, 20, 18, 12);
			graphics2.DrawLine(new Pen(this.color_2), 22, 20, 22, 12);
			graphics2.DrawLine(new Pen(this.color_2), 26, 20, 26, 12);
			graphics2.DrawString("r", new Font("Marlett", 8f), new SolidBrush(this.color_4), new Rectangle(19, 2, base.Width, base.Height), GClass6.stringFormat_1);
			if (this.Boolean_0)
			{
				path = GClass6.smethod_0(rectangle_, 6);
				rectangle = new Rectangle(Convert.ToInt32(this.int_0 / 2) - 2, 4, 36, this.int_1 - 8);
				graphicsPath = GClass6.smethod_0(rectangle, 4);
				graphics2.FillPath(new SolidBrush(this.color_0), path);
				graphics2.FillPath(new SolidBrush(this.color_3), graphicsPath);
				graphics2.DrawLine(new Pen(this.color_2), Convert.ToInt32(this.int_0 / 2) + 12, 20, Convert.ToInt32(this.int_0 / 2) + 12, 12);
				graphics2.DrawLine(new Pen(this.color_2), Convert.ToInt32(this.int_0 / 2) + 16, 20, Convert.ToInt32(this.int_0 / 2) + 16, 12);
				graphics2.DrawLine(new Pen(this.color_2), Convert.ToInt32(this.int_0 / 2) + 20, 20, Convert.ToInt32(this.int_0 / 2) + 20, 12);
				graphics2.DrawString("ü", new Font("Wingdings", 14f), new SolidBrush(this.color_4), new Rectangle(8, 7, base.Width, base.Height), GClass6.stringFormat_0);
			}
			break;
		case GControl16.GEnum3.Style3:
			path = GClass6.smethod_0(rectangle_, 16);
			rectangle = new Rectangle(this.int_0 - 28, 4, 22, this.int_1 - 8);
			graphicsPath.AddEllipse(rectangle);
			graphics2.FillPath(new SolidBrush(this.color_3), path);
			graphics2.FillPath(new SolidBrush(this.color_1), graphicsPath);
			graphics2.DrawString("OFF", this.Font, new SolidBrush(this.color_1), new Rectangle(-12, 2, this.int_0, this.int_1), GClass6.stringFormat_1);
			if (this.Boolean_0)
			{
				path = GClass6.smethod_0(rectangle_, 16);
				rectangle = new Rectangle(6, 4, 22, this.int_1 - 8);
				graphicsPath.Reset();
				graphicsPath.AddEllipse(rectangle);
				graphics2.FillPath(new SolidBrush(this.color_3), path);
				graphics2.FillPath(new SolidBrush(this.color_0), graphicsPath);
				graphics2.DrawString("ON", this.Font, new SolidBrush(this.color_0), new Rectangle(12, 2, this.int_0, this.int_1), GClass6.stringFormat_1);
			}
			break;
		case GControl16.GEnum3.Style4:
			if (this.Boolean_0)
			{
			}
			break;
		case GControl16.GEnum3.Style5:
		{
			bool boolean_ = this.Boolean_0;
			break;
		}
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x0600018F RID: 399 RVA: 0x002620B8 File Offset: 0x002602B8
	private void method_0()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_0 = gclass.color_0;
	}

	// Token: 0x040000BD RID: 189
	private int int_0;

	// Token: 0x040000BE RID: 190
	private int int_1;

	// Token: 0x040000BF RID: 191
	private GControl16.GEnum3 genum3_0;

	// Token: 0x040000C0 RID: 192
	private bool bool_0;

	// Token: 0x040000C1 RID: 193
	private GEnum5 genum5_0;

	// Token: 0x040000C2 RID: 194
	[CompilerGenerated]
	private GControl16.GDelegate2 gdelegate2_0;

	// Token: 0x040000C3 RID: 195
	private Color color_0 = GClass6.color_0;

	// Token: 0x040000C4 RID: 196
	private Color color_1 = Color.FromArgb(220, 85, 96);

	// Token: 0x040000C5 RID: 197
	private Color color_2 = Color.FromArgb(84, 85, 86);

	// Token: 0x040000C6 RID: 198
	private Color color_3 = Color.FromArgb(45, 47, 49);

	// Token: 0x040000C7 RID: 199
	private Color color_4 = Color.FromArgb(243, 243, 243);

	// Token: 0x02000029 RID: 41
	// (Invoke) Token: 0x06000191 RID: 401
	public delegate void GDelegate2(object sender);

	// Token: 0x0200002A RID: 42
	[Flags]
	public enum GEnum3
	{
		// Token: 0x040000C9 RID: 201
		Style1 = 0,
		// Token: 0x040000CA RID: 202
		Style2 = 1,
		// Token: 0x040000CB RID: 203
		Style3 = 2,
		// Token: 0x040000CC RID: 204
		Style4 = 3,
		// Token: 0x040000CD RID: 205
		Style5 = 4
	}
}
