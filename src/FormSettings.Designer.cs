﻿namespace LEWP.Core
{
    partial class FormSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtImageNumber = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboSat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboStyle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.NumericUpDown();
            this.CheckStartup = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(8, 566);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 88);
            this.panel1.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(234, 13);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 44);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseOnClick);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(62, 13);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 44);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSaveOnClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ComboSat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(8, 276);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(452, 290);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source Settings:";
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(6, 136);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 148);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtImageNumber);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(424, 101);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtImageNumber
            // 
            this.txtImageNumber.Location = new System.Drawing.Point(18, 37);
            this.txtImageNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtImageNumber.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.txtImageNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtImageNumber.Name = "txtImageNumber";
            this.txtImageNumber.Size = new System.Drawing.Size(240, 31);
            this.txtImageNumber.TabIndex = 1;
            this.txtImageNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtImageNumber.ValueChanged += new System.EventHandler(this.OnChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Image Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Source:";
            // 
            // ComboSat
            // 
            this.ComboSat.FormattingEnabled = true;
            this.ComboSat.Items.AddRange(new object[] {
            "Himawari-8",
            "NASA DSCOVR",
            "NASA APOD"});
            this.ComboSat.Location = new System.Drawing.Point(24, 67);
            this.ComboSat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ComboSat.Name = "ComboSat";
            this.ComboSat.Size = new System.Drawing.Size(400, 33);
            this.ComboSat.TabIndex = 8;
            this.ComboSat.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckStartup);
            this.groupBox1.Controls.Add(this.ComboStyle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInterval);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(452, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General:";
            // 
            // ComboStyle
            // 
            this.ComboStyle.FormattingEnabled = true;
            this.ComboStyle.Items.AddRange(new object[] {
            "Fill",
            "Fit"});
            this.ComboStyle.Location = new System.Drawing.Point(24, 140);
            this.ComboStyle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ComboStyle.Name = "ComboStyle";
            this.ComboStyle.Size = new System.Drawing.Size(400, 33);
            this.ComboStyle.TabIndex = 4;
            this.ComboStyle.SelectedIndexChanged += new System.EventHandler(this.OnChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Wallpaper Style:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update every:";
            // 
            // txtInterval
            // 
            this.txtInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtInterval.Location = new System.Drawing.Point(24, 65);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInterval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.txtInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(92, 31);
            this.txtInterval.TabIndex = 0;
            this.txtInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // startup_chk
            // 
            this.CheckStartup.AutoSize = true;
            this.CheckStartup.Location = new System.Drawing.Point(23, 182);
            this.CheckStartup.Name = "startup_chk";
            this.CheckStartup.Size = new System.Drawing.Size(188, 29);
            this.CheckStartup.TabIndex = 5;
            this.CheckStartup.Text = "Run on Startup";
            this.CheckStartup.UseVisualStyleBackColor = true;
            this.CheckStartup.CheckedChanged += new System.EventHandler(this.CheckStartup_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettingsOnLoad);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtInterval;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboSat;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown txtImageNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboStyle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CheckStartup;
    }
}