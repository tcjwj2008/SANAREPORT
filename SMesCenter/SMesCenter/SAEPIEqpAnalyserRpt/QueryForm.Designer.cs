namespace SAEPIEqpAnalyserRpt
{
    partial class QueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.calAnalyserTo = new SMes.Controls.CalendarButtonEx();
            this.txtAnalyserTimeE = new SMes.Controls.TextBoxEx(this.components);
            this.calAnalyserFrom = new SMes.Controls.CalendarButtonEx();
            this.txtAnalyserTimeS = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.txtParameter = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.txtPurity = new SMes.Controls.TextBoxEx(this.components);
            this.txtAnaly = new SMes.Controls.TextBoxEx(this.components);
            this.纯化仪 = new SMes.Controls.LableEx(this.components);
            this.txtGroup = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.ccbGroup = new SMes.Controls.CheckComboBoxButtonEx();
            this.ccbAnaly = new SMes.Controls.CheckComboBoxButtonEx();
            this.ccbPurity = new SMes.Controls.CheckComboBoxButtonEx();
            this.ccbParameter = new SMes.Controls.CheckComboBoxButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.ccbParameter);
            this.panelEx1.Controls.Add(this.ccbPurity);
            this.panelEx1.Controls.Add(this.ccbAnaly);
            this.panelEx1.Controls.Add(this.ccbGroup);
            this.panelEx1.Controls.Add(this.calAnalyserTo);
            this.panelEx1.Controls.Add(this.calAnalyserFrom);
            this.panelEx1.Controls.Add(this.txtAnalyserTimeE);
            this.panelEx1.Controls.Add(this.txtAnalyserTimeS);
            this.panelEx1.Controls.Add(this.lableEx5);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.txtParameter);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.txtPurity);
            this.panelEx1.Controls.Add(this.txtAnaly);
            this.panelEx1.Controls.Add(this.纯化仪);
            this.panelEx1.Controls.Add(this.txtGroup);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(743, 212);
            this.panelEx1.TabIndex = 1;
            // 
            // calAnalyserTo
            // 
            this.calAnalyserTo.BackColor = System.Drawing.Color.Transparent;
            this.calAnalyserTo.BindTextBoxEx = this.txtAnalyserTimeE;
            this.calAnalyserTo.IsShowTimeDetail = true;
            this.calAnalyserTo.Location = new System.Drawing.Point(679, 131);
            this.calAnalyserTo.Name = "calAnalyserTo";
            this.calAnalyserTo.Size = new System.Drawing.Size(23, 23);
            this.calAnalyserTo.TabIndex = 18;
            // 
            // txtAnalyserTimeE
            // 
            this.txtAnalyserTimeE.AlwaysActive = false;
            this.txtAnalyserTimeE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAnalyserTimeE.IsMultipleRow = false;
            this.txtAnalyserTimeE.Location = new System.Drawing.Point(479, 133);
            this.txtAnalyserTimeE.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtAnalyserTimeE.LovFormReturnValue")));
            this.txtAnalyserTimeE.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtAnalyserTimeE.MultipleRowValue")));
            this.txtAnalyserTimeE.MustNeeded = false;
            this.txtAnalyserTimeE.Name = "txtAnalyserTimeE";
            this.txtAnalyserTimeE.Size = new System.Drawing.Size(194, 22);
            this.txtAnalyserTimeE.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtAnalyserTimeE.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAnalyserTimeE.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtAnalyserTimeE.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAnalyserTimeE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAnalyserTimeE.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtAnalyserTimeE.StateCommon.Border.Rounding = 2;
            this.txtAnalyserTimeE.TabIndex = 16;
            // 
            // calAnalyserFrom
            // 
            this.calAnalyserFrom.BackColor = System.Drawing.Color.Transparent;
            this.calAnalyserFrom.BindTextBoxEx = this.txtAnalyserTimeS;
            this.calAnalyserFrom.IsShowTimeDetail = true;
            this.calAnalyserFrom.Location = new System.Drawing.Point(318, 132);
            this.calAnalyserFrom.Name = "calAnalyserFrom";
            this.calAnalyserFrom.Size = new System.Drawing.Size(23, 23);
            this.calAnalyserFrom.TabIndex = 17;
            // 
            // txtAnalyserTimeS
            // 
            this.txtAnalyserTimeS.AlwaysActive = false;
            this.txtAnalyserTimeS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAnalyserTimeS.IsMultipleRow = false;
            this.txtAnalyserTimeS.Location = new System.Drawing.Point(118, 133);
            this.txtAnalyserTimeS.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtAnalyserTimeS.LovFormReturnValue")));
            this.txtAnalyserTimeS.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtAnalyserTimeS.MultipleRowValue")));
            this.txtAnalyserTimeS.MustNeeded = false;
            this.txtAnalyserTimeS.Name = "txtAnalyserTimeS";
            this.txtAnalyserTimeS.Size = new System.Drawing.Size(194, 22);
            this.txtAnalyserTimeS.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtAnalyserTimeS.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAnalyserTimeS.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtAnalyserTimeS.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAnalyserTimeS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAnalyserTimeS.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtAnalyserTimeS.StateCommon.Border.Rounding = 2;
            this.txtAnalyserTimeS.TabIndex = 15;
            // 
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(401, 132);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(72, 23);
            this.lableEx5.Text = "到：";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(12, 133);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "抓取时间从：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtParameter
            // 
            this.txtParameter.AlwaysActive = false;
            this.txtParameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtParameter.IsMultipleRow = false;
            this.txtParameter.Location = new System.Drawing.Point(479, 95);
            this.txtParameter.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtParameter.LovFormReturnValue")));
            this.txtParameter.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtParameter.MultipleRowValue")));
            this.txtParameter.MustNeeded = false;
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.ReadOnly = true;
            this.txtParameter.Size = new System.Drawing.Size(194, 22);
            this.txtParameter.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtParameter.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtParameter.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtParameter.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtParameter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtParameter.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtParameter.StateCommon.Border.Rounding = 2;
            this.txtParameter.TabIndex = 7;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(373, 94);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(100, 23);
            this.lableEx4.Text = "参数：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPurity
            // 
            this.txtPurity.AlwaysActive = false;
            this.txtPurity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPurity.IsMultipleRow = false;
            this.txtPurity.Location = new System.Drawing.Point(118, 95);
            this.txtPurity.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtPurity.LovFormReturnValue")));
            this.txtPurity.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtPurity.MultipleRowValue")));
            this.txtPurity.MustNeeded = false;
            this.txtPurity.Name = "txtPurity";
            this.txtPurity.ReadOnly = true;
            this.txtPurity.Size = new System.Drawing.Size(194, 22);
            this.txtPurity.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtPurity.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPurity.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtPurity.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtPurity.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPurity.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtPurity.StateCommon.Border.Rounding = 2;
            this.txtPurity.TabIndex = 5;
            // 
            // txtAnaly
            // 
            this.txtAnaly.AlwaysActive = false;
            this.txtAnaly.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAnaly.IsMultipleRow = false;
            this.txtAnaly.Location = new System.Drawing.Point(479, 52);
            this.txtAnaly.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtAnaly.LovFormReturnValue")));
            this.txtAnaly.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtAnaly.MultipleRowValue")));
            this.txtAnaly.MustNeeded = false;
            this.txtAnaly.Name = "txtAnaly";
            this.txtAnaly.ReadOnly = true;
            this.txtAnaly.Size = new System.Drawing.Size(194, 22);
            this.txtAnaly.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtAnaly.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAnaly.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtAnaly.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtAnaly.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAnaly.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtAnaly.StateCommon.Border.Rounding = 2;
            this.txtAnaly.TabIndex = 4;
            // 
            // 纯化仪
            // 
            this.纯化仪.AutoSize = false;
            this.纯化仪.Font = new System.Drawing.Font("Arial", 10F);
            this.纯化仪.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.纯化仪.Location = new System.Drawing.Point(373, 52);
            this.纯化仪.Name = "纯化仪";
            this.纯化仪.Size = new System.Drawing.Size(100, 23);
            this.纯化仪.Text = "分析仪：";
            this.纯化仪.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGroup
            // 
            this.txtGroup.AlwaysActive = false;
            this.txtGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGroup.IsMultipleRow = false;
            this.txtGroup.Location = new System.Drawing.Point(118, 53);
            this.txtGroup.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtGroup.LovFormReturnValue")));
            this.txtGroup.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtGroup.MultipleRowValue")));
            this.txtGroup.MustNeeded = false;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.ReadOnly = true;
            this.txtGroup.Size = new System.Drawing.Size(194, 22);
            this.txtGroup.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtGroup.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGroup.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtGroup.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtGroup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGroup.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtGroup.StateCommon.Border.Rounding = 2;
            this.txtGroup.TabIndex = 2;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(12, 94);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "纯化器：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(12, 52);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(100, 23);
            this.lableEx1.Text = "分析仪组：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ccbGroup
            // 
            this.ccbGroup.BackColor = System.Drawing.Color.Transparent;
            this.ccbGroup.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.ccbGroup.InitValue = "";
            this.ccbGroup.ListHeigh = 100;
            this.ccbGroup.Location = new System.Drawing.Point(318, 48);
            this.ccbGroup.Name = "ccbGroup";
            this.ccbGroup.Size = new System.Drawing.Size(27, 27);
            this.ccbGroup.SourceCodeOrSql = "SELECT DISTINCT \'FALST\',ANALYSER_GROUP_NAME AS NAME,ANALYSER_GROUP_NAME AS VALUE " +
                "FROM sa_eqp_analyser_values";
            this.ccbGroup.SplitStr = ",";
            this.ccbGroup.TabIndex = 25;
            this.ccbGroup.TargetTextBoxEx = this.txtGroup;
            this.ccbGroup.ValueAsChar = "";
            this.ccbGroup.ValueAsNumber = "";
            // 
            // ccbAnaly
            // 
            this.ccbAnaly.BackColor = System.Drawing.Color.Transparent;
            this.ccbAnaly.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.ccbAnaly.InitValue = "";
            this.ccbAnaly.ListHeigh = 100;
            this.ccbAnaly.Location = new System.Drawing.Point(679, 47);
            this.ccbAnaly.Name = "ccbAnaly";
            this.ccbAnaly.Size = new System.Drawing.Size(27, 27);
            this.ccbAnaly.SourceCodeOrSql = "SELECT DISTINCT \'FALST\',ANALYSER_NAME AS NAME,ANALYSER_NAME AS VALUE FROM sa_eqp_" +
                "analyser_values";
            this.ccbAnaly.SplitStr = ",";
            this.ccbAnaly.TabIndex = 26;
            this.ccbAnaly.TargetTextBoxEx = this.txtAnaly;
            this.ccbAnaly.ValueAsChar = "";
            this.ccbAnaly.ValueAsNumber = "";
            // 
            // ccbPurity
            // 
            this.ccbPurity.BackColor = System.Drawing.Color.Transparent;
            this.ccbPurity.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.ccbPurity.InitValue = "";
            this.ccbPurity.ListHeigh = 100;
            this.ccbPurity.Location = new System.Drawing.Point(318, 94);
            this.ccbPurity.Name = "ccbPurity";
            this.ccbPurity.Size = new System.Drawing.Size(27, 27);
            this.ccbPurity.SourceCodeOrSql = "SELECT DISTINCT \'FALST\',PURITY_NAME AS NAME,PURITY_NAME AS VALUE FROM sa_eqp_anal" +
                "yser_values";
            this.ccbPurity.SplitStr = ",";
            this.ccbPurity.TabIndex = 27;
            this.ccbPurity.TargetTextBoxEx = this.txtPurity;
            this.ccbPurity.ValueAsChar = "";
            this.ccbPurity.ValueAsNumber = "";
            // 
            // ccbParameter
            // 
            this.ccbParameter.BackColor = System.Drawing.Color.Transparent;
            this.ccbParameter.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.ccbParameter.InitValue = "";
            this.ccbParameter.ListHeigh = 100;
            this.ccbParameter.Location = new System.Drawing.Point(679, 93);
            this.ccbParameter.Name = "ccbParameter";
            this.ccbParameter.Size = new System.Drawing.Size(27, 27);
            this.ccbParameter.SourceCodeOrSql = "SELECT DISTINCT \'FALST\',PARAMETER_NAME AS NAME,PARAMETER_NAME AS VALUE FROM sa_eq" +
                "p_analyser_values";
            this.ccbParameter.SplitStr = ",";
            this.ccbParameter.TabIndex = 28;
            this.ccbParameter.TargetTextBoxEx = this.txtParameter;
            this.ccbParameter.ValueAsChar = "";
            this.ccbParameter.ValueAsNumber = "";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 237);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnClearQuery);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.TextBoxEx txtParameter;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.TextBoxEx txtPurity;
        private SMes.Controls.TextBoxEx txtAnaly;
        private SMes.Controls.LableEx 纯化仪;
        private SMes.Controls.TextBoxEx txtGroup;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.CalendarButtonEx calAnalyserTo;
        private SMes.Controls.CalendarButtonEx calAnalyserFrom;
        private SMes.Controls.TextBoxEx txtAnalyserTimeE;
        private SMes.Controls.TextBoxEx txtAnalyserTimeS;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.CheckComboBoxButtonEx ccbAnaly;
        private SMes.Controls.CheckComboBoxButtonEx ccbGroup;
        private SMes.Controls.CheckComboBoxButtonEx ccbParameter;
        private SMes.Controls.CheckComboBoxButtonEx ccbPurity;
    }
}