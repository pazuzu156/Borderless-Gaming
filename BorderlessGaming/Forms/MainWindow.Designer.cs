using BorderlessGaming.Logic.Core;
using BorderlessGaming.Properties;

namespace BorderlessGaming.Forms
{
    partial class MainWindow
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
            this.btnMakeBorderless = new System.Windows.Forms.Button();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.processContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAddToFavs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByTheWindowTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByRegex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextBorderless = new System.Windows.Forms.ToolStripMenuItem();
            this.contextBorderlessOn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSetWindowTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHideProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFavScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.addSelectedItem = new System.Windows.Forms.Button();
            this.lstFavorites = new System.Windows.Forms.ListBox();
            this.mnuFavoritesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNoSizeChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSetSetWindowSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAutomaximize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdjustWindowBounds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDelayBorderless = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHideMouseCursor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHideWindowsTaskbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRemoveMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMuteInBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRemoveFromFavs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveFavorite = new System.Windows.Forms.Button();
            this.processLabel = new System.Windows.Forms.Label();
            this.favoritesLabel = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.toolStripOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRunOnStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLanguages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGlobalHotkey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMouseLock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMouseHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMinimizedToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCloseToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHideBalloonTips = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSlowWindowDetection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripViewFullProcessDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRestoreProcesses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPauseAutomaticProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOpenDataFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripToggleMouseCursorVisibility = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripToggleWindowsTaskbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFullApplicationRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsageGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRegexReference = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripReportBug = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSupportUs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRestoreWindow = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.processContext.SuspendLayout();
            this.mnuFavoritesContext.SuspendLayout();
            this.trayIconContextMenu.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakeBorderless
            // 
            this.btnMakeBorderless.Image = global::BorderlessGaming.Properties.Resources.Borderless;
            this.btnMakeBorderless.Location = new System.Drawing.Point(3, 45);
            this.btnMakeBorderless.Name = "btnMakeBorderless";
            this.btnMakeBorderless.Size = new System.Drawing.Size(37, 36);
            this.btnMakeBorderless.TabIndex = 1;
            this.btnMakeBorderless.UseVisualStyleBackColor = true;
            this.btnMakeBorderless.Click += new System.EventHandler(this.btnMakeBorderless_Click);
            this.btnMakeBorderless.MouseHover += new System.EventHandler(this.btnMakeBorderless_MouseHover);
            // 
            // lstProcesses
            // 
            this.lstProcesses.ContextMenuStrip = this.processContext;
            this.lstProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.IntegralHeight = false;
            this.lstProcesses.Location = new System.Drawing.Point(11, 24);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(240, 161);
            this.lstProcesses.Sorted = true;
            this.lstProcesses.TabIndex = 0;
            this.lstProcesses.SelectedIndexChanged += new System.EventHandler(this.lstProcesses_SelectedIndexChanged);
            // 
            // processContext
            // 
            this.processContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAddToFavs,
            this.toolStripMenuItem1,
            this.contextBorderless,
            this.contextBorderlessOn,
            this.toolStripSetWindowTitle,
            this.toolStripMenuItem8,
            this.toolStripHideProcess});
            this.processContext.Name = "processContext";
            this.processContext.Size = new System.Drawing.Size(187, 126);
            this.processContext.Opening += new System.ComponentModel.CancelEventHandler(this.processContext_Opening);
            // 
            // contextAddToFavs
            // 
            this.contextAddToFavs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripByTheWindowTitle,
            this.toolStripByRegex,
            this.toolStripByProcess});
            this.contextAddToFavs.Name = "contextAddToFavs";
            this.contextAddToFavs.Size = new System.Drawing.Size(186, 22);
            this.contextAddToFavs.Text = "Add to Favorites...";
            // 
            // toolStripByTheWindowTitle
            // 
            this.toolStripByTheWindowTitle.Name = "toolStripByTheWindowTitle";
            this.toolStripByTheWindowTitle.Size = new System.Drawing.Size(250, 22);
            this.toolStripByTheWindowTitle.Text = "... by the window title text";
            this.toolStripByTheWindowTitle.Click += new System.EventHandler(this.byTheWindowTitleTextToolStripMenuItem_Click);
            // 
            // toolStripByRegex
            // 
            this.toolStripByRegex.Name = "toolStripByRegex";
            this.toolStripByRegex.Size = new System.Drawing.Size(250, 22);
            this.toolStripByRegex.Text = "... by the window title text (regex)";
            this.toolStripByRegex.Click += new System.EventHandler(this.byTheWindowTitleTextregexToolStripMenuItem_Click);
            // 
            // toolStripByProcess
            // 
            this.toolStripByProcess.Name = "toolStripByProcess";
            this.toolStripByProcess.Size = new System.Drawing.Size(250, 22);
            this.toolStripByProcess.Text = "... by the process binary name";
            this.toolStripByProcess.Click += new System.EventHandler(this.byTheProcessBinaryNameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // contextBorderless
            // 
            this.contextBorderless.Name = "contextBorderless";
            this.contextBorderless.Size = new System.Drawing.Size(186, 22);
            this.contextBorderless.Text = "Make Borderless";
            this.contextBorderless.Click += new System.EventHandler(this.btnMakeBorderless_Click);
            // 
            // contextBorderlessOn
            // 
            this.contextBorderlessOn.Name = "contextBorderlessOn";
            this.contextBorderlessOn.Size = new System.Drawing.Size(186, 22);
            this.contextBorderlessOn.Text = "Make Borderless on...";
            // 
            // toolStripSetWindowTitle
            // 
            this.toolStripSetWindowTitle.Name = "toolStripSetWindowTitle";
            this.toolStripSetWindowTitle.Size = new System.Drawing.Size(186, 22);
            this.toolStripSetWindowTitle.Text = "Set Window Title";
            this.toolStripSetWindowTitle.Click += new System.EventHandler(this.setWindowTitleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(183, 6);
            // 
            // toolStripHideProcess
            // 
            this.toolStripHideProcess.Name = "toolStripHideProcess";
            this.toolStripHideProcess.Size = new System.Drawing.Size(186, 22);
            this.toolStripHideProcess.Text = "Hide This Process";
            this.toolStripHideProcess.Click += new System.EventHandler(this.hideThisProcessToolStripMenuItem_Click);
            // 
            // contextFavScreen
            // 
            this.contextFavScreen.Name = "contextFavScreen";
            this.contextFavScreen.Size = new System.Drawing.Size(207, 22);
            this.contextFavScreen.Text = "Select Favorite Screen...";
            // 
            // addSelectedItem
            // 
            this.addSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addSelectedItem.AutoSize = true;
            this.addSelectedItem.Image = global::BorderlessGaming.Properties.Resources.Add;
            this.addSelectedItem.Location = new System.Drawing.Point(3, 3);
            this.addSelectedItem.Name = "addSelectedItem";
            this.addSelectedItem.Size = new System.Drawing.Size(37, 36);
            this.addSelectedItem.TabIndex = 7;
            this.addSelectedItem.UseVisualStyleBackColor = true;
            this.addSelectedItem.Click += new System.EventHandler(this.addSelectedItem_Click);
            this.addSelectedItem.MouseHover += new System.EventHandler(this.addSelectedItem_MouseHover);
            // 
            // lstFavorites
            // 
            this.lstFavorites.ContextMenuStrip = this.mnuFavoritesContext;
            this.lstFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFavorites.FormattingEnabled = true;
            this.lstFavorites.IntegralHeight = false;
            this.lstFavorites.Location = new System.Drawing.Point(305, 24);
            this.lstFavorites.Name = "lstFavorites";
            this.lstFavorites.Size = new System.Drawing.Size(240, 161);
            this.lstFavorites.Sorted = true;
            this.lstFavorites.TabIndex = 10;
            this.lstFavorites.SelectedIndexChanged += new System.EventHandler(this.lstFavorites_SelectedIndexChanged);
            // 
            // mnuFavoritesContext
            // 
            this.mnuFavoritesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFullScreen,
            this.toolStripNoSizeChange,
            this.toolStripSetSetWindowSize,
            this.toolStripMenuItem6,
            this.toolStripAutomaximize,
            this.toolStripAdjustWindowBounds,
            this.toolStripMenuItem4,
            this.toolStripAlwaysOnTop,
            this.toolStripDelayBorderless,
            this.toolStripHideMouseCursor,
            this.toolStripHideWindowsTaskbar,
            this.toolStripRemoveMenus,
            this.toolStripMenuItem9,
            this.contextFavScreen,
            this.toolStripMuteInBackground,
            this.contextRemoveFromFavs});
            this.mnuFavoritesContext.Name = "mnuFavoritesRightClick";
            this.mnuFavoritesContext.Size = new System.Drawing.Size(208, 308);
            this.mnuFavoritesContext.Opening += new System.ComponentModel.CancelEventHandler(this.mnuFavoritesContext_Opening);
            // 
            // toolStripFullScreen
            // 
            this.toolStripFullScreen.CheckOnClick = true;
            this.toolStripFullScreen.Name = "toolStripFullScreen";
            this.toolStripFullScreen.Size = new System.Drawing.Size(207, 22);
            this.toolStripFullScreen.Text = "Full Screen";
            this.toolStripFullScreen.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // toolStripNoSizeChange
            // 
            this.toolStripNoSizeChange.CheckOnClick = true;
            this.toolStripNoSizeChange.Name = "toolStripNoSizeChange";
            this.toolStripNoSizeChange.Size = new System.Drawing.Size(207, 22);
            this.toolStripNoSizeChange.Text = "No Size Change";
            this.toolStripNoSizeChange.Click += new System.EventHandler(this.noSizeChangeToolStripMenuItem_Click);
            // 
            // toolStripSetSetWindowSize
            // 
            this.toolStripSetSetWindowSize.Name = "toolStripSetSetWindowSize";
            this.toolStripSetSetWindowSize.Size = new System.Drawing.Size(207, 22);
            this.toolStripSetSetWindowSize.Text = "Set Window Size";
            this.toolStripSetSetWindowSize.Click += new System.EventHandler(this.setWindowSizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(204, 6);
            // 
            // toolStripAutomaximize
            // 
            this.toolStripAutomaximize.CheckOnClick = true;
            this.toolStripAutomaximize.Name = "toolStripAutomaximize";
            this.toolStripAutomaximize.Size = new System.Drawing.Size(207, 22);
            this.toolStripAutomaximize.Text = "Auto-Maximize";
            this.toolStripAutomaximize.Click += new System.EventHandler(this.automaximizeToolStripMenuItem_Click);
            // 
            // toolStripAdjustWindowBounds
            // 
            this.toolStripAdjustWindowBounds.Name = "toolStripAdjustWindowBounds";
            this.toolStripAdjustWindowBounds.Size = new System.Drawing.Size(207, 22);
            this.toolStripAdjustWindowBounds.Text = "Adjust Window Bounds";
            this.toolStripAdjustWindowBounds.Click += new System.EventHandler(this.adjustWindowBoundsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(204, 6);
            // 
            // toolStripAlwaysOnTop
            // 
            this.toolStripAlwaysOnTop.CheckOnClick = true;
            this.toolStripAlwaysOnTop.Name = "toolStripAlwaysOnTop";
            this.toolStripAlwaysOnTop.Size = new System.Drawing.Size(207, 22);
            this.toolStripAlwaysOnTop.Text = "Always On Top";
            this.toolStripAlwaysOnTop.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // toolStripDelayBorderless
            // 
            this.toolStripDelayBorderless.CheckOnClick = true;
            this.toolStripDelayBorderless.Name = "toolStripDelayBorderless";
            this.toolStripDelayBorderless.Size = new System.Drawing.Size(207, 22);
            this.toolStripDelayBorderless.Text = "Delay Borderless Window";
            this.toolStripDelayBorderless.Click += new System.EventHandler(this.delayBorderlessToolStripMenuItem_Click);
            // 
            // toolStripHideMouseCursor
            // 
            this.toolStripHideMouseCursor.CheckOnClick = true;
            this.toolStripHideMouseCursor.Name = "toolStripHideMouseCursor";
            this.toolStripHideMouseCursor.Size = new System.Drawing.Size(207, 22);
            this.toolStripHideMouseCursor.Text = "Hide Mouse Cursor";
            this.toolStripHideMouseCursor.Click += new System.EventHandler(this.hideMouseCursorToolStripMenuItem_Click);
            // 
            // toolStripHideWindowsTaskbar
            // 
            this.toolStripHideWindowsTaskbar.CheckOnClick = true;
            this.toolStripHideWindowsTaskbar.Name = "toolStripHideWindowsTaskbar";
            this.toolStripHideWindowsTaskbar.Size = new System.Drawing.Size(207, 22);
            this.toolStripHideWindowsTaskbar.Text = "Hide Windows Taskbar";
            this.toolStripHideWindowsTaskbar.Click += new System.EventHandler(this.hideWindowsTaskbarToolStripMenuItem_Click);
            // 
            // toolStripRemoveMenus
            // 
            this.toolStripRemoveMenus.CheckOnClick = true;
            this.toolStripRemoveMenus.Name = "toolStripRemoveMenus";
            this.toolStripRemoveMenus.Size = new System.Drawing.Size(207, 22);
            this.toolStripRemoveMenus.Text = "Remove Menus";
            this.toolStripRemoveMenus.Click += new System.EventHandler(this.removeMenusToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(204, 6);
            // 
            // toolStripMuteInBackground
            // 
            this.toolStripMuteInBackground.CheckOnClick = true;
            this.toolStripMuteInBackground.Name = "toolStripMuteInBackground";
            this.toolStripMuteInBackground.Size = new System.Drawing.Size(207, 22);
            this.toolStripMuteInBackground.Text = "Mute In Background";
            this.toolStripMuteInBackground.Click += new System.EventHandler(this.muteInBackgroundToolStripMenuItem_Click);
            // 
            // contextRemoveFromFavs
            // 
            this.contextRemoveFromFavs.Name = "contextRemoveFromFavs";
            this.contextRemoveFromFavs.Size = new System.Drawing.Size(207, 22);
            this.contextRemoveFromFavs.Text = "Remove From Favorites";
            this.contextRemoveFromFavs.Click += new System.EventHandler(this.btnRemoveFavorite_Click);
            // 
            // btnRemoveFavorite
            // 
            this.btnRemoveFavorite.Image = global::BorderlessGaming.Properties.Resources.Remove;
            this.btnRemoveFavorite.Location = new System.Drawing.Point(3, 129);
            this.btnRemoveFavorite.Name = "btnRemoveFavorite";
            this.btnRemoveFavorite.Size = new System.Drawing.Size(37, 36);
            this.btnRemoveFavorite.TabIndex = 11;
            this.btnRemoveFavorite.UseVisualStyleBackColor = true;
            this.btnRemoveFavorite.Click += new System.EventHandler(this.btnRemoveFavorite_Click);
            this.btnRemoveFavorite.MouseHover += new System.EventHandler(this.btnRemoveFavorite_MouseHover);
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processLabel.Location = new System.Drawing.Point(11, 8);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(76, 13);
            this.processLabel.TabIndex = 20;
            this.processLabel.Text = "Applications";
            // 
            // favoritesLabel
            // 
            this.favoritesLabel.AutoSize = true;
            this.favoritesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoritesLabel.Location = new System.Drawing.Point(305, 8);
            this.favoritesLabel.Name = "favoritesLabel";
            this.favoritesLabel.Size = new System.Drawing.Size(59, 13);
            this.favoritesLabel.TabIndex = 19;
            this.favoritesLabel.Text = "Favorites";
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconContextMenu;
            this.trayIcon.Icon = global::BorderlessGaming.Properties.Resources.BorderlessGamingLogo;
            this.trayIcon.Text = "Borderless Gaming";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayIconContextMenu
            // 
            this.trayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem7,
            this.exitToolStripMenuItem});
            this.trayIconContextMenu.Name = "trayIconContextMenu";
            this.trayIconContextMenu.Size = new System.Drawing.Size(196, 54);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openToolStripMenuItem.Text = "Show";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "Exit Borderless Gaming";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOptions,
            this.toolsToolStripMenuItem,
            this.toolStripInfo});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.MinimumSize = new System.Drawing.Size(0, 31);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(556, 31);
            this.mnuMain.TabIndex = 16;
            this.mnuMain.Text = "mnuMain";
            // 
            // toolStripOptions
            // 
            this.toolStripOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRunOnStartup,
            this.toolStripLanguages,
            this.toolStripCheckForUpdates,
            this.toolStripMenuItem3,
            this.toolStripGlobalHotkey,
            this.toolStripMouseLock,
            this.toolStripMouseHide,
            this.toolStripMenuItem5,
            this.toolStripMinimizedToTray,
            this.toolStripCloseToTray,
            this.toolStripHideBalloonTips,
            this.toolStripSlowWindowDetection,
            this.toolStripViewFullProcessDetails,
            this.toolStripMenuItem10,
            this.toolStripRestoreProcesses});
            this.toolStripOptions.Name = "toolStripOptions";
            this.toolStripOptions.Size = new System.Drawing.Size(61, 27);
            this.toolStripOptions.Text = "&Options";
            // 
            // toolStripRunOnStartup
            // 
            this.toolStripRunOnStartup.CheckOnClick = true;
            this.toolStripRunOnStartup.Name = "toolStripRunOnStartup";
            this.toolStripRunOnStartup.Size = new System.Drawing.Size(316, 22);
            this.toolStripRunOnStartup.Text = "Run On Startup";
            this.toolStripRunOnStartup.CheckedChanged += new System.EventHandler(this.toolStripRunOnStartup_CheckChanged);
            // 
            // toolStripLanguages
            // 
            this.toolStripLanguages.Name = "toolStripLanguages";
            this.toolStripLanguages.Size = new System.Drawing.Size(316, 22);
            this.toolStripLanguages.Text = "Select Language";
            // 
            // toolStripCheckForUpdates
            // 
            this.toolStripCheckForUpdates.CheckOnClick = true;
            this.toolStripCheckForUpdates.Name = "toolStripCheckForUpdates";
            this.toolStripCheckForUpdates.Size = new System.Drawing.Size(316, 22);
            this.toolStripCheckForUpdates.Text = "Check For Updates";
            this.toolStripCheckForUpdates.CheckedChanged += new System.EventHandler(this.toolStripCheckForUpdates_CheckedChanged);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(313, 6);
            // 
            // toolStripGlobalHotkey
            // 
            this.toolStripGlobalHotkey.CheckOnClick = true;
            this.toolStripGlobalHotkey.Name = "toolStripGlobalHotkey";
            this.toolStripGlobalHotkey.Size = new System.Drawing.Size(316, 22);
            this.toolStripGlobalHotkey.Text = "Use Global Hotkey                 (Win+F6)";
            this.toolStripGlobalHotkey.CheckedChanged += new System.EventHandler(this.toolStripGlobalHotkey_CheckChanged);
            // 
            // toolStripMouseLock
            // 
            this.toolStripMouseLock.CheckOnClick = true;
            this.toolStripMouseLock.Name = "toolStripMouseLock";
            this.toolStripMouseLock.Size = new System.Drawing.Size(316, 22);
            this.toolStripMouseLock.Text = "Use Mouse Lock Hotkey       (Scroll Lock)";
            this.toolStripMouseLock.CheckedChanged += new System.EventHandler(this.toolStripMouseLock_CheckChanged);
            // 
            // toolStripMouseHide
            // 
            this.toolStripMouseHide.CheckOnClick = true;
            this.toolStripMouseHide.Name = "toolStripMouseHide";
            this.toolStripMouseHide.Size = new System.Drawing.Size(316, 22);
            this.toolStripMouseHide.Text = "Use Mouse Hide Hotkey       (Win+Scroll Lock)";
            this.toolStripMouseHide.CheckedChanged += new System.EventHandler(this.useMouseHideHotkeyWinScrollLockToolStripMenuItem_CheckChanged);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(313, 6);
            // 
            // toolStripMinimizedToTray
            // 
            this.toolStripMinimizedToTray.CheckOnClick = true;
            this.toolStripMinimizedToTray.Name = "toolStripMinimizedToTray";
            this.toolStripMinimizedToTray.Size = new System.Drawing.Size(316, 22);
            this.toolStripMinimizedToTray.Text = "Start Minimized To Tray";
            this.toolStripMinimizedToTray.CheckedChanged += new System.EventHandler(this.startMinimizedToTrayToolStripMenuItem_CheckedChanged);
            // 
            // toolStripCloseToTray
            // 
            this.toolStripCloseToTray.CheckOnClick = true;
            this.toolStripCloseToTray.Name = "toolStripCloseToTray";
            this.toolStripCloseToTray.Size = new System.Drawing.Size(316, 22);
            this.toolStripCloseToTray.Text = "Close To Tray";
            this.toolStripCloseToTray.CheckedChanged += new System.EventHandler(this.closeToTrayToolStripMenuItem_CheckedChanged);
            // 
            // toolStripHideBalloonTips
            // 
            this.toolStripHideBalloonTips.CheckOnClick = true;
            this.toolStripHideBalloonTips.Name = "toolStripHideBalloonTips";
            this.toolStripHideBalloonTips.Size = new System.Drawing.Size(316, 22);
            this.toolStripHideBalloonTips.Text = "Hide Balloon Tips";
            this.toolStripHideBalloonTips.CheckedChanged += new System.EventHandler(this.hideBalloonTipsToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSlowWindowDetection
            // 
            this.toolStripSlowWindowDetection.CheckOnClick = true;
            this.toolStripSlowWindowDetection.Name = "toolStripSlowWindowDetection";
            this.toolStripSlowWindowDetection.Size = new System.Drawing.Size(316, 22);
            this.toolStripSlowWindowDetection.Text = "&Use Slower Window Detection";
            this.toolStripSlowWindowDetection.Click += new System.EventHandler(this.useSlowerWindowDetectionToolStripMenuItem_Click);
            // 
            // toolStripViewFullProcessDetails
            // 
            this.toolStripViewFullProcessDetails.CheckOnClick = true;
            this.toolStripViewFullProcessDetails.Name = "toolStripViewFullProcessDetails";
            this.toolStripViewFullProcessDetails.Size = new System.Drawing.Size(316, 22);
            this.toolStripViewFullProcessDetails.Text = "View Full Process Details";
            this.toolStripViewFullProcessDetails.CheckedChanged += new System.EventHandler(this.viewFullProcessDetailsToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(313, 6);
            // 
            // toolStripRestoreProcesses
            // 
            this.toolStripRestoreProcesses.Name = "toolStripRestoreProcesses";
            this.toolStripRestoreProcesses.Size = new System.Drawing.Size(316, 22);
            this.toolStripRestoreProcesses.Text = "Restore All Hidden Applications";
            this.toolStripRestoreProcesses.Click += new System.EventHandler(this.resetHiddenProcessesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPauseAutomaticProcessing,
            this.toolStripOpenDataFolder,
            this.toolStripMenuItem11,
            this.toolStripToggleMouseCursorVisibility,
            this.toolStripToggleWindowsTaskbar,
            this.toolStripMenuItem12,
            this.toolStripFullApplicationRefresh});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 27);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // toolStripPauseAutomaticProcessing
            // 
            this.toolStripPauseAutomaticProcessing.CheckOnClick = true;
            this.toolStripPauseAutomaticProcessing.Name = "toolStripPauseAutomaticProcessing";
            this.toolStripPauseAutomaticProcessing.Size = new System.Drawing.Size(250, 22);
            this.toolStripPauseAutomaticProcessing.Text = "Pause Automatic Processing";
            this.toolStripPauseAutomaticProcessing.Click += new System.EventHandler(this.pauseAutomaticProcessingToolStripMenuItem_Click);
            // 
            // toolStripOpenDataFolder
            // 
            this.toolStripOpenDataFolder.Name = "toolStripOpenDataFolder";
            this.toolStripOpenDataFolder.Size = new System.Drawing.Size(250, 22);
            this.toolStripOpenDataFolder.Text = "Open Data Folder";
            this.toolStripOpenDataFolder.Click += new System.EventHandler(this.openDataFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(247, 6);
            // 
            // toolStripToggleMouseCursorVisibility
            // 
            this.toolStripToggleMouseCursorVisibility.Name = "toolStripToggleMouseCursorVisibility";
            this.toolStripToggleMouseCursorVisibility.Size = new System.Drawing.Size(250, 22);
            this.toolStripToggleMouseCursorVisibility.Text = "Toggle Mouse Cursor Visibility";
            this.toolStripToggleMouseCursorVisibility.Click += new System.EventHandler(this.toggleMouseCursorVisibilityToolStripMenuItem_Click);
            // 
            // toolStripToggleWindowsTaskbar
            // 
            this.toolStripToggleWindowsTaskbar.Name = "toolStripToggleWindowsTaskbar";
            this.toolStripToggleWindowsTaskbar.Size = new System.Drawing.Size(250, 22);
            this.toolStripToggleWindowsTaskbar.Text = "Toggle Windows Taskbar Visibility";
            this.toolStripToggleWindowsTaskbar.Click += new System.EventHandler(this.toggleWindowsTaskbarVisibilityToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(247, 6);
            // 
            // toolStripFullApplicationRefresh
            // 
            this.toolStripFullApplicationRefresh.Name = "toolStripFullApplicationRefresh";
            this.toolStripFullApplicationRefresh.Size = new System.Drawing.Size(250, 22);
            this.toolStripFullApplicationRefresh.Text = "Full Application Refresh";
            this.toolStripFullApplicationRefresh.Click += new System.EventHandler(this.fullApplicationRefreshToolStripMenuItem_Click);
            // 
            // toolStripInfo
            // 
            this.toolStripInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsageGuide,
            this.toolStripRegexReference,
            this.toolStripMenuItem13,
            this.toolStripReportBug,
            this.toolStripSupportUs,
            this.toolStripMenuItem2,
            this.toolStripAbout});
            this.toolStripInfo.Name = "toolStripInfo";
            this.toolStripInfo.Size = new System.Drawing.Size(44, 27);
            this.toolStripInfo.Text = "&Help";
            // 
            // toolStripUsageGuide
            // 
            this.toolStripUsageGuide.Name = "toolStripUsageGuide";
            this.toolStripUsageGuide.Size = new System.Drawing.Size(161, 22);
            this.toolStripUsageGuide.Text = "Usage Guide";
            this.toolStripUsageGuide.Click += new System.EventHandler(this.usageGuideToolStripMenuItem_Click);
            // 
            // toolStripRegexReference
            // 
            this.toolStripRegexReference.Name = "toolStripRegexReference";
            this.toolStripRegexReference.Size = new System.Drawing.Size(161, 22);
            this.toolStripRegexReference.Text = "Regex Reference";
            this.toolStripRegexReference.Click += new System.EventHandler(this.toolStripRegexReference_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(158, 6);
            // 
            // toolStripReportBug
            // 
            this.toolStripReportBug.Name = "toolStripReportBug";
            this.toolStripReportBug.Size = new System.Drawing.Size(161, 22);
            this.toolStripReportBug.Text = "Report a Bug";
            this.toolStripReportBug.Click += new System.EventHandler(this.toolStripReportBug_Click);
            // 
            // toolStripSupportUs
            // 
            this.toolStripSupportUs.Name = "toolStripSupportUs";
            this.toolStripSupportUs.Size = new System.Drawing.Size(161, 22);
            this.toolStripSupportUs.Text = "Support Us";
            this.toolStripSupportUs.Click += new System.EventHandler(this.toolStripSupportUs_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 6);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(161, 22);
            this.toolStripAbout.Text = "About...";
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.processLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.favoritesLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstProcesses, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstFavorites, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 196);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addSelectedItem);
            this.flowLayoutPanel1.Controls.Add(this.btnMakeBorderless);
            this.flowLayoutPanel1.Controls.Add(this.btnRestoreWindow);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveFavorite);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(257, 21);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(42, 167);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btnRestoreWindow
            // 
            this.btnRestoreWindow.Image = global::BorderlessGaming.Properties.Resources.Bordered;
            this.btnRestoreWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRestoreWindow.Location = new System.Drawing.Point(3, 87);
            this.btnRestoreWindow.Name = "btnRestoreWindow";
            this.btnRestoreWindow.Size = new System.Drawing.Size(37, 36);
            this.btnRestoreWindow.TabIndex = 12;
            this.btnRestoreWindow.UseVisualStyleBackColor = true;
            this.btnRestoreWindow.Click += new System.EventHandler(this.btnRestoreWindow_Click);
            this.btnRestoreWindow.MouseHover += new System.EventHandler(this.btnRestoreWindow_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 227);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(556, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(59, 17);
            this.statusLabel.Text = "Loading...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 249);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.Icon = global::BorderlessGaming.Properties.Resources.BorderlessGamingLogo;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 288);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borderless Gaming";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.processContext.ResumeLayout(false);
            this.mnuFavoritesContext.ResumeLayout(false);
            this.trayIconContextMenu.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeBorderless;
        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.Button addSelectedItem;
        private System.Windows.Forms.ListBox lstFavorites;
        private System.Windows.Forms.Button btnRemoveFavorite;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Label favoritesLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripRunOnStartup;
        private System.Windows.Forms.ToolStripMenuItem toolStripInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripReportBug;
        private System.Windows.Forms.ToolStripMenuItem toolStripSupportUs;
        private System.Windows.Forms.ToolStripMenuItem toolStripRegexReference;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip processContext;
        private System.Windows.Forms.ToolStripMenuItem contextAddToFavs;
        private System.Windows.Forms.ToolStripMenuItem contextBorderless;
        private System.Windows.Forms.ToolStripMenuItem contextBorderlessOn;
        private System.Windows.Forms.ToolStripMenuItem contextFavScreen;
        private System.Windows.Forms.ContextMenuStrip mnuFavoritesContext;
        private System.Windows.Forms.ToolStripMenuItem contextRemoveFromFavs;
        private System.Windows.Forms.ToolStripMenuItem toolStripGlobalHotkey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMouseLock;
        private System.Windows.Forms.ToolStripMenuItem toolStripByTheWindowTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStripByProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripByRegex;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdjustWindowBounds;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripAutomaximize;
        private System.Windows.Forms.Button btnRestoreWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMinimizedToTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripCloseToTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideBalloonTips;
        private System.Windows.Forms.ToolStripMenuItem toolStripCheckForUpdates;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;//this might get replaced if you redo anything in the form designer
        private System.Windows.Forms.ToolStripMenuItem toolStripViewFullProcessDetails;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetSetWindowSize;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripFullScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripRemoveMenus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripAlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelayBorderless;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripToggleWindowsTaskbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetWindowTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideWindowsTaskbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideMouseCursor;
        private System.Windows.Forms.ToolStripMenuItem toolStripToggleMouseCursorVisibility;
        private System.Windows.Forms.ToolStripMenuItem toolStripMouseHide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripRestoreProcesses;
        private System.Windows.Forms.ToolStripMenuItem toolStripPauseAutomaticProcessing;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripNoSizeChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpenDataFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripFullApplicationRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripSlowWindowDetection;
        private System.Windows.Forms.ToolStripMenuItem toolStripUsageGuide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMuteInBackground;
        private System.Windows.Forms.ToolStripMenuItem toolStripLanguages;
    }
}