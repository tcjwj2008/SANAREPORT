using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMes.Core.Interface;

namespace SAEPIReoperateRpt
{
    public class Entry : SMes.Core.Interface.IMesPlugin
    {
        #region IMesPlugin 成员

        IApplication _application = null;
        public string PluginName
        {
            get { return "快测重投报表"; }
        }

        public string PluginDescription
        {
            get { return "快测重投报表"; }
        }

        public string PluginAuthor
        {
            get { return "江宏涛"; }
        }

        public SMes.Core.Interface.IApplication Application
        {
            get
            {
                return _application;
            }
            set
            {
                _application = value;
            }
        }

        public void Load()
        {
            MainForm mainForm = new MainForm();
            SMes.Controls.Utility.FormHelper.Show(mainForm, _application);
        }

        public void UnLoad()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
