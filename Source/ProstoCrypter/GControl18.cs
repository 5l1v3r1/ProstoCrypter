using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x0200002F RID: 47
public class GControl18 : ContainerControl
{
	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060001B5 RID: 437 RVA: 0x00262B0C File Offset: 0x00260D0C
	// (set) Token: 0x060001B6 RID: 438 RVA: 0x00262B20 File Offset: 0x00260D20
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

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060001B7 RID: 439 RVA: 0x00262B34 File Offset: 0x00260D34
	// (set) Token: 0x060001B8 RID: 440 RVA: 0x00262B48 File Offset: 0x00260D48
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

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060001B9 RID: 441 RVA: 0x00262B5C File Offset: 0x00260D5C
	// (set) Token: 0x060001BA RID: 442 RVA: 0x00262B70 File Offset: 0x00260D70
	[Category("Colors")]
	public Color Color_2
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

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060001BB RID: 443 RVA: 0x00262B84 File Offset: 0x00260D84
	// (set) Token: 0x060001BC RID: 444 RVA: 0x00262B98 File Offset: 0x00260D98
	[Category("Colors")]
	public Color Color_3
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

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060001BD RID: 445 RVA: 0x00262BAC File Offset: 0x00260DAC
	// (set) Token: 0x060001BE RID: 446 RVA: 0x00262BC0 File Offset: 0x00260DC0
	[Category("Options")]
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

	// Token: 0x060001BF RID: 447 RVA: 0x00262BD4 File Offset: 0x00260DD4
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		if (e.Button == MouseButtons.Left & new Rectangle(0, 0, base.Width, this.int_2).Contains(e.Location))
		{
			this.bool_0 = true;
			this.point_0 = e.Location;
		}
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00262C2C File Offset: 0x00260E2C
	private void GControl18_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (this.Boolean_0 && (e.Button == MouseButtons.Left & new Rectangle(0, 0, base.Width, this.int_2).Contains(e.Location)))
		{
			if (base.FindForm().WindowState == FormWindowState.Normal)
			{
				base.FindForm().WindowState = FormWindowState.Maximized;
				base.FindForm().Refresh();
				return;
			}
			if (base.FindForm().WindowState == FormWindowState.Maximized)
			{
				base.FindForm().WindowState = FormWindowState.Normal;
				base.FindForm().Refresh();
			}
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00262CC0 File Offset: 0x00260EC0
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.bool_0 = false;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00262CDC File Offset: 0x00260EDC
	protected virtual void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (this.bool_0)
		{
			base.Parent.Location = new Point(Control.MousePosition.X - this.point_0.X, Control.MousePosition.Y - this.point_0.Y);
		}
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00262D3C File Offset: 0x00260F3C
	protected virtual void OnCreateControl()
	{
		base.OnCreateControl();
		base.ParentForm.FormBorderStyle = FormBorderStyle.None;
		base.ParentForm.AllowTransparency = false;
		base.ParentForm.TransparencyKey = Color.Fuchsia;
		base.ParentForm.FindForm().StartPosition = FormStartPosition.CenterScreen;
		this.Dock = DockStyle.Fill;
		base.Invalidate();
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00262D98 File Offset: 0x00260F98
	public GControl18()
	{
		base.MouseDoubleClick += this.GControl18_MouseDoubleClick;
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.White;
		this.Font = new Font("Segoe UI", 12f);
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00262EA4 File Offset: 0x002610A4
	protected virtual void OnPaint(PaintEventArgs e)
	{
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width;
		this.int_1 = base.Height;
		Rectangle rect = new Rectangle(0, 0, this.int_0, this.int_1);
		Rectangle rect2 = new Rectangle(0, 0, this.int_0, 50);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics.Clear(this.BackColor);
		graphics.FillRectangle(new SolidBrush(this.color_1), rect);
		graphics.FillRectangle(new SolidBrush(this.color_0), rect2);
		graphics.FillRectangle(new SolidBrush(Color.FromArgb(243, 243, 243)), new Rectangle(13, 16, 4, 18));
		graphics.DrawString(this.Text, this.Font, new SolidBrush(this.color_4), new Rectangle(26, 15, this.int_0, this.int_1), GClass6.stringFormat_0);
		graphics.DrawRectangle(new Pen(this.color_2), rect);
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x040000E4 RID: 228
	private int int_0;

	// Token: 0x040000E5 RID: 229
	private int int_1;

	// Token: 0x040000E6 RID: 230
	private bool bool_0;

	// Token: 0x040000E7 RID: 231
	private bool bool_1;

	// Token: 0x040000E8 RID: 232
	private Point point_0 = new Point(0, 0);

	// Token: 0x040000E9 RID: 233
	private int int_2 = 50;

	// Token: 0x040000EA RID: 234
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x040000EB RID: 235
	private Color color_1 = Color.FromArgb(60, 70, 73);

	// Token: 0x040000EC RID: 236
	private Color color_2 = Color.FromArgb(53, 58, 60);

	// Token: 0x040000ED RID: 237
	private Color color_3 = GClass6.color_0;

	// Token: 0x040000EE RID: 238
	private Color color_4 = Color.FromArgb(234, 234, 234);

	// Token: 0x040000EF RID: 239
	private Color color_5 = Color.FromArgb(171, 171, 172);

	// Token: 0x040000F0 RID: 240
	private Color color_6 = Color.FromArgb(196, 199, 200);

	// Token: 0x040000F1 RID: 241
	public Color color_7 = Color.FromArgb(45, 47, 49);
}
