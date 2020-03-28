using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMesCenter.AppObj;

namespace SMesCenter.UserControls
{
    public partial class OrganizationButton : UserControl
    {
        public event OrganizationButtonClickedEventHandler OnOrgButtonSwitch;

        private string _orgId = string.Empty;

        public string OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }
        private string _orgName = string.Empty;

        public string OrgName
        {
            get { return _orgName; }
            set 
            { 
                _orgName = value;
                this.btOrg.Text = _orgName;
            }
        }
        private bool _isInUsed = false;

        public bool IsInUsed
        {
            get { return _isInUsed; }
            set
            {
                _isInUsed = value;
                if (_isInUsed)
                {
                    this.pbStatus.Image = global::SMesCenter.Properties.Resources.OrgSelected;
                    this.btOrg.Enabled = false;
                }
                else
                {
                    this.pbStatus.Image = global::SMesCenter.Properties.Resources.OrgUnSelect;
                    this.btOrg.Enabled = true;
                }
            }
        }

        public OrganizationButton()
        {
            InitializeComponent();
        }

        public OrganizationButton(string orgId,string orgName,bool isInUsed)
        {
            _orgId = orgId;
            _orgName = orgName;
            _isInUsed = isInUsed;
            InitializeComponent();
        }

        private void OrganizationButton_Load(object sender, EventArgs e)
        {
            this.btOrg.Text = _orgName;
            IsInUsed = _isInUsed;
        }

        private void btOrg_Click(object sender, EventArgs e)
        {
            /////触发出事件
            if (OnOrgButtonSwitch != null)
            {
                OrganizationButtonClickedEventHandler invoke = OnOrgButtonSwitch;
                invoke(this, e);
            }
        }

    }
}
