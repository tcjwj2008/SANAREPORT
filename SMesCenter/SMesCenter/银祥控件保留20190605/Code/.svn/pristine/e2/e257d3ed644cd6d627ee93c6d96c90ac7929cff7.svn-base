using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Core.Interface
{
    public interface IMesPlugin
    {
        /// <summary>
        /// 插件名称
        /// </summary>
        /// <returns></returns>
        string PluginName { get; }

        /// <summary>
        /// 插件描述
        /// </summary>
        /// <returns></returns>
        string PluginDescription { get; }

        /// <summary>
        /// 作者信息
        /// </summary>
        /// <returns></returns>
        string PluginAuthor { get; }

        /// <summary>
        /// 得到主程序实例
        /// </summary>
        /// <returns></returns>
        IApplication Application { get; set; }

        /// <summary>
        /// 装载插件
        /// </summary>
        /// <returns></returns>
        void Load();

        ///<summary>
        ///卸载插件
        ///</summary>
        ///<returns></returns>
        void UnLoad();

        //event EventHandler<EventArgs> Loading;
    }
}
