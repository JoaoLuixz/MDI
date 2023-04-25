namespace MDI
{
    public partial class MainForm : Form
    {
        Agenda? AgendaForm;
        CEP? CEPForm;
        Sobre? SobreForm;


        public MainForm()
        {
            InitializeComponent();
        }

        private void gfdgdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(AgendaForm == null)
            {
                AgendaForm = new Agenda();
                AgendaForm.MdiParent = this;
                AgendaForm.WindowState = FormWindowState.Maximized;
                AgendaForm.Show();
            }
            else
            {
                AgendaForm.Activate();
            }
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CEPForm == null)
            {
                CEPForm = new CEP();
                CEPForm.MdiParent = this;
                CEPForm.WindowState = FormWindowState.Maximized;
                CEPForm.Show();
            }
            else
            {
                CEPForm.Activate();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SobreForm == null)
            {
                SobreForm = new Sobre();
                //SobreForm.MdiParent = this;
                //SobreForm.WindowState = FormWindowState.Maximized;
                SobreForm.ShowDialog();
            }
            else
            {
                SobreForm.Activate();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}