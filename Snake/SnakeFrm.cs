namespace Snake
{
    public partial class SnakeFrm : Form
    {
        public System.Windows.Forms.Timer t;
        public SnakeFrm()
        {
            InitializeComponent();
            this.t = new System.Windows.Forms.Timer();
            Initialize();
            this.DoubleBuffered = true;
            this.BackColor = Color.Black;
        }

        public void Initialize()
        {
            this.t.Enabled = true;
            this.t.Interval = 100;
        }
    }
}