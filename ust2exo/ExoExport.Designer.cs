namespace ust2exo
{
    partial class ExoExport
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
            ExportButton = new Button();
            BackButton = new Button();
            label1 = new Label();
            LocLanel_x = new Label();
            LocBox_x = new TextBox();
            LocLabel_y = new Label();
            LocBox_y = new TextBox();
            LocLabel_z = new Label();
            LocBox_z = new TextBox();
            ZoomLabel = new Label();
            ZoomBox = new TextBox();
            ClearnessLabel = new Label();
            ClearnessBox = new TextBox();
            RotateLabel = new Label();
            RotateBox = new TextBox();
            SizeLabel = new Label();
            SizeBox = new TextBox();
            SppedLabel = new Label();
            SpeedBox = new TextBox();
            BlendLabel = new Label();
            BlendBox = new ComboBox();
            ScrollCheck = new CheckBox();
            CharCheck = new CheckBox();
            AdjustCheck = new CheckBox();
            FontBox = new ComboBox();
            TypeBox = new ComboBox();
            AlignBox = new ComboBox();
            BoldCheck = new CheckBox();
            ItalicCheck = new CheckBox();
            MoveCheck = new CheckBox();
            SpaceLabel_x = new Label();
            SpaceLabel_y = new Label();
            SpaceBox_x = new NumericUpDown();
            SpaceBox_y = new NumericUpDown();
            ColorDialog1 = new ColorDialog();
            Color1Button = new Button();
            Color2Button = new Button();
            Color1Label = new Label();
            Color2Label = new Label();
            ColorDialog2 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)SpaceBox_x).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpaceBox_y).BeginInit();
            SuspendLayout();
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(658, 433);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(110, 40);
            ExportButton.TabIndex = 14;
            ExportButton.Text = "exoファイル作成";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(542, 433);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(110, 40);
            BackButton.TabIndex = 15;
            BackButton.Text = "戻る";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 16;
            label1.Text = "テキストオブジェクト一括設定";
            // 
            // LocLanel_x
            // 
            LocLanel_x.AutoSize = true;
            LocLanel_x.Location = new Point(30, 45);
            LocLanel_x.Name = "LocLanel_x";
            LocLanel_x.Size = new Size(23, 15);
            LocLanel_x.TabIndex = 17;
            LocLanel_x.Text = "X : ";
            // 
            // LocBox_x
            // 
            LocBox_x.Location = new Point(100, 42);
            LocBox_x.Name = "LocBox_x";
            LocBox_x.Size = new Size(100, 23);
            LocBox_x.TabIndex = 18;
            LocBox_x.Text = "0.0";
            // 
            // LocLabel_y
            // 
            LocLabel_y.AutoSize = true;
            LocLabel_y.Location = new Point(30, 75);
            LocLabel_y.Name = "LocLabel_y";
            LocLabel_y.Size = new Size(23, 15);
            LocLabel_y.TabIndex = 19;
            LocLabel_y.Text = "Y : ";
            // 
            // LocBox_y
            // 
            LocBox_y.Location = new Point(100, 72);
            LocBox_y.Name = "LocBox_y";
            LocBox_y.Size = new Size(100, 23);
            LocBox_y.TabIndex = 20;
            LocBox_y.Text = "0.0";
            // 
            // LocLabel_z
            // 
            LocLabel_z.AutoSize = true;
            LocLabel_z.Location = new Point(30, 105);
            LocLabel_z.Name = "LocLabel_z";
            LocLabel_z.Size = new Size(23, 15);
            LocLabel_z.TabIndex = 21;
            LocLabel_z.Text = "Z : ";
            // 
            // LocBox_z
            // 
            LocBox_z.Location = new Point(100, 102);
            LocBox_z.Name = "LocBox_z";
            LocBox_z.Size = new Size(100, 23);
            LocBox_z.TabIndex = 22;
            LocBox_z.Text = "0.0";
            // 
            // ZoomLabel
            // 
            ZoomLabel.AutoSize = true;
            ZoomLabel.Location = new Point(30, 135);
            ZoomLabel.Name = "ZoomLabel";
            ZoomLabel.Size = new Size(52, 15);
            ZoomLabel.TabIndex = 23;
            ZoomLabel.Text = "拡大率 : ";
            // 
            // ZoomBox
            // 
            ZoomBox.Location = new Point(100, 132);
            ZoomBox.Name = "ZoomBox";
            ZoomBox.Size = new Size(100, 23);
            ZoomBox.TabIndex = 24;
            ZoomBox.Text = "100.00";
            // 
            // ClearnessLabel
            // 
            ClearnessLabel.AutoSize = true;
            ClearnessLabel.Location = new Point(30, 165);
            ClearnessLabel.Name = "ClearnessLabel";
            ClearnessLabel.Size = new Size(52, 15);
            ClearnessLabel.TabIndex = 25;
            ClearnessLabel.Text = "透明度 : ";
            // 
            // ClearnessBox
            // 
            ClearnessBox.Location = new Point(100, 162);
            ClearnessBox.Name = "ClearnessBox";
            ClearnessBox.Size = new Size(100, 23);
            ClearnessBox.TabIndex = 26;
            ClearnessBox.Text = "0.0";
            // 
            // RotateLabel
            // 
            RotateLabel.AutoSize = true;
            RotateLabel.Location = new Point(30, 195);
            RotateLabel.Name = "RotateLabel";
            RotateLabel.Size = new Size(40, 15);
            RotateLabel.TabIndex = 27;
            RotateLabel.Text = "回転 : ";
            // 
            // RotateBox
            // 
            RotateBox.Location = new Point(100, 192);
            RotateBox.Name = "RotateBox";
            RotateBox.Size = new Size(100, 23);
            RotateBox.TabIndex = 28;
            RotateBox.Text = "0.00";
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Location = new Point(30, 225);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(44, 15);
            SizeLabel.TabIndex = 29;
            SizeLabel.Text = "サイズ : ";
            // 
            // SizeBox
            // 
            SizeBox.Location = new Point(100, 222);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(100, 23);
            SizeBox.TabIndex = 30;
            SizeBox.Text = "100";
            // 
            // SppedLabel
            // 
            SppedLabel.AutoSize = true;
            SppedLabel.Location = new Point(30, 255);
            SppedLabel.Name = "SppedLabel";
            SppedLabel.Size = new Size(64, 15);
            SppedLabel.TabIndex = 31;
            SppedLabel.Text = "表示速度 : ";
            // 
            // SpeedBox
            // 
            SpeedBox.Location = new Point(100, 252);
            SpeedBox.Name = "SpeedBox";
            SpeedBox.Size = new Size(100, 23);
            SpeedBox.TabIndex = 32;
            SpeedBox.Text = "0.0";
            // 
            // BlendLabel
            // 
            BlendLabel.AutoSize = true;
            BlendLabel.Location = new Point(427, 45);
            BlendLabel.Name = "BlendLabel";
            BlendLabel.Size = new Size(56, 15);
            BlendLabel.TabIndex = 33;
            BlendLabel.Text = "合成モード";
            // 
            // BlendBox
            // 
            BlendBox.FormattingEnabled = true;
            BlendBox.Items.AddRange(new object[] { "通常", "加算", "減算", "乗算", "スクリーン", "オーバーレイ", "比較(明)", "比較(暗)", "輝度", "色差", "陰影", "明暗", "差分" });
            BlendBox.Location = new Point(300, 42);
            BlendBox.Name = "BlendBox";
            BlendBox.Size = new Size(121, 23);
            BlendBox.TabIndex = 34;
            BlendBox.Text = "通常";
            // 
            // ScrollCheck
            // 
            ScrollCheck.AutoSize = true;
            ScrollCheck.Location = new Point(300, 74);
            ScrollCheck.Name = "ScrollCheck";
            ScrollCheck.Size = new Size(95, 19);
            ScrollCheck.TabIndex = 36;
            ScrollCheck.Text = "自動スクロール";
            ScrollCheck.UseVisualStyleBackColor = true;
            // 
            // CharCheck
            // 
            CharCheck.AutoSize = true;
            CharCheck.Location = new Point(300, 104);
            CharCheck.Name = "CharCheck";
            CharCheck.Size = new Size(151, 19);
            CharCheck.TabIndex = 37;
            CharCheck.Text = "文字ごとに個別オブジェクト";
            CharCheck.UseVisualStyleBackColor = true;
            CharCheck.CheckedChanged += CharCheck_CheckedChanged;
            // 
            // AdjustCheck
            // 
            AdjustCheck.AutoSize = true;
            AdjustCheck.Location = new Point(300, 164);
            AdjustCheck.Name = "AdjustCheck";
            AdjustCheck.Size = new Size(164, 19);
            AdjustCheck.TabIndex = 38;
            AdjustCheck.Text = "オブジェクトの長さを自動調整";
            AdjustCheck.UseVisualStyleBackColor = true;
            // 
            // FontBox
            // 
            FontBox.FormattingEnabled = true;
            FontBox.Location = new Point(570, 42);
            FontBox.Name = "FontBox";
            FontBox.Size = new Size(121, 23);
            FontBox.TabIndex = 41;
            FontBox.Text = "MS UI Gothic";
            // 
            // TypeBox
            // 
            TypeBox.FormattingEnabled = true;
            TypeBox.Items.AddRange(new object[] { "標準文字", "影付き文字", "影付き文字(薄)", "縁取り文字", "縁取り文字(細)" });
            TypeBox.Location = new Point(570, 72);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(121, 23);
            TypeBox.TabIndex = 42;
            TypeBox.Text = "標準文字";
            // 
            // AlignBox
            // 
            AlignBox.FormattingEnabled = true;
            AlignBox.Items.AddRange(new object[] { "左寄せ[上]", "中央揃え[上]", "右寄せ[上]", "左寄せ[中]", "中央揃え[中]", "右寄せ[中]", "左寄せ[下]", "中央揃え[下]", "右寄せ[下]", "縦書 上寄[右]", "縦書 中央[右]", "縦書 下寄[右]", "縦書 上寄[中]", "縦書 中央[中]", "縦書 下寄[中]", "縦書 上寄[左]", "縦書 中央[左]", "縦書 下寄[左]" });
            AlignBox.Location = new Point(570, 102);
            AlignBox.Name = "AlignBox";
            AlignBox.Size = new Size(121, 23);
            AlignBox.TabIndex = 43;
            AlignBox.Text = "左寄せ[上]";
            // 
            // BoldCheck
            // 
            BoldCheck.AutoSize = true;
            BoldCheck.Location = new Point(570, 134);
            BoldCheck.Name = "BoldCheck";
            BoldCheck.Size = new Size(50, 19);
            BoldCheck.TabIndex = 44;
            BoldCheck.Text = "太字";
            BoldCheck.UseVisualStyleBackColor = true;
            // 
            // ItalicCheck
            // 
            ItalicCheck.AutoSize = true;
            ItalicCheck.Location = new Point(570, 164);
            ItalicCheck.Name = "ItalicCheck";
            ItalicCheck.Size = new Size(50, 19);
            ItalicCheck.TabIndex = 45;
            ItalicCheck.Text = "斜体";
            ItalicCheck.UseVisualStyleBackColor = true;
            // 
            // MoveCheck
            // 
            MoveCheck.AutoSize = true;
            MoveCheck.Location = new Point(300, 134);
            MoveCheck.Name = "MoveCheck";
            MoveCheck.Size = new Size(138, 19);
            MoveCheck.TabIndex = 37;
            MoveCheck.Text = "移動座標上に表示する";
            MoveCheck.UseVisualStyleBackColor = true;
            MoveCheck.Visible = false;
            // 
            // SpaceLabel_x
            // 
            SpaceLabel_x.AutoSize = true;
            SpaceLabel_x.Location = new Point(570, 195);
            SpaceLabel_x.Name = "SpaceLabel_x";
            SpaceLabel_x.Size = new Size(40, 15);
            SpaceLabel_x.TabIndex = 46;
            SpaceLabel_x.Text = "字間 : ";
            // 
            // SpaceLabel_y
            // 
            SpaceLabel_y.AutoSize = true;
            SpaceLabel_y.Location = new Point(570, 225);
            SpaceLabel_y.Name = "SpaceLabel_y";
            SpaceLabel_y.Size = new Size(40, 15);
            SpaceLabel_y.TabIndex = 48;
            SpaceLabel_y.Text = "行間 : ";
            // 
            // SpaceBox_x
            // 
            SpaceBox_x.Location = new Point(616, 193);
            SpaceBox_x.Name = "SpaceBox_x";
            SpaceBox_x.Size = new Size(50, 23);
            SpaceBox_x.TabIndex = 50;
            // 
            // SpaceBox_y
            // 
            SpaceBox_y.Location = new Point(616, 223);
            SpaceBox_y.Name = "SpaceBox_y";
            SpaceBox_y.Size = new Size(50, 23);
            SpaceBox_y.TabIndex = 51;
            // 
            // ColorDialog1
            // 
            ColorDialog1.Color = Color.White;
            // 
            // Color1Button
            // 
            Color1Button.Location = new Point(300, 191);
            Color1Button.Name = "Color1Button";
            Color1Button.Size = new Size(100, 23);
            Color1Button.TabIndex = 52;
            Color1Button.Text = "文字色";
            Color1Button.UseVisualStyleBackColor = true;
            Color1Button.Click += Color1Button_Click;
            // 
            // Color2Button
            // 
            Color2Button.Location = new Point(300, 221);
            Color2Button.Name = "Color2Button";
            Color2Button.Size = new Size(100, 23);
            Color2Button.TabIndex = 53;
            Color2Button.Text = "影・縁色";
            Color2Button.UseVisualStyleBackColor = true;
            Color2Button.Click += Color2Button_Click;
            // 
            // Color1Label
            // 
            Color1Label.AutoSize = true;
            Color1Label.Location = new Point(406, 195);
            Color1Label.Name = "Color1Label";
            Color1Label.Size = new Size(35, 15);
            Color1Label.TabIndex = 54;
            Color1Label.Text = "#ffffff";
            // 
            // Color2Label
            // 
            Color2Label.AutoSize = true;
            Color2Label.Location = new Point(406, 225);
            Color2Label.Name = "Color2Label";
            Color2Label.Size = new Size(50, 15);
            Color2Label.TabIndex = 55;
            Color2Label.Text = "#000000";
            // 
            // ExoExport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Color2Label);
            Controls.Add(Color1Label);
            Controls.Add(Color2Button);
            Controls.Add(Color1Button);
            Controls.Add(SpaceBox_y);
            Controls.Add(SpaceBox_x);
            Controls.Add(SpaceLabel_y);
            Controls.Add(SpaceLabel_x);
            Controls.Add(ItalicCheck);
            Controls.Add(BoldCheck);
            Controls.Add(AlignBox);
            Controls.Add(TypeBox);
            Controls.Add(FontBox);
            Controls.Add(AdjustCheck);
            Controls.Add(MoveCheck);
            Controls.Add(CharCheck);
            Controls.Add(ScrollCheck);
            Controls.Add(BlendBox);
            Controls.Add(BlendLabel);
            Controls.Add(SpeedBox);
            Controls.Add(SppedLabel);
            Controls.Add(SizeBox);
            Controls.Add(SizeLabel);
            Controls.Add(RotateBox);
            Controls.Add(RotateLabel);
            Controls.Add(ClearnessBox);
            Controls.Add(ClearnessLabel);
            Controls.Add(ZoomBox);
            Controls.Add(ZoomLabel);
            Controls.Add(LocBox_z);
            Controls.Add(LocLabel_z);
            Controls.Add(LocBox_y);
            Controls.Add(LocLabel_y);
            Controls.Add(LocBox_x);
            Controls.Add(LocLanel_x);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Controls.Add(ExportButton);
            Name = "ExoExport";
            Size = new Size(800, 500);
            VisibleChanged += ExoExport_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)SpaceBox_x).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpaceBox_y).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExportButton;
        private Button BackButton;
        private Label label1;
        private Label LocLanel_x;
        private TextBox LocBox_x;
        private Label LocLabel_y;
        private TextBox LocBox_y;
        private Label LocLabel_z;
        private TextBox LocBox_z;
        private Label ZoomLabel;
        private TextBox ZoomBox;
        private Label ClearnessLabel;
        private TextBox ClearnessBox;
        private Label RotateLabel;
        private TextBox RotateBox;
        private Label SizeLabel;
        private TextBox SizeBox;
        private Label SppedLabel;
        private TextBox SpeedBox;
        private Label BlendLabel;
        private ComboBox BlendBox;
        private CheckBox ScrollCheck;
        private CheckBox CharCheck;
        private CheckBox AdjustCheck;
        private ComboBox FontBox;
        private ComboBox TypeBox;
        private ComboBox AlignBox;
        private CheckBox BoldCheck;
        private CheckBox ItalicCheck;
        private CheckBox MoveCheck;
        private Label SpaceLabel_x;
        private Label SpaceLabel_y;
        private NumericUpDown SpaceBox_x;
        private NumericUpDown SpaceBox_y;
        private ColorDialog ColorDialog1;
        private Button Color1Button;
        private Button Color2Button;
        private Label Color1Label;
        private Label Color2Label;
        private ColorDialog ColorDialog2;
    }
}
