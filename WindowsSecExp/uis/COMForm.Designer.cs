namespace WindowsSecExp
{
    partial class COMForm
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
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uibtnCOMFact = new Sunny.UI.UIButton();
            this.uitbxCOMFactRslt = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uitbxCOMFact = new Sunny.UI.UITextBox();
            this.uibtnCOMSplt = new Sunny.UI.UIButton();
            this.uitbxCOMSpltRslt = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uitbxCOMSplt = new Sunny.UI.UITextBox();
            this.uiPanel.SuspendLayout();
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel
            // 
            this.uiPanel.Controls.Add(this.uiTabControlMenu1);
            this.uiPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uiPanel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel.Location = new System.Drawing.Point(0, 0);
            this.uiPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel.Name = "uiPanel";
            this.uiPanel.Radius = 0;
            this.uiPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uiPanel.Size = new System.Drawing.Size(872, 509);
            this.uiPanel.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel.TabIndex = 1;
            this.uiPanel.Text = null;
            this.uiPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Controls.Add(this.tabPage2);
            this.uiTabControlMenu1.Controls.Add(this.tabPage3);
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(60, 150);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(872, 509);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControlMenu1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiTabControlMenu1.TabIndex = 1;
            this.uiTabControlMenu1.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uiTabControlMenu1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.tabPage1.Controls.Add(this.uibtnCOMSplt);
            this.tabPage1.Controls.Add(this.uitbxCOMSpltRslt);
            this.tabPage1.Controls.Add(this.uiLabel10);
            this.tabPage1.Controls.Add(this.uiLabel11);
            this.tabPage1.Controls.Add(this.uitbxCOMSplt);
            this.tabPage1.Controls.Add(this.uibtnCOMFact);
            this.tabPage1.Controls.Add(this.uitbxCOMFactRslt);
            this.tabPage1.Controls.Add(this.uiLabel3);
            this.tabPage1.Controls.Add(this.uiLabel2);
            this.tabPage1.Controls.Add(this.uitbxCOMFact);
            this.tabPage1.Location = new System.Drawing.Point(151, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(721, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "自定义COM";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.tabPage2.Location = new System.Drawing.Point(151, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(721, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WordCOM";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.tabPage3.Location = new System.Drawing.Point(151, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(721, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ExcelCOM";
            // 
            // uibtnCOMFact
            // 
            this.uibtnCOMFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnCOMFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnCOMFact.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnCOMFact.Location = new System.Drawing.Point(569, 103);
            this.uibtnCOMFact.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnCOMFact.Name = "uibtnCOMFact";
            this.uibtnCOMFact.Radius = 10;
            this.uibtnCOMFact.Size = new System.Drawing.Size(100, 35);
            this.uibtnCOMFact.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnCOMFact.TabIndex = 27;
            this.uibtnCOMFact.Text = "调  用";
            this.uibtnCOMFact.Click += new System.EventHandler(this.uibtnCOMFact_Click);
            // 
            // uitbxCOMFactRslt
            // 
            this.uitbxCOMFactRslt.ButtonSymbol = 61761;
            this.uitbxCOMFactRslt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxCOMFactRslt.FillColor = System.Drawing.Color.White;
            this.uitbxCOMFactRslt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxCOMFactRslt.Location = new System.Drawing.Point(357, 103);
            this.uitbxCOMFactRslt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxCOMFactRslt.Maximum = 2147483647D;
            this.uitbxCOMFactRslt.Minimum = -2147483648D;
            this.uitbxCOMFactRslt.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxCOMFactRslt.Name = "uitbxCOMFactRslt";
            this.uitbxCOMFactRslt.Size = new System.Drawing.Size(180, 35);
            this.uitbxCOMFactRslt.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxCOMFactRslt.TabIndex = 23;
            this.uitbxCOMFactRslt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(308, 108);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(20, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 26;
            this.uiLabel3.Text = "=";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(90, 108);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(50, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 25;
            this.uiLabel2.Text = "阶乘";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uitbxCOMFact
            // 
            this.uitbxCOMFact.ButtonSymbol = 61761;
            this.uitbxCOMFact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxCOMFact.FillColor = System.Drawing.Color.White;
            this.uitbxCOMFact.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxCOMFact.Location = new System.Drawing.Point(169, 103);
            this.uitbxCOMFact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxCOMFact.Maximum = 2147483647D;
            this.uitbxCOMFact.Minimum = -2147483648D;
            this.uitbxCOMFact.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxCOMFact.Name = "uitbxCOMFact";
            this.uitbxCOMFact.Size = new System.Drawing.Size(115, 35);
            this.uitbxCOMFact.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxCOMFact.TabIndex = 21;
            this.uitbxCOMFact.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uibtnCOMSplt
            // 
            this.uibtnCOMSplt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.uibtnCOMSplt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnCOMSplt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uibtnCOMSplt.Location = new System.Drawing.Point(569, 166);
            this.uibtnCOMSplt.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnCOMSplt.Name = "uibtnCOMSplt";
            this.uibtnCOMSplt.Radius = 10;
            this.uibtnCOMSplt.Size = new System.Drawing.Size(100, 35);
            this.uibtnCOMSplt.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnCOMSplt.TabIndex = 41;
            this.uibtnCOMSplt.Text = "调  用";
            this.uibtnCOMSplt.Click += new System.EventHandler(this.uibtnCOMSplt_Click);
            // 
            // uitbxCOMSpltRslt
            // 
            this.uitbxCOMSpltRslt.ButtonSymbol = 61761;
            this.uitbxCOMSpltRslt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxCOMSpltRslt.FillColor = System.Drawing.Color.White;
            this.uitbxCOMSpltRslt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxCOMSpltRslt.Location = new System.Drawing.Point(357, 166);
            this.uitbxCOMSpltRslt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxCOMSpltRslt.Maximum = 2147483647D;
            this.uitbxCOMSpltRslt.Minimum = -2147483648D;
            this.uitbxCOMSpltRslt.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxCOMSpltRslt.Name = "uitbxCOMSpltRslt";
            this.uitbxCOMSpltRslt.Size = new System.Drawing.Size(180, 35);
            this.uitbxCOMSpltRslt.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxCOMSpltRslt.TabIndex = 37;
            this.uitbxCOMSpltRslt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.Location = new System.Drawing.Point(308, 171);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(20, 23);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 40;
            this.uiLabel10.Text = "=";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.Location = new System.Drawing.Point(58, 171);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(80, 23);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 39;
            this.uiLabel11.Text = "拆分句子";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uitbxCOMSplt
            // 
            this.uitbxCOMSplt.ButtonSymbol = 61761;
            this.uitbxCOMSplt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxCOMSplt.FillColor = System.Drawing.Color.White;
            this.uitbxCOMSplt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxCOMSplt.Location = new System.Drawing.Point(169, 166);
            this.uitbxCOMSplt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxCOMSplt.Maximum = 2147483647D;
            this.uitbxCOMSplt.Minimum = -2147483648D;
            this.uitbxCOMSplt.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxCOMSplt.Name = "uitbxCOMSplt";
            this.uitbxCOMSplt.Size = new System.Drawing.Size(115, 35);
            this.uitbxCOMSplt.Style = Sunny.UI.UIStyle.Custom;
            this.uitbxCOMSplt.TabIndex = 35;
            this.uitbxCOMSplt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // COMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 509);
            this.Controls.Add(this.uiPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "COMForm";
            this.Text = "COMForm";
            this.uiPanel.ResumeLayout(false);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UIButton uibtnCOMFact;
        private Sunny.UI.UITextBox uitbxCOMFactRslt;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uitbxCOMFact;
        private Sunny.UI.UIButton uibtnCOMSplt;
        private Sunny.UI.UITextBox uitbxCOMSpltRslt;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox uitbxCOMSplt;
    }
}