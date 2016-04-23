using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeloduetMark.Utils
{
    /// <summary>
    /// 编辑器的文本框IO操作静态类
    /// </summary>
    public static class EditorIO
    {
        public static bool Saved = false;
        /// <summary>
        /// 最后一次打开的文件的路径
        /// </summary>
        public static string FilePath { get; set; }
        /// <summary>
        /// 打开指定文件
        /// </summary>
        /// <param name="path">文件地址</param>
        public static void Read(string path)
        {
            try
            {
                Utils.PluginUtil.CurMainWindow.TextBox.Text = System.IO.File.ReadAllText(path,Encoding.UTF8);
            }
            catch (ArgumentException)//处理参数错误
            {
                MessageBox.Show("参数错误，文件未保存！");
                return;
            }
            catch (System.UnauthorizedAccessException)//处理验证错误
            {
                MessageBox.Show("IO错误或权限不足，请尝试以管理员权限运行本程序！");
                return;
            }
            //读取成功后，更新FilePath的值
            FilePath = path;
            PluginUtil.CurMainWindow.OnTextChanged();
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        public static void Save()
        {
            try
            {
                //把文本框内容写入硬盘
                System.IO.File.WriteAllText(FilePath, Utils.PluginUtil.CurMainWindow.TextBox.Text, Encoding.UTF8);

            }
            catch (ArgumentException)//接收参数错误
            {
                MessageBox.Show("参数错误，文件未保存！");
                return;
            }
            catch (System.UnauthorizedAccessException)//接收验证错误
            {
                MessageBox.Show("IO错误或权限不足，请尝试以管理员权限运行本程序！");
                return;
            }
            Saved = true;

        }
        /// <summary>
        /// 保存文件（新路径）
        /// </summary>
        /// <param name="path">文件地址</param>
        public static void Save(string path)
        {
            //更新路径
            FilePath = path;
            //保存
            Save();
        }
    }
}
