using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace ust2exo
{
    public partial class ObjectEdit : UserControl
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

        /// <summary>
        /// iniファイルへ文字列の書き込み
        /// </summary>
        /// <param name="lpAppName">アプリケーション名</param>
        /// <param name="lpKeyName">キー</param>
        /// <param name="lpString">書き込み文字</param>
        /// <param name="lpFileName">ファイル名</param>
        [DllImport("kernel32.dll")]
        public static extern uint WritePrivateProfileString
        (
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFileName
        );

        public ObjectEdit(Ust u, Exo e)
        {
            InitializeComponent();
            ust = u;
            exo = e;
        }

        /// <summary>
        /// 表示時の処理
        /// </summary>
        private void ObjectEdit_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // 表のリセット
                UstDataView.Rows.Clear();
                ExoDataView.Rows.Clear();

                // 音符を表に表示
                foreach (Notes note in ust.Notes)
                {
                    UstDataView.Rows.Add(note.Name, note.Lyric, note.Length);
                }
            }
        }
        /// <summary>
        /// 歌詞をExoリストに追加
        /// </summary>
        private void ObjAddButton_Click(object sender, EventArgs e)
        {
            // 選択行を並び替え
            var query = from DataGridViewRow r in UstDataView.SelectedRows
                        orderby r.Index
                        select r;

            foreach (DataGridViewRow r in query)
            {

                List<int> lyricIds = new();
                lyricIds.Add(r.Index);
                ExoDataView.Rows.Add(lyricIds, r.Cells[1].Value, r.Cells[1].Value, r.Cells[2].Value);
                r.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
        /// <summary>
        /// 歌詞を結合してExoリストに追加
        /// </summary>
        private void ObjJoinAddButton_Click(object sender, EventArgs e)
        {
            // 選択行を並び替え
            var query = from DataGridViewRow r in UstDataView.SelectedRows
                        orderby r.Index
                        select r;

            string joinedText = "";
            string joinedLyric = "";
            double joinedLength = 0;
            List<int> lyricIds = new();
            foreach (DataGridViewRow r in query)
            {

                joinedText += r.Cells[1].Value;
                joinedLyric += (r.Cells[1].Value + " ");
                joinedLength += double.Parse("" + r.Cells[2].Value);
                lyricIds.Add(r.Index);
                r.DefaultCellStyle.BackColor = Color.LightGray;
            }
            ExoDataView.Rows.Add(lyricIds, joinedText, joinedLyric, joinedLength);
        }
        /// <summary>
        /// オブジェクトを結合
        /// </summary>
        private void ObjJoinButton_Click(Object sender, EventArgs e)
        {
            if (ExoDataView.SelectedRows.Count != 0)
            {
                // 選択行を並び替え
                var query = from DataGridViewRow r in ExoDataView.SelectedRows
                            orderby r.Index
                            select r;
                string joinedText = "";
                string joinedLyric = "";
                double joinedLength = 0;
                List<int> lyricIds = new();
                List<DataGridViewRow> selectedObj = new();
                foreach (DataGridViewRow r in query)
                {
                    selectedObj.Add(r);
                    joinedText += r.Cells[1].Value;
                    joinedLyric += (r.Cells[2].Value + " ");
                    joinedLength += double.Parse("" + r.Cells[3].Value);
                    lyricIds.AddRange(r.Cells[0].Value as List<int>);
                }
                ExoDataView.Rows.Insert(selectedObj[0].Index, 1);
                ExoDataView.Rows[selectedObj[0].Index - 1].Cells[0].Value = lyricIds;
                ExoDataView.Rows[selectedObj[0].Index - 1].Cells[1].Value = joinedText;
                ExoDataView.Rows[selectedObj[0].Index - 1].Cells[2].Value = joinedLyric;
                ExoDataView.Rows[selectedObj[0].Index - 1].Cells[3].Value = joinedLength.ToString();

                foreach (DataGridViewRow r in query)
                {
                    ExoDataView.Rows.Remove(r);
                }
            }
        }
        /// <summary>
        /// オブジェクトを分割
        /// </summary>
        private void ObjSpiltButton_Click(Object sender, EventArgs e)
        {
            if (ExoDataView.SelectedRows.Count != 0)
            {
                // 選択行を並び替え
                var query = from DataGridViewRow r in ExoDataView.SelectedRows
                            orderby r.Index
                            select r;
                foreach (DataGridViewRow r in query)
                {
                    int noteNum = (r.Cells[0].Value as List<int>).Count;
                    ExoDataView.Rows.Insert(r.Index, noteNum);
                    int i = noteNum;
                    foreach (int noteId in r.Cells[0].Value as List<int>)
                    {
                        List<int> lyricIds = new();
                        lyricIds.Add(noteId);
                        ExoDataView.Rows[r.Index - i].Cells[0].Value = lyricIds;
                        ExoDataView.Rows[r.Index - i].Cells[1].Value = UstDataView.Rows[noteId].Cells[1].Value;
                        ExoDataView.Rows[r.Index - i].Cells[2].Value = UstDataView.Rows[noteId].Cells[1].Value;
                        ExoDataView.Rows[r.Index - i].Cells[3].Value = UstDataView.Rows[noteId].Cells[2].Value.ToString();
                        i--;
                    }
                    ExoDataView.Rows.Remove(r);
                }
            }
        }
        /// <summary>
        /// 歌詞をExoリストから削除
        /// </summary>
        private void ObjDeleteButton_Click(object sender, EventArgs e)
        {
            if (ExoDataView.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow r in ExoDataView.SelectedRows)
                {
                    foreach (int i in r.Cells[0].Value as List<int>)
                    {
                        UstDataView.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }

                    ExoDataView.Rows.Remove(r);
                }
            }
        }
        /// <summary>
        /// オブジェクトの編集
        /// </summary>
        private void ObjEditButton_Click(object sender, EventArgs e)
        {
            if (ExoDataView.SelectedRows.Count != 0)
            {
                DataGridViewRow editRow = ExoDataView.SelectedRows[0];
                var objEditForm = new TextEditForm(editRow.Cells[1].Value.ToString(), editRow.Cells[2].Value.ToString());
                objEditForm.ShowDialog();

                editRow.Cells[1].Value = objEditForm.ObjText;
                editRow.Cells[2].Value = objEditForm.ObjLyric;
            }
        }
        private void ObjUpButton_Click(object sender, EventArgs e)
        {
            if (ExoDataView.SelectedRows.Count != 0)
            {
                // 選択行を並び替え
                var query = from DataGridViewRow r in ExoDataView.SelectedRows
                            orderby r.Index
                            select r;

                List<DataGridViewRow> selectedObj = new();
                foreach (DataGridViewRow r in query) selectedObj.Add(r);
                if (selectedObj[0].Index != 0)
                {
                    ExoDataView.Rows.Insert(selectedObj.Last().Index + 1, 1);
                    for (int i = 0; i < 4; i++)
                    {
                        ExoDataView.Rows[selectedObj.Last().Index + 1].Cells[i].Value = ExoDataView.Rows[selectedObj[0].Index - 1].Cells[i].Value;
                    }
                    ExoDataView.Rows.RemoveAt(selectedObj[0].Index - 1);
                }
            }
        }
        private void ObjDownButton_Click(object sender, EventArgs e)
        {
            if (ExoDataView.SelectedRows.Count != 0)
            {
                // 選択行を並び替え
                var query = from DataGridViewRow r in ExoDataView.SelectedRows
                            orderby r.Index
                            select r;

                List<DataGridViewRow> selectedObj = new();
                foreach (DataGridViewRow r in query) selectedObj.Add(r);
                if (selectedObj.Last().Index != ExoDataView.RowCount - 1)
                {
                    ExoDataView.Rows.Insert(selectedObj[0].Index, 1);
                    for (int i = 0; i < 4; i++)
                    {
                        ExoDataView.Rows[selectedObj[0].Index - 1].Cells[i].Value = ExoDataView.Rows[selectedObj.Last().Index + 1].Cells[i].Value;
                    }
                    ExoDataView.Rows.RemoveAt(selectedObj.Last().Index + 1);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1.objectEdit.Visible = false;
            Form1.pjSetting.Visible = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ExoDataView.Rows.Count != 0)
            {
                // Exoクラスにオブジェクトを格納
                exo.Objects.Clear();
                exo.Length = 0;
                foreach (DataGridViewRow r in ExoDataView.Rows)
                {
                    string objText = "" + r.Cells[1].Value.ToString();
                    double objTicks = double.Parse("" + r.Cells[3].Value.ToString());

                    // 文字をUnicodeに変換
                    byte[] unicodeArray = Encoding.Unicode.GetBytes(objText);
                    string unicodetext = BitConverter.ToString(unicodeArray);
                    unicodetext = Regex.Replace(unicodetext, "-", "").ToLower().PadRight(4096, '0');

                    // Length計算
                    // bpm = 60秒あたりの拍数 60/Tempoで1拍の秒数
                    // UTAUは480で1拍 Length/480で拍数
                    // (Length/480)*(60/Tempo)で秒数
                    // fps = 1秒あたりのフレーム
                    // (Length/480)*(60/Tempo)*fpsで秒数
                    var fps = exo.Rate;
                    var objLength = (objTicks / 480) * (60 / ust.Tempo) * fps;

                    Objects objects = new(r.Index.ToString(), objLength, unicodetext);
                    objects.Start = exo.Length + 1;
                    objects.End = exo.Length + objLength;
                    exo.Add(objects);

                    exo.Length += objLength;

                }
                Form1.objectEdit.Visible = false;
                Form1.exoExport.Visible = true;
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("テキストオブジェクトを追加してください");
            }
        }
    }
}
