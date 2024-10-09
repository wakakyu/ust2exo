namespace ust2exo
{
    public class Exo
    {
        private int width;
        private int height;
        private int rate;
        private int audio_rate;
        private double length;
        private List<Objects> obj = new();  //オブジェクトのリスト

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public int AudioRate
        {
            get { return audio_rate; }
            set { audio_rate = value; }
        }
        public double Length
        {
            get { return length; }
            set {  length = value; }
        }
        public List<Objects> Objects
        { 
            get { return obj; }
        }

        public void Set(int w, int h, int r, int a)
        {
            this.width = w;
            this.height = h;
            this.rate = r;
            this.audio_rate = a;
        }
        public void Add(Objects o)
        {
            obj.Add(o);
        }
    }
}
