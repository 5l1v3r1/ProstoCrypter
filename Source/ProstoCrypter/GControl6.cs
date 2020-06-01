using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x0200001C RID: 28
public class GControl6 : Control
{
	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060000D0 RID: 208 RVA: 0x0025E6F0 File Offset: 0x0025C8F0
	// (set) Token: 0x060000D1 RID: 209 RVA: 0x0025E704 File Offset: 0x0025C904
	private ListBox ListBox_0
	{
		get
		{
			return this.listBox_0;
		}
		set
		{
			if (this.listBox_0 != null)
			{
				this.listBox_0.DrawItem -= this.listBox_0_DrawItem;
			}
			this.listBox_0 = value;
			if (this.listBox_0 != null)
			{
				this.listBox_0.DrawItem += this.listBox_0_DrawItem;
			}
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x0025E758 File Offset: 0x0025C958
	// (set) Token: 0x060000D3 RID: 211 RVA: 0x0025E76C File Offset: 0x0025C96C
	[Category("Options")]
	public string[] String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			this.ListBox_0.Items.Clear();
			this.ListBox_0.Items.AddRange(value);
			base.Invalidate();
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060000D4 RID: 212 RVA: 0x0025E7AC File Offset: 0x0025C9AC
	// (set) Token: 0x060000D5 RID: 213 RVA: 0x0025E7C0 File Offset: 0x0025C9C0
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

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000D6 RID: 214 RVA: 0x0025E7D4 File Offset: 0x0025C9D4
	public string String_1
	{
		get
		{
			return this.ListBox_0.SelectedItem.ToString();
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x0025E7F4 File Offset: 0x0025C9F4
	public int Int32_0
	{
		get
		{
			return this.ListBox_0.SelectedIndex;
		}
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x0025E80C File Offset: 0x0025CA0C
	public void method_0()
	{
		this.ListBox_0.Items.Clear();
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0025E82C File Offset: 0x0025CA2C
	public void method_1()
	{
		int num = this.ListBox_0.SelectedItems.Count - 1;
		if (num >= 0)
		{
			this.ListBox_0.Items.Remove(this.ListBox_0.SelectedItems[num]);
			num += -1;
		}
	}

	// Token: 0x060000DA RID: 218 RVA: 0x0025E878 File Offset: 0x0025CA78
	public void listBox_0_DrawItem(object sender, DrawItemEventArgs e)
	{
		if (e.Index < 0)
		{
			return;
		}
		e.DrawBackground();
		e.DrawFocusRectangle();
		e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
		e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		if (e.State.ToString().IndexOf("Selected,") < 0)
		{
			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(51, 53, 55)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
			e.Graphics.DrawString(" " + this.ListBox_0.Items[e.Index].ToString(), new Font("Segoe UI", 8f), Brushes.White, (float)e.Bounds.X, (float)(e.Bounds.Y + 2));
		}
		else
		{
			e.Graphics.FillRectangle(new SolidBrush(this.color_1), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
			e.Graphics.DrawString(" " + this.ListBox_0.Items[e.Index].ToString(), new Font("Segoe UI", 8f), Brushes.White, (float)e.Bounds.X, (float)(e.Bounds.Y + 2));
		}
		e.Graphics.Dispose();
	}

	// Token: 0x060000DB RID: 219 RVA: 0x0025EA74 File Offset: 0x0025CC74
	protected virtual void OnCreateControl()
	{
		base.OnCreateControl();
		if (!base.Controls.Contains(this.ListBox_0))
		{
			base.Controls.Add(this.ListBox_0);
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x0025EAAC File Offset: 0x0025CCAC
	public void method_2(object[] object_0)
	{
		this.ListBox_0.Items.Remove("");
		this.ListBox_0.Items.AddRange(object_0);
	}

	// Token: 0x060000DD RID: 221 RVA: 0x0025EAE0 File Offset: 0x0025CCE0
	public void method_3(object object_0)
	{
		this.ListBox_0.Items.Remove("");
		this.ListBox_0.Items.Add(object_0);
	}

	// Token: 0x060000DE RID: 222 RVA: 0x0025EB14 File Offset: 0x0025CD14
	public GControl6()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.ListBox_0.DrawMode = DrawMode.OwnerDrawFixed;
		this.ListBox_0.ScrollAlwaysVisible = false;
		this.ListBox_0.HorizontalScrollbar = false;
		this.ListBox_0.BorderStyle = BorderStyle.None;
		this.ListBox_0.BackColor = this.color_0;
		this.ListBox_0.ForeColor = Color.White;
		this.ListBox_0.Location = new Point(3, 3);
		this.ListBox_0.Font = new Font("Segoe UI", 8f);
		this.ListBox_0.ItemHeight = 20;
		this.ListBox_0.Items.Clear();
		this.ListBox_0.IntegralHeight = false;
		base.Size = new Size(131, 101);
		this.BackColor = this.color_0;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x0025EC3C File Offset: 0x0025CE3C
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_4();
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics.Clear(this.BackColor);
		this.ListBox_0.Size = new Size(base.Width - 6, base.Height - 2);
		graphics.FillRectangle(new SolidBrush(this.color_0), rect);
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0025ECFC File Offset: 0x0025CEFC
	private void method_4()
	{
		GClass0 gclass = GClass6.smethod_3(this);
		this.color_1 = gclass.color_0;
	}

	// Token: 0x04000072 RID: 114
	private ListBox listBox_0 = new ListBox();

	// Token: 0x04000073 RID: 115
	private string[] string_0 = new string[]
	{
		""
	};

	// Token: 0x04000074 RID: 116
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x04000075 RID: 117
	private Color color_1 = GClass6.color_0;
}
