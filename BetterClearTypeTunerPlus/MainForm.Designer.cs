namespace BetterClearTypeTunerPlus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblSample1 = new System.Windows.Forms.Label();
            this.panelSmall = new System.Windows.Forms.Panel();
            this.lblSample3 = new System.Windows.Forms.Label();
            this.lblSample2 = new System.Windows.Forms.Label();
            this.pbZoomed = new System.Windows.Forms.PictureBox();
            this.cbFontAntialiasing = new System.Windows.Forms.CheckBox();
            this.rbGrayscale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbBGR = new System.Windows.Forms.RadioButton();
            this.rbRGB = new System.Windows.Forms.RadioButton();
            this.nudContrast = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNotAdmin = new System.Windows.Forms.Label();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.cbDarkmode = new System.Windows.Forms.CheckBox();
            this.status = new System.Windows.Forms.Label();
            this.panelBottomBorder = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelSmall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoomed)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSample1
            // 
            this.lblSample1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblSample1, "lblSample1");
            this.lblSample1.Name = "lblSample1";
            // 
            // panelSmall
            // 
            this.panelSmall.BackColor = System.Drawing.Color.White;
            this.panelSmall.Controls.Add(this.lblSample3);
            this.panelSmall.Controls.Add(this.lblSample2);
            this.panelSmall.Controls.Add(this.lblSample1);
            this.panelSmall.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panelSmall, "panelSmall");
            this.panelSmall.Name = "panelSmall";
            // 
            // lblSample3
            // 
            this.lblSample3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblSample3, "lblSample3");
            this.lblSample3.Name = "lblSample3";
            // 
            // lblSample2
            // 
            this.lblSample2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblSample2, "lblSample2");
            this.lblSample2.Name = "lblSample2";
            // 
            // pbZoomed
            // 
            resources.ApplyResources(this.pbZoomed, "pbZoomed");
            this.pbZoomed.Name = "pbZoomed";
            this.pbZoomed.TabStop = false;
            // 
            // cbFontAntialiasing
            // 
            this.cbFontAntialiasing.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cbFontAntialiasing, "cbFontAntialiasing");
            this.cbFontAntialiasing.Name = "cbFontAntialiasing";
            this.cbFontAntialiasing.UseVisualStyleBackColor = false;
            this.cbFontAntialiasing.CheckedChanged += new System.EventHandler(this.ControlsChanged);
            // 
            // rbGrayscale
            // 
            this.rbGrayscale.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.rbGrayscale, "rbGrayscale");
            this.rbGrayscale.Name = "rbGrayscale";
            this.rbGrayscale.TabStop = true;
            this.rbGrayscale.UseVisualStyleBackColor = false;
            this.rbGrayscale.CheckedChanged += new System.EventHandler(this.ControlsChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBGR);
            this.panel1.Controls.Add(this.rbRGB);
            this.panel1.Controls.Add(this.rbGrayscale);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // rbBGR
            // 
            this.rbBGR.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.rbBGR, "rbBGR");
            this.rbBGR.Name = "rbBGR";
            this.rbBGR.TabStop = true;
            this.rbBGR.UseVisualStyleBackColor = false;
            this.rbBGR.CheckedChanged += new System.EventHandler(this.ControlsChanged);
            // 
            // rbRGB
            // 
            this.rbRGB.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.rbRGB, "rbRGB");
            this.rbRGB.Name = "rbRGB";
            this.rbRGB.TabStop = true;
            this.rbRGB.UseVisualStyleBackColor = false;
            this.rbRGB.CheckedChanged += new System.EventHandler(this.ControlsChanged);
            // 
            // nudContrast
            // 
            this.nudContrast.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.nudContrast, "nudContrast");
            this.nudContrast.ForeColor = System.Drawing.Color.Black;
            this.nudContrast.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudContrast.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nudContrast.Name = "nudContrast";
            this.nudContrast.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nudContrast.ValueChanged += new System.EventHandler(this.ControlsChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnRestoreDefaults
            // 
            resources.ApplyResources(this.btnRestoreDefaults, "btnRestoreDefaults");
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.toolTip1.SetToolTip(this.btnRestoreDefaults, resources.GetString("btnRestoreDefaults.ToolTip"));
            this.btnRestoreDefaults.UseVisualStyleBackColor = true;
            this.btnRestoreDefaults.Click += new System.EventHandler(this.BtnRestoreDefaults_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btnSet
            // 
            resources.ApplyResources(this.btnSet, "btnSet");
            this.btnSet.Name = "btnSet";
            this.toolTip1.SetToolTip(this.btnSet, resources.GetString("btnSet.ToolTip"));
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.ControlsChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblNotAdmin
            // 
            this.lblNotAdmin.BackColor = System.Drawing.Color.White;
            this.lblNotAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblNotAdmin, "lblNotAdmin");
            this.lblNotAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblNotAdmin.Name = "lblNotAdmin";
            // 
            // btnChangeFont
            // 
            resources.ApplyResources(this.btnChangeFont, "btnChangeFont");
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            // 
            // cbDarkmode
            // 
            this.cbDarkmode.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cbDarkmode, "cbDarkmode");
            this.cbDarkmode.Name = "cbDarkmode";
            this.cbDarkmode.UseVisualStyleBackColor = false;
            this.cbDarkmode.CheckedChanged += new System.EventHandler(this.cbDarkmode_CheckedChanged);
            // 
            // status
            // 
            resources.ApplyResources(this.status, "status");
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Name = "status";
            // 
            // panelBottomBorder
            // 
            this.panelBottomBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.panelBottomBorder, "panelBottomBorder");
            this.panelBottomBorder.Name = "panelBottomBorder";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.status);
            this.Controls.Add(this.panelBottomBorder);
            this.Controls.Add(this.cbDarkmode);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.lblNotAdmin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRestoreDefaults);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudContrast);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbFontAntialiasing);
            this.Controls.Add(this.pbZoomed);
            this.Controls.Add(this.panelSmall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DpiChanged += new System.Windows.Forms.DpiChangedEventHandler(this.MainForm_DpiChanged);
            this.panelSmall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbZoomed)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudContrast)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblSample1;
		private System.Windows.Forms.Panel panelSmall;
		private System.Windows.Forms.Label lblSample3;
		private System.Windows.Forms.Label lblSample2;
		private System.Windows.Forms.PictureBox pbZoomed;
		private System.Windows.Forms.CheckBox cbFontAntialiasing;
		private System.Windows.Forms.RadioButton rbGrayscale;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbBGR;
		private System.Windows.Forms.RadioButton rbRGB;
		private System.Windows.Forms.NumericUpDown nudContrast;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnRestoreDefaults;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblNotAdmin;
		private System.Windows.Forms.Button btnChangeFont;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.CheckBox cbDarkmode;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Panel panelBottomBorder;
		private System.Windows.Forms.Label label8;
	}
}

