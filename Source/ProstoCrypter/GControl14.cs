using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x02000026 RID: 38
public class GControl14 : TabControl
{
	// Token: 0x06000155 RID: 341 RVA: 0x00260C34 File Offset: 0x0025EE34
	protected virtual void CreateHandle()
	{
		base.CreateHandle();
		base.Alignment = TabAlignment.Top;
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000156 RID: 342 RVA: 0x00260C50 File Offset: 0x0025EE50
	// (set) Token: 0x06000157 RID: 343 RVA: 0x00260C64 File Offset: 0x0025EE64
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

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000158 RID: 344 RVA: 0x00260C78 File Offset: 0x0025EE78
	// (set) Token: 0x06000159 RID: 345 RVA: 0x00260C8C File Offset: 0x0025EE8C
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

	// Token: 0x0600015A RID: 346 RVA: 0x00260CA0 File Offset: 0x0025EEA0
	public GControl14()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = Color.FromArgb(60, 70, 73);
		this.Font = new Font("Segoe UI", 10f);
		base.SizeMode = TabSizeMode.Fixed;
		base.ItemSize = new Size(120, 40);
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00260D30 File Offset: 0x0025EF30
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_0();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		this.int_0 = base.Width - 1;
		this.int_1 = base.Height - 1;
		Graphics graphics2 = graphics;
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics2.Clear(this.color_1);
		try
		{
			base.SelectedTab.BackColor = this.color_0;
		}
		catch
		{
		}
		for (int i = 0; i <= base.TabCount - 1; i++)
		{
			Rectangle rectangle = new Rectangle(new Point(base.GetTabRect(i).Location.X + 2, base.GetTabRect(i).Location.Y), new Size(base.GetTabRect(i).Width, base.GetTabRect(i).Height));
			Rectangle rectangle2 = new Rectangle(rectangle.Location, new Size(rectangle.Width, rectangle.Height));
			if (i == base.SelectedIndex)
			{
				graphics2.FillRectangle(new SolidBrush(this.color_1), rectangle2);
				graphics2.FillRectangle(new SolidBrush(this.color_2), rectangle2);
				if (base.ImageList != null)
				{
					try
					{
						if (base.ImageList.Images[base.TabPages[i].ImageIndex] != null)
						{
							graphics2.DrawImage(base.ImageList.Images[base.TabPages[i].ImageIndex], new Point(rectangle2.Location.X + 8, rectangle2.Location.Y + 6));
							graphics2.DrawString("      " + base.TabPages[i].Text, this.Font, Brushes.White, rectangle2, GClass6.stringFormat_1);
						}
						else
						{
							graphics2.DrawString(base.TabPages[i].Text, this.Font, Brushes.White, rectangle2, GClass6.stringFormat_1);
						}
						goto IL_3D8;
					}
					catch (Exception ex)
					{
						throw new Exception(ex.Message);
					}
				}
				graphics2.DrawString(base.TabPages[i].Text, this.Font, Brushes.White, rectangle2, GClass6.stringFormat_1);
			}
			else
			{
				graphics2.FillRectangle(new SolidBrush(this.color_1), rectangle2);
				if (base.ImageList != null)
				{
					try
					{
						if (base.ImageList.Images[base.TabPages[i].ImageIndex] != null)
						{
							graphics2.DrawImage(base.ImageList.Images[base.TabPages[i].ImageIndex], new Point(rectangle2.Location.X + 8, rectangle2.Location.Y + 6));
							graphics2.DrawString("      " + base.TabPages[i].Text, this.Font, new SolidBrush(Color.White), rectangle2, new StringFormat
							{
								LineAlignment = StringAlignment.Center,
								Alignment = StringAlignment.Center
							});
						}
						else
						{
							graphics2.DrawString(base.TabPages[i].Text, this.Font, new SolidBrush(Color.White), rectangle2, new StringFormat
							{
								LineAlignment = StringAlignment.Center,
								Alignment = StringAlignment.Center
							});
						}
						goto IL_3D8;
					}
					catch (Exception ex2)
					{
						throw new Exception(ex2.Message);
					}
				}
				graphics2.DrawString(base.TabPages[i].Text, this.Font, new SolidBrush(Color.White), rectangle2, new StringFormat
				{
					LineAlignment = StringAlignment.Center,
					Alignment = StringAlignment.Center
				});
			}
			IL_3D8:;
		}
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00261198 File Offset: 0x0025F398
	private void method_0()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_2 = gclass.color_0;
	}

	// Token: 0x040000AB RID: 171
	private int int_0;

	// Token: 0x040000AC RID: 172
	private int int_1;

	// Token: 0x040000AD RID: 173
	private Color color_0 = Color.FromArgb(60, 70, 73);

	// Token: 0x040000AE RID: 174
	private Color color_1 = Color.FromArgb(45, 47, 49);

	// Token: 0x040000AF RID: 175
	private Color color_2 = GClass6.color_0;
}
