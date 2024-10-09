namespace ust2exo
{
    partial class ObjectEdit
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ObjAddButton = new Button();
            ExoDataView = new DataGridView();
            LyricIndex = new DataGridViewTextBoxColumn();
            ExoViewMenu = new ContextMenuStrip(components);
            EditObj = new ToolStripMenuItem();
            結合ToolStripMenuItem = new ToolStripMenuItem();
            分割ToolStripMenuItem = new ToolStripMenuItem();
            DeleteObj = new ToolStripMenuItem();
            MoveObj = new ToolStripMenuItem();
            MoveUpObj = new ToolStripMenuItem();
            MoveDownObj = new ToolStripMenuItem();
            ExoViewText = new DataGridViewTextBoxColumn();
            ExoViewLyric = new DataGridViewTextBoxColumn();
            ExoViewLength = new DataGridViewTextBoxColumn();
            BackButton = new Button();
            NextButton = new Button();
            UstDataView = new DataGridView();
            UstViewId = new DataGridViewTextBoxColumn();
            UstViewMenu = new ContextMenuStrip(components);
            そのまま追加ToolStripMenuItem = new ToolStripMenuItem();
            AddToExo = new ToolStripMenuItem();
            UstViewLyric = new DataGridViewTextBoxColumn();
            UstViewLegth = new DataGridViewTextBoxColumn();
            UstLabel = new Label();
            ExoLabel = new Label();
            ObjJoinAddButton = new Button();
            ObjUpButton = new Button();
            ObjEditButton = new Button();
            ObjJoinButton = new Button();
            ObjSpiltButton = new Button();
            ObjDeleteButton = new Button();
            ObjDownButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ExoDataView).BeginInit();
            ExoViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UstDataView).BeginInit();
            UstViewMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ObjAddButton
            // 
            ObjAddButton.Location = new Point(371, 152);
            ObjAddButton.Margin = new Padding(15);
            ObjAddButton.Name = "ObjAddButton";
            ObjAddButton.Size = new Size(55, 65);
            ObjAddButton.TabIndex = 16;
            ObjAddButton.Text = "→\r\n追加";
            ObjAddButton.UseVisualStyleBackColor = true;
            ObjAddButton.Click += ObjAddButton_Click;
            // 
            // ExoDataView
            // 
            ExoDataView.AllowUserToAddRows = false;
            ExoDataView.AllowUserToDeleteRows = false;
            ExoDataView.AllowUserToResizeColumns = false;
            ExoDataView.AllowUserToResizeRows = false;
            ExoDataView.BackgroundColor = SystemColors.Window;
            ExoDataView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            ExoDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExoDataView.Columns.AddRange(new DataGridViewColumn[] { LyricIndex, ExoViewText, ExoViewLyric, ExoViewLength });
            ExoDataView.Location = new Point(444, 53);
            ExoDataView.Name = "ExoDataView";
            ExoDataView.ReadOnly = true;
            ExoDataView.RowHeadersVisible = false;
            ExoDataView.ScrollBars = ScrollBars.Vertical;
            ExoDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ExoDataView.Size = new Size(300, 320);
            ExoDataView.TabIndex = 15;
            ExoDataView.DoubleClick += ObjEditButton_Click;
            // 
            // LyricIndex
            // 
            LyricIndex.ContextMenuStrip = ExoViewMenu;
            LyricIndex.HeaderText = "元の歌詞id";
            LyricIndex.Name = "LyricIndex";
            LyricIndex.ReadOnly = true;
            LyricIndex.Visible = false;
            // 
            // ExoViewMenu
            // 
            ExoViewMenu.Items.AddRange(new ToolStripItem[] { EditObj, 結合ToolStripMenuItem, 分割ToolStripMenuItem, DeleteObj, MoveObj });
            ExoViewMenu.Name = "ExoViewMenu";
            ExoViewMenu.Size = new Size(99, 114);
            // 
            // EditObj
            // 
            EditObj.Name = "EditObj";
            EditObj.Size = new Size(98, 22);
            EditObj.Text = "編集";
            EditObj.Click += ObjEditButton_Click;
            // 
            // 結合ToolStripMenuItem
            // 
            結合ToolStripMenuItem.Name = "結合ToolStripMenuItem";
            結合ToolStripMenuItem.Size = new Size(98, 22);
            結合ToolStripMenuItem.Text = "結合";
            結合ToolStripMenuItem.Click += ObjJoinButton_Click;
            // 
            // 分割ToolStripMenuItem
            // 
            分割ToolStripMenuItem.Name = "分割ToolStripMenuItem";
            分割ToolStripMenuItem.Size = new Size(98, 22);
            分割ToolStripMenuItem.Text = "分割";
            分割ToolStripMenuItem.Click += ObjSpiltButton_Click;
            // 
            // DeleteObj
            // 
            DeleteObj.Name = "DeleteObj";
            DeleteObj.Size = new Size(98, 22);
            DeleteObj.Text = "削除";
            DeleteObj.Click += ObjDeleteButton_Click;
            // 
            // MoveObj
            // 
            MoveObj.DropDownItems.AddRange(new ToolStripItem[] { MoveUpObj, MoveDownObj });
            MoveObj.Name = "MoveObj";
            MoveObj.Size = new Size(98, 22);
            MoveObj.Text = "移動";
            // 
            // MoveUpObj
            // 
            MoveUpObj.Name = "MoveUpObj";
            MoveUpObj.Size = new Size(180, 22);
            MoveUpObj.Text = "上へ";
            MoveUpObj.Click += ObjUpButton_Click;
            // 
            // MoveDownObj
            // 
            MoveDownObj.Name = "MoveDownObj";
            MoveDownObj.Size = new Size(180, 22);
            MoveDownObj.Text = "下へ";
            MoveDownObj.Click += ObjDownButton_Click;
            // 
            // ExoViewText
            // 
            ExoViewText.ContextMenuStrip = ExoViewMenu;
            ExoViewText.HeaderText = "テキスト";
            ExoViewText.Name = "ExoViewText";
            ExoViewText.ReadOnly = true;
            ExoViewText.Resizable = DataGridViewTriState.False;
            ExoViewText.SortMode = DataGridViewColumnSortMode.NotSortable;
            ExoViewText.Width = 120;
            // 
            // ExoViewLyric
            // 
            ExoViewLyric.ContextMenuStrip = ExoViewMenu;
            ExoViewLyric.HeaderText = "歌詞";
            ExoViewLyric.Name = "ExoViewLyric";
            ExoViewLyric.ReadOnly = true;
            ExoViewLyric.Resizable = DataGridViewTriState.False;
            ExoViewLyric.SortMode = DataGridViewColumnSortMode.NotSortable;
            ExoViewLyric.Width = 80;
            // 
            // ExoViewLength
            // 
            ExoViewLength.ContextMenuStrip = ExoViewMenu;
            ExoViewLength.HeaderText = "長さ";
            ExoViewLength.Name = "ExoViewLength";
            ExoViewLength.ReadOnly = true;
            ExoViewLength.Resizable = DataGridViewTriState.False;
            ExoViewLength.SortMode = DataGridViewColumnSortMode.NotSortable;
            ExoViewLength.Width = 80;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(542, 433);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(110, 40);
            BackButton.TabIndex = 14;
            BackButton.Text = "戻る";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(658, 433);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(110, 40);
            NextButton.TabIndex = 13;
            NextButton.Text = "次へ";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // UstDataView
            // 
            UstDataView.AllowUserToAddRows = false;
            UstDataView.AllowUserToDeleteRows = false;
            UstDataView.AllowUserToResizeColumns = false;
            UstDataView.AllowUserToResizeRows = false;
            UstDataView.BackgroundColor = SystemColors.Window;
            UstDataView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            UstDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UstDataView.Columns.AddRange(new DataGridViewColumn[] { UstViewId, UstViewLyric, UstViewLegth });
            UstDataView.Location = new Point(53, 53);
            UstDataView.Name = "UstDataView";
            UstDataView.ReadOnly = true;
            UstDataView.RowHeadersVisible = false;
            UstDataView.ScrollBars = ScrollBars.Vertical;
            UstDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UstDataView.Size = new Size(300, 320);
            UstDataView.TabIndex = 12;
            // 
            // UstViewId
            // 
            UstViewId.ContextMenuStrip = UstViewMenu;
            UstViewId.HeaderText = "id";
            UstViewId.Name = "UstViewId";
            UstViewId.ReadOnly = true;
            UstViewId.Resizable = DataGridViewTriState.False;
            UstViewId.SortMode = DataGridViewColumnSortMode.NotSortable;
            UstViewId.Width = 70;
            // 
            // UstViewMenu
            // 
            UstViewMenu.Items.AddRange(new ToolStripItem[] { そのまま追加ToolStripMenuItem, AddToExo });
            UstViewMenu.Name = "UstViewMenu";
            UstViewMenu.Size = new Size(140, 48);
            // 
            // そのまま追加ToolStripMenuItem
            // 
            そのまま追加ToolStripMenuItem.Name = "そのまま追加ToolStripMenuItem";
            そのまま追加ToolStripMenuItem.Size = new Size(139, 22);
            そのまま追加ToolStripMenuItem.Text = "そのまま追加";
            そのまま追加ToolStripMenuItem.Click += ObjAddButton_Click;
            // 
            // AddToExo
            // 
            AddToExo.Name = "AddToExo";
            AddToExo.Size = new Size(139, 22);
            AddToExo.Text = "結合して追加";
            AddToExo.Click += ObjAddButton_Click;
            // 
            // UstViewLyric
            // 
            UstViewLyric.ContextMenuStrip = UstViewMenu;
            UstViewLyric.HeaderText = "歌詞";
            UstViewLyric.Name = "UstViewLyric";
            UstViewLyric.ReadOnly = true;
            UstViewLyric.Resizable = DataGridViewTriState.False;
            UstViewLyric.SortMode = DataGridViewColumnSortMode.NotSortable;
            UstViewLyric.Width = 110;
            // 
            // UstViewLegth
            // 
            UstViewLegth.ContextMenuStrip = UstViewMenu;
            UstViewLegth.HeaderText = "長さ";
            UstViewLegth.Name = "UstViewLegth";
            UstViewLegth.ReadOnly = true;
            UstViewLegth.Resizable = DataGridViewTriState.False;
            UstViewLegth.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // UstLabel
            // 
            UstLabel.AutoSize = true;
            UstLabel.Location = new Point(53, 35);
            UstLabel.Name = "UstLabel";
            UstLabel.Size = new Size(23, 15);
            UstLabel.TabIndex = 9;
            UstLabel.Text = "ust";
            // 
            // ExoLabel
            // 
            ExoLabel.AutoSize = true;
            ExoLabel.Location = new Point(444, 35);
            ExoLabel.Name = "ExoLabel";
            ExoLabel.Size = new Size(26, 15);
            ExoLabel.TabIndex = 17;
            ExoLabel.Text = "exo";
            // 
            // ObjJoinAddButton
            // 
            ObjJoinAddButton.Location = new Point(371, 239);
            ObjJoinAddButton.Margin = new Padding(15, 7, 15, 7);
            ObjJoinAddButton.Name = "ObjJoinAddButton";
            ObjJoinAddButton.Size = new Size(55, 65);
            ObjJoinAddButton.TabIndex = 16;
            ObjJoinAddButton.Text = "→\r\n結合\r\n追加";
            ObjJoinAddButton.UseVisualStyleBackColor = true;
            ObjJoinAddButton.Click += ObjJoinAddButton_Click;
            // 
            // ObjUpButton
            // 
            ObjUpButton.Location = new Point(449, 379);
            ObjUpButton.Name = "ObjUpButton";
            ObjUpButton.Size = new Size(30, 23);
            ObjUpButton.TabIndex = 18;
            ObjUpButton.Text = "↑";
            ObjUpButton.UseVisualStyleBackColor = true;
            ObjUpButton.Click += ObjUpButton_Click;
            // 
            // ObjEditButton
            // 
            ObjEditButton.Location = new Point(485, 379);
            ObjEditButton.Name = "ObjEditButton";
            ObjEditButton.Size = new Size(50, 23);
            ObjEditButton.TabIndex = 19;
            ObjEditButton.Text = "編集";
            ObjEditButton.UseVisualStyleBackColor = true;
            ObjEditButton.Click += ObjEditButton_Click;
            // 
            // ObjJoinButton
            // 
            ObjJoinButton.Location = new Point(541, 379);
            ObjJoinButton.Name = "ObjJoinButton";
            ObjJoinButton.Size = new Size(50, 23);
            ObjJoinButton.TabIndex = 20;
            ObjJoinButton.Text = "結合";
            ObjJoinButton.UseVisualStyleBackColor = true;
            ObjJoinButton.Click += ObjJoinButton_Click;
            // 
            // ObjSpiltButton
            // 
            ObjSpiltButton.Location = new Point(597, 379);
            ObjSpiltButton.Name = "ObjSpiltButton";
            ObjSpiltButton.Size = new Size(50, 23);
            ObjSpiltButton.TabIndex = 21;
            ObjSpiltButton.Text = "分割";
            ObjSpiltButton.UseVisualStyleBackColor = true;
            ObjSpiltButton.Click += ObjSpiltButton_Click;
            // 
            // ObjDeleteButton
            // 
            ObjDeleteButton.Location = new Point(653, 379);
            ObjDeleteButton.Name = "ObjDeleteButton";
            ObjDeleteButton.Size = new Size(50, 23);
            ObjDeleteButton.TabIndex = 21;
            ObjDeleteButton.Text = "削除";
            ObjDeleteButton.UseVisualStyleBackColor = true;
            ObjDeleteButton.Click += ObjDeleteButton_Click;
            // 
            // ObjDownButton
            // 
            ObjDownButton.Location = new Point(709, 379);
            ObjDownButton.Name = "ObjDownButton";
            ObjDownButton.Size = new Size(30, 23);
            ObjDownButton.TabIndex = 18;
            ObjDownButton.Text = "↓";
            ObjDownButton.UseVisualStyleBackColor = true;
            ObjDownButton.Click += ObjDownButton_Click;
            // 
            // ObjectEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ObjDeleteButton);
            Controls.Add(ObjSpiltButton);
            Controls.Add(ObjJoinButton);
            Controls.Add(ObjEditButton);
            Controls.Add(ObjDownButton);
            Controls.Add(ObjUpButton);
            Controls.Add(ExoLabel);
            Controls.Add(NextButton);
            Controls.Add(BackButton);
            Controls.Add(ExoDataView);
            Controls.Add(ObjJoinAddButton);
            Controls.Add(ObjAddButton);
            Controls.Add(UstDataView);
            Controls.Add(UstLabel);
            Name = "ObjectEdit";
            Size = new Size(800, 500);
            VisibleChanged += ObjectEdit_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)ExoDataView).EndInit();
            ExoViewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UstDataView).EndInit();
            UstViewMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip UstViewMenu;
        private ToolStripMenuItem AddToExo;
        private ToolStripMenuItem EditObj;
        private ToolStripMenuItem DeleteObj;
        private ContextMenuStrip ExoViewMenu;
        private Button ObjAddButton;
        private DataGridView ExoDataView;
        private Button BackButton;
        private Button NextButton;
        private DataGridView UstDataView;
        private Label UstLabel;
        private DataGridViewTextBoxColumn UstViewId;
        private DataGridViewTextBoxColumn UstViewLyric;
        private DataGridViewTextBoxColumn UstViewLegth;
        private DataGridViewTextBoxColumn LyricIndex;
        private DataGridViewTextBoxColumn ExoViewText;
        private DataGridViewTextBoxColumn ExoViewLyric;
        private DataGridViewTextBoxColumn ExoViewLength;
        private Label ExoLabel;
        private ToolStripMenuItem 結合ToolStripMenuItem;
        private ToolStripMenuItem 分割ToolStripMenuItem;
        private Button ObjJoinAddButton;
        private ToolStripMenuItem そのまま追加ToolStripMenuItem;
        private Button ObjUpButton;
        private Button ObjEditButton;
        private Button ObjJoinButton;
        private Button ObjSpiltButton;
        private Button ObjDeleteButton;
        private Button ObjDownButton;
        private ToolStripMenuItem MoveObj;
        private ToolStripMenuItem MoveUpObj;
        private ToolStripMenuItem MoveDownObj;
    }
}
