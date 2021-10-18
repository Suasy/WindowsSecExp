namespace WindowsSecExp
{
    partial class RegeditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegeditForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel = new Sunny.UI.UIPanel();
            this.uitbxCrtKey = new Sunny.UI.UITextBox();
            this.uidgvReg = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uibtnRefrh = new Sunny.UI.UIButton();
            this.uibtnSetVal = new Sunny.UI.UIButton();
            this.uibtnCrtKey = new Sunny.UI.UIButton();
            this.uibtnDelChs = new Sunny.UI.UIButton();
            this.uibtnBack = new Sunny.UI.UIButton();
            this.uilblPath = new Sunny.UI.UILabel();
            this.uiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uidgvReg)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel
            // 
            this.uiPanel.Controls.Add(this.uitbxCrtKey);
            this.uiPanel.Controls.Add(this.uidgvReg);
            this.uiPanel.Controls.Add(this.uibtnRefrh);
            this.uiPanel.Controls.Add(this.uibtnSetVal);
            this.uiPanel.Controls.Add(this.uibtnCrtKey);
            this.uiPanel.Controls.Add(this.uibtnDelChs);
            this.uiPanel.Controls.Add(this.uibtnBack);
            this.uiPanel.Controls.Add(this.uilblPath);
            this.uiPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.uiPanel, "uiPanel");
            this.uiPanel.Name = "uiPanel";
            this.uiPanel.Radius = 10;
            this.uiPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uiPanel.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uitbxCrtKey
            // 
            this.uitbxCrtKey.ButtonSymbol = 61761;
            this.uitbxCrtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxCrtKey.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uitbxCrtKey, "uitbxCrtKey");
            this.uitbxCrtKey.Maximum = 2147483647D;
            this.uitbxCrtKey.Minimum = -2147483648D;
            this.uitbxCrtKey.Name = "uitbxCrtKey";
            this.uitbxCrtKey.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxCrtKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uidgvReg
            // 
            this.uidgvReg.AllowUserToAddRows = false;
            this.uidgvReg.AllowUserToDeleteRows = false;
            this.uidgvReg.AllowUserToResizeColumns = false;
            this.uidgvReg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uidgvReg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uidgvReg.BackgroundColor = System.Drawing.Color.White;
            this.uidgvReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uidgvReg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uidgvReg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uidgvReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.uidgvReg, "uidgvReg");
            this.uidgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uidgvReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uidgvReg.DefaultCellStyle = dataGridViewCellStyle3;
            this.uidgvReg.EnableHeadersVisualStyles = false;
            this.uidgvReg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uidgvReg.MultiSelect = false;
            this.uidgvReg.Name = "uidgvReg";
            this.uidgvReg.ReadOnly = true;
            this.uidgvReg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uidgvReg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uidgvReg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.uidgvReg.RowHeight = 35;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.uidgvReg.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uidgvReg.RowTemplate.Height = 35;
            this.uidgvReg.SelectedIndex = -1;
            this.uidgvReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uidgvReg.ShowRect = false;
            this.uidgvReg.Style = Sunny.UI.UIStyle.Custom;
            this.uidgvReg.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uidgvReg_CellMouseDoubleClick);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // uibtnRefrh
            // 
            this.uibtnRefrh.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.uibtnRefrh, "uibtnRefrh");
            this.uibtnRefrh.Name = "uibtnRefrh";
            this.uibtnRefrh.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnRefrh.Click += new System.EventHandler(this.uibtnRefrh_Click);
            // 
            // uibtnSetVal
            // 
            this.uibtnSetVal.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.uibtnSetVal, "uibtnSetVal");
            this.uibtnSetVal.Name = "uibtnSetVal";
            this.uibtnSetVal.Radius = 10;
            this.uibtnSetVal.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnSetVal.Click += new System.EventHandler(this.uibtnSetVal_Click);
            // 
            // uibtnCrtKey
            // 
            this.uibtnCrtKey.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.uibtnCrtKey, "uibtnCrtKey");
            this.uibtnCrtKey.Name = "uibtnCrtKey";
            this.uibtnCrtKey.Radius = 10;
            this.uibtnCrtKey.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnCrtKey.Click += new System.EventHandler(this.uibtnCrtKey_Click);
            // 
            // uibtnDelChs
            // 
            this.uibtnDelChs.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.uibtnDelChs, "uibtnDelChs");
            this.uibtnDelChs.Name = "uibtnDelChs";
            this.uibtnDelChs.Radius = 10;
            this.uibtnDelChs.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnDelChs.Click += new System.EventHandler(this.uibtnDelChs_Click);
            // 
            // uibtnBack
            // 
            this.uibtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.uibtnBack, "uibtnBack");
            this.uibtnBack.Name = "uibtnBack";
            this.uibtnBack.Radius = 10;
            this.uibtnBack.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnBack.Click += new System.EventHandler(this.uibtnBack_Click);
            // 
            // uilblPath
            // 
            this.uilblPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.uilblPath, "uilblPath");
            this.uilblPath.Name = "uilblPath";
            this.uilblPath.Style = Sunny.UI.UIStyle.Custom;
            // 
            // RegeditForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegeditForm";
            this.uiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uidgvReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel;
        private Sunny.UI.UIButton uibtnSetVal;
        private Sunny.UI.UIButton uibtnCrtKey;
        private Sunny.UI.UIButton uibtnDelChs;
        private Sunny.UI.UIButton uibtnBack;
        private Sunny.UI.UILabel uilblPath;
        private Sunny.UI.UIButton uibtnRefrh;
        private Sunny.UI.UIDataGridView uidgvReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Sunny.UI.UITextBox uitbxCrtKey;
    }
}