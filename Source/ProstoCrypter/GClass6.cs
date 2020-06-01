using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x02000030 RID: 48
public static class GClass6
{
	// Token: 0x060001C6 RID: 454 RVA: 0x00262FF4 File Offset: 0x002611F4
	public static GraphicsPath smethod_0(Rectangle rectangle_0, int int_0)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		int num = int_0 * 2;
		graphicsPath.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Y, num, num), -180f, 90f);
		graphicsPath.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Y, num, num), -90f, 90f);
		graphicsPath.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 0f, 90f);
		graphicsPath.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 90f, 90f);
		graphicsPath.AddLine(new Point(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y), new Point(rectangle_0.X, int_0 + rectangle_0.Y));
		return graphicsPath;
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00263100 File Offset: 0x00261300
	public static GraphicsPath smethod_1(float float_0, float float_1, float float_2, float float_3, double double_0 = 0.3, bool bool_0 = true, bool bool_1 = true, bool bool_2 = true, bool bool_3 = true)
	{
		float num = Math.Min(float_2, float_3) * (float)double_0;
		float num2 = float_0 + float_2;
		float num3 = float_1 + float_3;
		GraphicsPath graphicsPath;
		GraphicsPath result = graphicsPath = new GraphicsPath();
		if (bool_0)
		{
			graphicsPath.AddArc(float_0, float_1, num, num, 180f, 90f);
		}
		else
		{
			graphicsPath.AddLine(float_0, float_1, float_0, float_1);
		}
		if (bool_1)
		{
			graphicsPath.AddArc(num2 - num, float_1, num, num, 270f, 90f);
		}
		else
		{
			graphicsPath.AddLine(num2, float_1, num2, float_1);
		}
		if (bool_2)
		{
			graphicsPath.AddArc(num2 - num, num3 - num, num, num, 0f, 90f);
		}
		else
		{
			graphicsPath.AddLine(num2, num3, num2, num3);
		}
		if (bool_3)
		{
			graphicsPath.AddArc(float_0, num3 - num, num, num, 90f, 90f);
		}
		else
		{
			graphicsPath.AddLine(float_0, num3, float_0, num3);
		}
		graphicsPath.CloseFigure();
		return result;
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x002631C8 File Offset: 0x002613C8
	public static GraphicsPath smethod_2(int int_0, int int_1, bool bool_0)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		int num = 12;
		int num2 = 6;
		if (!bool_0)
		{
			graphicsPath.AddLine(int_0, int_1 + num2, int_0 + num, int_1 + num2);
			graphicsPath.AddLine(int_0 + num, int_1 + num2, int_0 + num2, int_1);
		}
		else
		{
			graphicsPath.AddLine(int_0 + 1, int_1, int_0 + num + 1, int_1);
			graphicsPath.AddLine(int_0 + num, int_1, int_0 + num2, int_1 + num2 - 1);
		}
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00263230 File Offset: 0x00261430
	public static GClass0 smethod_3(Control control_0)
	{
		if (control_0 == null)
		{
			throw new ArgumentNullException();
		}
		GClass0 gclass = new GClass0();
		while (control_0 != null && control_0.GetType() != typeof(GControl18))
		{
			control_0 = control_0.Parent;
		}
		if (control_0 != null)
		{
			GControl18 gcontrol = (GControl18)control_0;
			gclass.color_0 = gcontrol.Color_3;
		}
		return gclass;
	}

	// Token: 0x040000F2 RID: 242
	public static Color color_0 = Color.FromArgb(35, 168, 109);

	// Token: 0x040000F3 RID: 243
	public static readonly StringFormat stringFormat_0 = new StringFormat
	{
		Alignment = StringAlignment.Near,
		LineAlignment = StringAlignment.Near
	};

	// Token: 0x040000F4 RID: 244
	public static readonly StringFormat stringFormat_1 = new StringFormat
	{
		Alignment = StringAlignment.Center,
		LineAlignment = StringAlignment.Center
	};
}
