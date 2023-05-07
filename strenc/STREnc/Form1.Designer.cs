namespace STREnc
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000021F4 File Offset: 0x000003F4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002214 File Offset: 0x00000414
		private void InitializeComponent()
		{
			this.tbInput = new global::System.Windows.Forms.TextBox();
			this.tbOutput = new global::System.Windows.Forms.TextBox();
			this.btnEncrypt = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.tbInput.Location = new global::System.Drawing.Point(13, 13);
			this.tbInput.Name = "tbInput";
			this.tbInput.Size = new global::System.Drawing.Size(775, 20);
			this.tbInput.TabIndex = 0;
			this.tbOutput.Location = new global::System.Drawing.Point(13, 68);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.ReadOnly = true;
			this.tbOutput.Size = new global::System.Drawing.Size(775, 20);
			this.tbOutput.TabIndex = 1;
			this.btnEncrypt.Location = new global::System.Drawing.Point(13, 39);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new global::System.Drawing.Size(775, 23);
			this.btnEncrypt.TabIndex = 2;
			this.btnEncrypt.Text = "Encrypt";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 97);
			base.Controls.Add(this.btnEncrypt);
			base.Controls.Add(this.tbOutput);
			base.Controls.Add(this.tbInput);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "Form1";
			this.Text = "StrEnc";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.TextBox tbInput;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.TextBox tbOutput;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button btnEncrypt;
	}
}
