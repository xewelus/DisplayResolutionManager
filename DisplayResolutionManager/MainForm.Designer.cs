
namespace DisplayResolutionManager
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnProfile1920_60 = new System.Windows.Forms.Button();
			this.btnProfile1920_144 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCurrent = new System.Windows.Forms.Label();
			this.btnProfile2560_144 = new System.Windows.Forms.Button();
			this.btnProfile2560_60 = new System.Windows.Forms.Button();
			this.btnProfile3840_60 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnProfile1920_60
			// 
			this.btnProfile1920_60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnProfile1920_60.Location = new System.Drawing.Point(15, 37);
			this.btnProfile1920_60.Name = "btnProfile1920_60";
			this.btnProfile1920_60.Size = new System.Drawing.Size(165, 25);
			this.btnProfile1920_60.TabIndex = 0;
			this.btnProfile1920_60.Text = "1920 x 1080 (60 Гц)";
			this.btnProfile1920_60.UseVisualStyleBackColor = true;
			this.btnProfile1920_60.Click += new System.EventHandler(this.btnProfile1920_60_Click);
			// 
			// btnProfile1920_144
			// 
			this.btnProfile1920_144.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnProfile1920_144.Location = new System.Drawing.Point(196, 37);
			this.btnProfile1920_144.Name = "btnProfile1920_144";
			this.btnProfile1920_144.Size = new System.Drawing.Size(165, 25);
			this.btnProfile1920_144.TabIndex = 1;
			this.btnProfile1920_144.Text = "1920 x 1080 (144 Гц)";
			this.btnProfile1920_144.UseVisualStyleBackColor = true;
			this.btnProfile1920_144.Click += new System.EventHandler(this.btnProfile1920_144_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Текущее:";
			// 
			// lblCurrent
			// 
			this.lblCurrent.AutoSize = true;
			this.lblCurrent.ForeColor = System.Drawing.Color.DimGray;
			this.lblCurrent.Location = new System.Drawing.Point(73, 9);
			this.lblCurrent.Name = "lblCurrent";
			this.lblCurrent.Size = new System.Drawing.Size(10, 13);
			this.lblCurrent.TabIndex = 3;
			this.lblCurrent.Text = "-";
			// 
			// btnProfile2560_144
			// 
			this.btnProfile2560_144.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnProfile2560_144.Location = new System.Drawing.Point(196, 68);
			this.btnProfile2560_144.Name = "btnProfile2560_144";
			this.btnProfile2560_144.Size = new System.Drawing.Size(165, 25);
			this.btnProfile2560_144.TabIndex = 5;
			this.btnProfile2560_144.Text = "2560 x 1440 (144 Гц)";
			this.btnProfile2560_144.UseVisualStyleBackColor = true;
			this.btnProfile2560_144.Click += new System.EventHandler(this.btnProfile2560_144_Click);
			// 
			// btnProfile2560_60
			// 
			this.btnProfile2560_60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnProfile2560_60.Location = new System.Drawing.Point(15, 68);
			this.btnProfile2560_60.Name = "btnProfile2560_60";
			this.btnProfile2560_60.Size = new System.Drawing.Size(165, 25);
			this.btnProfile2560_60.TabIndex = 4;
			this.btnProfile2560_60.Text = "2560 x 1440 (60 Гц)";
			this.btnProfile2560_60.UseVisualStyleBackColor = true;
			this.btnProfile2560_60.Click += new System.EventHandler(this.btnProfile2560_60_Click);
			// 
			// btnProfile3840_60
			// 
			this.btnProfile3840_60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnProfile3840_60.Location = new System.Drawing.Point(15, 99);
			this.btnProfile3840_60.Name = "btnProfile3840_60";
			this.btnProfile3840_60.Size = new System.Drawing.Size(165, 25);
			this.btnProfile3840_60.TabIndex = 6;
			this.btnProfile3840_60.Text = "3840 х 2160 (60 Гц)";
			this.btnProfile3840_60.UseVisualStyleBackColor = true;
			this.btnProfile3840_60.Click += new System.EventHandler(this.btnProfile3840_60_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Location = new System.Drawing.Point(4, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(371, 4);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Location = new System.Drawing.Point(4, 131);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(371, 4);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(267, 140);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(108, 24);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 168);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnProfile3840_60);
			this.Controls.Add(this.btnProfile2560_144);
			this.Controls.Add(this.btnProfile2560_60);
			this.Controls.Add(this.lblCurrent);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnProfile1920_144);
			this.Controls.Add(this.btnProfile1920_60);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Разрешение экрана";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnProfile1920_60;
		private System.Windows.Forms.Button btnProfile1920_144;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCurrent;
		private System.Windows.Forms.Button btnProfile2560_144;
		private System.Windows.Forms.Button btnProfile2560_60;
		private System.Windows.Forms.Button btnProfile3840_60;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnClose;
	}
}

