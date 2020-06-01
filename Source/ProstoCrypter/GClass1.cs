using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000017 RID: 23
public class GClass1 : ComboBox
{
	// Token: 0x060000A1 RID: 161 RVA: 0x0025DD98 File Offset: 0x0025BF98
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		this.genum5_0 = GEnum5.Down;
		base.Invalidate();
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x0025DDBC File Offset: 0x0025BFBC
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0025DDE0 File Offset: 0x0025BFE0
	protected virtual void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		this.genum5_0 = GEnum5.Over;
		base.Invalidate();
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0025DE04 File Offset: 0x0025C004
	protected virtual void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		this.genum5_0 = GEnum5.None;
		base.Invalidate();
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x0025DE28 File Offset: 0x0025C028
	protected virtual void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		this.int_3 = e.Location.X;
		this.int_4 = e.Location.Y;
		base.Invalidate();
		if (e.X < base.Width - 41)
		{
			this.Cursor = Cursors.IBeam;
			return;
		}
		this.Cursor = Cursors.Hand;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x0025DE94 File Offset: 0x0025C094
	protected virtual void OnDrawItem(DrawItemEventArgs e)
	{
		base.OnDrawItem(e);
		base.Invalidate();
		if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
		{
			base.Invalidate();
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0025DEC4 File Offset: 0x0025C0C4
	protected virtual void OnClick(EventArgs e)
	{
		base.OnClick(e);
		base.Invalidate();
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x0025DEE0 File Offset: 0x0025C0E0
	// (set) Token: 0x060000A9 RID: 169 RVA: 0x0025DEF4 File Offset: 0x0025C0F4
	[Category("Colors")]
	public Color Color_0
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

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000AA RID: 170 RVA: 0x0025DF08 File Offset: 0x0025C108
	// (set) Token: 0x060000AB RID: 171 RVA: 0x0025DF1C File Offset: 0x0025C11C
	private int Int32_0
	{
		get
		{
			return this.int_2;
		}
		set
		{
			this.int_2 = value;
			try
			{
				this.method_0(value);
			}
			catch
			{
			}
			base.Invalidate();
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0025DF54 File Offset: 0x0025C154
	public void GClass1_DrawItem(object sender, DrawItemEventArgs e)
	{
		if (e.Index < 0)
		{
			return;
		}
		e.DrawBackground();
		e.DrawFocusRectangle();
		e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		if ((e.State & DrawItemState.Selected) != DrawItemState.Selected)
		{
			e.Graphics.FillRectangle(new SolidBrush(this.color_0), e.Bounds);
		}
		else
		{
			e.Graphics.FillRectangle(new SolidBrush(this.color_2), e.Bounds);
		}
		e.Graphics.DrawString(base.GetItemText(base.Items[e.Index]), new Font("Segoe UI", 8f), Brushes.White, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height));
		e.Graphics.Dispose();
	}

	// Token: 0x060000AD RID: 173 RVA: 0x0025E074 File Offset: 0x0025C274
	protected virtual void OnResize(EventArgs e)
	{
		base.OnResize(e);
		base.Height = 18;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0025E090 File Offset: 0x0025C290
	public GClass1()
	{
		base.DrawItem += this.GClass1_DrawItem;
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		base.DrawMode = DrawMode.OwnerDrawFixed;
		this.BackColor = Color.FromArgb(45, 45, 48);
		this.ForeColor = Color.White;
		base.DropDownStyle = ComboBoxStyle.DropDownList;
		this.Cursor = Cursors.Hand;
		this.Int32_0 = 0;
		base.ItemHeight = 18;
		this.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
	}

	// Token: 0x060000AF RID: 175 RVA: 0x0025E158 File Offset: 0x0025C358
	protected virtual void OnPaint(PaintEventArgs e)
	{
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width;
		this.int_1 = base.Height;
		Rectangle rect = new Rectangle(0, 0, this.int_0, this.int_1);
		Rectangle rect2 = new Rectangle(Convert.ToInt32(this.int_0 - 40), 0, this.int_0, this.int_1);
		GraphicsPath graphicsPath = new GraphicsPath();
		new GraphicsPath();
		graphics.Clear(Color.FromArgb(45, 45, 48));
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics.FillRectangle(new SolidBrush(this.color_1), rect);
		graphicsPath.Reset();
		graphicsPath.AddRectangle(rect2);
		graphics.SetClip(graphicsPath);
		graphics.FillRectangle(new SolidBrush(this.color_0), rect2);
		graphics.ResetClip();
		graphics.DrawLine(Pens.White, this.int_0 - 10, 6, this.int_0 - 30, 6);
		graphics.DrawLine(Pens.White, this.int_0 - 10, 12, this.int_0 - 30, 12);
		graphics.DrawLine(Pens.White, this.int_0 - 10, 18, this.int_0 - 30, 18);
		graphics.DrawString(this.Text, this.Font, Brushes.White, new Point(4, 6), GClass6.stringFormat_0);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0025E2EC File Offset: 0x0025C4EC
	void method_0(int int_5)
	{
		base.SelectedIndex = int_5;
	}

	// Token: 0x04000061 RID: 97
	private int int_0;

	// Token: 0x04000062 RID: 98
	private int int_1;

	// Token: 0x04000063 RID: 99
	private int int_2;

	// Token: 0x04000064 RID: 100
	private int int_3;

	// Token: 0x04000065 RID: 101
	private int int_4;

	// Token: 0x04000066 RID: 102
	private GEnum5 genum5_0;

	// Token: 0x04000067 RID: 103
	private Color color_0 = Color.FromArgb(25, 27, 29);

	// Token: 0x04000068 RID: 104
	private Color color_1 = Color.FromArgb(45, 47, 49);

	// Token: 0x04000069 RID: 105
	private Color color_2 = Color.FromArgb(35, 168, 109);
}
