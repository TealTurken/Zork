
namespace ZorkBuilder
{
    partial class Game_Screen
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
            System.Windows.Forms.ToolStripMenuItem FileMenuTool;
            System.Windows.Forms.ToolStripMenuItem MenuHelp;
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.GameInterface = new System.Windows.Forms.SplitContainer();
            this.GameScreenText = new System.Windows.Forms.Label();
            this.GameOutputBox = new System.Windows.Forms.TextBox();
            this.GameInputBox = new System.Windows.Forms.TextBox();
            this.QuickControls = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.ButtonDrop = new System.Windows.Forms.Button();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.ButtonInventory = new System.Windows.Forms.Button();
            this.ButtonLook = new System.Windows.Forms.Button();
            this.DirButtonWest = new System.Windows.Forms.Button();
            this.DirButtonEast = new System.Windows.Forms.Button();
            this.DirButtonSouth = new System.Windows.Forms.Button();
            this.DirButtonNorth = new System.Windows.Forms.Button();
            this.fileOpen = new System.Windows.Forms.OpenFileDialog();
            this.fileSave = new System.Windows.Forms.SaveFileDialog();
            this.GamePlayerInterface = new System.Windows.Forms.SplitContainer();
            this.label16 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            FileMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameInterface)).BeginInit();
            this.GameInterface.Panel1.SuspendLayout();
            this.GameInterface.Panel2.SuspendLayout();
            this.GameInterface.SuspendLayout();
            this.QuickControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePlayerInterface)).BeginInit();
            this.GamePlayerInterface.Panel1.SuspendLayout();
            this.GamePlayerInterface.Panel2.SuspendLayout();
            this.GamePlayerInterface.SuspendLayout();
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
            this.MenuNewGame.Click += new System.EventHandler(this.MenuNewGame_Click);
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
            this.MenuExit.Click += new System.EventHandler(this.stripMenuExit);
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
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            FileMenuTool,
            MenuHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(784, 25);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip";
            // 
            // GameInterface
            // 
            this.GameInterface.Dock = System.Windows.Forms.DockStyle.Left;
            this.GameInterface.Location = new System.Drawing.Point(0, 25);
            this.GameInterface.Name = "GameInterface";
            this.GameInterface.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // GameInterface.Panel1
            // 
            this.GameInterface.Panel1.AutoScroll = true;
            this.GameInterface.Panel1.Controls.Add(this.GameScreenText);
            this.GameInterface.Panel1.Controls.Add(this.GameOutputBox);
            this.GameInterface.Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameInterface.Panel1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            // 
            // GameInterface.Panel2
            // 
            this.GameInterface.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.GameInterface.Panel2.Controls.Add(this.GameInputBox);
            this.GameInterface.Panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.GameInterface.Size = new System.Drawing.Size(500, 461);
            this.GameInterface.SplitterDistance = 397;
            this.GameInterface.TabIndex = 2;
            // 
            // GameScreenText
            // 
            this.GameScreenText.AutoSize = true;
            this.GameScreenText.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameScreenText.Location = new System.Drawing.Point(10, 15);
            this.GameScreenText.Name = "GameScreenText";
            this.GameScreenText.Size = new System.Drawing.Size(35, 13);
            this.GameScreenText.TabIndex = 1;
            this.GameScreenText.Text = "Game";
            // 
            // GameOutputBox
            // 
            this.GameOutputBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameOutputBox.Location = new System.Drawing.Point(10, 15);
            this.GameOutputBox.Multiline = true;
            this.GameOutputBox.Name = "GameOutputBox";
            this.GameOutputBox.ReadOnly = true;
            this.GameOutputBox.Size = new System.Drawing.Size(480, 382);
            this.GameOutputBox.TabIndex = 0;
            // 
            // GameInputBox
            // 
            this.GameInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameInputBox.Location = new System.Drawing.Point(10, 5);
            this.GameInputBox.Multiline = true;
            this.GameInputBox.Name = "GameInputBox";
            this.GameInputBox.Size = new System.Drawing.Size(480, 45);
            this.GameInputBox.TabIndex = 0;
            // 
            // QuickControls
            // 
            this.QuickControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuickControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuickControls.Controls.Add(this.label13);
            this.QuickControls.Controls.Add(this.ButtonDrop);
            this.QuickControls.Controls.Add(this.controlsLabel);
            this.QuickControls.Controls.Add(this.ButtonInventory);
            this.QuickControls.Controls.Add(this.ButtonLook);
            this.QuickControls.Controls.Add(this.DirButtonWest);
            this.QuickControls.Controls.Add(this.DirButtonEast);
            this.QuickControls.Controls.Add(this.DirButtonSouth);
            this.QuickControls.Controls.Add(this.DirButtonNorth);
            this.QuickControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuickControls.Location = new System.Drawing.Point(500, 360);
            this.QuickControls.Name = "QuickControls";
            this.QuickControls.Padding = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.QuickControls.Size = new System.Drawing.Size(284, 126);
            this.QuickControls.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 7F);
            this.label13.Location = new System.Drawing.Point(33, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Move";
            // 
            // ButtonDrop
            // 
            this.ButtonDrop.Location = new System.Drawing.Point(221, 62);
            this.ButtonDrop.Name = "ButtonDrop";
            this.ButtonDrop.Size = new System.Drawing.Size(50, 29);
            this.ButtonDrop.TabIndex = 6;
            this.ButtonDrop.Text = "Drop";
            this.ButtonDrop.UseVisualStyleBackColor = true;
            // 
            // controlsLabel
            // 
            this.controlsLabel.AutoSize = true;
            this.controlsLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsLabel.Location = new System.Drawing.Point(197, 5);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(75, 13);
            this.controlsLabel.TabIndex = 5;
            this.controlsLabel.Text = "Quick Controls";
            // 
            // ButtonInventory
            // 
            this.ButtonInventory.Location = new System.Drawing.Point(186, 27);
            this.ButtonInventory.Name = "ButtonInventory";
            this.ButtonInventory.Size = new System.Drawing.Size(85, 29);
            this.ButtonInventory.TabIndex = 5;
            this.ButtonInventory.Text = "Inventory";
            this.ButtonInventory.UseVisualStyleBackColor = true;
            // 
            // ButtonLook
            // 
            this.ButtonLook.Location = new System.Drawing.Point(124, 27);
            this.ButtonLook.Name = "ButtonLook";
            this.ButtonLook.Size = new System.Drawing.Size(56, 29);
            this.ButtonLook.TabIndex = 4;
            this.ButtonLook.Text = "Look";
            this.ButtonLook.UseVisualStyleBackColor = true;
            // 
            // DirButtonWest
            // 
            this.DirButtonWest.Location = new System.Drawing.Point(6, 55);
            this.DirButtonWest.Name = "DirButtonWest";
            this.DirButtonWest.Size = new System.Drawing.Size(24, 24);
            this.DirButtonWest.TabIndex = 3;
            this.DirButtonWest.Text = "<";
            this.DirButtonWest.UseVisualStyleBackColor = true;
            // 
            // DirButtonEast
            // 
            this.DirButtonEast.Location = new System.Drawing.Point(66, 55);
            this.DirButtonEast.Name = "DirButtonEast";
            this.DirButtonEast.Size = new System.Drawing.Size(24, 24);
            this.DirButtonEast.TabIndex = 2;
            this.DirButtonEast.Text = ">";
            this.DirButtonEast.UseVisualStyleBackColor = true;
            // 
            // DirButtonSouth
            // 
            this.DirButtonSouth.Location = new System.Drawing.Point(36, 85);
            this.DirButtonSouth.Name = "DirButtonSouth";
            this.DirButtonSouth.Size = new System.Drawing.Size(24, 24);
            this.DirButtonSouth.TabIndex = 1;
            this.DirButtonSouth.Text = "v";
            this.DirButtonSouth.UseVisualStyleBackColor = true;
            // 
            // DirButtonNorth
            // 
            this.DirButtonNorth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DirButtonNorth.Location = new System.Drawing.Point(36, 25);
            this.DirButtonNorth.Name = "DirButtonNorth";
            this.DirButtonNorth.Size = new System.Drawing.Size(24, 24);
            this.DirButtonNorth.TabIndex = 0;
            this.DirButtonNorth.Text = "^";
            this.DirButtonNorth.UseVisualStyleBackColor = true;
            // 
            // fileOpen
            // 
            this.fileOpen.DefaultExt = "JSON";
            this.fileOpen.FileName = "openNewFile";
            this.fileOpen.Title = "Open a new game file";
            this.fileOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.fileOpen_FileOk);
            // 
            // fileSave
            // 
            this.fileSave.CreatePrompt = true;
            this.fileSave.DefaultExt = "JSON";
            this.fileSave.Title = "File Save";
            this.fileSave.FileOk += new System.ComponentModel.CancelEventHandler(this.fileSave_FileOk);
            // 
            // GamePlayerInterface
            // 
            this.GamePlayerInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePlayerInterface.Location = new System.Drawing.Point(500, 25);
            this.GamePlayerInterface.Name = "GamePlayerInterface";
            this.GamePlayerInterface.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // GamePlayerInterface.Panel1
            // 
            this.GamePlayerInterface.Panel1.Controls.Add(this.label16);
            this.GamePlayerInterface.Panel1.Controls.Add(this.listBox2);
            this.GamePlayerInterface.Panel1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            // 
            // GamePlayerInterface.Panel2
            // 
            this.GamePlayerInterface.Panel2.Controls.Add(this.label15);
            this.GamePlayerInterface.Panel2.Controls.Add(this.label14);
            this.GamePlayerInterface.Panel2.Controls.Add(this.textBox6);
            this.GamePlayerInterface.Panel2.Controls.Add(this.textBox5);
            this.GamePlayerInterface.Size = new System.Drawing.Size(284, 335);
            this.GamePlayerInterface.SplitterDistance = 245;
            this.GamePlayerInterface.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Window;
            this.label16.Font = new System.Drawing.Font("Calibri", 16F);
            this.label16.Location = new System.Drawing.Point(170, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 27);
            this.label16.TabIndex = 4;
            this.label16.Text = "Inventory";
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Items.AddRange(new object[] {
            "Jewel Encrusted Egg",
            "Lamp",
            "Leaflet"});
            this.listBox2.Location = new System.Drawing.Point(10, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(264, 220);
            this.listBox2.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 16F);
            this.label15.Location = new System.Drawing.Point(185, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 27);
            this.label15.TabIndex = 3;
            this.label15.Text = "Moves";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 16F);
            this.label14.Location = new System.Drawing.Point(16, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 27);
            this.label14.TabIndex = 2;
            this.label14.Text = "Score";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Calibri", 14F);
            this.textBox6.Location = new System.Drawing.Point(175, 32);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 30);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "#ofMoves";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calibri", 14F);
            this.textBox5.Location = new System.Drawing.Point(10, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 30);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "#ofPoints";
            // 
            // Game_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 486);
            this.Controls.Add(this.GamePlayerInterface);
            this.Controls.Add(this.QuickControls);
            this.Controls.Add(this.GameInterface);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Calibri", 8F);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 491);
            this.Name = "Game_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.GameInterface.Panel1.ResumeLayout(false);
            this.GameInterface.Panel1.PerformLayout();
            this.GameInterface.Panel2.ResumeLayout(false);
            this.GameInterface.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameInterface)).EndInit();
            this.GameInterface.ResumeLayout(false);
            this.QuickControls.ResumeLayout(false);
            this.QuickControls.PerformLayout();
            this.GamePlayerInterface.Panel1.ResumeLayout(false);
            this.GamePlayerInterface.Panel1.PerformLayout();
            this.GamePlayerInterface.Panel2.ResumeLayout(false);
            this.GamePlayerInterface.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePlayerInterface)).EndInit();
            this.GamePlayerInterface.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuNew;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuEditRoomData;
        private System.Windows.Forms.SplitContainer GameInterface;
        private System.Windows.Forms.TextBox GameInputBox;
        private System.Windows.Forms.TextBox GameOutputBox;
        private System.Windows.Forms.Panel QuickControls;
        private System.Windows.Forms.Button DirButtonWest;
        private System.Windows.Forms.Button DirButtonEast;
        private System.Windows.Forms.Button DirButtonSouth;
        private System.Windows.Forms.Button DirButtonNorth;
        private System.Windows.Forms.Button ButtonLook;
        private System.Windows.Forms.Button ButtonInventory;
        private System.Windows.Forms.OpenFileDialog fileOpen;
        private System.Windows.Forms.SaveFileDialog fileSave;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Label GameScreenText;
        private System.Windows.Forms.SplitContainer GamePlayerInterface;
        private System.Windows.Forms.ToolStripMenuItem MenuNewGame;
        private System.Windows.Forms.ToolStripMenuItem MenuNewGameWorld;
        private System.Windows.Forms.ToolStripMenuItem MenuControls;
        private System.Windows.Forms.Button ButtonDrop;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem welcomeMessageToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
    }
}

