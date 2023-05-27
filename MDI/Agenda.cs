using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;


namespace MDI
{
    public partial class Agenda : Form
    {
        private Repositorio repositorio;
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            bsAgenda.DataSource = repositorio;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DAL.Agenda agenda = new DAL.Agenda(); frmDetalhes frm = new frmDetalhes();
            frm.agenda = agenda;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Create(agenda);
                bsAgenda.Add(agenda);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var agenda = bsAgenda.Current as DAL.Agenda;
            if (agenda != null)
            {
                repositorio.Delete(agenda);
                bsAgenda.Remove(agenda);
                bsAgenda.ResetBindings(false);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmDetalhes frm = new frmDetalhes();
            frm.agenda = bsAgenda.Current as DAL.Agenda;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Update(frm.agenda);
                bsAgenda.ResetBindings(false);
            }
        }
    }
}
