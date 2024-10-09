namespace ust2exo
{
    partial class TextEditForm
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
            TextLabel = new Label();
            ObjTextBox = new TextBox();
            LyricLabel = new Label();
            LyricTextBox = new TextBox();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(12, 9);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(42, 15);
            TextLabel.TabIndex = 0;
            TextLabel.Text = "テキスト";
            // 
            // ObjTextBox
            // 
            ObjTextBox.Location = new Point(12, 27);
            ObjTextBox.Multiline = true;
            ObjTextBox.Name = "ObjTextBox";
            ObjTextBox.Size = new Size(300, 50);
            ObjTextBox.TabIndex = 1;
            // 
            // LyricLabel
            // 
            LyricLabel.AutoSize = true;
            LyricLabel.Location = new Point(12, 90);
            LyricLabel.Name = "LyricLabel";
            LyricLabel.Size = new Size(31, 15);
            LyricLabel.TabIndex = 2;
            LyricLabel.Text = "歌詞";
            // 
            // LyricTextBox
            // 
            LyricTextBox.BackColor = SystemColors.Window;
            LyricTextBox.Location = new Point(12, 108);
            LyricTextBox.Name = "LyricTextBox";
            LyricTextBox.ReadOnly = true;
            LyricTextBox.Size = new Size(300, 23);
            LyricTextBox.TabIndex = 3;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(212, 160);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(100, 40);
            ConfirmButton.TabIndex = 4;
            ConfirmButton.Text = "決定";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // TextEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 211);
            Controls.Add(ConfirmButton);
            Controls.Add(LyricTextBox);
            Controls.Add(LyricLabel);
            Controls.Add(ObjTextBox);
            Controls.Add(TextLabel);
            KeyPreview = true;
            Name = "TextEditForm";
            Text = "テキストオブジェクトの詳細設定";
            Load += ObjEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextLabel;
        private TextBox ObjTextBox;
        private Label LyricLabel;
        private TextBox LyricTextBox;
        private Button ConfirmButton;
    }
}