namespace WindowsSecExp
{
    partial class ValueForm
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
            this.uibtnCfm = new Sunny.UI.UIButton();
            this.uitbxValName = new Sunny.UI.UITextBox();
            this.uitbxValData = new Sunny.UI.UITextBox();
            this.uicbxValKind = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uibtnCfm
            // 
            this.uibtnCfm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uibtnCfm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uibtnCfm.Location = new System.Drawing.Point(204, 203);
            this.uibtnCfm.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtnCfm.Name = "uibtnCfm";
            this.uibtnCfm.Radius = 10;
            this.uibtnCfm.Size = new System.Drawing.Size(100, 35);
            this.uibtnCfm.Style = Sunny.UI.UIStyle.Custom;
            this.uibtnCfm.TabIndex = 4;
            this.uibtnCfm.Text = "确  认";
            this.uibtnCfm.Click += new System.EventHandler(this.uibtnCfm_Click);
            // 
            // uitbxValName
            // 
            this.uitbxValName.ButtonSymbol = 61761;
            this.uitbxValName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxValName.FillColor = System.Drawing.Color.White;
            this.uitbxValName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxValName.Location = new System.Drawing.Point(141, 41);
            this.uitbxValName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxValName.Maximum = 2147483647D;
            this.uitbxValName.Minimum = -2147483648D;
            this.uitbxValName.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxValName.Name = "uitbxValName";
            this.uitbxValName.Size = new System.Drawing.Size(163, 29);
            this.uitbxValName.TabIndex = 5;
            this.uitbxValName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uitbxValData
            // 
            this.uitbxValData.ButtonSymbol = 61761;
            this.uitbxValData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uitbxValData.FillColor = System.Drawing.Color.White;
            this.uitbxValData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitbxValData.Location = new System.Drawing.Point(141, 151);
            this.uitbxValData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitbxValData.Maximum = 2147483647D;
            this.uitbxValData.Minimum = -2147483648D;
            this.uitbxValData.MinimumSize = new System.Drawing.Size(1, 1);
            this.uitbxValData.Name = "uitbxValData";
            this.uitbxValData.Size = new System.Drawing.Size(163, 29);
            this.uitbxValData.TabIndex = 6;
            this.uitbxValData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uicbxValKind
            // 
            this.uicbxValKind.DataSource = null;
            this.uicbxValKind.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uicbxValKind.FillColor = System.Drawing.Color.White;
            this.uicbxValKind.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uicbxValKind.Location = new System.Drawing.Point(141, 94);
            this.uicbxValKind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uicbxValKind.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicbxValKind.Name = "uicbxValKind";
            this.uicbxValKind.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uicbxValKind.Size = new System.Drawing.Size(163, 29);
            this.uicbxValKind.TabIndex = 7;
            this.uicbxValKind.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(53, 41);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(65, 29);
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "值名称";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(53, 94);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(65, 29);
            this.uiLabel2.TabIndex = 9;
            this.uiLabel2.Text = "值类型";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(53, 151);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(65, 29);
            this.uiLabel3.TabIndex = 10;
            this.uiLabel3.Text = "值数据";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uicbxValKind);
            this.Controls.Add(this.uitbxValData);
            this.Controls.Add(this.uitbxValName);
            this.Controls.Add(this.uibtnCfm);
            this.Name = "ValueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "键值";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uibtnCfm;
        private Sunny.UI.UITextBox uitbxValName;
        private Sunny.UI.UITextBox uitbxValData;
        private Sunny.UI.UIComboBox uicbxValKind;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
    }
}