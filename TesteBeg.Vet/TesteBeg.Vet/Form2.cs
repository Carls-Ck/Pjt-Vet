using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteBeg.Vet;

namespace TesteBeg.Vet
{
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        Medicos novoMedico;

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            //Evento do botão Salvar o qual grava as informações através do método Salvar ou Alterar, criado na classe Funcionários.
            try
            {
                novoMedico = new Medicos();

                if (txtCodigo.Text == "0")
                {
                    novoMedico.Salvar(txtNome.Text, txtEndereco.Text, txtExperiencia.Text,
                        txtArea.ValueMember, txtDP.Text, txtTelefone.Text);
                    MessageBox.Show("Funcionário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoMedico.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtEndereco.Text, txtExperiencia.Text,
                        txtArea.ValueMember, txtDP.Text, txtTelefone.Text);
                    MessageBox.Show("Funcionário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ListarMedicos();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ComboBox GetTxtArea()
        {
            return txtArea;
        }

        //Método responsável por limpar os componentes do formulário.
        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtEndereco.Clear();
            txtExperiencia.Clear();
            txtArea.Items.Clear();
            txtDP.Clear();
            txtTelefone.Clear();
        }

        //Método que realiza o intervalo de cores dentro do DataGriView.
        private void Estilo()
        {
            for (int i = 0; i < dtgMedicos.Rows.Count; i += 2)
            {
                dtgMedicos.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        //Método que lista os dados da tabela Funcionários no DataGridView.
        private void ListarMedicos()
        {
            novoMedico = new Medicos();
            dtgMedicos.DataSource = novoMedico.Listar();
            Estilo();
        }

        //Método que será executado quando o frmFuncionario for carregado.
        private void frmMedicos_Load(object sender, EventArgs e)
        {
            ListarMedicos();
        }

        //Evento que detecta a célula clicada dentro do dtgMedicos.
        private void dtgMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Primeiro verificará se há linhas, ou seja, registros no DataGridView.
            if (e.RowIndex >= 0)
            {
                //Se houver linhas, a próxima verificação é se foi a coluna btnEditar que foi clicada.
                if (dtgMedicos.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //Se isso for verdade, atribui a todos o campos do formulário os respectivos conteúdos do banco sobre o funcionário clicado.
                    txtCodigo.Text = dtgMedicos.Rows[e.RowIndex].Cells["ID_MEDICOS"].Value.ToString();
                    txtNome.Text = dtgMedicos.Rows[e.RowIndex].Cells["NOME_MEDICOS"].Value.ToString();
                    txtEndereco.Text = dtgMedicos.Rows[e.RowIndex].Cells["ENDERECO_MEDICOS"].Value.ToString();
                    txtExperiencia.Text = dtgMedicos.Rows[e.RowIndex].Cells["EXPERIENCIA_MEDICOS"].Value.ToString();
                    txtArea.Text = dtgMedicos.Rows[e.RowIndex].Cells["AREA_MEDICOS"].Value.ToString();
                    txtDP.Text = dtgMedicos.Rows[e.RowIndex].Cells["DP_MEDICOS"].Value.ToString();
                    txtTelefone.Text = dtgMedicos.Rows[e.RowIndex].Cells["TELEFONE_MEDICOS"].Value.ToString();
                }
                else
                {
                    //Senão, verifica se o nome da coluna que recebeu o clique é btnEcluir e se o botão que foi clicado na caixa de mensagem é o Yes.
                    if (dtgMedicos.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            //Acessa o método Excluir da classe Funcionários, excluindo os registros, tendo como base a coluna ID_FUNCIONARIO.
                            novoMedico = new Medicos();
                            novoMedico.Excluir(Convert.ToInt32(dtgMedicos.Rows[e.RowIndex].Cells["ID_MDICOS"].Value));
                            MessageBox.Show("Funcionario excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarMedicos();
                            Limpar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void frmMedicos_Load_1(object sender, EventArgs e)
        {

        }
    }
}

