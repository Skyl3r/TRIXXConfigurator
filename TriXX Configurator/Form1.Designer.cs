namespace TriXX_Configurator
{
	partial class TRIXXConf
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRIXXConf));
			this.label1 = new System.Windows.Forms.Label();
			this.Label_TRIXXPath = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Button_Load = new System.Windows.Forms.Button();
			this.Button_BrowseDialog = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Label_VDDCOffsetMax = new System.Windows.Forms.Label();
			this.Label_VDDCOffsetMin = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Button_Save = new System.Windows.Forms.Button();
			this.TextBox_MaxOffset = new System.Windows.Forms.TextBox();
			this.TextBox_MinOffset = new System.Windows.Forms.TextBox();
			this.TextBox_MaxMemClock = new System.Windows.Forms.TextBox();
			this.TextBox_MaxGPUClock = new System.Windows.Forms.TextBox();
			this.TextBox_MVVDCDisable = new System.Windows.Forms.TextBox();
			this.TextBox_VDDCIDisable = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "TRIXX Path:";
			// 
			// Label_TRIXXPath
			// 
			this.Label_TRIXXPath.AutoSize = true;
			this.Label_TRIXXPath.Location = new System.Drawing.Point(67, 0);
			this.Label_TRIXXPath.Name = "Label_TRIXXPath";
			this.Label_TRIXXPath.Size = new System.Drawing.Size(12, 13);
			this.Label_TRIXXPath.TabIndex = 1;
			this.Label_TRIXXPath.Text = "\\";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.Button_Load);
			this.panel1.Controls.Add(this.Button_BrowseDialog);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.Label_TRIXXPath);
			this.panel1.Location = new System.Drawing.Point(7, 125);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(341, 57);
			this.panel1.TabIndex = 2;
			// 
			// Button_Load
			// 
			this.Button_Load.Location = new System.Drawing.Point(259, 27);
			this.Button_Load.Name = "Button_Load";
			this.Button_Load.Size = new System.Drawing.Size(75, 23);
			this.Button_Load.TabIndex = 3;
			this.Button_Load.Text = "Load";
			this.Button_Load.UseVisualStyleBackColor = true;
			this.Button_Load.Click += new System.EventHandler(this.Button_Load_Click);
			// 
			// Button_BrowseDialog
			// 
			this.Button_BrowseDialog.Location = new System.Drawing.Point(6, 27);
			this.Button_BrowseDialog.Name = "Button_BrowseDialog";
			this.Button_BrowseDialog.Size = new System.Drawing.Size(75, 23);
			this.Button_BrowseDialog.TabIndex = 2;
			this.Button_BrowseDialog.Text = "Browse";
			this.Button_BrowseDialog.UseVisualStyleBackColor = true;
			this.Button_BrowseDialog.Click += new System.EventHandler(this.Button_BrowseDialog_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.TextBox_VDDCIDisable);
			this.panel2.Controls.Add(this.TextBox_MVVDCDisable);
			this.panel2.Controls.Add(this.TextBox_MaxGPUClock);
			this.panel2.Controls.Add(this.TextBox_MaxMemClock);
			this.panel2.Controls.Add(this.TextBox_MinOffset);
			this.panel2.Controls.Add(this.TextBox_MaxOffset);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.Label_VDDCOffsetMin);
			this.panel2.Controls.Add(this.Label_VDDCOffsetMax);
			this.panel2.Location = new System.Drawing.Point(7, 188);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(341, 171);
			this.panel2.TabIndex = 3;
			// 
			// Label_VDDCOffsetMax
			// 
			this.Label_VDDCOffsetMax.AutoSize = true;
			this.Label_VDDCOffsetMax.Location = new System.Drawing.Point(5, 9);
			this.Label_VDDCOffsetMax.Name = "Label_VDDCOffsetMax";
			this.Label_VDDCOffsetMax.Size = new System.Drawing.Size(100, 13);
			this.Label_VDDCOffsetMax.TabIndex = 0;
			this.Label_VDDCOffsetMax.Text = "Max Voltage Offset:";
			// 
			// Label_VDDCOffsetMin
			// 
			this.Label_VDDCOffsetMin.AutoSize = true;
			this.Label_VDDCOffsetMin.Location = new System.Drawing.Point(5, 35);
			this.Label_VDDCOffsetMin.Name = "Label_VDDCOffsetMin";
			this.Label_VDDCOffsetMin.Size = new System.Drawing.Size(97, 13);
			this.Label_VDDCOffsetMin.TabIndex = 1;
			this.Label_VDDCOffsetMin.Text = "Min Voltage Offset:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Max Memory Clock:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Max GPU Clock:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "MVVDC Disable:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "VDDCI Disable:";
			// 
			// Button_Save
			// 
			this.Button_Save.Location = new System.Drawing.Point(273, 365);
			this.Button_Save.Name = "Button_Save";
			this.Button_Save.Size = new System.Drawing.Size(75, 23);
			this.Button_Save.TabIndex = 4;
			this.Button_Save.Text = "Save Config";
			this.Button_Save.UseVisualStyleBackColor = true;
			this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
			// 
			// TextBox_MaxOffset
			// 
			this.TextBox_MaxOffset.Location = new System.Drawing.Point(261, 6);
			this.TextBox_MaxOffset.Name = "TextBox_MaxOffset";
			this.TextBox_MaxOffset.Size = new System.Drawing.Size(75, 20);
			this.TextBox_MaxOffset.TabIndex = 7;
			this.TextBox_MaxOffset.TextChanged += new System.EventHandler(this.TextBox_MaxOffset_TextChanged);
			// 
			// TextBox_MinOffset
			// 
			this.TextBox_MinOffset.Location = new System.Drawing.Point(261, 32);
			this.TextBox_MinOffset.Name = "TextBox_MinOffset";
			this.TextBox_MinOffset.Size = new System.Drawing.Size(75, 20);
			this.TextBox_MinOffset.TabIndex = 8;
			this.TextBox_MinOffset.TextChanged += new System.EventHandler(this.TextBox_MinOffset_TextChanged);
			// 
			// TextBox_MaxMemClock
			// 
			this.TextBox_MaxMemClock.Location = new System.Drawing.Point(261, 58);
			this.TextBox_MaxMemClock.Name = "TextBox_MaxMemClock";
			this.TextBox_MaxMemClock.Size = new System.Drawing.Size(75, 20);
			this.TextBox_MaxMemClock.TabIndex = 9;
			this.TextBox_MaxMemClock.TextChanged += new System.EventHandler(this.TextBox_MaxMemClock_TextChanged);
			// 
			// TextBox_MaxGPUClock
			// 
			this.TextBox_MaxGPUClock.Location = new System.Drawing.Point(261, 84);
			this.TextBox_MaxGPUClock.Name = "TextBox_MaxGPUClock";
			this.TextBox_MaxGPUClock.Size = new System.Drawing.Size(75, 20);
			this.TextBox_MaxGPUClock.TabIndex = 11;
			this.TextBox_MaxGPUClock.TextChanged += new System.EventHandler(this.TextBox_MaxGPUClock_TextChanged);
			// 
			// TextBox_MVVDCDisable
			// 
			this.TextBox_MVVDCDisable.Location = new System.Drawing.Point(261, 113);
			this.TextBox_MVVDCDisable.Name = "TextBox_MVVDCDisable";
			this.TextBox_MVVDCDisable.Size = new System.Drawing.Size(75, 20);
			this.TextBox_MVVDCDisable.TabIndex = 12;
			this.TextBox_MVVDCDisable.TextChanged += new System.EventHandler(this.TextBox_MVVDCDisable_TextChanged);
			// 
			// TextBox_VDDCIDisable
			// 
			this.TextBox_VDDCIDisable.Location = new System.Drawing.Point(261, 139);
			this.TextBox_VDDCIDisable.Name = "TextBox_VDDCIDisable";
			this.TextBox_VDDCIDisable.Size = new System.Drawing.Size(75, 20);
			this.TextBox_VDDCIDisable.TabIndex = 13;
			this.TextBox_VDDCIDisable.TextChanged += new System.EventHandler(this.TextBox_VDDCIDisable_TextChanged);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Location = new System.Drawing.Point(7, 46);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(341, 73);
			this.panel3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(296, 37);
			this.label3.TabIndex = 0;
			this.label3.Text = "TRIXX Configurator";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(337, 69);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Load your TRIXX.exe from the install directory and edit internal variables below." +
    " This program really works, so you can really damage your cards. Be careful!\r\n-S" +
    "kyl3r @ OC.net";
			// 
			// TRIXXConf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 400);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Button_Save);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TRIXXConf";
			this.Text = "TRIXX Configurator";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Label_TRIXXPath;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Button_BrowseDialog;
		private System.Windows.Forms.Button Button_Load;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label Label_VDDCOffsetMax;
		private System.Windows.Forms.Label Label_VDDCOffsetMin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button Button_Save;
		private System.Windows.Forms.TextBox TextBox_MaxOffset;
		private System.Windows.Forms.TextBox TextBox_VDDCIDisable;
		private System.Windows.Forms.TextBox TextBox_MVVDCDisable;
		private System.Windows.Forms.TextBox TextBox_MaxGPUClock;
		private System.Windows.Forms.TextBox TextBox_MaxMemClock;
		private System.Windows.Forms.TextBox TextBox_MinOffset;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
	}
}

