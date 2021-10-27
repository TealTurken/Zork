
namespace ZorkBuilder.Forms
{
    partial class StartUp
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
            System.Windows.Forms.ToolStripMenuItem FileMenuTool;
            System.Windows.Forms.ToolStripMenuItem MenuHelp;
            System.Windows.Forms.GroupBox ContentBox;
            this.MenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewGameWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditRoomData = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuControls = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.newWorldButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.WorldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            FileMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            ContentBox = new System.Windows.Forms.GroupBox();
            ContentBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FileMenuTool
            // 
            FileMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNew,
            this.MenuOpenFile,
            this.MenuSave,
            this.MenuSaveAs,
            this.MenuEdit,
            this.MenuExit});
            FileMenuTool.Name = "FileMenuTool";
            FileMenuTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            FileMenuTool.Size = new System.Drawing.Size(37, 19);
            FileMenuTool.Text = "&File";
            // 
            // MenuNew
            // 
            this.MenuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewGame,
            this.MenuNewGameWorld});
            this.MenuNew.Name = "MenuNew";
            this.MenuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuNew.Size = new System.Drawing.Size(155, 22);
            this.MenuNew.Text = "&New";
            // 
            // MenuNewGame
            // 
            this.MenuNewGame.AutoToolTip = true;
            this.MenuNewGame.Name = "MenuNewGame";
            this.MenuNewGame.Size = new System.Drawing.Size(167, 22);
            this.MenuNewGame.Text = "New Game";
            this.MenuNewGame.ToolTipText = "Start a new game session";
            // 
            // MenuNewGameWorld
            // 
            this.MenuNewGameWorld.AutoToolTip = true;
            this.MenuNewGameWorld.Name = "MenuNewGameWorld";
            this.MenuNewGameWorld.Size = new System.Drawing.Size(167, 22);
            this.MenuNewGameWorld.Text = "New Game World";
            this.MenuNewGameWorld.ToolTipText = "Create a new game world";
            // 
            // MenuOpenFile
            // 
            this.MenuOpenFile.Name = "MenuOpenFile";
            this.MenuOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOpenFile.Size = new System.Drawing.Size(155, 22);
            this.MenuOpenFile.Text = "Open...";
            this.MenuOpenFile.ToolTipText = "Open existing game file";
            // 
            // MenuSave
            // 
            this.MenuSave.AutoToolTip = true;
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSave.Size = new System.Drawing.Size(155, 22);
            this.MenuSave.Text = "Save";
            this.MenuSave.ToolTipText = "Save game";
            // 
            // MenuSaveAs
            // 
            this.MenuSaveAs.Name = "MenuSaveAs";
            this.MenuSaveAs.Size = new System.Drawing.Size(155, 22);
            this.MenuSaveAs.Text = "Save As...";
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditRoomData,
            this.welcomeMessageToolStripMenuItem});
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(155, 22);
            this.MenuEdit.Text = "Edit";
            // 
            // MenuEditRoomData
            // 
            this.MenuEditRoomData.Name = "MenuEditRoomData";
            this.MenuEditRoomData.Size = new System.Drawing.Size(173, 22);
            this.MenuEditRoomData.Text = "Game World...";
            this.MenuEditRoomData.ToolTipText = "Edit game world data";
            // 
            // welcomeMessageToolStripMenuItem
            // 
            this.welcomeMessageToolStripMenuItem.Name = "welcomeMessageToolStripMenuItem";
            this.welcomeMessageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.welcomeMessageToolStripMenuItem.Text = "Welcome Message";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuExit.Size = new System.Drawing.Size(155, 22);
            this.MenuExit.Text = "E&xit";
            // 
            // MenuHelp
            // 
            MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuControls});
            MenuHelp.Name = "MenuHelp";
            MenuHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            MenuHelp.Size = new System.Drawing.Size(44, 19);
            MenuHelp.Text = "&Help";
            // 
            // MenuControls
            // 
            this.MenuControls.Name = "MenuControls";
            this.MenuControls.Size = new System.Drawing.Size(153, 22);
            this.MenuControls.Text = "Game Controls";
            this.MenuControls.ToolTipText = "Display game controls in Game window";
            // 
            // ContentBox
            // 
            ContentBox.Controls.Add(this.exitButton);
            ContentBox.Controls.Add(this.newWorldButton);
            ContentBox.Controls.Add(this.openButton);
            ContentBox.Controls.Add(this.continueButton);
            ContentBox.Controls.Add(this.NewButton);
            ContentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ContentBox.Location = new System.Drawing.Point(0, 25);
            ContentBox.Name = "ContentBox";
            ContentBox.Size = new System.Drawing.Size(308, 190);
            ContentBox.TabIndex = 3;
            ContentBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitButton.Location = new System.Drawing.Point(3, 108);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(302, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newWorldButton
            // 
            this.newWorldButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newWorldButton.Location = new System.Drawing.Point(3, 85);
            this.newWorldButton.Name = "newWorldButton";
            this.newWorldButton.Size = new System.Drawing.Size(302, 23);
            this.newWorldButton.TabIndex = 3;
            this.newWorldButton.Text = "New World";
            this.newWorldButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openButton.Location = new System.Drawing.Point(3, 62);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(302, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.continueButton.Location = new System.Drawing.Point(3, 39);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(302, 23);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            this.NewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewButton.Location = new System.Drawing.Point(3, 16);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(302, 23);
            this.NewButton.TabIndex = 0;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            FileMenuTool,
            MenuHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(308, 25);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            this.openFileDialog.Title = "Open a game file";
            // 
            // WorldBindingSource
            // 
            this.WorldBindingSource.DataSource = typeof(ZorkBuilder.Forms.WorldViewModel);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 215);
            this.Controls.Add(ContentBox);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartUp";
            this.Text = "Zork Main Menu";
            ContentBox.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuNew;
        private System.Windows.Forms.ToolStripMenuItem MenuNewGame;
        private System.Windows.Forms.ToolStripMenuItem MenuNewGameWorld;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuEditRoomData;
        private System.Windows.Forms.ToolStripMenuItem welcomeMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuControls;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newWorldButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource WorldBindingSource;
    }
}