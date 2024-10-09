namespace ust2exo
{
    public class Objects
    {
        private string name;
        private double length;
        private double start;
        private double end;
        private string text;

        public Objects(string name, double length,  string text)
        {
            this.name = name;
            this.length = length;
            this.text = text;
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
        public double Start
        {
            get { return start; }
            set { start = value; }
        }
        public double End
        {
            get { return end; }
            set { end = value; }
        }
        public string Text
        {
            get { return text; }
            //set { text = value; }
        }
    }
}
