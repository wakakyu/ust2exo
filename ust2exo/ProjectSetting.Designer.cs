namespace ust2exo
{
    partial class ProjectSetting
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
            NextButton = new Button();
            SelectUstButton = new Button();
            UstPathBox = new TextBox();
            UstPathLabel = new Label();
            SizeLabel1 = new Label();
            WidthBox = new TextBox();
            SizeLabel2 = new Label();
            HeightBox = new TextBox();
            RateLabel1 = new Label();
            RateBox = new TextBox();
            RateLabel2 = new Label();
            AudioLabel1 = new Label();
            AudioRateBox = new TextBox();
            AudioLabel2 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // NextButton
            // 
            NextButton.Location = new Point(658, 433);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(110, 40);
            NextButton.TabIndex = 0;
            NextButton.Text = "次へ";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // SelectUstButton
            // 
            SelectUstButton.Location = new Point(510, 42);
            SelectUstButton.Name = "SelectUstButton";
            SelectUstButton.Size = new Size(98, 23);
            SelectUstButton.TabIndex = 14;
            SelectUstButton.Text = "ファイルを選択";
            SelectUstButton.UseVisualStyleBackColor = true;
            SelectUstButton.Click += SelectUstButton_Click;
            // 
            // UstPathBox
            // 
            UstPathBox.BackColor = SystemColors.Window;
            UstPathBox.Location = new Point(71, 42);
            UstPathBox.Name = "UstPathBox";
            UstPathBox.ReadOnly = true;
            UstPathBox.Size = new Size(433, 23);
            UstPathBox.TabIndex = 13;
            // 
            // UstPathLabel
            // 
            UstPathLabel.AutoSize = true;
            UstPathLabel.Location = new Point(30, 45);
            UstPathLabel.Name = "UstPathLabel";
            UstPathLabel.Size = new Size(35, 15);
            UstPathLabel.TabIndex = 12;
            UstPathLabel.Text = "ust：";
            // 
            // SizeLabel1
            // 
            SizeLabel1.AutoSize = true;
            SizeLabel1.Location = new Point(30, 125);
            SizeLabel1.Name = "SizeLabel1";
            SizeLabel1.Size = new Size(52, 15);
            SizeLabel1.TabIndex = 15;
            SizeLabel1.Text = "解像度 : ";
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(110, 122);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(50, 23);
            WidthBox.TabIndex = 16;
            WidthBox.Text = "1920";
            // 
            // SizeLabel2
            // 
            SizeLabel2.AutoSize = true;
            SizeLabel2.Location = new Point(166, 125);
            SizeLabel2.Name = "SizeLabel2";
            SizeLabel2.Size = new Size(15, 15);
            SizeLabel2.TabIndex = 0;
            SizeLabel2.Text = "×";
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(187, 122);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(50, 23);
            HeightBox.TabIndex = 17;
            HeightBox.Text = "1080";
            // 
            // RateLabel1
            // 
            RateLabel1.AutoSize = true;
            RateLabel1.Location = new Point(29, 155);
            RateLabel1.Name = "RateLabel1";
            RateLabel1.Size = new Size(75, 15);
            RateLabel1.TabIndex = 18;
            RateLabel1.Text = "フレームレート : ";
            // 
            // RateBox
            // 
            RateBox.Location = new Point(110, 152);
            RateBox.Name = "RateBox";
            RateBox.Size = new Size(100, 23);
            RateBox.TabIndex = 19;
            RateBox.Text = "60";
            // 
            // RateLabel2
            // 
            RateLabel2.AutoSize = true;
            RateLabel2.Location = new Point(216, 155);
            RateLabel2.Name = "RateLabel2";
            RateLabel2.Size = new Size(23, 15);
            RateLabel2.TabIndex = 20;
            RateLabel2.Text = "fps";
            // 
            // AudioLabel1
            // 
            AudioLabel1.AutoSize = true;
            AudioLabel1.Location = new Point(30, 185);
            AudioLabel1.Name = "AudioLabel1";
            AudioLabel1.Size = new Size(65, 15);
            AudioLabel1.TabIndex = 21;
            AudioLabel1.Text = "音声レート : ";
            // 
            // AudioRateBox
            // 
            AudioRateBox.Location = new Point(110, 182);
            AudioRateBox.Name = "AudioRateBox";
            AudioRateBox.Size = new Size(100, 23);
            AudioRateBox.TabIndex = 22;
            AudioRateBox.Text = "44100";
            // 
            // AudioLabel2
            // 
            AudioLabel2.AutoSize = true;
            AudioLabel2.Location = new Point(216, 185);
            AudioLabel2.Name = "AudioLabel2";
            AudioLabel2.Size = new Size(21, 15);
            AudioLabel2.TabIndex = 23;
            AudioLabel2.Text = "Hz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 24;
            label1.Text = "1. ustファイルを選択";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 100);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 25;
            label2.Text = "2. プロジェクトの設定";
            // 
            // ProjectSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AudioLabel2);
            Controls.Add(AudioRateBox);
            Controls.Add(AudioLabel1);
            Controls.Add(RateLabel2);
            Controls.Add(RateBox);
            Controls.Add(RateLabel1);
            Controls.Add(HeightBox);
            Controls.Add(SizeLabel2);
            Controls.Add(WidthBox);
            Controls.Add(SizeLabel1);
            Controls.Add(SelectUstButton);
            Controls.Add(UstPathBox);
            Controls.Add(UstPathLabel);
            Controls.Add(NextButton);
            Name = "ProjectSetting";
            Size = new Size(800, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NextButton;
        private Button SelectUstButton;
        private TextBox UstPathBox;
        private Label UstPathLabel;
        private Label SizeLabel1;
        private TextBox WidthBox;
        private Label SizeLabel2;
        private TextBox HeightBox;
        private Label RateLabel1;
        private TextBox RateBox;
        private Label RateLabel2;
        private Label AudioLabel1;
        private TextBox AudioRateBox;
        private Label AudioLabel2;
        private Label label1;
        private Label label2;
    }
}
