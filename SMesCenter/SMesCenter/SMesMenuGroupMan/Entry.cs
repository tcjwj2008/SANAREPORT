﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMes.Core.Interface;

namespace SMesMenuGroupMan
{
    public class Entry : SMes.Core.Interface.IMesPlugin
    {
        #region IMesPlugin 成员

        IApplication _application = null;
        public string PluginName
        {
            get { return "菜单组管理"; }
        }

        public string PluginDescription
        {
            get { return "菜单组管理"; }
        }

        public string PluginAuthor
        {
            get { return "chsl"; }
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
