namespace ust2exo
{
    /// <summary>
    /// ustファイルのデータ
    /// </summary>
    public class Ust
    {
        private string projectName;
        private double tempo;
        private List<Notes> notes = new();  //音符のリスト

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }
        public double Tempo
        {
            get { return tempo; }
            set { tempo = value; }
        }
        public List<Notes> Notes
        {
            get { return notes; }
        }

        public void Add(Notes n)
        {
            notes.Add(n);
        }
    }
}
