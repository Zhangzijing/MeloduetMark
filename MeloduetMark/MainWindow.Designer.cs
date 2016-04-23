namespace MeloduetMark
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLayouter = new System.Windows.Forms.TableLayoutPanel();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsslFileState = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTabPage = new MeloduetMark.UI.MeloduetPages();
            this.tabPageEditor = new System.Windows.Forms.TabPage();
            this.TextEditor = new System.Windows.Forms.RichTextBox();
            this.tabPagePreview = new System.Windows.Forms.TabPage();
            this.Previewer = new System.Windows.Forms.WebBrowser();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOutputToHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlugins = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPluginMan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMDLang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTecSup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.MainLayouter.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.tabPageEditor.SuspendLayout();
            this.tabPagePreview.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayouter
            // 
            this.MainLayouter.ColumnCount = 2;
            this.MainLayouter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayouter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayouter.Controls.Add(this.MainStatusStrip, 0, 2);
            this.MainLayouter.Controls.Add(this.MainTabPage, 0, 1);
            this.MainLayouter.Controls.Add(this.MenuStrip, 0, 0);
            this.MainLayouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayouter.Location = new System.Drawing.Point(0, 0);
            this.MainLayouter.Name = "MainLayouter";
            this.MainLayouter.RowCount = 3;
            this.MainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.MainLayouter.Size = new System.Drawing.Size(787, 514);
            this.MainLayouter.TabIndex = 5;
            // 
            // MainStatusStrip
            // 
            this.MainLayouter.SetColumnSpan(this.MainStatusStrip, 2);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStatusLabel,
            this.toolStripSeparator1,
            this.tsslFileState});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 493);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(787, 21);
            this.MainStatusStrip.TabIndex = 5;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // MainStatusLabel
            // 
            this.MainStatusLabel.Name = "MainStatusLabel";
            this.MainStatusLabel.Size = new System.Drawing.Size(44, 16);
            this.MainStatusLabel.Text = "Ready";
            this.MainStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 21);
            // 
            // tsslFileState
            // 
            this.tsslFileState.AutoSize = false;
            this.tsslFileState.Name = "tsslFileState";
            this.tsslFileState.Size = new System.Drawing.Size(400, 16);
            this.tsslFileState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainTabPage
            // 
            this.MainLayouter.SetColumnSpan(this.MainTabPage, 2);
            this.MainTabPage.Controls.Add(this.tabPageEditor);
            this.MainTabPage.Controls.Add(this.tabPagePreview);
            this.MainTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabPage.Location = new System.Drawing.Point(3, 28);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.SelectedIndex = 0;
            this.MainTabPage.Size = new System.Drawing.Size(781, 462);
            this.MainTabPage.TabIndex = 4;
            this.MainTabPage.SelectedIndexChanged += new System.EventHandler(this.MainTabPage_SelectedIndexChanged);
            // 
            // tabPageEditor
            // 
            this.tabPageEditor.Controls.Add(this.TextEditor);
            this.tabPageEditor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageEditor.Location = new System.Drawing.Point(4, 26);
            this.tabPageEditor.Name = "tabPageEditor";
            this.tabPageEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditor.Size = new System.Drawing.Size(773, 432);
            this.tabPageEditor.TabIndex = 0;
            this.tabPageEditor.Text = "编辑";
            this.tabPageEditor.UseVisualStyleBackColor = true;
            this.tabPageEditor.Enter += new System.EventHandler(this.tabPageEditor_Enter);
            // 
            // TextEditor
            // 
            this.TextEditor.AcceptsTab = true;
            this.TextEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextEditor.DetectUrls = false;
            this.TextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextEditor.HideSelection = false;
            this.TextEditor.Location = new System.Drawing.Point(3, 3);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.ShortcutsEnabled = false;
            this.TextEditor.Size = new System.Drawing.Size(767, 426);
            this.TextEditor.TabIndex = 0;
            this.TextEditor.Text = "";
            this.TextEditor.TextChanged += new System.EventHandler(this.TextEditor_TextChanged);
            // 
            // tabPagePreview
            // 
            this.tabPagePreview.Controls.Add(this.Previewer);
            this.tabPagePreview.Location = new System.Drawing.Point(4, 26);
            this.tabPagePreview.Name = "tabPagePreview";
            this.tabPagePreview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreview.Size = new System.Drawing.Size(773, 432);
            this.tabPagePreview.TabIndex = 1;
            this.tabPagePreview.Text = "预览";
            this.tabPagePreview.UseVisualStyleBackColor = true;
            this.tabPagePreview.Enter += new System.EventHandler(this.tabPagePreview_Enter);
            // 
            // Previewer
            // 
            this.Previewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Previewer.Location = new System.Drawing.Point(3, 3);
            this.Previewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.Previewer.Name = "Previewer";
            this.Previewer.Size = new System.Drawing.Size(767, 426);
            this.Previewer.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.AllowItemReorder = true;
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainLayouter.SetColumnSpan(this.MenuStrip, 2);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiTools,
            this.tsmiView,
            this.tsmiHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(787, 25);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripMenuItem2,
            this.tsmiExport});
            this.tsmiFile.MergeIndex = 0;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 21);
            this.tsmiFile.Text = "文件(&F)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(206, 22);
            this.tsmiNew.Text = "新建(&N)";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(206, 22);
            this.tsmiOpen.Text = "打开(&O)";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(206, 22);
            this.tsmiSave.Text = "保存(&S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(206, 22);
            this.tsmiSaveAs.Text = "另存为(&A)";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 6);
            // 
            // tsmiExport
            // 
            this.tsmiExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOutputToHtml});
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(206, 22);
            this.tsmiExport.Text = "导出(&E)";
            // 
            // tsmiOutputToHtml
            // 
            this.tsmiOutputToHtml.Name = "tsmiOutputToHtml";
            this.tsmiOutputToHtml.Size = new System.Drawing.Size(137, 22);
            this.tsmiOutputToHtml.Text = "导出为html";
            this.tsmiOutputToHtml.Click += new System.EventHandler(this.tsmiOutputToHtml_Click);
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlugins,
            this.tsmiPluginMan});
            this.tsmiTools.MergeIndex = 97;
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(59, 21);
            this.tsmiTools.Text = "工具(&T)";
            // 
            // tsmiPlugins
            // 
            this.tsmiPlugins.Name = "tsmiPlugins";
            this.tsmiPlugins.Size = new System.Drawing.Size(200, 22);
            this.tsmiPlugins.Text = "插件(&P)";
            // 
            // tsmiPluginMan
            // 
            this.tsmiPluginMan.Name = "tsmiPluginMan";
            this.tsmiPluginMan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiPluginMan.Size = new System.Drawing.Size(200, 22);
            this.tsmiPluginMan.Text = "插件管理器(&M)";
            this.tsmiPluginMan.Click += new System.EventHandler(this.tsmiPluginMan_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPreview,
            this.tsmiFullScreen});
            this.tsmiView.MergeIndex = 98;
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(60, 21);
            this.tsmiView.Text = "视图(&V)";
            // 
            // tsmiPreview
            // 
            this.tsmiPreview.Name = "tsmiPreview";
            this.tsmiPreview.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiPreview.Size = new System.Drawing.Size(136, 22);
            this.tsmiPreview.Text = "预览(&P)";
            this.tsmiPreview.Click += new System.EventHandler(this.tsmiPreview_Click);
            // 
            // tsmiFullScreen
            // 
            this.tsmiFullScreen.CheckOnClick = true;
            this.tsmiFullScreen.Name = "tsmiFullScreen";
            this.tsmiFullScreen.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.tsmiFullScreen.Size = new System.Drawing.Size(136, 22);
            this.tsmiFullScreen.Text = "全屏";
            this.tsmiFullScreen.Click += new System.EventHandler(this.tsmiFullScreen_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMan,
            this.tsmiMDLang,
            this.toolStripMenuItem1,
            this.tsmiAbout,
            this.tsmiTecSup,
            this.tsmiFeedback});
            this.tsmiHelp.MergeIndex = 99;
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiMan
            // 
            this.tsmiMan.Name = "tsmiMan";
            this.tsmiMan.Size = new System.Drawing.Size(203, 22);
            this.tsmiMan.Text = "使用手册(&M)";
            this.tsmiMan.Click += new System.EventHandler(this.tsmiMan_Click);
            // 
            // tsmiMDLang
            // 
            this.tsmiMDLang.Name = "tsmiMDLang";
            this.tsmiMDLang.Size = new System.Drawing.Size(203, 22);
            this.tsmiMDLang.Text = "Markdown语法手册(&A)";
            this.tsmiMDLang.Click += new System.EventHandler(this.tsmiMDLang_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(203, 22);
            this.tsmiAbout.Text = "关于(&B)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiTecSup
            // 
            this.tsmiTecSup.Name = "tsmiTecSup";
            this.tsmiTecSup.Size = new System.Drawing.Size(203, 22);
            this.tsmiTecSup.Text = "技术支持(&T)";
            this.tsmiTecSup.Click += new System.EventHandler(this.tsmiTecSup_Click);
            // 
            // tsmiFeedback
            // 
            this.tsmiFeedback.Name = "tsmiFeedback";
            this.tsmiFeedback.Size = new System.Drawing.Size(203, 22);
            this.tsmiFeedback.Text = "意见反馈(&F)";
            this.tsmiFeedback.Click += new System.EventHandler(this.tsmiFeedback_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 514);
            this.Controls.Add(this.MainLayouter);
            this.Name = "MainWindow";
            this.Text = "Meloduet Mark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainLayouter.ResumeLayout(false);
            this.MainLayouter.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.MainTabPage.ResumeLayout(false);
            this.tabPageEditor.ResumeLayout(false);
            this.tabPagePreview.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayouter;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusLabel;
        private UI.MeloduetPages MainTabPage;
        private System.Windows.Forms.TabPage tabPageEditor;
        private System.Windows.Forms.RichTextBox TextEditor;
        private System.Windows.Forms.TabPage tabPagePreview;
        private System.Windows.Forms.WebBrowser Previewer;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiOutputToHtml;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        public System.Windows.Forms.ToolStripMenuItem tsmiPlugins;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreview;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiMan;
        private System.Windows.Forms.ToolStripMenuItem tsmiMDLang;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiTecSup;
        private System.Windows.Forms.ToolStripMenuItem tsmiFeedback;
        private System.Windows.Forms.ToolStripStatusLabel tsslFileState;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFullScreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiPluginMan;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
    }
}

