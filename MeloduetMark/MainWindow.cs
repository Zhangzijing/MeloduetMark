using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PluginDevelopmentKits;

namespace MeloduetMark
{
    public partial class MainWindow : Form, IPluginHost
    {
        public MainWindow()
        {
            //初始化插件列表，初始化IPluginHost.Window
            InitializeComponent();            
            this.Plugins = new List<IPlugin>();
            Window = this;
        }
        #region IPluginHost必须实现的
        public string Title { get { return this.Text; } set { Text = value; } }
        public StatusStrip StatusControl { get { return this.MainStatusStrip; }}

        public List<IPlugin> Plugins { get; }
        public MenuStrip MainMenu { get { return MenuStrip; } }
        public RichTextBox TextBox { get { return TextEditor; } }
        public TabControl Pages { get { return MainTabPage; } }
        public TableLayoutPanel Layouter { get { return MainLayouter; } }
        public Form Window { get; }
        #endregion

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //初始化PluginUtil类
            Utils.PluginUtil.CurMainWindow = this;
            Utils.PluginUtil.Load();
            

        }

        //切换Tabpage
        private void tsmiPreview_Click(object sender, EventArgs e)
        {
            if(MainTabPage.SelectedTab==tabPagePreview)
            {
                MainTabPage.SelectedTab =tabPageEditor;
            }
            else
            {
                MainTabPage.SelectedTab = tabPagePreview;
                
            }
        }


        //显示预览
        private void tabPagePreview_Enter(object sender, EventArgs e)
        {
            Previewer.DocumentText = Utils.MarkdownSimply.GetHtmlText(TextBox.Text);
        }

        private void tsmiOutputToHtml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "html(*.html)|*.html";
            sfd.ShowDialog();
            try
            {
                System.IO.File.WriteAllText(sfd.FileName, Utils.MarkdownSimply.GetHtmlText(TextBox.Text));
                tsslFileState.Text = "<已导出>" + sfd.FileName;
            }
            catch (ArgumentException)
            {
                return;
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (!Utils.EditorIO.Saved && DialogResult.OK!=MessageBox.Show("文件还没有保存，是否忽略并继续？", "提示", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information)) return;
            

            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Markdown文本文件(*.md;*.markdown)|*.md;*.markdown";
            ofg.ShowDialog();
            if (!System.IO.File.Exists(ofg.FileName))
            {
                MessageBox.Show("打开的文件不存在", "错误",MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            try
            {
                Utils.EditorIO.Read(ofg.FileName);

            }
            catch (ArgumentException)
            {
                MessageBox.Show("路径错误，文件未打开。");
            }

        }

        private void tabPageEditor_Enter(object sender, EventArgs e)
        {
            
        }

        private void MainTabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pages.SelectedIndex == 0)
            {
                TextBox.Focus();
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (Utils.EditorIO.FilePath!=null)
            {
                Utils.EditorIO.Save();

                tsslFileState.Text = "<已保存>" + Utils.EditorIO.FilePath;
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Markdown文本文件(*.md;*.markdown)|*.md;*.markdown";
            sfd.ShowDialog();
        
            Utils.EditorIO.Save(sfd.FileName);
           if(Utils.EditorIO.Saved) tsslFileState.Text = "<已保存>" + Utils.EditorIO.FilePath;

            
        }

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged();
        }
        public void OnTextChanged()
        {
            if (Utils.EditorIO.FilePath != null)
            {
                tsslFileState.Text = "<未保存>" + Utils.EditorIO.FilePath;
            }
            else
            {
                tsslFileState.Text = "<未保存>未命名文件";
            }
        }
        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Markdown文本文件(*.md;*.markdown)|*.md;*.markdown";
            sfd.ShowDialog();

                Utils.EditorIO.Save(sfd.FileName);
            if (Utils.EditorIO.Saved) tsslFileState.Text = "<已保存>" + Utils.EditorIO.FilePath;

        }

        private void tsmiMan_Click(object sender, EventArgs e)
        {
            var file = (Application.StartupPath + @"\help\index.html");
            if (System.IO.File.Exists(file)) {
                System.Diagnostics.Process.Start(file);
            }
        }

        private void tsmiMDLang_Click(object sender, EventArgs e)
        {
            var file = (Application.StartupPath + @"\help\md.html");
            if (System.IO.File.Exists(file))
            {
                System.Diagnostics.Process.Start(file);
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            //var file = (Application.StartupPath + @"\help\about.html");
            //if (System.IO.File.Exists(file))
            //{
            //    System.Diagnostics.Process.Start(file);
            //}
            new Forms.AboutBox().ShowDialog();
        }

        private void tsmiTecSup_Click(object sender, EventArgs e)
        {
            var file = (Application.StartupPath + @"\help\tec.html");
            if (System.IO.File.Exists(file))
            {
                System.Diagnostics.Process.Start(file);
            }
        }

        private void tsmiFeedback_Click(object sender, EventArgs e)
        {
            var file = (Application.StartupPath + @"\help\feedback.html");
            if (System.IO.File.Exists(file))
            {
                System.Diagnostics.Process.Start(file);
            }
        }
        //全屏切换
        private void tsmiFullScreen_Click(object sender, EventArgs e)
        {
            
            if (tsmiFullScreen.Checked)
            {

                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                MainStatusLabel.Text = "全屏模式 按F11退出全屏";
            }
            else
            {

                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                MainStatusLabel.Text = "";
            }
        }

        private void tsmiPluginMan_Click(object sender, EventArgs e)
        {
            new Forms.PluginMan().ShowDialog();
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            if (!Utils.EditorIO.Saved && DialogResult.OK != MessageBox.Show("文件还没有保存，是否忽略并继续？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                return;


            TextBox.Clear();
            Utils.EditorIO.FilePath = null;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Utils.EditorIO.Saved && DialogResult.OK != MessageBox.Show("文件还没有保存，是否忽略并继续？", "提示",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                e.Cancel = true; 
        }
    }
}
