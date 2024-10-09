using System.Text;

namespace ust2exo
{
    public partial class ExoExport : UserControl
    {
        private Ust ust = new();
        private Exo exo = new();

        public ExoExport(Ust u, Exo e)
        {
            InitializeComponent();
            ust = u;
            exo = e;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1.exoExport.Visible = false;
            Form1.objectEdit.Visible = true;
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            var exoPath = SelectExoFile();

            if (exoPath != string.Empty && exo.Objects.Count != 0)
            {
                string exoText =
                (
                    "[exedit]\n" +
                    $"width={exo.Width}\n" +
                    $"height={exo.Height}\n" +
                    $"rate={exo.Rate}\n" +
                    "scale=1\n" +
                    $"length={exo.Objects[exo.Objects.Count - 1].End}\n" +
                    $"audio_rate={exo.AudioRate}\n" +
                    "audio_ch=2\n"
                );

                foreach (Objects obj in exo.Objects)
                {
                    exoText +=
                    (
                        $"[{obj.Name}]\n" +
                        $"start={obj.Start}\n" +
                        $"end={obj.End}\n" +
                        "layer=1\n" +
                        "overlay=1\n" +
                        "camera=0\n"
                    );
                    exoText +=
                    (
                        $"[{obj.Name}.0]\n" +
                        "_name=テキスト\n" +
                        $"サイズ={SizeBox.Text}\n" +
                        $"表示速度={SpeedBox.Text}\n" +
                        $"文字毎に個別オブジェクト={Convert.ToInt32(CharCheck.Checked)}\n" +
                        $"移動座標上に表示する={Convert.ToInt32(MoveCheck.Checked)}\n" +
                        $"自動スクロール={Convert.ToInt32(ScrollCheck.Checked)}\n" +
                        $"B={Convert.ToInt32(BoldCheck.Checked)}\n" +
                        $"I={Convert.ToInt32(ItalicCheck.Checked)}\n" +
                        // 影付き, 縁取り
                        $"type={TypeBox.SelectedIndex}\n" +
                        "autoadjust=0\n" +
                        "soft=1\n" +
                        "monospace=0\n" +
                        // 左寄せ, 中央寄せ, 右寄せ
                        $"align={AlignBox.SelectedIndex}\n" +
                        // 字間
                        $"spacing_x={SpaceBox_x.Text}\n" +
                        // 行間
                        $"spacing_y={SpaceBox_y.Text}\n" +
                        "precision=1\n" +
                        $"color={Color1Label.Text.Replace("#", "")}\n" +
                        $"color2={Color2Label.Text.Replace("#", "")}\n" +
                        $"font={FontBox.Text}\n" +
                        $"text={obj.Text}\n"
                    );
                    exoText +=
                    (
                        $"[{obj.Name}.1]\n" +
                        "_name=標準描画\n" +
                        $"X={LocBox_x.Text}\n" +
                        $"Y={LocBox_y.Text}\n" +
                        $"Z={LocBox_z.Text}\n" +
                        $"拡大率={ZoomBox.Text}\n" +
                        $"透明度={ClearnessBox.Text}\n" +
                        $"回転={RotateBox.Text}\n" +
                        $"blend={BlendBox.SelectedIndex}\n"
                    );

                }

                // exoファイル出力
                // 文字コードを指定
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding enc = Encoding.GetEncoding("Shift_JIS");
                // ファイルを開く
                StreamWriter writer = new StreamWriter(exoPath, false, enc);
                // テキストを書き込む
                writer.WriteLine(exoText);
                // ファイルを閉じる
                writer.Close();

                MessageBox.Show("exoファイルの保存が完了しました");
                Application.Exit();
            }
            else if (exo.Objects.Count == 0)
            {
                MessageBox.Show("オブジェクトがありません");
            }
        }

        /// <summary>
        /// exoファイル保存先選択
        /// </summary>
        /// <returns>string:選択されたファイルのフルパス キャンセル時はEmpty</returns>
        private string SelectExoFile()
        {
            string ret = string.Empty;

            //OpenFileDialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "exoファイルを保存";
                saveFileDialog.Filter = "Aviutlオブジェクトファイル(*.exo)|*.exo|すべてのファイル(*.*)|*.*";
                saveFileDialog.FileName = "てすと.exo";
                //openFileDialog.InitialDirectory = "c:";  //最初に開くフォルダ

                //ファイル選択ダイアログを開く
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ret = saveFileDialog.FileName;
                }
            }
            return ret;
        }

        private void CharCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (CharCheck.Checked)
            {
                MoveCheck.Visible = true;
            }
            else
            {
                MoveCheck.Visible = false;
            }
        }

        // 画面が表示されたときの処理
        private void ExoExport_VisibleChanged(object sender, EventArgs e)
        {
            // フォントリストにフォント名を追加
            System.Drawing.Text.InstalledFontCollection ifc = new System.Drawing.Text.InstalledFontCollection();
            FontFamily[] ffs = ifc.Families;
            foreach (FontFamily ff in ffs)
            {
                //Fontオブジェクトを作成
                Font fnt = new Font(ff, 8);
                FontBox.Items.Add(fnt.Name);
            }
        }

        private void Color1Button_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                //選択された色の取得
                string R = Convert.ToString(ColorDialog1.Color.R, 16).PadLeft(2, '0');
                string G = Convert.ToString(ColorDialog1.Color.G, 16).PadLeft(2, '0');
                string B = Convert.ToString(ColorDialog1.Color.B, 16).PadLeft(2, '0');
                Color1Label.Text = "#" + R + G + B;
            }
        }

        private void Color2Button_Click(object sender, EventArgs e)
        {
            if (ColorDialog2.ShowDialog() == DialogResult.OK)
            {
                //選択された色の取得
                string R = Convert.ToString(ColorDialog2.Color.R, 16).PadLeft(2, '0');
                string G = Convert.ToString(ColorDialog2.Color.G, 16).PadLeft(2, '0');
                string B = Convert.ToString(ColorDialog2.Color.B, 16).PadLeft(2, '0');
                Color2Label.Text = "#" + R + G + B;
            }
        }
    }
}
