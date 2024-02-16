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

        private Consults newConsults;

        private void btnMedic_Click(object sender, EventArgs e)
        {
            frmMedics frmMedics = new frmMedics();
            Medic.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacients Pacients = new frmPacients();
            Pacients.ShowDialog();
        } 

        private void btnConsults_Click(object sender, EventArgs e)
        {
            frmConsults Consults = new frmConsults();
            Consults.ShowDialog();
        }

        private void ListConsults()
        {
            try
            {
                NewConsults = new Consults();
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
            ListConsults();
            
        }

    }
}
