
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
            this.GamePlayerInterface = new System.Windows.Forms.SplitContainer();
            this.label16 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            FileMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
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
            // GameInterface
            // 
            this.GameInterface.Dock = System.Windows.Forms.DockStyle.Left;
            this.GameInterface.Location = new System.Drawing.Point(0, 0);
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
            this.GameInterface.Size = new System.Drawing.Size(500, 486);
            this.GameInterface.SplitterDistance = 418;
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
            this.GameOutputBox.Size = new System.Drawing.Size(480, 403);
            this.GameOutputBox.TabIndex = 0;
            // 
            // GameInputBox
            // 
            this.GameInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameInputBox.Location = new System.Drawing.Point(10, 5);
            this.GameInputBox.Multiline = true;
            this.GameInputBox.Name = "GameInputBox";
            this.GameInputBox.Size = new System.Drawing.Size(480, 49);
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
            this.label13.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            // GamePlayerInterface
            // 
            this.GamePlayerInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePlayerInterface.Location = new System.Drawing.Point(500, 0);
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
            this.GamePlayerInterface.Size = new System.Drawing.Size(284, 360);
            this.GamePlayerInterface.SplitterDistance = 263;
            this.GamePlayerInterface.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Window;
            this.label16.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(170, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 27);
            this.label16.TabIndex = 4;
            this.label16.Text = "Inventory";
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Items.AddRange(new object[] {
            "Jewel Encrusted Egg",
            "Lamp",
            "Leaflet"});
            this.listBox2.Location = new System.Drawing.Point(10, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(264, 238);
            this.listBox2.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(185, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 27);
            this.label15.TabIndex = 3;
            this.label15.Text = "Moves";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(16, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 27);
            this.label14.TabIndex = 2;
            this.label14.Text = "Score";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(175, 32);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 30);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "#ofMoves";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(10, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 30);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "#ofPoints";
            // 
            // FileMenuTool
            // 
            FileMenuTool.Name = "FileMenuTool";
            FileMenuTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            FileMenuTool.Size = new System.Drawing.Size(37, 19);
            FileMenuTool.Text = "&File";
            // 
            // MenuHelp
            // 
            MenuHelp.Name = "MenuHelp";
            MenuHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            MenuHelp.Size = new System.Drawing.Size(44, 19);
            MenuHelp.Text = "&Help";
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
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 491);
            this.Name = "Game_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork";
            this.Load += new System.EventHandler(this.MainForm_Load);
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

        }

        #endregion
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
        private System.Windows.Forms.Button ButtonDrop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
    }
}

