namespace ProgLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFigure(object sender, EventArgs e)
        {
            elements.Add(new GrapgObject());
            panel1.Invalidate();
        }

        private void ClearFigures(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        List<GrapgObject> elements = new List<GrapgObject>();

        private void PaintPanel(object sender, PaintEventArgs e)
        {
            foreach (GrapgObject elem in elements)
            {
                elem.Draw(e.Graphics);
            }
        }
    }
}