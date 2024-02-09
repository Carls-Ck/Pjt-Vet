using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace TesteBeg.Vet
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

  
        private Pacientes novoPaciente;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novoPaciente = new Pacientes();

                if (txtCodigoP.Text == "0")
                {
                    novoPaciente.Salvar(txtNome.Text, txtDono.Text, dtpIdade.Text,
                        clbProblema.ValueMember, clbVacinas.Text, txtHistorico.Text);
                    MessageBox.Show("Funcionário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoPaciente.Alterar(Convert.ToInt32(txtCodigoP.Text), txtNome.Text, txtDono.Text, dtpIdade.Text,
                       clbProblema.ValueMember, clbVacinas.Text, txtHistorico.Text);
                    MessageBox.Show("Funcionário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ListarPacientes();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarPacientes()
        {
            throw new NotImplementedException();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtCodigoP.Text = "0";
            txtNome.Clear();
            txtDono.Clear();
            txtHistorico.Clear();
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgPacientes.Rows.Count; i += 2)
            {
                dtgPacientes.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void dtgPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //primeiro verifica se possui informações mostradas no DataGridView
            if (e.RowIndex >= 0)
            {
                //se sim, verifica se a coluna clicada foi referente ao btnEditar
                if (dtgPacientes.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //se a condição for verdadeira, cada componente do formulário receberá as informações do DataGrid correspondentes a eles
                    txtCodigoP.Text = dtgPacientes.Rows[e.RowIndex].Cells["ID_PACIENTE"].Value.ToString();
                    txtNome.Text = dtgPacientes.Rows[e.RowIndex].Cells["NOME_PACIENTE"].Value.ToString();
                    txtDono.Text = dtgPacientes.Rows[e.RowIndex].Cells["DONO_PACIENTE"].Value.ToString();
                    dtpIdade.Value = Convert.ToDateTime(dtgPacientes.Rows[e.RowIndex].Cells["NASCIMENTO_PACIENTE"].Value.ToString());
                    clbEspecie.Text = dtgPacientes.Rows[e.RowIndex].Cells["ESPECIE_PACIENTE"].Value.ToString();
                    clbVacinas.Text = dtgPacientes.Rows[e.RowIndex].Cells["VACINAS_PACIENTE"].Value.ToString();
                    clbProblema.Text = dtgPacientes.Rows[e.RowIndex].Cells["PROBLEMA_PACIENTE"].Value.ToString();
                    txtHistorico.Text = dtgPacientes.Rows[e.RowIndex].Cells["HISTORICO_PACIENTE"].Value.ToString();
                }
            }
        }

        private void ListarPaciente()
        {
            try
            {
                novoPaciente = new Pacientes();
                dtgPacientes.DataSource = novoPaciente.Listar();

                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPaceintes_Load(object sender, EventArgs e)
        {
            ListarPacientes();
        }

        private void txtDono_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
