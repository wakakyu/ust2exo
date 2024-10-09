namespace ust2exo
{
    public partial class Form1 : Form
    {
        private Ust ust = new();
        private Exo exo = new();

        public static ProjectSetting pjSetting;
        public static ObjectEdit objectEdit;
        public static ExoExport exoExport;

        public Form1()
        {
            InitializeComponent();

            pjSetting = new ProjectSetting(ust, exo);
            panel1.Controls.Add(pjSetting);
            pjSetting.Visible = true;

            objectEdit = new ObjectEdit(ust, exo);
            panel1.Controls.Add(objectEdit);
            objectEdit.Visible = false;

            exoExport = new ExoExport(ust, exo);
            panel1.Controls.Add(exoExport);
            exoExport.Visible = false;

        }
    }
}
