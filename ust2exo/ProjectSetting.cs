using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace ust2exo
{
    public partial class ProjectSetting : UserControl
    {
        private Ust ust = new();
        private Exo exo = new();

        /// <summary>
        /// iniファイルの情報を取得
        /// </summary>
        /// <param name="lpAppName">セクション</param>
        /// <param name="lpKeyName">キー</param>
        /// <param name="lpDefault">デフォルト値</param>
        /// <param name="lpReturnedString">戻り値</param>
        /// <param name="nSize">最大文字数</param>
        /// <param name="lpFileName">ファイル名</param>
        [DllImport("kernel32.dll")]
        public static extern int GetPrivateProfileString
        (
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            int nSize,
            string lpFileName
        );

        /// <summary>
        /// iniファイルのセクション一覧を取得
        /// </summary>
        /// <param name="SectionsPointer">戻り値</param>
        /// <param name="nSize">最大文字数</param>
        /// <param name="lpFileName">ファイル名</param>
        [DllImport("kernel32.dll")]
        public static extern int GetPrivateProfileSectionNames
        (
            IntPtr SectionsPointer,
            int nSize,
            string lpFileName
        );

        public ProjectSetting(Ust u, Exo e)
        {
            InitializeComponent();
            ust = u;
            exo = e;
        }

        /// <summary>
        /// ustファイル選択ボタンをクリックしたときの処理
        /// </summary>
        private void SelectUstButton_Click(object sender, EventArgs e)
        {
            ust.Notes.Clear();
            var ustPath = SelectUstFile();

            if (ustPath != string.Empty)
            {
                UstPathBox.Text = ustPath;

                var exoPath = Regex.Replace(ustPath, ".ust", ".exo");

                // ustファイルからプロジェクト名とテンポを取得してUstクラスに格納
                StringBuilder pjName = new StringBuilder(1024);
                StringBuilder pjTempo = new StringBuilder(1024);
                GetPrivateProfileString("#SETTING", "ProjectName", string.Empty, pjName, pjName.Capacity, ustPath);
                GetPrivateProfileString("#SETTING", "Tempo", string.Empty, pjTempo, pjTempo.Capacity, ustPath);
                ust.ProjectName = pjName.ToString();
                ust.Tempo = double.Parse(pjTempo.ToString());

                // ustファイルのセクションを取得
                IntPtr SectionsPointer = Marshal.StringToHGlobalAnsi(new String('\0', 1024));
                //セクション名一覧 null文字区切り
                int length = GetPrivateProfileSectionNames(SectionsPointer, 102400, ustPath);
                if (0 < length)
                {
                    String result = Marshal.PtrToStringAnsi(SectionsPointer, length);
                    string[] x = result.Split('\0');
                    foreach (string section in x)
                    {
                        if (Regex.IsMatch(section, @"#[0-9]"))
                        {
                            StringBuilder notesLen = new StringBuilder(100);  // 長さ
                            StringBuilder notesLyric = new StringBuilder(100);  // 歌詞
                            GetPrivateProfileString(section, "Length", string.Empty, notesLen, notesLen.Capacity, ustPath);
                            GetPrivateProfileString(section, "Lyric", string.Empty, notesLyric, notesLyric.Capacity, ustPath);
                            Notes notes = new(section, double.Parse(notesLen.ToString()), notesLyric.ToString());
                            ust.Add(notes);

                        }
                    }
                }
                Marshal.FreeHGlobal(SectionsPointer);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ust.ProjectName != null)
            {
                exo.Width = int.Parse(WidthBox.Text);
                exo.Height = int.Parse(HeightBox.Text);
                exo.Rate = int.Parse(RateBox.Text);
                exo.AudioRate = int.Parse(AudioRateBox.Text);

                Form1.pjSetting.Visible = false;
                Form1.objectEdit.Visible = true;
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("ustファイルを選択してください");
            }
        }

        /// <summary>
        /// ustファイル選択
        /// </summary>
        /// <returns>string:選択されたファイルのフルパス キャンセル時はEmpty</returns>
        private string SelectUstFile()
        {
            string ret = string.Empty;

            //OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "ustファイルを選択";
                openFileDialog.Filter = "UTAUスクリプト形式(*.ust)|*.ust|すべてのファイル(*.*)|*.*";
                //openFileDialog.InitialDirectory = "c:";  //最初に開くフォルダ

                //ファイル選択ダイアログを開く
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ret = openFileDialog.FileName;
                }
            }
            return ret;
        }
    }
}
