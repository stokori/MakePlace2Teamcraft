﻿namespace MakePlace2Teamcraft
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpItemsEdit = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.updItemCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboItemList = new System.Windows.Forms.ComboBox();
            this.grpExport = new System.Windows.Forms.GroupBox();
            this.btnExportTeamCraft = new System.Windows.Forms.Button();
            this.grpDyesEdit = new System.Windows.Forms.GroupBox();
            this.btnSaveDye = new System.Windows.Forms.Button();
            this.updDyeCount = new System.Windows.Forms.NumericUpDown();
            this.lblDyeAmount = new System.Windows.Forms.Label();
            this.lblDye = new System.Windows.Forms.Label();
            this.cboDyes = new System.Windows.Forms.ComboBox();
            this.grpDyes = new System.Windows.Forms.GroupBox();
            this.txtDyes = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpItemsEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updItemCount)).BeginInit();
            this.grpExport.SuspendLayout();
            this.grpDyesEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updDyeCount)).BeginInit();
            this.grpDyes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLoadFile,
            this.menuItemCloseFile,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "File";
            // 
            // menuItemLoadFile
            // 
            this.menuItemLoadFile.Name = "menuItemLoadFile";
            this.menuItemLoadFile.Size = new System.Drawing.Size(184, 22);
            this.menuItemLoadFile.Text = "Load MakePlace File";
            this.menuItemLoadFile.Click += new System.EventHandler(this.menuItemLoadFile_Click);
            // 
            // menuItemCloseFile
            // 
            this.menuItemCloseFile.Name = "menuItemCloseFile";
            this.menuItemCloseFile.Size = new System.Drawing.Size(184, 22);
            this.menuItemCloseFile.Text = "Close MakePlace File";
            this.menuItemCloseFile.Click += new System.EventHandler(this.menuItemCloseFile_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(184, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 19);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(313, 157);
            this.txtOutput.TabIndex = 2;
            // 
            // grpItemsEdit
            // 
            this.grpItemsEdit.Controls.Add(this.btnSave);
            this.grpItemsEdit.Controls.Add(this.updItemCount);
            this.grpItemsEdit.Controls.Add(this.label2);
            this.grpItemsEdit.Controls.Add(this.label1);
            this.grpItemsEdit.Controls.Add(this.cboItemList);
            this.grpItemsEdit.Location = new System.Drawing.Point(343, 27);
            this.grpItemsEdit.Name = "grpItemsEdit";
            this.grpItemsEdit.Size = new System.Drawing.Size(284, 110);
            this.grpItemsEdit.TabIndex = 4;
            this.grpItemsEdit.TabStop = false;
            this.grpItemsEdit.Text = "Edit Items";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(9, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // updItemCount
            // 
            this.updItemCount.Location = new System.Drawing.Point(58, 46);
            this.updItemCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updItemCount.Name = "updItemCount";
            this.updItemCount.ReadOnly = true;
            this.updItemCount.Size = new System.Drawing.Size(120, 20);
            this.updItemCount.TabIndex = 3;
            this.updItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item:";
            // 
            // cboItemList
            // 
            this.cboItemList.FormattingEnabled = true;
            this.cboItemList.Location = new System.Drawing.Point(58, 19);
            this.cboItemList.Name = "cboItemList";
            this.cboItemList.Size = new System.Drawing.Size(194, 21);
            this.cboItemList.TabIndex = 0;
            this.cboItemList.SelectedIndexChanged += new System.EventHandler(this.cboItemList_SelectedIndexChanged);
            // 
            // grpExport
            // 
            this.grpExport.Controls.Add(this.btnExportTeamCraft);
            this.grpExport.Location = new System.Drawing.Point(343, 259);
            this.grpExport.Name = "grpExport";
            this.grpExport.Size = new System.Drawing.Size(283, 84);
            this.grpExport.TabIndex = 5;
            this.grpExport.TabStop = false;
            this.grpExport.Text = "Export";
            // 
            // btnExportTeamCraft
            // 
            this.btnExportTeamCraft.Enabled = false;
            this.btnExportTeamCraft.Location = new System.Drawing.Point(58, 30);
            this.btnExportTeamCraft.Name = "btnExportTeamCraft";
            this.btnExportTeamCraft.Size = new System.Drawing.Size(160, 30);
            this.btnExportTeamCraft.TabIndex = 0;
            this.btnExportTeamCraft.Text = "Export to TeamCraft";
            this.btnExportTeamCraft.UseVisualStyleBackColor = true;
            this.btnExportTeamCraft.Click += new System.EventHandler(this.btnExportTeamCraft_Click);
            // 
            // grpDyesEdit
            // 
            this.grpDyesEdit.Controls.Add(this.btnSaveDye);
            this.grpDyesEdit.Controls.Add(this.updDyeCount);
            this.grpDyesEdit.Controls.Add(this.lblDyeAmount);
            this.grpDyesEdit.Controls.Add(this.lblDye);
            this.grpDyesEdit.Controls.Add(this.cboDyes);
            this.grpDyesEdit.Location = new System.Drawing.Point(343, 143);
            this.grpDyesEdit.Name = "grpDyesEdit";
            this.grpDyesEdit.Size = new System.Drawing.Size(284, 110);
            this.grpDyesEdit.TabIndex = 5;
            this.grpDyesEdit.TabStop = false;
            this.grpDyesEdit.Text = "Edit Dyes";
            // 
            // btnSaveDye
            // 
            this.btnSaveDye.Enabled = false;
            this.btnSaveDye.Location = new System.Drawing.Point(9, 77);
            this.btnSaveDye.Name = "btnSaveDye";
            this.btnSaveDye.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDye.TabIndex = 4;
            this.btnSaveDye.Text = "Save";
            this.btnSaveDye.UseVisualStyleBackColor = true;
            this.btnSaveDye.Click += new System.EventHandler(this.btnSaveDye_Click);
            // 
            // updDyeCount
            // 
            this.updDyeCount.Location = new System.Drawing.Point(58, 46);
            this.updDyeCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updDyeCount.Name = "updDyeCount";
            this.updDyeCount.ReadOnly = true;
            this.updDyeCount.Size = new System.Drawing.Size(120, 20);
            this.updDyeCount.TabIndex = 3;
            this.updDyeCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDyeAmount
            // 
            this.lblDyeAmount.AutoSize = true;
            this.lblDyeAmount.Location = new System.Drawing.Point(6, 48);
            this.lblDyeAmount.Name = "lblDyeAmount";
            this.lblDyeAmount.Size = new System.Drawing.Size(46, 13);
            this.lblDyeAmount.TabIndex = 2;
            this.lblDyeAmount.Text = "Amount:";
            // 
            // lblDye
            // 
            this.lblDye.AutoSize = true;
            this.lblDye.Location = new System.Drawing.Point(22, 22);
            this.lblDye.Name = "lblDye";
            this.lblDye.Size = new System.Drawing.Size(29, 13);
            this.lblDye.TabIndex = 1;
            this.lblDye.Text = "Dye:";
            // 
            // cboDyes
            // 
            this.cboDyes.FormattingEnabled = true;
            this.cboDyes.Location = new System.Drawing.Point(58, 19);
            this.cboDyes.Name = "cboDyes";
            this.cboDyes.Size = new System.Drawing.Size(194, 21);
            this.cboDyes.TabIndex = 0;
            this.cboDyes.SelectedIndexChanged += new System.EventHandler(this.cboDyes_SelectedIndexChanged);
            // 
            // grpDyes
            // 
            this.grpDyes.Controls.Add(this.txtDyes);
            this.grpDyes.Location = new System.Drawing.Point(12, 215);
            this.grpDyes.Name = "grpDyes";
            this.grpDyes.Size = new System.Drawing.Size(325, 128);
            this.grpDyes.TabIndex = 4;
            this.grpDyes.TabStop = false;
            this.grpDyes.Text = "Dyes";
            // 
            // txtDyes
            // 
            this.txtDyes.Location = new System.Drawing.Point(6, 19);
            this.txtDyes.Multiline = true;
            this.txtDyes.Name = "txtDyes";
            this.txtDyes.ReadOnly = true;
            this.txtDyes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDyes.Size = new System.Drawing.Size(313, 103);
            this.txtDyes.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 356);
            this.Controls.Add(this.grpDyes);
            this.Controls.Add(this.grpDyesEdit);
            this.Controls.Add(this.grpExport);
            this.Controls.Add(this.grpItemsEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MakePlace 2 Teamcraft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpItemsEdit.ResumeLayout(false);
            this.grpItemsEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updItemCount)).EndInit();
            this.grpExport.ResumeLayout(false);
            this.grpDyesEdit.ResumeLayout(false);
            this.grpDyesEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updDyeCount)).EndInit();
            this.grpDyes.ResumeLayout(false);
            this.grpDyes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoadFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemCloseFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox grpItemsEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown updItemCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboItemList;
        private System.Windows.Forms.GroupBox grpExport;
        private System.Windows.Forms.Button btnExportTeamCraft;
        private System.Windows.Forms.GroupBox grpDyesEdit;
        private System.Windows.Forms.Button btnSaveDye;
        private System.Windows.Forms.NumericUpDown updDyeCount;
        private System.Windows.Forms.Label lblDyeAmount;
        private System.Windows.Forms.Label lblDye;
        private System.Windows.Forms.ComboBox cboDyes;
        private System.Windows.Forms.GroupBox grpDyes;
        private System.Windows.Forms.TextBox txtDyes;
    }
}

