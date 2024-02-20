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
    public partial class frmPacients : Form
    {
        public frmPacients()
        {
            InitializeComponent();
        }


        private Pacients newPacient;


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                newPacient = new Pacients();

                if (txtCodeP.Text == "0")
                {
                    newPacient.Save(txtName.Text, txtOwner.Text, dtpBorn.Text,
                        clbProblem.ValueMember, clbVaccines.Text, txtHistory.Text);
                    MessageBox.Show("Funcionário salvo com sucesso!", "success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    newPacient.Change(Convert.ToInt32(txtCodeP.Text), txtName.Text, txtOwner.Text, dtpBorn.Text,
                       clbProblem.ValueMember, clbVaccines.Text, txtHistory.Text);
                    MessageBox.Show("Funcionário alterado com sucesso!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ListPacients();
                btnClear_Click();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            btnClear_Click();
        }

        private void btnClear_Click()
        {
            throw new NotImplementedException();
        }

        private void dtgPacients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //primeiro verifica se possui informações mostradas no DataGridView
            if (e.RowIndex >= 0)
            {
                //se sim, verifica se a coluna clicada foi referente ao btnEditar
                if (dtgPacients.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    //se a condição for verdadeira, cada componente do formulário receberá as informações do DataGrid correspondentes a eles
                    txtCodeP.Text = dtgPacients.Rows[e.RowIndex].Cells["ID_PACIENT"].Value.ToString();
                    txtName.Text = dtgPacients.Rows[e.RowIndex].Cells["NAME_PACIENT"].Value.ToString();
                    txtOwner.Text = dtgPacients.Rows[e.RowIndex].Cells["OWNER_PACIENT"].Value.ToString();
                    dtpBorn.Value = Convert.ToDateTime(dtgPacients.Rows[e.RowIndex].Cells["BORN_PACIENT"].Value.ToString());
                    clbSpecies.Text = dtgPacients.Rows[e.RowIndex].Cells["SPECIES_PACIENT"].Value.ToString();
                    clbVaccines.Text = dtgPacients.Rows[e.RowIndex].Cells["VACCINES_PACIENT"].Value.ToString();
                    clbProblem.Text = dtgPacients.Rows[e.RowIndex].Cells["PROBLEM_PACIENT"].Value.ToString();
                    txtHistory.Text = dtgPacients.Rows[e.RowIndex].Cells["HISTORY_PACIENT"].Value.ToString();
                }

            }
        }

        private void Style()
        {
            for (int i = 0; i < dtgPacients.Rows.Count; i += 2)
            {
                dtgPacients.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void ListPacients()
        {
            try
            {
                Pacients newPacient = new Pacients();
                dtgPacients.DataSource = newPacient.List();

                Style();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPaceints_Load(object sender, EventArgs e)
        {
            ListPacients();
        }

        private void txtOwner_TextChanged(object sender, EventArgs e)
        {

        }
private void btnClear_Click(object sender, EventArgs e)
        {
            txtCodeP.Text = "0";
            txtName.Clear();
            txtOwner.Clear();
            txtHistory.Clear();

        }
    }
}

