using System;

namespace TesteBeg.Vet
{
    partial class frmPacients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacients));
            this.dtgPacients = new System.Windows.Forms.DataGridView();
            this.DONO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESPECIE_PACIENTE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VACINAS_PACIENTE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblIdadeP = new System.Windows.Forms.Label();
            this.lblEspeciePaciente = new System.Windows.Forms.Label();
            this.lblProblema = new System.Windows.Forms.Label();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblVacinaPaciente = new System.Windows.Forms.Label();
            this.clbVaccines = new System.Windows.Forms.CheckedListBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.clbSpecies = new System.Windows.Forms.CheckedListBox();
            this.clbProblem = new System.Windows.Forms.CheckedListBox();
            this.txtCodeP = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPacients
            // 
            this.dtgPacients.AllowUserToAddRows = false;
            this.dtgPacients.AllowUserToDeleteRows = false;
            this.dtgPacients.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgPacients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPacients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DONO_PACIENTE,
            this.NOME_PACIENTE,
            this.ESPECIE_PACIENTE,
            this.VACINAS_PACIENTE,
            this.Problema});
            this.dtgPacients.Location = new System.Drawing.Point(12, 283);
            this.dtgPacients.Name = "dtgPacients";
            this.dtgPacients.Size = new System.Drawing.Size(579, 150);
            this.dtgPacients.TabIndex = 1;
            this.dtgPacients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPacients_CellContentClick);
            // 
            // DONO_PACIENTE
            // 
            this.DONO_PACIENTE.DataPropertyName = "DONO_PACIENTE";
            this.DONO_PACIENTE.HeaderText = "Dono";
            this.DONO_PACIENTE.Name = "DONO_PACIENTE";
            this.DONO_PACIENTE.ReadOnly = true;
            this.DONO_PACIENTE.Width = 130;
            // 
            // NOME_PACIENTE
            // 
            this.NOME_PACIENTE.DataPropertyName = "NOME_PACIENTE";
            this.NOME_PACIENTE.HeaderText = "Nome do Pet";
            this.NOME_PACIENTE.Name = "NOME_PACIENTE";
            this.NOME_PACIENTE.ReadOnly = true;
            this.NOME_PACIENTE.Width = 130;
            // 
            // ESPECIE_PACIENTE
            // 
            this.ESPECIE_PACIENTE.DataPropertyName = "ESPECIE_PACIENTE";
            this.ESPECIE_PACIENTE.HeaderText = "Especie do pet";
            this.ESPECIE_PACIENTE.Name = "ESPECIE_PACIENTE";
            this.ESPECIE_PACIENTE.ReadOnly = true;
            this.ESPECIE_PACIENTE.Width = 130;
            // 
            // VACINAS_PACIENTE
            // 
            this.VACINAS_PACIENTE.DataPropertyName = "VACINAS_PACIENTE";
            this.VACINAS_PACIENTE.HeaderText = "Vacinas";
            this.VACINAS_PACIENTE.Name = "VACINAS_PACIENTE";
            this.VACINAS_PACIENTE.ReadOnly = true;
            this.VACINAS_PACIENTE.Visible = false;
            this.VACINAS_PACIENTE.Width = 150;
            // 
            // Problema
            // 
            this.Problema.HeaderText = "Problema";
            this.Problema.Name = "Problema";
            this.Problema.ReadOnly = true;
            this.Problema.Width = 150;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClear});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(616, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.Location = new System.Drawing.Point(12, 43);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(55, 19);
            this.lblNomePaciente.TabIndex = 2;
            this.lblNomePaciente.Text = "Dono:";
            // 
            // lblIdadeP
            // 
            this.lblIdadeP.AutoSize = true;
            this.lblIdadeP.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeP.Location = new System.Drawing.Point(12, 122);
            this.lblIdadeP.Name = "lblIdadeP";
            this.lblIdadeP.Size = new System.Drawing.Size(104, 19);
            this.lblIdadeP.TabIndex = 3;
            this.lblIdadeP.Text = "Nascimento:";
            // 
            // lblEspeciePaciente
            // 
            this.lblEspeciePaciente.AutoSize = true;
            this.lblEspeciePaciente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspeciePaciente.Location = new System.Drawing.Point(12, 158);
            this.lblEspeciePaciente.Name = "lblEspeciePaciente";
            this.lblEspeciePaciente.Size = new System.Drawing.Size(149, 19);
            this.lblEspeciePaciente.TabIndex = 4;
            this.lblEspeciePaciente.Text = "Espécie de Animal:";
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblema.Location = new System.Drawing.Point(12, 232);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(86, 19);
            this.lblProblema.TabIndex = 5;
            this.lblProblema.Text = "Problema:";
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(317, 120);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(80, 19);
            this.lblHistorico.TabIndex = 6;
            this.lblHistorico.Text = "Histórico:";
            // 
            // lblVacinaPaciente
            // 
            this.lblVacinaPaciente.AutoSize = true;
            this.lblVacinaPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacinaPaciente.Location = new System.Drawing.Point(12, 196);
            this.lblVacinaPaciente.Name = "lblVacinaPaciente";
            this.lblVacinaPaciente.Size = new System.Drawing.Size(71, 19);
            this.lblVacinaPaciente.TabIndex = 7;
            this.lblVacinaPaciente.Text = "Vacinas:";
            // 
            // clbVaccines
            // 
            this.clbVaccines.FormattingEnabled = true;
            this.clbVaccines.Items.AddRange(new object[] {
            "",
            "Raiva",
            "Parvovirose",
            "Cinomose",
            "Hepatite",
            "Leptospirose",
            "Rinotraqueíte",
            "Calicivirose",
            "Panleucopenia",
            "Leucemia felina",
            "Tétano",
            "encefalomielite",
            "bronquite",
            "Laringotraqueíte",
            "Maxomatose",
            "Hemorrágica viral"});
            this.clbVaccines.Location = new System.Drawing.Point(89, 196);
            this.clbVaccines.Name = "clbVaccines";
            this.clbVaccines.Size = new System.Drawing.Size(224, 19);
            this.clbVaccines.TabIndex = 8;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(73, 42);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(518, 20);
            this.txtOwner.TabIndex = 10;
            // 
            // txtHistory
            // 
            this.txtHistory.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHistory.Location = new System.Drawing.Point(403, 119);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(188, 20);
            this.txtHistory.TabIndex = 12;
            this.txtHistory.Text = "fale o histórico de sintomas";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(122, 120);
            this.dtpBorn.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(191, 20);
            this.dtpBorn.TabIndex = 14;
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAnimal.Location = new System.Drawing.Point(12, 69);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(113, 19);
            this.lblNomeAnimal.TabIndex = 15;
            this.lblNomeAnimal.Text = "Nome do Pet:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(460, 20);
            this.txtName.TabIndex = 16;
            // 
            // clbSpecies
            // 
            this.clbSpecies.FormattingEnabled = true;
            this.clbSpecies.Items.AddRange(new object[] {
            "",
            "Cão de pequeno porte ( > 10 meses)",
            "Cão de médio porte  ( > 13 meses)",
            "Cão de grande porte ( > 19 meses )",
            "Cão filhote",
            "Gato adulto ( > 12 meses)",
            "Gato filhote",
            "Cavalo de médio porte ( > 4 anos )",
            "Cavalo de grande porte ( > 6 anos)",
            "Cavalo filhote",
            "Arara adulta( > 2,5 anos)",
            "Papagaio adulto( > 3 anos)",
            "Calopsita ( > 9 meses)",
            "Periquito ( > 7 meses)",
            "Cacatua ( > 3 anos)",
            "Ave filhote",
            "Coelho adulto ( > 6 meses)",
            "Coelho filhote"});
            this.clbSpecies.Location = new System.Drawing.Point(164, 158);
            this.clbSpecies.Name = "clbSpecies";
            this.clbSpecies.Size = new System.Drawing.Size(149, 19);
            this.clbSpecies.TabIndex = 17;
            // 
            // clbProblem
            // 
            this.clbProblem.FormattingEnabled = true;
            this.clbProblem.Items.AddRange(new object[] {
            "",
            "Exame de Rotina",
            "alergia",
            "infecção cutânea",
            "falta de apetite",
            "vômito",
            "diarreia",
            "agressividade",
            "problema dentário",
            "problemas urinários",
            "problemas gastrointestinais",
            "problemas oftalmológicos",
            "parasitas",
            "problemas respiratórios"});
            this.clbProblem.Location = new System.Drawing.Point(104, 232);
            this.clbProblem.Name = "clbProblem";
            this.clbProblem.Size = new System.Drawing.Size(209, 19);
            this.clbProblem.TabIndex = 18;
            // 
            // txtCodeP
            // 
            this.txtCodeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeP.Location = new System.Drawing.Point(534, 92);
            this.txtCodeP.Name = "txtCodeP";
            this.txtCodeP.Size = new System.Drawing.Size(57, 20);
            this.txtCodeP.TabIndex = 19;
            this.txtCodeP.Text = "Nº:";
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 22);
            this.btnClear.Text = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmPacients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(616, 434);
            this.Controls.Add(this.txtCodeP);
            this.Controls.Add(this.clbProblem);
            this.Controls.Add(this.clbSpecies);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNomeAnimal);
            this.Controls.Add(this.dtpBorn);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.clbVaccines);
            this.Controls.Add(this.lblVacinaPaciente);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.lblEspeciePaciente);
            this.Controls.Add(this.lblIdadeP);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.dtgPacients);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "frmPacients";
            this.ShowIcon = false;
            this.Text = "PacientRegister";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.DataGridView dtgPacients;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblIdadeP;
        private System.Windows.Forms.Label lblEspeciePaciente;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label lblVacinaPaciente;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckedListBox clbSpecies;
        private System.Windows.Forms.CheckedListBox clbProblem;
        private System.Windows.Forms.CheckedListBox clbVaccines;
        private System.Windows.Forms.TextBox txtCodeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Especie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vacinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problema;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PACIENTE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ESPECIE_PACIENTE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VACINAS_PACIENTE;
        private System.Windows.Forms.ToolStripButton btnClear;
    }
}