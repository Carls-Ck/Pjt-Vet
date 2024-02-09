using System;

namespace TesteBeg.Vet
{
    partial class frmMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicos));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtExperiencia = new System.Windows.Forms.TextBox();
            this.txtDP = new System.Windows.Forms.MaskedTextBox();
            this.dtgMedicos = new System.Windows.Forms.DataGridView();
            this.ID_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_MEDICO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DISPONIBILIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPERIENCIA_MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.botaoSalvar});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(609, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(23, 22);
            this.botaoSalvar.Text = "salvar";
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Experiência:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Área:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.NavajoWhite;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.NavajoWhite;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dias Disponíveis:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(110, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(58, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(394, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(110, 116);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(394, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtExperiencia
            // 
            this.txtExperiencia.Location = new System.Drawing.Point(110, 142);
            this.txtExperiencia.Name = "txtExperiencia";
            this.txtExperiencia.Size = new System.Drawing.Size(100, 20);
            this.txtExperiencia.TabIndex = 11;
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(357, 142);
            this.txtDP.Mask = "00/00/0000";
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(100, 20);
            this.txtDP.TabIndex = 13;
            this.txtDP.ValidatingType = typeof(System.DateTime);
            // 
            // dtgMedicos
            // 
            this.dtgMedicos.AllowUserToAddRows = false;
            this.dtgMedicos.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dtgMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CODIGO,
            this.NOME_MEDICO,
            this.AREA_MEDICO,
            this.DISPONIBILIDADE,
            this.Zap,
            this.EXPERIENCIA_MEDICO});
            this.dtgMedicos.Location = new System.Drawing.Point(30, 211);
            this.dtgMedicos.Name = "dtgMedicos";
            this.dtgMedicos.RowHeadersVisible = false;
            this.dtgMedicos.Size = new System.Drawing.Size(553, 155);
            this.dtgMedicos.TabIndex = 14;
            this.dtgMedicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMedicos_CellContentClick);
            // 
            // ID_CODIGO
            // 
            this.ID_CODIGO.DataPropertyName = "ID_CODIGO";
            this.ID_CODIGO.HeaderText = "Código";
            this.ID_CODIGO.Name = "ID_CODIGO";
            this.ID_CODIGO.ReadOnly = true;
            this.ID_CODIGO.Visible = false;
            // 
            // NOME_MEDICO
            // 
            this.NOME_MEDICO.DataPropertyName = "NOME_MEDICO";
            this.NOME_MEDICO.HeaderText = "Nome";
            this.NOME_MEDICO.Name = "NOME_MEDICO";
            this.NOME_MEDICO.ReadOnly = true;
            this.NOME_MEDICO.Width = 150;
            // 
            // AREA_MEDICO
            // 
            this.AREA_MEDICO.DataPropertyName = "AREA_MEDICO";
            this.AREA_MEDICO.HeaderText = "Área";
            this.AREA_MEDICO.Name = "AREA_MEDICO";
            this.AREA_MEDICO.ReadOnly = true;
            this.AREA_MEDICO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AREA_MEDICO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AREA_MEDICO.Width = 140;
            // 
            // DISPONIBILIDADE
            // 
            this.DISPONIBILIDADE.DataPropertyName = "DISPONIBILIDADE";
            this.DISPONIBILIDADE.HeaderText = "Disponibilidade";
            this.DISPONIBILIDADE.Name = "DISPONIBILIDADE";
            this.DISPONIBILIDADE.ReadOnly = true;
            this.DISPONIBILIDADE.Visible = false;
            this.DISPONIBILIDADE.Width = 230;
            // 
            // Zap
            // 
            this.Zap.HeaderText = "Telefone";
            this.Zap.Name = "Zap";
            // 
            // EXPERIENCIA_MEDICO
            // 
            this.EXPERIENCIA_MEDICO.DataPropertyName = "EXPERIENCIA_MEDICO";
            this.EXPERIENCIA_MEDICO.HeaderText = "Experiencia";
            this.EXPERIENCIA_MEDICO.Name = "EXPERIENCIA_MEDICO";
            this.EXPERIENCIA_MEDICO.ReadOnly = true;
            this.EXPERIENCIA_MEDICO.Width = 160;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(357, 167);
            this.txtTelefone.Mask = "(55) 00 000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(147, 20);
            this.txtTelefone.TabIndex = 15;
            // 
            // txtArea
            // 
            this.txtArea.FormattingEnabled = true;
            this.txtArea.Items.AddRange(new object[] {
            "Anestesiologia veterinária",
            "Biologia da conservação veterinária",
            "Cardiologia veterinária",
            "Dermatologia veterinária",
            "Endocrinologia veterinária",
            "Geriatria veterinária",
            "Imunologia veterinaria",
            "Medicina de animais de grande porte",
            "Medicina de animais de laboratório",
            "Medicina de animais de pequeno porte ",
            "Medicina de animais exóticos",
            "Medicina de animais marinhos",
            "Medicina comportamental veterinária",
            "Medicina reprodutiva de animais",
            "Medicina de vida selvagem",
            "Nefralogia e Urologia veterinária",
            "Neurologia veterinária",
            "Neonatologia veterinária",
            "Nutrição veterinária",
            "Odontologia veterinária",
            "Oftamologia veterinária",
            "Oncologia veterinaria",
            "Ornitologia veterinária",
            "Ortopedia veterinária",
            "Psicologia animal veterinária",
            "Parasitologia veterinária",
            "Radiologia veterinária",
            "Radioterapia veterinária",
            "Saúde pública veterinária",
            "Toxicologia veterinária"});
            this.txtArea.Location = new System.Drawing.Point(110, 170);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(160, 21);
            this.txtArea.TabIndex = 16;
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 390);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.dtgMedicos);
            this.Controls.Add(this.txtDP);
            this.Controls.Add(this.txtExperiencia);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "frmMedicos";
            this.ShowIcon = false;
            this.Text = "Cadastro Médicos";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtExperiencia;
        private System.Windows.Forms.MaskedTextBox txtDP;
        private System.Windows.Forms.DataGridView dtgMedicos;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ComboBox txtArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewComboBoxColumn Área;
        private System.Windows.Forms.DataGridViewTextBoxColumn DP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exp;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_MEDICO;
        private System.Windows.Forms.DataGridViewComboBoxColumn AREA_MEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISPONIBILIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPERIENCIA_MEDICO;
    }
}