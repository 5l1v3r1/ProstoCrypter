using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

// Token: 0x0200002E RID: 46
public class GClass5 : TreeView
{
	// Token: 0x060001B1 RID: 433 RVA: 0x00262780 File Offset: 0x00260980
	protected virtual void OnDrawNode(DrawTreeNodeEventArgs e)
	{
		try
		{
			Rectangle rect = new Rectangle(e.Bounds.Location.X, e.Bounds.Location.Y, e.Bounds.Width, e.Bounds.Height);
			TreeNodeStates treeNodeStates = this.treeNodeStates_0;
			if (treeNodeStates != TreeNodeStates.Selected)
			{
				if (treeNodeStates != TreeNodeStates.Checked)
				{
					if (treeNodeStates == TreeNodeStates.Default)
					{
						e.Graphics.FillRectangle(Brushes.Red, rect);
						e.Graphics.DrawString(e.Node.Text, new Font("Segoe UI", 8f), Brushes.LimeGreen, new Rectangle(rect.X + 2, rect.Y + 2, rect.Width, rect.Height), GClass6.stringFormat_0);
						base.Invalidate();
					}
				}
				else
				{
					e.Graphics.FillRectangle(Brushes.Green, rect);
					e.Graphics.DrawString(e.Node.Text, new Font("Segoe UI", 8f), Brushes.Black, new Rectangle(rect.X + 2, rect.Y + 2, rect.Width, rect.Height), GClass6.stringFormat_0);
					base.Invalidate();
				}
			}
			else
			{
				e.Graphics.FillRectangle(Brushes.Green, rect);
				e.Graphics.DrawString(e.Node.Text, new Font("Segoe UI", 8f), Brushes.Black, new Rectangle(rect.X + 2, rect.Y + 2, rect.Width, rect.Height), GClass6.stringFormat_0);
				base.Invalidate();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		base.OnDrawNode(e);
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00262980 File Offset: 0x00260B80
	public GClass5()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.BackColor = this.color_0;
		this.ForeColor = Color.White;
		base.LineColor = this.color_1;
		base.DrawMode = TreeViewDrawMode.OwnerDrawAll;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x002629F4 File Offset: 0x00260BF4
	protected virtual void OnPaint(PaintEventArgs e)
	{
		Bitmap bitmap = new Bitmap(base.Width, base.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		graphics.Clear(this.BackColor);
		graphics.FillRectangle(new SolidBrush(this.color_0), rect);
		graphics.DrawString(this.Text, new Font("Segoe UI", 8f), Brushes.Black, new Rectangle(this.method_0().X + 2, base.Bounds.Y + 2, base.Bounds.Width, base.Bounds.Height), GClass6.stringFormat_0);
		base.OnPaint(e);
		graphics.Dispose();
		e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
		bitmap.Dispose();
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00262AF8 File Offset: 0x00260CF8
	Rectangle method_0()
	{
		return base.Bounds;
	}

	// Token: 0x040000E1 RID: 225
	private TreeNodeStates treeNodeStates_0;

	// Token: 0x040000E2 RID: 226
	private Color color_0 = Color.FromArgb(45, 47, 49);

	// Token: 0x040000E3 RID: 227
	private Color color_1 = Color.FromArgb(25, 27, 29);
}
