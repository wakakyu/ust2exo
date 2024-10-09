namespace ust2exo
{
    public partial class TextEditForm : Form
    {
        public string ObjText { get; private set; }
        public string ObjLyric { get; private set; }
        public TextEditForm(string text, string lyric)
        {
            InitializeComponent();
            ObjText = text;
            ObjLyric = lyric;
        }

        private void ObjEditForm_Load(object sender, EventArgs e)
        {
            ObjTextBox.Text = ObjText;
            LyricTextBox.Text = ObjLyric;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ObjText = ObjTextBox.Text;
            ObjLyric = LyricTextBox.Text;
            this.Close();
        }
    }
}
