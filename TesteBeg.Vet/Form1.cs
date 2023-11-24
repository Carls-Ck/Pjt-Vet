using TesteBeg.Vet;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteBeg.Vet
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedicos formMedicos = new frmMedicos();
            formMedicos.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes Pacientes = new frmPacientes();
            Pacientes.ShowDialog();
        }

        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } */

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas Consultas = new frmConsultas();
            Consultas.ShowDialog();
        }

        private void btnMedicos_Click_1(object sender, EventArgs e)
        {

        }
    }
}
