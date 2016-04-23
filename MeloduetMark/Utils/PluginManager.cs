using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using PluginDevelopmentKits;

namespace MeloduetMark.Utils
{
    /// <summary>
    /// 插件管理类
    /// </summary>
    public class PluginUtil
    {
        /// <summary>
        /// 当前主窗口，从外部设置
        /// </summary>
        public static MainWindow CurMainWindow { get; set; }
        /// <summary>
        /// 加载插件
        /// </summary>
        public static void Load()
        {
            //如果插件目录不存在，那么创建
            if (!Directory.Exists(Application.StartupPath + "\\plugins"))
                Directory.CreateDirectory(Application.StartupPath + "\\plugins");
            //得到所有dll文件，保存到files数组
            string[] files = Directory.GetFiles(Application.StartupPath + @"\plugins", "*.dll");
            //遍历所有的dll
            foreach (var item in files)
            {
               
                try
                {
                    //加载Assembly         
                    Assembly assembly = Assembly.LoadFrom(item);
                    //GetTypes
                    Type[] types = assembly.GetTypes();
                    /*
                        遍历Types，找到实现IPlugin的类，转换为插件的实例，为它设置Editor属性（=CurWindow），
                        把它添加到菜单栏和插件列表。
                    */
                    foreach (var type in types)
                    {

                        if (type.GetInterface("IPlugin") != null)
                        {
                            Object obj = type.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                            IPlugin plugin = (IPlugin)obj;
                            plugin.Editor = CurMainWindow;


                            CurMainWindow.tsmiPlugins.DropDownItems.Add(plugin.Name, null, plugin.OnMenuItemClicked);
                            plugin.OnEnable();
                            CurMainWindow.Plugins.Add(plugin);
                            plugin.Enabled = true;
                        }//end if
                    }//end foreach
                }
                catch (ReflectionTypeLoadException)//如果引发了类型加载失败的异常
                {
                    MessageBox.Show("文件：" + item + "无法加载，请检查是否损坏！");
                }//end try
                

            }
        }
        private static void OnPluginsLoaded()
        {

        }
    }
}
