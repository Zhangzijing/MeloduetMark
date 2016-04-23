using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeloduetMark.Forms
{
    public partial class PluginMan : Form
    {
        public PluginMan()
        {
            InitializeComponent();
        }

        private void PluginMan_Load(object sender, EventArgs e)
        {
            LoadPluginsToListView();
        }
        private string GetStatus(bool b)
        {
            if (b)
            {
                return "";
            }
            else
            {
                return "(禁用)";
            }
        }
        private void LoadPluginsToListView()
        {
            lvPlugins.Items.Clear();
            foreach (var plug in Utils.PluginUtil.CurMainWindow.Plugins)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = plug.Name + GetStatus(plug.Enabled);
                if (plug.Icon != null)
                {
                    imgList.Images.Add(plug.Icon);
                    lvi.ImageIndex = imgList.Images.Count - 1;
                }
                else
                {
                    lvi.ImageIndex = 0;
                }
                lvPlugins.Items.Add(lvi);
            }
        }

        private void lvPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPlugins.SelectedIndices.Count != 1) return;
            var sel = Utils.PluginUtil.CurMainWindow.Plugins[lvPlugins.SelectedIndices[0]];
            string info = string.Format("名称：{0}\r\n作者：{1}\r\n简介：\r\n    {2}\r\n插件版本：{3}\r\n支持的版本：{4}",
                sel.Name, sel.Author, sel.Description, sel.PluginVersion, sel.SupportedVersion);
            lkUpdate.Tag = sel.UpdateURL;
            lkWebsite.Tag = sel.Website;
            lblPlugInfo.Text = info;

        }

        private void lkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!lkWebsite.Tag.ToString().StartsWith("http"))
            {
                return;
            }
            System.Diagnostics.Process.Start(lkWebsite.Tag.ToString());
            lkWebsite.LinkVisited = false;
        }

        private void lkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!lkUpdate.Tag.ToString().StartsWith("http"))
            {
                return;
            }
            System.Diagnostics.Process.Start(lkUpdate.Tag.ToString());
            lkUpdate.LinkVisited = false;
        }

        private void tsEnable_Click(object sender, EventArgs e)
        {

            for (int index = 0; index < lvPlugins.SelectedIndices.Count; index++)
            {
                var sel = Utils.PluginUtil.CurMainWindow.Plugins[lvPlugins.SelectedIndices[index]];
                if (sel.Enabled) continue;
                sel.Enabled = true; 
                sel.OnEnable();
                var lvi = lvPlugins.Items[lvPlugins.SelectedIndices[index]];
                
                lvi.Text = sel.Name + GetStatus(sel.Enabled);
            }


        }

        private void tsDisable_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < lvPlugins.SelectedIndices.Count; index++)
            {
                var sel = Utils.PluginUtil.CurMainWindow.Plugins[lvPlugins.SelectedIndices[index]];
                if (!sel.Enabled) continue;
                sel.Enabled = false;
                sel.OnDisable();
                var lvi = lvPlugins.Items[lvPlugins.SelectedIndices[index]];

                lvi.Text = sel.Name + GetStatus(sel.Enabled);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < lvPlugins.SelectedIndices.Count; index++)
            {
                var sel = Utils.PluginUtil.CurMainWindow.Plugins[lvPlugins.SelectedIndices[index]];
                if (sel.Enabled) continue;
                sel.Enabled = true;
                sel.OnReload();
                var lvi = lvPlugins.Items[lvPlugins.SelectedIndices[index]];

                lvi.Text = sel.Name + GetStatus(sel.Enabled);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (lvPlugins.SelectedIndices.Count != 1) return;
            var sel = Utils.PluginUtil.CurMainWindow.Plugins[lvPlugins.SelectedIndices[0]];
            if (sel.OnSettingClicked==null)
            {
                MessageBox.Show("本插件不支持设置！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sel.OnSettingClicked.Invoke(null,null);

        }
    }
}
