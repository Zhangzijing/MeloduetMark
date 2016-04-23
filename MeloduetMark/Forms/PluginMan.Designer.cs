namespace MeloduetMark.Forms
{
    partial class PluginMan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginMan));
            this.lvPlugins = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lkWebsite = new System.Windows.Forms.LinkLabel();
            this.lkUpdate = new System.Windows.Forms.LinkLabel();
            this.lblPlugInfo = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsEnable = new System.Windows.Forms.ToolStripButton();
            this.tsDisable = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPlugins
            // 
            this.lvPlugins.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvPlugins.HideSelection = false;
            this.lvPlugins.LargeImageList = this.imgList;
            this.lvPlugins.Location = new System.Drawing.Point(0, 0);
            this.lvPlugins.Name = "lvPlugins";
            this.lvPlugins.Size = new System.Drawing.Size(350, 251);
            this.lvPlugins.SmallImageList = this.imgList;
            this.lvPlugins.TabIndex = 0;
            this.lvPlugins.UseCompatibleStateImageBehavior = false;
            this.lvPlugins.SelectedIndexChanged += new System.EventHandler(this.lvPlugins_SelectedIndexChanged);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "plugin.png");
            // 
            // lkWebsite
            // 
            this.lkWebsite.AutoSize = true;
            this.lkWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkWebsite.Location = new System.Drawing.Point(455, 230);
            this.lkWebsite.Name = "lkWebsite";
            this.lkWebsite.Size = new System.Drawing.Size(53, 12);
            this.lkWebsite.TabIndex = 2;
            this.lkWebsite.TabStop = true;
            this.lkWebsite.Text = "作者网站";
            this.lkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkWebsite_LinkClicked);
            // 
            // lkUpdate
            // 
            this.lkUpdate.AutoSize = true;
            this.lkUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkUpdate.Location = new System.Drawing.Point(514, 230);
            this.lkUpdate.Name = "lkUpdate";
            this.lkUpdate.Size = new System.Drawing.Size(53, 12);
            this.lkUpdate.TabIndex = 3;
            this.lkUpdate.TabStop = true;
            this.lkUpdate.Text = "更新地址";
            this.lkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkUpdate_LinkClicked);
            // 
            // lblPlugInfo
            // 
            this.lblPlugInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblPlugInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPlugInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlugInfo.Location = new System.Drawing.Point(356, 28);
            this.lblPlugInfo.Multiline = true;
            this.lblPlugInfo.Name = "lblPlugInfo";
            this.lblPlugInfo.ReadOnly = true;
            this.lblPlugInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblPlugInfo.Size = new System.Drawing.Size(214, 189);
            this.lblPlugInfo.TabIndex = 4;
            this.lblPlugInfo.Text = "名称：\r\n作者：\r\n简介：\r\n插件版本：\r\n支持的版本：\r\n";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEnable,
            this.tsDisable,
            this.btnReload,
            this.btnSetting});
            this.toolStrip.Location = new System.Drawing.Point(350, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(220, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsEnable
            // 
            this.tsEnable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEnable.Image = ((System.Drawing.Image)(resources.GetObject("tsEnable.Image")));
            this.tsEnable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEnable.Name = "tsEnable";
            this.tsEnable.Size = new System.Drawing.Size(23, 22);
            this.tsEnable.Text = "启用";
            this.tsEnable.Click += new System.EventHandler(this.tsEnable_Click);
            // 
            // tsDisable
            // 
            this.tsDisable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDisable.Image = ((System.Drawing.Image)(resources.GetObject("tsDisable.Image")));
            this.tsDisable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDisable.Name = "tsDisable";
            this.tsDisable.Size = new System.Drawing.Size(23, 22);
            this.tsDisable.Text = "禁用";
            this.tsDisable.Click += new System.EventHandler(this.tsDisable_Click);
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(23, 22);
            this.btnReload.Text = "重启";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(23, 22);
            this.btnSetting.Text = "设置";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // PluginMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 251);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lkUpdate);
            this.Controls.Add(this.lkWebsite);
            this.Controls.Add(this.lvPlugins);
            this.Controls.Add(this.lblPlugInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PluginMan";
            this.Text = "插件管理器";
            this.Load += new System.EventHandler(this.PluginMan_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPlugins;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.LinkLabel lkWebsite;
        private System.Windows.Forms.LinkLabel lkUpdate;
        private System.Windows.Forms.TextBox lblPlugInfo;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsEnable;
        private System.Windows.Forms.ToolStripButton tsDisable;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnSetting;
    }
}