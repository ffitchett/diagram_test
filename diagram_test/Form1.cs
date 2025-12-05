namespace diagram_test
{
    public partial class Form1 : Form
    {
        public Particle p;
        


        public Form1()
        {
            InitializeComponent();
            p = new Particle(20, 20, 20, 20, Properties.Resources.circle);
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(p.getImage(), p.getX(), p.getY(), p.getWidth(), p.getHeight());
        }
    }
}
