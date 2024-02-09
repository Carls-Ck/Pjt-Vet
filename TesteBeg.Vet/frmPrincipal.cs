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
        public int num;
        public frmPrincipal()
        {
            InitializeComponent();
            num = 0;
        }

        private Consulta novaConsulta;

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedicos formMedicos = new frmMedicos();
            Medico.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes Pacientes = new frmPacientes();
            Pacientes.ShowDialog();
        } 

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas Consultas = new frmConsultas();
            Consultas.ShowDialog();
        }

        private void ListarConsultas()
        {
            try
            {
                novaConsulta = new Consulta();
                dtgConsultas.DataSource = novaConsulta.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmPrincipal Principal = new frmPrincipal();
            ListarConsultas();
            
        }

    }
}
