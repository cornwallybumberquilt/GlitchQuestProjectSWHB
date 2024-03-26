namespace IdleGame
{
    public partial class Form1 : Form
    {
        private Grid grid;

        public Form1()
        {
            InitializeComponent();
            grid = new Grid(20, 10, 10, renderLines: true);
            this.Controls.Add(grid);
        }
    }
}