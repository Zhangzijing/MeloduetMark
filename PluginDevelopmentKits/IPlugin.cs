using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PluginDevelopmentKits
{
    /// <summary>
    /// 插件接口 - 所有插件必须实现该接口
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// 名
        /// </summary>
        string Name { get; }
        /// <summary>
        /// 描述
        /// </summary>
        string Description { get; }
        /// <summary>
        /// 作者
        /// </summary>
        string Author { get; }
        /// <summary>
        /// 作者网站
        /// </summary>
        string Website { get; }
        /// <summary>
        /// 更新链接，如果是支持自动更新的，请按照指定格式编写网页
        /// </summary>
        string UpdateURL { get; }
        /// <summary>
        /// 是否可自动更新
        /// </summary>
        bool AutoUpdatable { get; }
        /// <summary>
        /// 插件版本
        /// </summary>
        Version PluginVersion { get; }
        /// <summary>
        /// 支持的编辑器最新版本
        /// </summary>
        Version SupportedVersion { get; }
        /// <summary>
        /// 图标
        /// </summary>
        Image Icon { get; set; }
        bool Enabled { get; set; }
        /// <summary>
        /// 编辑器，由编辑器自动设置，不必更改。
        /// </summary>
        IPluginHost Editor { get; set; }
        /// <summary>
        /// 当菜单栏“工具->插件”里，该插件的对应项被点击时的事件
        /// </summary>
        EventHandler OnMenuItemClicked { get; set; }
        EventHandler OnSettingClicked { get; set; }
        /// <summary>
        /// 启用时发生
        /// </summary>
        void OnEnable();
        /// <summary>
        /// 禁用时发生
        /// </summary>
        void OnDisable();
        /// <summary>
        /// 重启时发生
        /// </summary>
        void OnReload();


    }

}
