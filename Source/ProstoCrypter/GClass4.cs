using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200001B RID: 27
public class GClass4 : Label
{
	// Token: 0x060000CE RID: 206 RVA: 0x0025E67C File Offset: 0x0025C87C
	protected virtual void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		base.Invalidate();
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0025E698 File Offset: 0x0025C898
	public GClass4()
	{
		base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
		this.Font = new Font("Segoe UI", 8f);
		this.ForeColor = Color.White;
		this.BackColor = Color.Transparent;
		this.Text = this.Text;
	}
}
