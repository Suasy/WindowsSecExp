namespace WindowsSecExp
{
    partial class FileMgtForm
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
            this.uiPanel = new Sunny.UI.UIPanel();
            this.uicbxNewLine = new Sunny.UI.UICheckBox();
            this.uitbxDst = new Sunny.UI.UITextBox();
            this.uitbxDir = new Sunny.UI.UITextBox();
            this.uibtnRefrh = new Sunny.UI.UIButton();
            this.uibtnChsDst = new Sunny.UI.UIButton();
            this.uibtnExport = new Sunny.UI.UIButton();
            this.uibtnMerge = new Sunny.UI.UIButton();
            this.uitbxResult = new Sunny.UI.UITextBox();
            this.uibtnOpenFile = new Sunny.UI.UIButton();
            this.uibtnDown = new Sunny.UI.UIButton();
            this.uibtnUp = new Sunny.UI.UIButton();
            this.uilbxDst = new Sunny.UI.UIListBox();
            this.uibtnClear = new Sunny.UI.UIButton();
            this.uibtnAdd = new Sunny.UI.UIButton();
            this.uilbxSrc = new Sunny.UI.UIListBox();
            this.uibtnChsDir = new Sunny.UI.UIButton();
            this.uiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel
            // 
            this.uiPanel.Controls.Add(this.uicbxNewLine);
            this.uiPanel.Controls.Add(this.uitbxDst);
            this.uiPanel.Controls.Add(this.uitbxDir);
            this.uiPanel.Controls.Add(this.uibtnRefrh);
            this.uiPanel.Controls.Add(this.uibtnChsDst);
            this.uiPanel.Controls.Add(this.uibtnExport);
            this.uiPanel.Controls.Add(this.uibtnMerge);
            this.uiPanel.Controls.Add(this.uitbxResult);
            this.uiPanel.Controls.Add(this.uibtnOpenFile);
            this.uiPanel.Controls.Add(this.uibtnDown);
            this.uiPanel.Controls.Add(this.uibtnUp);
            this.uiPanel.Controls.Add(this.uilbxDst);
            this.uiPanel.Controls.Add(this.uibtnClear);
            this.uiPanel.Controls.Add(this.uibtnAdd);
            this.uiPanel.Controls.Add(this.uilbxSrc);
            this.uiPanel.Controls.Add(this.uibtnChsDir);
            this.uiPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uiPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel.Location = new System.Drawing.Point(0, 0);
            this.uiPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel.Name = "uiPanel";
            this.uiPanel.Radius = 0;
            this.uiPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uiPanel.Size = new System.Drawing.Size(872, 509);
            this.uiPanel.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel.TabIndex = 0;
            this.uiPanel.Text = null;
            this.uiPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uicbxNewLine
            // 
            this.uicbxNewLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uicbxNewLine.Checked = true;
            this.uicbxNewLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uicbxNewLine.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uicbxNewLine.Location = new System.Drawing.Point(430, 456);
            this.uicbxNewLine.MinimumSize = new System.Drawing.Size(1, 1);
            this.uicbxNewLine.Name = "uicbxNewLine";
            this.uicbxNewLine.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uicbxNewLine.Size = new System.Drawing.Size(150, 29);
            this.uicbxNewLine.Style = Sunny.UI.UIStyle.Custom;
            this.uicbxNewLine.TabIndex = 16;
            this.uicbxNewLine.Text = "是否换行";
            // 
            // uitbxDst
            // 
            this.uitbxDst.ButtonSymbol = 61761;
            this.uitbxDst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxDst.FillColor = System.Drawing.Color.White;
            this.uitbxDst.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxDst.Location = new System.Drawing.Point(430, 18);
            this.uitbxDst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxDst.Maximum = 2147483647D;
            this.uitbxDst.Minimum = -2147483648D;
            this.uitbxDst.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxDst.Name = "uitbxDst";
            this.uitbxDst.Size = new System.Drawing.Size(247, 35);
            this.uitbxDst.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxDst.TabIndex = 15;
            this.uitbxDst.Text = "请设置目标文件名";
            this.uitbxDst.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uitbxDir
            // 
            this.uitbxDir.ButtonSymbol = 61761;
            this.uitbxDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxDir.FillColor = System.Drawing.Color.White;
            this.uitbxDir.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxDir.Location = new System.Drawing.Point(11, 18);
            this.uitbxDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxDir.Maximum = 2147483647D;
            this.uitbxDir.Minimum = -2147483648D;
            this.uitbxDir.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxDir.Name = "uitbxDir";
            this.uitbxDir.Size = new System.Drawing.Size(247, 35);
            this.uitbxDir.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxDir.TabIndex = 14;
            this.uitbxDir.Text = "请选择文件目录";
            this.uitbxDir.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uibtnRefrh
            // 
            this.uibtnRefrh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnRefrh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnRefrh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnRefrh.Location = new System.Drawing.Point(11, 235);
            this.uibtnRefrh.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnRefrh.Name = "uibtnRefrh";
            this.uibtnRefrh.Radius = 10;
            this.uibtnRefrh.Size = new System.Drawing.Size(100, 35);
            this.uibtnRefrh.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnRefrh.TabIndex = 13;
            this.uibtnRefrh.Text = "刷  新";
            this.uibtnRefrh.Click += new System.EventHandler(this.uibtnRefrh_Click);
            // 
            // uibtnChsDst
            // 
            this.uibtnChsDst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnChsDst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnChsDst.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnChsDst.Location = new System.Drawing.Point(736, 18);
            this.uibtnChsDst.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnChsDst.Name = "uibtnChsDst";
            this.uibtnChsDst.Radius = 10;
            this.uibtnChsDst.Size = new System.Drawing.Size(123, 35);
            this.uibtnChsDst.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnChsDst.TabIndex = 11;
            this.uibtnChsDst.Text = "目标文件名";
            this.uibtnChsDst.Click += new System.EventHandler(this.uibtnDstFile_Click);
            // 
            // uibtnExport
            // 
            this.uibtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnExport.Location = new System.Drawing.Point(759, 452);
            this.uibtnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnExport.Name = "uibtnExport";
            this.uibtnExport.Radius = 10;
            this.uibtnExport.Size = new System.Drawing.Size(100, 35);
            this.uibtnExport.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnExport.TabIndex = 10;
            this.uibtnExport.Text = "导  出";
            this.uibtnExport.Click += new System.EventHandler(this.uibtnExport_Click);
            // 
            // uibtnMerge
            // 
            this.uibtnMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnMerge.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnMerge.Location = new System.Drawing.Point(586, 452);
            this.uibtnMerge.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnMerge.Name = "uibtnMerge";
            this.uibtnMerge.Radius = 10;
            this.uibtnMerge.Size = new System.Drawing.Size(100, 35);
            this.uibtnMerge.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnMerge.TabIndex = 9;
            this.uibtnMerge.Text = "合  并";
            this.uibtnMerge.Click += new System.EventHandler(this.uibtnMerge_Click);
            // 
            // uitbxResult
            // 
            this.uitbxResult.ButtonSymbol = 61761;
            this.uitbxResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxResult.FillColor = System.Drawing.Color.White;
            this.uitbxResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxResult.Location = new System.Drawing.Point(430, 61);
            this.uitbxResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxResult.Maximum = 2147483647D;
            this.uitbxResult.Minimum = -2147483648D;
            this.uitbxResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxResult.Multiline = true;
            this.uitbxResult.Name = "uitbxResult";
            this.uitbxResult.Size = new System.Drawing.Size(429, 383);
            this.uitbxResult.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxResult.TabIndex = 8;
            this.uitbxResult.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uibtnOpenFile
            // 
            this.uibtnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnOpenFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnOpenFile.Location = new System.Drawing.Point(301, 452);
            this.uibtnOpenFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnOpenFile.Name = "uibtnOpenFile";
            this.uibtnOpenFile.Radius = 10;
            this.uibtnOpenFile.Size = new System.Drawing.Size(100, 35);
            this.uibtnOpenFile.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnOpenFile.TabIndex = 7;
            this.uibtnOpenFile.Text = "打开文件";
            this.uibtnOpenFile.Click += new System.EventHandler(this.uibtnOpenFile_Click);
            // 
            // uibtnDown
            // 
            this.uibtnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnDown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnDown.Location = new System.Drawing.Point(158, 452);
            this.uibtnDown.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnDown.Name = "uibtnDown";
            this.uibtnDown.Radius = 10;
            this.uibtnDown.Size = new System.Drawing.Size(100, 35);
            this.uibtnDown.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnDown.TabIndex = 6;
            this.uibtnDown.Text = "下  移";
            this.uibtnDown.Click += new System.EventHandler(this.uibtnDown_Click);
            // 
            // uibtnUp
            // 
            this.uibtnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnUp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnUp.Location = new System.Drawing.Point(11, 452);
            this.uibtnUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnUp.Name = "uibtnUp";
            this.uibtnUp.Radius = 10;
            this.uibtnUp.Size = new System.Drawing.Size(100, 35);
            this.uibtnUp.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnUp.TabIndex = 5;
            this.uibtnUp.Text = "上  移";
            this.uibtnUp.Click += new System.EventHandler(this.uibtnUp_Click);
            // 
            // uilbxDst
            // 
            this.uilbxDst.FillColor = System.Drawing.Color.White;
            this.uilbxDst.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uilbxDst.FormatString = "";
            this.uilbxDst.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilbxDst.Location = new System.Drawing.Point(11, 278);
            this.uilbxDst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilbxDst.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilbxDst.Name = "uilbxDst";
            this.uilbxDst.Padding = new System.Windows.Forms.Padding(2);
            this.uilbxDst.Size = new System.Drawing.Size(390, 166);
            this.uilbxDst.Style = Sunny.UI.UIStyle.Custom;
            this.uilbxDst.TabIndex = 3;
            this.uilbxDst.Text = "uiListBox2";
            // 
            // uibtnClear
            // 
            this.uibtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnClear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnClear.Location = new System.Drawing.Point(301, 235);
            this.uibtnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnClear.Name = "uibtnClear";
            this.uibtnClear.Radius = 10;
            this.uibtnClear.Size = new System.Drawing.Size(100, 35);
            this.uibtnClear.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnClear.TabIndex = 4;
            this.uibtnClear.Text = "清  空";
            this.uibtnClear.Click += new System.EventHandler(this.uibtnClear_Click);
            // 
            // uibtnAdd
            // 
            this.uibtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnAdd.Location = new System.Drawing.Point(158, 235);
            this.uibtnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnAdd.Name = "uibtnAdd";
            this.uibtnAdd.Radius = 10;
            this.uibtnAdd.Size = new System.Drawing.Size(100, 35);
            this.uibtnAdd.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnAdd.TabIndex = 3;
            this.uibtnAdd.Text = "添  加";
            this.uibtnAdd.Click += new System.EventHandler(this.uibtnAdd_Click);
            // 
            // uilbxSrc
            // 
            this.uilbxSrc.FillColor = System.Drawing.Color.White;
            this.uilbxSrc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uilbxSrc.FormatString = "";
            this.uilbxSrc.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uilbxSrc.Location = new System.Drawing.Point(11, 61);
            this.uilbxSrc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uilbxSrc.MinimumSize = new System.Drawing.Size(1, 1);
            this.uilbxSrc.Name = "uilbxSrc";
            this.uilbxSrc.Padding = new System.Windows.Forms.Padding(2);
            this.uilbxSrc.Size = new System.Drawing.Size(390, 166);
            this.uilbxSrc.Style = Sunny.UI.UIStyle.Custom;
            this.uilbxSrc.TabIndex = 2;
            this.uilbxSrc.Text = "uiListBox1";
            // 
            // uibtnChsDir
            // 
            this.uibtnChsDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnChsDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnChsDir.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnChsDir.Location = new System.Drawing.Point(278, 18);
            this.uibtnChsDir.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnChsDir.Name = "uibtnChsDir";
            this.uibtnChsDir.Radius = 10;
            this.uibtnChsDir.Size = new System.Drawing.Size(123, 35);
            this.uibtnChsDir.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnChsDir.TabIndex = 0;
            this.uibtnChsDir.Text = "选择文件目录";
            this.uibtnChsDir.Click += new System.EventHandler(this.uibtnChsDir_Click);
            // 
            // FileMgtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 509);
            this.Controls.Add(this.uiPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileMgtForm";
            this.Text = "FileMgtForm";
            this.uiPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel;
        private Sunny.UI.UIListBox uilbxSrc;
        private Sunny.UI.UIButton uibtnChsDir;
        private Sunny.UI.UIButton uibtnOpenFile;
        private Sunny.UI.UIButton uibtnDown;
        private Sunny.UI.UIButton uibtnUp;
        private Sunny.UI.UIListBox uilbxDst;
        private Sunny.UI.UIButton uibtnClear;
        private Sunny.UI.UIButton uibtnAdd;
        private Sunny.UI.UITextBox uitbxResult;
        private Sunny.UI.UIButton uibtnChsDst;
        private Sunny.UI.UIButton uibtnExport;
        private Sunny.UI.UIButton uibtnMerge;
        private Sunny.UI.UIButton uibtnRefrh;
        private Sunny.UI.UITextBox uitbxDir;
        private Sunny.UI.UITextBox uitbxDst;
        private Sunny.UI.UICheckBox uicbxNewLine;
    }
}