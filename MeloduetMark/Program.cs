using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MeloduetMark
{
    /// <summary>
    /// Program类
    /// </summary>
    public static class Program
    {
       
        /// <summary>
        /// 程序入口函数
        /// </summary>
        /// <param name="args">参数列表</param>
        [STAThread] //主线程
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Utils.PluginUtil.CurMainWindow = new MainWindow();
            //接收参数
            if (args.Length == 1)
            {
                //如果参数是个存在的文件，打开
                if (System.IO.File.Exists(args[0]))
                {
                    Utils.EditorIO.Read(args[0]);
                }
            }
            //运行应用程序
            Application.Run(Utils.PluginUtil.CurMainWindow);
            
        }
    }
}
