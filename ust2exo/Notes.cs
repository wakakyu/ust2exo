namespace ust2exo
{
    /// <summary>
    /// ustの音符
    /// </summary>
    /// 
    public class Notes
    {
        private string name;
        private double length;
        private string lyric;

        /// <summary>
        /// Noteクラスのインスタンスを作成
        /// </summary>
        /// <param name="name">音符の名前(セクション名)</param>
        /// <param name="length">長さ</param>
        /// <param name="lyric">歌詞</param>
        public Notes(string name, double length, string lyric)
        {
            this.name = name;
            this.length = length;
            this.lyric = lyric;
        }

        public string Name
        {
            get { return name; }
            //set { name = value; }
        }
        public double Length
        {
            get { return length; }
            //set { length = value; }
        }
        public string Lyric
        {
            get { return lyric; }
            //set { lyric = value; }
        }
    }
}
