namespace SMesFunctionMan
{
    partial class ManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.lableEx10 = new SMes.Controls.LableEx(this.components);
            this.tbusenum = new SMes.Controls.TextBoxEx(this.components);
            this.cblastuser = new SMes.Controls.ComboBoxEx(this.components);
            this.calendarButtonEx1 = new SMes.Controls.CalendarButtonEx();
            this.tblastusedate = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx8 = new SMes.Controls.LableEx(this.components);
            this.lableEx9 = new SMes.Controls.LableEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.tbfunctioncode = new SMes.Controls.TextBoxEx(this.components);
            this.tbOwner = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx7 = new SMes.Controls.LableEx(this.components);
            this.CBMENUGROUP = new SMes.Controls.ComboBoxEx(this.components);
            this.CBORGID = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.tBDescription = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx6 = new SMes.Controls.LableEx(this.components);
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.tBFunctionpath = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.tBFunctionname = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cblastuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBMENUGROUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBORGID)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.lableEx10);
            this.panelEx1.Controls.Add(this.tbusenum);
            this.panelEx1.Controls.Add(this.cblastuser);
            this.panelEx1.Controls.Add(this.calendarButtonEx1);
            this.panelEx1.Controls.Add(this.tblastusedate);
            this.panelEx1.Controls.Add(this.lableEx8);
            this.panelEx1.Controls.Add(this.lableEx9);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.tbfunctioncode);
            this.panelEx1.Controls.Add(this.tbOwner);
            this.panelEx1.Controls.Add(this.lableEx7);
            this.panelEx1.Controls.Add(this.CBMENUGROUP);
            this.panelEx1.Controls.Add(this.CBORGID);
            this.panelEx1.Controls.Add(this.lableEx5);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.tBDescription);
            this.panelEx1.Controls.Add(this.lableEx6);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Controls.Add(this.tBFunctionpath);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.tBFunctionname);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1076, 401);
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEx1_Paint);
            // 
            // lableEx10
            // 
            this.lableEx10.AutoSize = false;
            this.lableEx10.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx10.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lableEx10.Location = new System.Drawing.Point(537, 72);
            this.lableEx10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx10.Name = "lableEx10";
            this.lableEx10.Size = new System.Drawing.Size(142, 28);
            this.lableEx10.Text = "总使用次数:";
            this.lableEx10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbusenum
            // 
            this.tbusenum.AlwaysActive = false;
            this.tbusenum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbusenum.IsMultipleRow = false;
            this.tbusenum.Location = new System.Drawing.Point(687, 72);
            this.tbusenum.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbusenum.LovFormReturnValue")));
            this.tbusenum.Margin = new System.Windows.Forms.Padding(4);
            this.tbusenum.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbusenum.MultipleRowValue")));
            this.tbusenum.MustNeeded = true;
            this.tbusenum.Name = "tbusenum";
            this.tbusenum.Size = new System.Drawing.Size(145, 26);
            this.tbusenum.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbusenum.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbusenum.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbusenum.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbusenum.StateCommon.Border.Rounding = 2;
            this.tbusenum.TabIndex = 76;
            this.tbusenum.Text = "0";
            // 
            // cblastuser
            // 
            this.cblastuser.AlwaysActive = false;
            this.cblastuser.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.cblastuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblastuser.DropDownWidth = 199;
            this.cblastuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cblastuser.Location = new System.Drawing.Point(687, 166);
            this.cblastuser.MustNeeded = true;
            this.cblastuser.Name = "cblastuser";
            this.cblastuser.Size = new System.Drawing.Size(145, 25);
            this.cblastuser.SourceCodeOrSql = "";
            this.cblastuser.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cblastuser.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cblastuser.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.cblastuser.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cblastuser.TabIndex = 74;
            // 
            // calendarButtonEx1
            // 
            this.calendarButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx1.BindTextBoxEx = this.tblastusedate;
            this.calendarButtonEx1.IsShowTimeDetail = true;
            this.calendarButtonEx1.Location = new System.Drawing.Point(986, 205);
            this.calendarButtonEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calendarButtonEx1.Name = "calendarButtonEx1";
            this.calendarButtonEx1.Size = new System.Drawing.Size(31, 29);
            this.calendarButtonEx1.TabIndex = 73;
            // 
            // tblastusedate
            // 
            this.tblastusedate.AlwaysActive = false;
            this.tblastusedate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tblastusedate.IsMultipleRow = false;
            this.tblastusedate.Location = new System.Drawing.Point(687, 208);
            this.tblastusedate.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tblastusedate.LovFormReturnValue")));
            this.tblastusedate.Margin = new System.Windows.Forms.Padding(4);
            this.tblastusedate.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tblastusedate.MultipleRowValue")));
            this.tblastusedate.MustNeeded = false;
            this.tblastusedate.Name = "tblastusedate";
            this.tblastusedate.Size = new System.Drawing.Size(291, 26);
            this.tblastusedate.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tblastusedate.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tblastusedate.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tblastusedate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tblastusedate.StateCommon.Border.Rounding = 2;
            this.tblastusedate.TabIndex = 70;
            // 
            // lableEx8
            // 
            this.lableEx8.AutoSize = false;
            this.lableEx8.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx8.Location = new System.Drawing.Point(537, 208);
            this.lableEx8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx8.Name = "lableEx8";
            this.lableEx8.Size = new System.Drawing.Size(142, 28);
            this.lableEx8.Text = "最后使用时间:";
            this.lableEx8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx9
            // 
            this.lableEx9.AutoSize = false;
            this.lableEx9.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx9.Location = new System.Drawing.Point(537, 165);
            this.lableEx9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx9.Name = "lableEx9";
            this.lableEx9.Size = new System.Drawing.Size(142, 28);
            this.lableEx9.Text = "最后使用者:";
            this.lableEx9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lableEx2.Location = new System.Drawing.Point(67, 70);
            this.lableEx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(230, 28);
            this.lableEx2.Text = "功能代码（程序集名称）:";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbfunctioncode
            // 
            this.tbfunctioncode.AlwaysActive = false;
            this.tbfunctioncode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbfunctioncode.IsMultipleRow = false;
            this.tbfunctioncode.Location = new System.Drawing.Point(338, 70);
            this.tbfunctioncode.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbfunctioncode.LovFormReturnValue")));
            this.tbfunctioncode.Margin = new System.Windows.Forms.Padding(4);
            this.tbfunctioncode.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbfunctioncode.MultipleRowValue")));
            this.tbfunctioncode.MustNeeded = true;
            this.tbfunctioncode.Name = "tbfunctioncode";
            this.tbfunctioncode.Size = new System.Drawing.Size(163, 26);
            this.tbfunctioncode.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbfunctioncode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbfunctioncode.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbfunctioncode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbfunctioncode.StateCommon.Border.Rounding = 2;
            this.tbfunctioncode.TabIndex = 60;
            // 
            // tbOwner
            // 
            this.tbOwner.AlwaysActive = false;
            this.tbOwner.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.tbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbOwner.DropDownWidth = 199;
            this.tbOwner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbOwner.Location = new System.Drawing.Point(250, 295);
            this.tbOwner.MustNeeded = true;
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(251, 25);
            this.tbOwner.SourceCodeOrSql = "";
            this.tbOwner.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbOwner.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbOwner.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbOwner.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.tbOwner.TabIndex = 49;
            this.tbOwner.SelectedIndexChanged += new System.EventHandler(this.tbOwner_SelectedIndexChanged);
            // 
            // lableEx7
            // 
            this.lableEx7.AutoSize = false;
            this.lableEx7.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx7.Location = new System.Drawing.Point(11, 295);
            this.lableEx7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx7.Name = "lableEx7";
            this.lableEx7.Size = new System.Drawing.Size(231, 28);
            this.lableEx7.Text = "创建者:";
            this.lableEx7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBMENUGROUP
            // 
            this.CBMENUGROUP.AlwaysActive = false;
            this.CBMENUGROUP.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.CBMENUGROUP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMENUGROUP.DropDownWidth = 199;
            this.CBMENUGROUP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBMENUGROUP.Items.AddRange(new object[] {
            "1"});
            this.CBMENUGROUP.Location = new System.Drawing.Point(250, 253);
            this.CBMENUGROUP.MustNeeded = true;
            this.CBMENUGROUP.Name = "CBMENUGROUP";
            this.CBMENUGROUP.Size = new System.Drawing.Size(251, 25);
            this.CBMENUGROUP.SourceCodeOrSql = "";
            this.CBMENUGROUP.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.CBMENUGROUP.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CBMENUGROUP.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.CBMENUGROUP.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.CBMENUGROUP.TabIndex = 47;
            this.CBMENUGROUP.SelectedIndexChanged += new System.EventHandler(this.CBMENUGROUP_SelectedIndexChanged);
            // 
            // CBORGID
            // 
            this.CBORGID.AlwaysActive = false;
            this.CBORGID.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.CBORGID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBORGID.DropDownWidth = 162;
            this.CBORGID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBORGID.Location = new System.Drawing.Point(338, 211);
            this.CBORGID.MustNeeded = true;
            this.CBORGID.Name = "CBORGID";
            this.CBORGID.Size = new System.Drawing.Size(163, 25);
            this.CBORGID.SourceCodeOrSql = "";
            this.CBORGID.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.CBORGID.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CBORGID.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.CBORGID.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.CBORGID.TabIndex = 46;
            this.CBORGID.SelectedIndexChanged += new System.EventHandler(this.CBORGID_SelectedIndexChanged);
            // 
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(11, 256);
            this.lableEx5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(231, 28);
            this.lableEx5.Text = "菜单组ID（预留）:";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(12, 209);
            this.lableEx3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(231, 28);
            this.lableEx3.Text = "组织ID:";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tBDescription
            // 
            this.tBDescription.AlwaysActive = false;
            this.tBDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tBDescription.IsMultipleRow = false;
            this.tBDescription.Location = new System.Drawing.Point(687, 297);
            this.tBDescription.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tBDescription.LovFormReturnValue")));
            this.tBDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tBDescription.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tBDescription.MultipleRowValue")));
            this.tBDescription.MustNeeded = false;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.Size = new System.Drawing.Size(291, 26);
            this.tBDescription.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tBDescription.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBDescription.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tBDescription.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBDescription.StateCommon.Border.Rounding = 2;
            this.tBDescription.TabIndex = 32;
            this.tBDescription.TextChanged += new System.EventHandler(this.tBDescription_TextChanged);
            // 
            // lableEx6
            // 
            this.lableEx6.AutoSize = false;
            this.lableEx6.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx6.Location = new System.Drawing.Point(537, 295);
            this.lableEx6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx6.Name = "lableEx6";
            this.lableEx6.Size = new System.Drawing.Size(142, 28);
            this.lableEx6.Text = "功能描述:";
            this.lableEx6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
            this.navigatorEx1.DataGridView = null;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Margin = new System.Windows.Forms.Padding(5);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.PageQueryRows = 10000;
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = false;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = false;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(1076, 40);
            this.navigatorEx1.StatusStrip = null;
            this.navigatorEx1.TabIndex = 34;
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            this.navigatorEx1.Load += new System.EventHandler(this.navigatorEx1_Load);
            // 
            // tBFunctionpath
            // 
            this.tBFunctionpath.AlwaysActive = false;
            this.tBFunctionpath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tBFunctionpath.IsMultipleRow = false;
            this.tBFunctionpath.Location = new System.Drawing.Point(687, 252);
            this.tBFunctionpath.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tBFunctionpath.LovFormReturnValue")));
            this.tBFunctionpath.Margin = new System.Windows.Forms.Padding(4);
            this.tBFunctionpath.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tBFunctionpath.MultipleRowValue")));
            this.tBFunctionpath.MustNeeded = true;
            this.tBFunctionpath.Name = "tBFunctionpath";
            this.tBFunctionpath.Size = new System.Drawing.Size(291, 26);
            this.tBFunctionpath.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tBFunctionpath.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBFunctionpath.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tBFunctionpath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBFunctionpath.StateCommon.Border.Rounding = 2;
            this.tBFunctionpath.TabIndex = 28;
            this.tBFunctionpath.TextChanged += new System.EventHandler(this.tBFunctionpath_TextChanged);
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(537, 252);
            this.lableEx4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(142, 28);
            this.lableEx4.Text = "功能路径:";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tBFunctionname
            // 
            this.tBFunctionname.AlwaysActive = false;
            this.tBFunctionname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tBFunctionname.IsMultipleRow = false;
            this.tBFunctionname.Location = new System.Drawing.Point(250, 113);
            this.tBFunctionname.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tBFunctionname.LovFormReturnValue")));
            this.tBFunctionname.Margin = new System.Windows.Forms.Padding(4);
            this.tBFunctionname.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tBFunctionname.MultipleRowValue")));
            this.tBFunctionname.MustNeeded = true;
            this.tBFunctionname.Name = "tBFunctionname";
            this.tBFunctionname.Size = new System.Drawing.Size(251, 26);
            this.tBFunctionname.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tBFunctionname.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBFunctionname.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tBFunctionname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBFunctionname.StateCommon.Border.Rounding = 2;
            this.tBFunctionname.TabIndex = 27;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lableEx1.Location = new System.Drawing.Point(68, 113);
            this.lableEx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(175, 28);
            this.lableEx1.Text = "功能名称（中文）:";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 401);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageForm";
            this.Text = "功能维护";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cblastuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBMENUGROUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBORGID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.TextBoxEx tBDescription;
        private SMes.Controls.LableEx lableEx6;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.TextBoxEx tBFunctionpath;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.TextBoxEx tBFunctionname;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.ComboBoxEx CBMENUGROUP;
        private SMes.Controls.ComboBoxEx CBORGID;
        private SMes.Controls.ComboBoxEx tbOwner;
        private SMes.Controls.LableEx lableEx7;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.TextBoxEx tbfunctioncode;
        private SMes.Controls.TextBoxEx tblastusedate;
        private SMes.Controls.LableEx lableEx8;
        private SMes.Controls.LableEx lableEx9;
        private SMes.Controls.LableEx lableEx10;
        private SMes.Controls.TextBoxEx tbusenum;
        private SMes.Controls.ComboBoxEx cblastuser;
        private SMes.Controls.CalendarButtonEx calendarButtonEx1;
    }
}