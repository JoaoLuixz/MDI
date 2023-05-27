using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class frmDetalhes : Form
    {
        public DAL.Agenda agenda;
        public frmDetalhes()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void frmDetalhes_Load(object sender, EventArgs e)
        {
            bsDetalhe.DataSource = agenda;
        }

        private void bsDetalhe_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
