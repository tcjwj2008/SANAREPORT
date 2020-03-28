using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMesCenter.AppObj;
using SMesCenter.UserControls;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SMesCenter
{
    public partial class Workbench : SMes.Controls.ExtendForm.BaseForm,SMes.Core.Interface.IApplication //继承基本窗口属性和对应接口属性（封装）
    {
        
        //客户拥有组织机构列表
        List<OrganizationButton> OrgBtnList = new List<OrganizationButton>();
        //私有登录成功属性
        private bool _loginSucess = false;

        public Workbench()
        {        
            InitializeComponent();
        }

        public MenuStrip WorkBenchMainMenuStrip
        {
            get { return this.menuSMain; }
        }
        void btn_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Text;
            switch (name)
            {
                case "银祥肉业":
                    MessageBox.Show("" + ((Button)sender).Name);
                    break;
                case "银祥食品":
                    MessageBox.Show("" + ((Button)sender).Name);
                    break;
                case "银祥肉制品":
                    MessageBox.Show("" + ((Button)sender).Name);
                    break;
                default:
                    MessageBox.Show("" + ((Button)sender).Name);
                    break;
                //继续添加
            }
        }

        private void Workbench_Load(object sender, EventArgs e)
        {



            SMes.Core.ApplicationCache.GlobalCache.Application = this;
            //创建登录窗口
            LoginForm LoginFormPlus = new LoginForm();
            LoginFormPlus.ShowDialog();
            if (!LoginFormPlus.isSuccessLogin)
            {
                Application.Exit();
                return;
            }
            _loginSucess = true;
            if (CenterCache.SMesCenterCache.SysInfo != null)
            {
                this.Text = CenterCache.SMesCenterCache.SysInfo.SystemName;
            }
            this.Text = "银祥集团业务融合中心";
            this.WindowState = FormWindowState.Maximized;
            //////加载组织代码
            /////LoaderOrgButtons_New();
            ////////初始化界面显示
            OrganizationButton btn;
            DataTable oraSource = new DataTable();
            oraSource = SqlHelper.ExecuteDataTable(@"select A.* from  SMES_ORGANIZATION A WHERE CONVERT(VARCHAR(50),A.ORGANIZATION_id) IN  (SELECT CONVERT(VARCHAR(50),D.orgId) FROM smes_functionName D WHERE D.functioncode IN(
            SELECT C.functionname FROM smes_function_user C ,smes_users B WHERE CONVERT(VARCHAR(50),C.userid)=CONVERT(VARCHAR(50),B.USER_NAME) AND B.USER_NAME='" + SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_User_NAME") + @"'))  order by organization_id", CommandType.Text);
            for (int i = 0; i < oraSource.Rows.Count; i++)
            {
                btn = new OrganizationButton();
                #region 旧代码
                //switch (i)
                //{
                //    case 10001:
                //        btn.OrgId = "10001";
                //        btn.OrgName = "银祥肉业";
                //        // btn.Dock = DockStyle.Top;
                //        btn.OnOrgButtonSwitch += new OrganizationButtonClickedEventHandler(OrganizationBtn_OnOrgButtonSwitch);
                //        OrgBtnList.Add(btn);
                //        btn.IsInUsed = true;
                //        break;
                //    case 10002:
                //        btn.OrgId = "10002";
                //        btn.OrgName = "银祥食品";
                //        // btn.Dock = DockStyle.Top;
                //        btn.OnOrgButtonSwitch += new OrganizationButtonClickedEventHandler(OrganizationBtn_OnOrgButtonSwitch);
                //        OrgBtnList.Add(btn);
                //        btn.IsInUsed = false;
                //        break;
                //    case 10003:
                //        btn.OrgId = "10003";
                //        btn.OrgName = "银祥肉制品";
                //        // btn.Dock = DockStyle.Top;
                //        btn.OnOrgButtonSwitch += new OrganizationButtonClickedEventHandler(OrganizationBtn_OnOrgButtonSwitch);
                //        OrgBtnList.Add(btn);
                //        btn.IsInUsed = false;
                //        break;
                //    case 3:
                //        btn.OrgId = "3";
                //        btn.OrgName = "银祥油脂";
                //        btn.OnOrgButtonSwitch += new OrganizationButtonClickedEventHandler(OrganizationBtn_OnOrgButtonSwitch);
                //        OrgBtnList.Add(btn);
                //        // btn.Dock = DockStyle.Top;
                //        btn.IsInUsed = false;
                //        break;
                //    case 4:
                //        btn.OrgId = "4";
                //        btn.OrgName = "银祥豆制品";
                //        btn.OnOrgButtonSwitch += new OrganizationButtonClickedEventHandler(OrganizationBtn_OnOrgButtonSwitch);
                //        OrgBtnList.Add(btn);
                //        // btn.Dock = DockStyle.Top;
                //        btn.IsInUsed = false;
                //        break;
                //    case 5:
                //        btn.OrgId = "5";
                //        btn.OrgName = "其他产业";
                //        btn.OnOrgButtonSwitch += new OrganizationButtonClickedEventHandler(OrganizationBtn_OnOrgButtonSwitch);
                //        OrgBtnList.Add(btn);
                //        // btn.Dock = DockStyle.Top;
                //        btn.IsInUsed = false;
                //        break;
                //}      
                #endregion
                btn.OrgId = oraSource.Rows[i]["ORGANIZATION_ID"].ToString();
                btn.OrgName = oraSource.Rows[i]["ORGANIZATION_NAME"].ToString();
                // btn.Dock = DockStyle.Top;

                OrgBtnList.Add(btn);
                btn.OnOrgButtonSwitch += new OrganizationButtonClickedEventHandler(OrganizationBtn_OnOrgButtonSwitch);
                btn.IsInUsed = false;
                btn.Parent = this.bgOrgs;
                btn.Top = 50 * (i)+20;
								btn.Left =5;
					
                //btn.Click += new EventHandler(btn_Click);

            }

         

            try
            {
                SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_ID", "0");
                SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_CODE", "0");
                SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_NAME", "银祥肉业");     
                dataGridViewEx1.DataSource= SqlHelper.ExecuteDataTable(Sql.CenterSql.InitFunctionName_Orgid("0"), CommandType.Text, null);
            }
            catch 
            {
      
            }

            SetFormInfoShow_New();

           

            ///////5分钟刷新配置的计时器开启
            //this.timerReflash.Start(); 

            #region 旧代码
            //SMes.Core.ApplicationCache.GlobalCache.Application = this;
            ////创建登录窗口
            //LoginForm LoginFormPlus = new LoginForm();
            //LoginFormPlus.ShowDialog();
            //if (!LoginFormPlus.isSuccessLogin)
            //{
            //    Application.Exit();
            //    return;
            //}
            //_loginSucess = true;
            //if (CenterCache.SMesCenterCache.SysInfo != null)
            //{
            //    this.Text = CenterCache.SMesCenterCache.SysInfo.SystemName;
            //}
            //this.WindowState = FormWindowState.Maximized;

            ////////载入切换组织按钮
            //LoaderOrgButtons();

            //////////根据当前厂区载入菜单
            //UserOrg uOrg = CenterCache.SMesCenterCache.UserOrgList.Find(m => m.IsInUsed == true);

            ////////全局参数设置当前厂区ID和编码
            //SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_ID", uOrg.OrgId);
            //SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_CODE", uOrg.OrgCode);
            //SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_NAME", uOrg.OrgName);

            ///////载入菜单
            //LoadMenu(uOrg.OrgId);

            ////////初始化界面显示
            //SetFormInfoShow();

            ///////5分钟刷新配置的计时器开启
            //this.timerReflash.Start(); 
            #endregion
        }


        private void SetFormInfoShow_New()
        {
            this.toolStripStatusLabel2.Text = "当前组织：" +SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_NAME");
            //this.toolStripStatusLabel5.Text = PropertyClass.OperatorID.ToString() + "|" + PropertyClass.OperatorName.ToString(); ;
            this.tsslUserName.Text = PropertyClass.OperatorName.ToString();
           

        }
        /// <summary>
        /// 旧的显示用户名的方法
        /// </summary>
        private void SetFormInfoShow()
        {
            this.tsslUserName.Text = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;
        }
        /// <summary>
        /// 加载组织按钮
        /// </summary>
        private void LoaderOrgButtons()
        {
            for (int i = CenterCache.SMesCenterCache.UserOrgList.Count-1; i >= 0; i--)
            {
                UserControls.OrganizationButton orgBtn = new UserControls.OrganizationButton(CenterCache.SMesCenterCache.UserOrgList[i].OrgId, CenterCache.SMesCenterCache.UserOrgList[i].OrgName, CenterCache.SMesCenterCache.UserOrgList[i].IsInUsed);
                orgBtn.Name = CenterCache.SMesCenterCache.UserOrgList[i].OrgCode;
                orgBtn.Location = new Point(1, 1);
                orgBtn.Dock = DockStyle.Top;
                orgBtn.OnOrgButtonSwitch += new OrganizationButtonClickedEventHandler(OrganizationBtn_OnOrgButtonSwitch);
                OrgBtnList.Add(orgBtn);
                this.bgOrgs.Controls.Add(orgBtn);

            }


        }


        private void LoaderOrgButtons_New()
        {
            for (int i = CenterCache.SMesCenterCache.UserOrgList.Count - 1; i >= 0; i--)
            {
                UserControls.OrganizationButton orgBtn = new UserControls.OrganizationButton(CenterCache.SMesCenterCache.UserOrgList[i].OrgId, CenterCache.SMesCenterCache.UserOrgList[i].OrgName, CenterCache.SMesCenterCache.UserOrgList[i].IsInUsed);
                orgBtn.Name = CenterCache.SMesCenterCache.UserOrgList[i].OrgCode;
                orgBtn.Location = new Point(1, 1);
                orgBtn.Dock = DockStyle.Top;
                orgBtn.OnOrgButtonSwitch += new OrganizationButtonClickedEventHandler(OrganizationBtn_OnOrgButtonSwitch);
                OrgBtnList.Add(orgBtn);
                this.bgOrgs.Controls.Add(orgBtn);

            }


        }

        private void LoadMenu(string orgId)
        {
            WorkBenchMainMenuStrip.Items.Clear();
            //////根据组织权限得到菜单类别
            List<AppObj.SysMenu> orgMenu = CenterCache.SMesCenterCache.SysMenuList.FindAll(m => m.OrganizationId == orgId || m.TopMenuFlag == "Y");

            int index = 0;/////tab用
            this.smTabControl.ClearButtom();////tab用
            this.dgvSubMenu.Rows.Clear();
            for (int i = 0; i < orgMenu.Count; i++)
            {
                if (orgMenu[i].TopMenuFlag == "Y")
                {
                    ToolStripMenuItem topMenu = new ToolStripMenuItem();
                    topMenu.Text = orgMenu[i].MenuName;

                    List<AppObj.SysMenu> drs = orgMenu.FindAll(m => m.ParentMenuId == orgMenu[i].MenuId);

                    CreateSubMenu(ref topMenu, drs, orgMenu);
                    WorkBenchMainMenuStrip.MdiWindowListItem = topMenu;
                    if (drs.Count > 0)
                    {
                        WorkBenchMainMenuStrip.Items.Add(topMenu);

                        this.smTabControl.AddButton(topMenu.Text, index, orgMenu[i].MenuId, sMesTabControl_Click);
                        index++;
                    }
                }
            }
            this.smTabControl.FirstButtomClick();////tab用
            
        }

        private void CreateSubMenu(ref ToolStripMenuItem topMenu, List<AppObj.SysMenu> dr, List<AppObj.SysMenu> table)
        {
            try
            {
                string tempstr = string.Empty;
                for (int i = 0; i < dr.Count; i++)
                {
                    tempstr = dr[i].MenuName + "[" + dr[i].FunctionCode + "]";
                    ToolStripMenuItem subMenu = new ToolStripMenuItem();
                    subMenu.Text = tempstr;
                    if (dr[i].TopMenuFlag.CompareTo("Y") == 0)
                    {
                        List<AppObj.SysMenu> drs = table.FindAll(m => m.ParentMenuId == dr[i].MenuId);
                        CreateSubMenu(ref subMenu, drs, table);
                        drs = null;
                    }
                    else
                    {
                        subMenu.Tag = dr[i].FunctionCode + "&" + dr[i].OrganizationCode + "&" + dr[i].ShowType + "&" + dr[i].FunctionType + "&" + dr[i].FunctionPath;

                        //subMenu.Image = ;

                        subMenu.Click += new EventHandler(subMenu_Click);

                        topMenu.DropDownItems.Add(subMenu);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static void subMenu_Click(object sender, EventArgs e)
        {
            SMes.Core.Service.FunctionService.CallFunction(((ToolStripMenuItem)sender).Tag.ToString());
        }

        private void sMesTabControl_Click(object sender, EventArgs e)
        {
            try
            {
                string menuId = ((ComponentFactory.Krypton.Toolkit.KryptonCheckButton)sender).Tag.ToString();

                string orgId = SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_ID");
                List<AppObj.SysMenu> dr = CenterCache.SMesCenterCache.SysMenuList.FindAll(m => m.OrganizationId == orgId && m.ParentMenuId == menuId);

                string tempstr = string.Empty;
                this.dgvSubMenu.Rows.Clear();
                for (int i = 0; i < dr.Count; i++)
                {
                    if (dr[i].TopMenuFlag.CompareTo("Y") == 0)
                    {
                        
                    }
                    else
                    {
                        this.dgvSubMenu.Rows.Add();
                        this.dgvSubMenu.Rows[this.dgvSubMenu.RowCount - 1].Cells[this.ColSeq.Name].Value = this.dgvSubMenu.RowCount.ToString();
                        this.dgvSubMenu.Rows[this.dgvSubMenu.RowCount - 1].Cells[this.ColFunctionId.Name].Value = dr[i].FunctionId;
                        this.dgvSubMenu.Rows[this.dgvSubMenu.RowCount - 1].Cells[this.ColMenuName.Name].Value = dr[i].MenuName;
                        this.dgvSubMenu.Rows[this.dgvSubMenu.RowCount - 1].Cells[this.ColMenuCode.Name].Value = dr[i].FunctionCode;
                        this.dgvSubMenu.Rows[this.dgvSubMenu.RowCount - 1].Cells[this.ColExePath.Name].Value = dr[i].FunctionCode + "&" + dr[i].OrganizationCode + "&" + dr[i].ShowType + "&" + dr[i].FunctionType + "&" + dr[i].FunctionPath;
                        this.dgvSubMenu.Rows[this.dgvSubMenu.RowCount - 1].Cells[this.ColItOwner.Name].Value = dr[i].ItOwner;
                        this.dgvSubMenu.Rows[this.dgvSubMenu.RowCount - 1].Cells[this.ColFunctionGroup.Name].Value = dr[i].FunctionGroup;
                        this.dgvSubMenu.Rows[this.dgvSubMenu.RowCount - 1].Cells[this.ColAssemblyEntryCount.Name].Value = dr[i].AssemblyEntryCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OrganizationBtn_OnOrgButtonSwitch_COPY(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("当前组织(厂区)下有未关闭的子功能，切换组织前请先关闭其他子功能", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OrganizationButton bt = (OrganizationButton)sender;
            string orgCode = string.Empty;
            string orgName = string.Empty;

            for (int i = 0; i < CenterCache.SMesCenterCache.UserOrgList.Count; i++)
            {
                if (CenterCache.SMesCenterCache.UserOrgList[i].OrgId == bt.OrgId)
                {
                    CenterCache.SMesCenterCache.UserOrgList[i].IsInUsed = true;
                    orgCode = CenterCache.SMesCenterCache.UserOrgList[i].OrgCode;
                    orgName = CenterCache.SMesCenterCache.UserOrgList[i].OrgName;
                }
                else
                {
                    CenterCache.SMesCenterCache.UserOrgList[i].IsInUsed = false;
                }
            }
            //////全局参数设置当前厂区ID和编码
            SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_ID", bt.OrgId);
            SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_CODE", orgCode);
            SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_NAME", orgName);

            /////////////
            LoadMenu(bt.OrgId);


            ////////////
            for (int i = 0; i < OrgBtnList.Count; i++)
            {
                if (OrgBtnList[i].OrgId == bt.OrgId)
                {
                    OrgBtnList[i].IsInUsed = true;
                }
                else
                {
                    OrgBtnList[i].IsInUsed = false;
                }
            }

        }

        private void OrganizationBtn_OnOrgButtonSwitch(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("当前组织(厂区)下有未关闭的子功能，切换组织前请先关闭其他子功能", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OrganizationButton bt = (OrganizationButton)sender;
            string orgCode = string.Empty;
            string orgName = string.Empty;

            for (int i = 0; i < OrgBtnList.Count; i++)
            {
                if (OrgBtnList[i].OrgId == bt.OrgId)
                {
                    try
                    {
                        OrgBtnList[i].IsInUsed = true;
                        orgCode = OrgBtnList[i].OrgId;
                        orgName = OrgBtnList[i].OrgName;
                        //////全局参数设置当前厂区ID和编码
                        SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_ID", bt.OrgId);
                        SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_CODE", orgCode);
                        SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_ORG_NAME", orgName);
                        dataGridViewEx1.DataSource = SqlHelper.ExecuteDataTable(Sql.CenterSql.InitFunctionName_Orgid_Username(orgCode, PropertyClass.OperatorName.ToString()), CommandType.Text, null);
                    }
                    catch
                    {

                    }
                    SetFormInfoShow_New();
                    break;
                }
                else
                {
                    OrgBtnList[i].IsInUsed = false;
                    continue;                   
                }
            }

            ///////////////
            //LoadMenu(bt.OrgId);


            //////////////
            for (int i = 0; i < OrgBtnList.Count; i++)
            {
                if (OrgBtnList[i].OrgId == bt.OrgId)
                {
                    OrgBtnList[i].IsInUsed = true;
                }
                else
                {
                    OrgBtnList[i].IsInUsed = false;
                }
            }
            
        }

        private void timerReflash_Tick(object sender, EventArgs e)
        {
            this.bgwDoReflash.RunWorkerAsync();
        }

        private void Workbench_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_loginSucess)
            {
                if (MessageBox.Show("是否要退出当前系统", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            this.timerReflash.Stop();
            if (bgwDoReflash.IsBusy)
            {
                bgwDoReflash.CancelAsync();
            }
        }

        private void bgwDoReflash_DoWork(object sender, DoWorkEventArgs e)
        {
            /////刷新最新的配置文件和lookupcode
            Services.ApplicationInitService.InitSysConfigs();
            ////比较是否有新的版本
            if (!CenterCache.SMesCenterCache.HasNewAssembleVersion)
            {
                List<string> serverAssemles = CenterUtil.GetNewUserAsssembles(SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId);
                ///////进行比较确认哪些需要更新
                for (int j = 0; j < serverAssemles.Count; j++)
                {
                    if (!CenterCache.SMesCenterCache.LocalAssembles.Contains(serverAssemles[j]))
                    {
                        CenterCache.SMesCenterCache.HasNewAssembleVersion = true;
                        break;
                    }
                }
            }
        }

        private void bgwDoReflash_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.tsslLoaderConfigStatus.Text = DateTime.Now.ToString("HH:mm:ss") + " 配置文件缓存刷新成功...";
            if (CenterCache.SMesCenterCache.HasNewAssembleVersion)
            {
                this.tsslNewVersionAlert.Text = "您有新程序更新，请重新登陆系统以获取更新...";
                this.tsslNewVersionIcon.Visible = true;
            }
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            this.smTabControl.ClearButtom();
        }

        private void dgvSubMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string exePath = SMes.Core.Utility.StrUtil.ValueToString(this.dgvSubMenu.Rows[e.RowIndex].Cells[this.ColExePath.Name].Value);
                ////////将用户打开记录写入数据库表
                try
                {
                    string funId = SMes.Core.Utility.StrUtil.ValueToString(this.dgvSubMenu.Rows[e.RowIndex].Cells[this.ColFunctionId.Name].Value);
                    string orgid = SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_ID");
                    string userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;

										CenterUtil.InsertEntryLog(SMes.Core.Config.ApplicationConfig.GetProperty("USERNAME"), funId, orgid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ///////////
                SMes.Core.Service.FunctionService.CallFunction(exePath);
            }
        }

        private void bgOrgs_Enter(object sender, EventArgs e)
        {

        }


				private void CSExeCall_User(string filepath,string User)
				{
					//路径：厂区编码/程序集名称文件夹/exe
					try
					{
						string exePath = filepath;
						ProcessStartInfo fileInfo = new ProcessStartInfo(exePath,User);
						Process.Start(fileInfo);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}

				}

        private void CSExeCall_New(string filepath)
        {
            //路径：厂区编码/程序集名称文件夹/exe
            try
            {
                string exePath =  filepath;
                ProcessStartInfo fileInfo = new ProcessStartInfo(exePath);
                Process.Start(fileInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 双击单元格触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewEx1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
							string exePath = System.Windows.Forms.Application.StartupPath + SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[e.RowIndex].Cells["功能路径"].Value) + @"/" + SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[e.RowIndex].Cells["功能路径"].Value)+".exe";
                ////////将用户打开记录写入数据库表
					 	try
                {
                    string funId = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[e.RowIndex].Cells["功能编号"].Value);
                    string funName = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[e.RowIndex].Cells["功能名称"].Value);
                    string orgid = SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_ID");
                    string userId = PropertyClass.OperatorID.ToString();
                    CenterUtil.UpdateFunctionUseNum(userId, funId,funName);
										try
										{
											//string funId = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[e.RowIndex].Cells["功能编号"].Value);
											//string orgid = SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_ID");
											//string userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
											CenterUtil.InsertEntryLog(userId, funId, orgid);
										}
										catch (Exception ex)
										{
											MessageBox.Show(ex.Message);
										}
                   // CSExeCall_New(exePath);
										CSExeCall_User(exePath, SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_User_ID"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ///////////
              
            }
        }

        private void dataGridViewEx1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   


     


 

    }
}
