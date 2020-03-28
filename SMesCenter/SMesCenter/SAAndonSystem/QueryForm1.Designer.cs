namespace SAAndonSystem
{
    partial class QueryForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm1));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.txtClosingGuser = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx6 = new SMes.Controls.LableEx(this.components);
            this.txtDisposGuser = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx7 = new SMes.Controls.LableEx(this.components);
            this.txtCallinGuser = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx8 = new SMes.Controls.LableEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.CobAndonName = new SMes.Controls.ComboBoxEx(this.components);
            this.CobMachineNumbe = new SMes.Controls.ComboBoxEx(this.components);
            this.ColAndonStatus = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobMachineNumbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColAndonStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.ColAndonStatus);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.CobMachineNumbe);
            this.panelEx1.Controls.Add(this.CobAndonName);
            this.panelEx1.Controls.Add(this.txtClosingGuser);
            this.panelEx1.Controls.Add(this.lableEx6);
            this.panelEx1.Controls.Add(this.txtDisposGuser);
            this.panelEx1.Controls.Add(this.lableEx7);
            this.panelEx1.Controls.Add(this.txtCallinGuser);
            this.panelEx1.Controls.Add(this.lableEx8);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(660, 215);
            this.panelEx1.TabIndex = 0;
            // 
            // txtClosingGuser
            // 
            this.txtClosingGuser.AlwaysActive = false;
            this.txtClosingGuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtClosingGuser.IsMultipleRow = false;
            this.txtClosingGuser.Location = new System.Drawing.Point(451, 146);
            this.txtClosingGuser.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtClosingGuser.LovFormReturnValue")));
            this.txtClosingGuser.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtClosingGuser.MultipleRowValue")));
            this.txtClosingGuser.MustNeeded = false;
            this.txtClosingGuser.Name = "txtClosingGuser";
            this.txtClosingGuser.Size = new System.Drawing.Size(150, 22);
            this.txtClosingGuser.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtClosingGuser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClosingGuser.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtClosingGuser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClosingGuser.StateCommon.Border.Rounding = 2;
            this.txtClosingGuser.TabIndex = 17;
            // 
            // lableEx6
            // 
            this.lableEx6.AutoSize = false;
            this.lableEx6.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx6.Location = new System.Drawing.Point(345, 145);
            this.lableEx6.Name = "lableEx6";
            this.lableEx6.Size = new System.Drawing.Size(100, 23);
            this.lableEx6.Text = "关闭人员：";
            this.lableEx6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDisposGuser
            // 
            this.txtDisposGuser.AlwaysActive = false;
            this.txtDisposGuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDisposGuser.IsMultipleRow = false;
            this.txtDisposGuser.Location = new System.Drawing.Point(451, 92);
            this.txtDisposGuser.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtDisposGuser.LovFormReturnValue")));
            this.txtDisposGuser.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtDisposGuser.MultipleRowValue")));
            this.txtDisposGuser.MustNeeded = false;
            this.txtDisposGuser.Name = "txtDisposGuser";
            this.txtDisposGuser.Size = new System.Drawing.Size(150, 22);
            this.txtDisposGuser.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtDisposGuser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDisposGuser.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDisposGuser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDisposGuser.StateCommon.Border.Rounding = 2;
            this.txtDisposGuser.TabIndex = 16;
            // 
            // lableEx7
            // 
            this.lableEx7.AutoSize = false;
            this.lableEx7.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx7.Location = new System.Drawing.Point(345, 91);
            this.lableEx7.Name = "lableEx7";
            this.lableEx7.Size = new System.Drawing.Size(100, 23);
            this.lableEx7.Text = "处理人员：";
            this.lableEx7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCallinGuser
            // 
            this.txtCallinGuser.AlwaysActive = false;
            this.txtCallinGuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCallinGuser.IsMultipleRow = false;
            this.txtCallinGuser.Location = new System.Drawing.Point(144, 146);
            this.txtCallinGuser.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtCallinGuser.LovFormReturnValue")));
            this.txtCallinGuser.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtCallinGuser.MultipleRowValue")));
            this.txtCallinGuser.MustNeeded = false;
            this.txtCallinGuser.Name = "txtCallinGuser";
            this.txtCallinGuser.Size = new System.Drawing.Size(150, 22);
            this.txtCallinGuser.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtCallinGuser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCallinGuser.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCallinGuser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCallinGuser.StateCommon.Border.Rounding = 2;
            this.txtCallinGuser.TabIndex = 15;
            // 
            // lableEx8
            // 
            this.lableEx8.AutoSize = false;
            this.lableEx8.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx8.Location = new System.Drawing.Point(38, 145);
            this.lableEx8.Name = "lableEx8";
            this.lableEx8.Size = new System.Drawing.Size(100, 23);
            this.lableEx8.Text = "触发人员：";
            this.lableEx8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(345, 35);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(100, 23);
            this.lableEx4.Text = "机台编号：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(38, 35);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "项目名称：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CobAndonName
            // 
            this.CobAndonName.AlwaysActive = false;
            this.CobAndonName.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.CobAndonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobAndonName.DropDownWidth = 150;
            this.CobAndonName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CobAndonName.Location = new System.Drawing.Point(144, 37);
            this.CobAndonName.MustNeeded = false;
            this.CobAndonName.Name = "CobAndonName";
            this.CobAndonName.Size = new System.Drawing.Size(150, 21);
            this.CobAndonName.SourceCodeOrSql = "";
            this.CobAndonName.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.CobAndonName.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CobAndonName.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.CobAndonName.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.CobAndonName.TabIndex = 30;
            // 
            // CobMachineNumbe
            // 
            this.CobMachineNumbe.AlwaysActive = false;
            this.CobMachineNumbe.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.CobMachineNumbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobMachineNumbe.DropDownWidth = 150;
            this.CobMachineNumbe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CobMachineNumbe.Location = new System.Drawing.Point(451, 37);
            this.CobMachineNumbe.MustNeeded = false;
            this.CobMachineNumbe.Name = "CobMachineNumbe";
            this.CobMachineNumbe.Size = new System.Drawing.Size(150, 21);
            this.CobMachineNumbe.SourceCodeOrSql = "";
            this.CobMachineNumbe.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.CobMachineNumbe.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CobMachineNumbe.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.CobMachineNumbe.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.CobMachineNumbe.TabIndex = 31;
            // 
            // ColAndonStatus
            // 
            this.ColAndonStatus.AlwaysActive = false;
            this.ColAndonStatus.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUPWITHNULL;
            this.ColAndonStatus.DisplayMember = "NAME";
            this.ColAndonStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColAndonStatus.DropDownWidth = 150;
            this.ColAndonStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ColAndonStatus.Location = new System.Drawing.Point(144, 93);
            this.ColAndonStatus.MustNeeded = true;
            this.ColAndonStatus.Name = "ColAndonStatus";
            this.ColAndonStatus.Size = new System.Drawing.Size(150, 21);
            this.ColAndonStatus.SourceCodeOrSql = "SA_ANDON_STATUS";
            this.ColAndonStatus.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ColAndonStatus.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ColAndonStatus.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.ColAndonStatus.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.ColAndonStatus.TabIndex = 33;
            this.ColAndonStatus.ValueMember = "VALUE";
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(38, 92);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "异常状态：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QueryForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 240);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm1";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm1_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm1_OnClearQuery);
            this.Load += new System.EventHandler(this.QueryForm1_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobMachineNumbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColAndonStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.TextBoxEx txtClosingGuser;
        private SMes.Controls.LableEx lableEx6;
        private SMes.Controls.TextBoxEx txtDisposGuser;
        private SMes.Controls.LableEx lableEx7;
        private SMes.Controls.TextBoxEx txtCallinGuser;
        private SMes.Controls.LableEx lableEx8;
        private SMes.Controls.ComboBoxEx CobMachineNumbe;
        private SMes.Controls.ComboBoxEx CobAndonName;
        private SMes.Controls.ComboBoxEx ColAndonStatus;
        private SMes.Controls.LableEx lableEx3;
    }
}