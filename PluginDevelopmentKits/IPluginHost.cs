using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace PluginDevelopmentKits
{
    /// <summary>
    /// 通过本接口共享编辑器的数据成员
    /// </summary>
    public interface IPluginHost
    {
        /// <summary>
        /// 窗口标题
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// 状态栏控件
        /// </summary>
        StatusStrip StatusControl { get;  }
        /// <summary>
        /// 插件列表
        /// </summary>
        List<IPlugin> Plugins { get; }
        /// <summary>
        /// 主菜单
        /// </summary>
        MenuStrip MainMenu { get; }
        /// <summary>
        /// 富文本编辑器框
        /// </summary>
        RichTextBox TextBox { get; }
        /// <summary>
        /// Tab控件
        /// </summary>
        TabControl Pages { get; }
        /// <summary>
        /// 布局器控件
        /// </summary>
        TableLayoutPanel Layouter { get; }
        /// <summary>
        /// 主窗口
        /// </summary>
        Form Window { get; }
    }
}
