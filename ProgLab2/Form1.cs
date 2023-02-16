using System.Security.Cryptography.X509Certificates;

namespace ProgLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GraphObject.MaxSize = panel1.ClientSize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        List<GraphObject> elements = new List<GraphObject>();
        //int q = 100;
        private void AddFigure(object sender, EventArgs e)
        {
            elements.Add(new GraphObject());
            panel1.Invalidate();
            //try
            //{
            //    elements[1].X = q; 
            //    elements[1].Y = q;
            //    q -= 200;
            //}
            //catch(ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ClearFigures(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        private void PaintPanel(object sender, PaintEventArgs e)
        {
            foreach (GraphObject elem in elements)
            {
                elem.Draw(e.Graphics);
            }
        }

        private void AddFigure_DoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                GraphObject newObj = new GraphObject();
                newObj.X = e.X;
                newObj.Y = e.Y;
                elements.Add(newObj);
                Refresh();
            }
            catch(ArgumentException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void ReSize(object sender, EventArgs e)
        {
                GraphObject.MaxSize = panel1.ClientSize;
        }
    }
}