
namespace ZorkBuilder
{
    partial class World
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
            this.roomsBox = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.ListBox();
            this.roomDataGroupBox = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomDescriptionBox = new System.Windows.Forms.TextBox();
            this.roomNameBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.startLocationCheck = new System.Windows.Forms.CheckBox();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.worldTab = new System.Windows.Forms.TabControl();
            this.neighborsTabPage = new System.Windows.Forms.TabPage();
            this.upLabel = new System.Windows.Forms.Label();
            this.upComboBox = new System.Windows.Forms.ComboBox();
            this.downLabel = new System.Windows.Forms.Label();
            this.downComboBox = new System.Windows.Forms.ComboBox();
            this.westLabel = new System.Windows.Forms.Label();
            this.westComboBox = new System.Windows.Forms.ComboBox();
            this.eastLabel = new System.Windows.Forms.Label();
            this.eastComboBox = new System.Windows.Forms.ComboBox();
            this.southLabel = new System.Windows.Forms.Label();
            this.southComboBox = new System.Windows.Forms.ComboBox();
            this.northLabel = new System.Windows.Forms.Label();
            this.northComboBox = new System.Windows.Forms.ComboBox();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.WorldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBox.SuspendLayout();
            this.roomDataGroupBox.SuspendLayout();
            this.worldTab.SuspendLayout();
            this.neighborsTabPage.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsBox
            // 
            this.roomsBox.Controls.Add(this.Delete);
            this.roomsBox.Controls.Add(this.AddRoomButton);
            this.roomsBox.Controls.Add(this.Rooms);
            this.roomsBox.Location = new System.Drawing.Point(2, 4);
            this.roomsBox.Name = "roomsBox";
            this.roomsBox.Size = new System.Drawing.Size(177, 324);
            this.roomsBox.TabIndex = 3;
            this.roomsBox.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(92, 293);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(7, 293);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(75, 23);
            this.AddRoomButton.TabIndex = 4;
            this.AddRoomButton.Text = "Add";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // Rooms
            // 
            this.Rooms.DataSource = this.roomsBindingSource;
            this.Rooms.DisplayMember = "Name";
            this.Rooms.FormattingEnabled = true;
            this.Rooms.Location = new System.Drawing.Point(7, 10);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(160, 277);
            this.Rooms.TabIndex = 3;
            this.Rooms.ValueMember = "Description";
            // 
            // roomDataGroupBox
            // 
            this.roomDataGroupBox.Controls.Add(this.Save);
            this.roomDataGroupBox.Controls.Add(this.roomDescriptionLabel);
            this.roomDataGroupBox.Controls.Add(this.roomDescriptionBox);
            this.roomDataGroupBox.Controls.Add(this.roomNameBox);
            this.roomDataGroupBox.Controls.Add(this.roomNameLabel);
            this.roomDataGroupBox.Controls.Add(this.startLocationCheck);
            this.roomDataGroupBox.Location = new System.Drawing.Point(185, 4);
            this.roomDataGroupBox.Name = "roomDataGroupBox";
            this.roomDataGroupBox.Size = new System.Drawing.Size(379, 324);
            this.roomDataGroupBox.TabIndex = 4;
            this.roomDataGroupBox.TabStop = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(0, 71);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 40;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(149, 8);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.roomDescriptionLabel.TabIndex = 28;
            this.roomDescriptionLabel.Text = "Description";
            // 
            // roomDescriptionBox
            // 
            this.roomDescriptionBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.roomDescriptionBox.Location = new System.Drawing.Point(152, 23);
            this.roomDescriptionBox.Multiline = true;
            this.roomDescriptionBox.Name = "roomDescriptionBox";
            this.roomDescriptionBox.Size = new System.Drawing.Size(215, 71);
            this.roomDescriptionBox.TabIndex = 27;
            // 
            // roomNameBox
            // 
            this.roomNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.roomNameBox.Location = new System.Drawing.Point(6, 23);
            this.roomNameBox.Name = "roomNameBox";
            this.roomNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roomNameBox.Size = new System.Drawing.Size(140, 20);
            this.roomNameBox.TabIndex = 25;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(3, 8);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(35, 13);
            this.roomNameLabel.TabIndex = 26;
            this.roomNameLabel.Text = "Name";
            // 
            // startLocationCheck
            // 
            this.startLocationCheck.AutoSize = true;
            this.startLocationCheck.Location = new System.Drawing.Point(4, 49);
            this.startLocationCheck.Name = "startLocationCheck";
            this.startLocationCheck.Size = new System.Drawing.Size(123, 17);
            this.startLocationCheck.TabIndex = 24;
            this.startLocationCheck.Text = "Can be start location";
            this.startLocationCheck.UseVisualStyleBackColor = true;
            // 
            // itemsListView
            // 
            this.itemsListView.HideSelection = false;
            this.itemsListView.Location = new System.Drawing.Point(5, 6);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(348, 152);
            this.itemsListView.TabIndex = 39;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.List;
            // 
            // worldTab
            // 
            this.worldTab.Controls.Add(this.neighborsTabPage);
            this.worldTab.Controls.Add(this.itemsTabPage);
            this.worldTab.Location = new System.Drawing.Point(185, 104);
            this.worldTab.Name = "worldTab";
            this.worldTab.SelectedIndex = 0;
            this.worldTab.Size = new System.Drawing.Size(367, 216);
            this.worldTab.TabIndex = 42;
            // 
            // neighborsTabPage
            // 
            this.neighborsTabPage.Controls.Add(this.upLabel);
            this.neighborsTabPage.Controls.Add(this.upComboBox);
            this.neighborsTabPage.Controls.Add(this.downLabel);
            this.neighborsTabPage.Controls.Add(this.downComboBox);
            this.neighborsTabPage.Controls.Add(this.westLabel);
            this.neighborsTabPage.Controls.Add(this.westComboBox);
            this.neighborsTabPage.Controls.Add(this.eastLabel);
            this.neighborsTabPage.Controls.Add(this.eastComboBox);
            this.neighborsTabPage.Controls.Add(this.southLabel);
            this.neighborsTabPage.Controls.Add(this.southComboBox);
            this.neighborsTabPage.Controls.Add(this.northLabel);
            this.neighborsTabPage.Controls.Add(this.northComboBox);
            this.neighborsTabPage.Location = new System.Drawing.Point(4, 22);
            this.neighborsTabPage.Name = "neighborsTabPage";
            this.neighborsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.neighborsTabPage.Size = new System.Drawing.Size(359, 190);
            this.neighborsTabPage.TabIndex = 0;
            this.neighborsTabPage.Text = "Neighbors";
            this.neighborsTabPage.UseVisualStyleBackColor = true;
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Location = new System.Drawing.Point(169, 98);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(21, 13);
            this.upLabel.TabIndex = 50;
            this.upLabel.Text = "Up";
            // 
            // upComboBox
            // 
            this.upComboBox.FormattingEnabled = true;
            this.upComboBox.Location = new System.Drawing.Point(120, 114);
            this.upComboBox.Name = "upComboBox";
            this.upComboBox.Size = new System.Drawing.Size(121, 21);
            this.upComboBox.TabIndex = 49;
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Location = new System.Drawing.Point(161, 138);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(35, 13);
            this.downLabel.TabIndex = 48;
            this.downLabel.Text = "Down";
            // 
            // downComboBox
            // 
            this.downComboBox.FormattingEnabled = true;
            this.downComboBox.Location = new System.Drawing.Point(120, 154);
            this.downComboBox.Name = "downComboBox";
            this.downComboBox.Size = new System.Drawing.Size(121, 21);
            this.downComboBox.TabIndex = 47;
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Location = new System.Drawing.Point(45, 32);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(32, 13);
            this.westLabel.TabIndex = 46;
            this.westLabel.Text = "West";
            // 
            // westComboBox
            // 
            this.westComboBox.FormattingEnabled = true;
            this.westComboBox.Location = new System.Drawing.Point(6, 47);
            this.westComboBox.Name = "westComboBox";
            this.westComboBox.Size = new System.Drawing.Size(121, 21);
            this.westComboBox.TabIndex = 45;
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Location = new System.Drawing.Point(273, 32);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(28, 13);
            this.eastLabel.TabIndex = 44;
            this.eastLabel.Text = "East";
            // 
            // eastComboBox
            // 
            this.eastComboBox.FormattingEnabled = true;
            this.eastComboBox.Location = new System.Drawing.Point(232, 47);
            this.eastComboBox.Name = "eastComboBox";
            this.eastComboBox.Size = new System.Drawing.Size(121, 21);
            this.eastComboBox.TabIndex = 43;
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Location = new System.Drawing.Point(161, 58);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(35, 13);
            this.southLabel.TabIndex = 42;
            this.southLabel.Text = "South";
            // 
            // southComboBox
            // 
            this.southComboBox.FormattingEnabled = true;
            this.southComboBox.Location = new System.Drawing.Point(120, 74);
            this.southComboBox.Name = "southComboBox";
            this.southComboBox.Size = new System.Drawing.Size(121, 21);
            this.southComboBox.TabIndex = 41;
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Location = new System.Drawing.Point(162, 4);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(33, 13);
            this.northLabel.TabIndex = 40;
            this.northLabel.Text = "North";
            // 
            // northComboBox
            // 
            this.northComboBox.FormattingEnabled = true;
            this.northComboBox.Location = new System.Drawing.Point(120, 20);
            this.northComboBox.Name = "northComboBox";
            this.northComboBox.Size = new System.Drawing.Size(121, 21);
            this.northComboBox.TabIndex = 39;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsListView);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.itemsTabPage.Size = new System.Drawing.Size(359, 190);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // WorldBindingSource
            // 
            this.WorldBindingSource.DataSource = typeof(ZorkBuilder.Forms.WorldViewModel);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.WorldBindingSource;
            // 
            // World
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 330);
            this.Controls.Add(this.worldTab);
            this.Controls.Add(this.roomDataGroupBox);
            this.Controls.Add(this.roomsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "World";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.roomsBox.ResumeLayout(false);
            this.roomDataGroupBox.ResumeLayout(false);
            this.roomDataGroupBox.PerformLayout();
            this.worldTab.ResumeLayout(false);
            this.neighborsTabPage.ResumeLayout(false);
            this.neighborsTabPage.PerformLayout();
            this.itemsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox roomsBox;
        private System.Windows.Forms.ListBox Rooms;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.GroupBox roomDataGroupBox;
        private System.Windows.Forms.TabControl worldTab;
        private System.Windows.Forms.TabPage neighborsTabPage;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.ComboBox westComboBox;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.ComboBox eastComboBox;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.ComboBox southComboBox;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.ComboBox northComboBox;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.TextBox roomDescriptionBox;
        private System.Windows.Forms.TextBox roomNameBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.CheckBox startLocationCheck;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.ComboBox upComboBox;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.ComboBox downComboBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource WorldBindingSource;
    }
}