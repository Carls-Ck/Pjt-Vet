namespace TesteBeg.Vet
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.Médico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMedicos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConsultas
            // 
            this.dtgConsultas.AllowUserToAddRows = false;
            this.dtgConsultas.AllowUserToDeleteRows = false;
            this.dtgConsultas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Médico});
            this.dtgConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgConsultas.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtgConsultas.Location = new System.Drawing.Point(20, 258);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.ReadOnly = true;
            this.dtgConsultas.Size = new System.Drawing.Size(835, 181);
            this.dtgConsultas.TabIndex = 0;
            // 
            // Médico
            // 
            this.Médico.HeaderText = "Column1";
            this.Médico.Name = "Médico";
            this.Médico.ReadOnly = true;
            this.Médico.Width = 30;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackgroundImage = global::TesteBeg.Vet.Properties.Resources.download__1_;
            this.btnConsultas.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultas.Location = new System.Drawing.Point(310, 28);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(292, 139);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Fazer Consulta";
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMedicos,
            this.toolStripSeparator1,
            this.btnPacientes,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMedicos
            // 
            this.btnMedicos.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicos.Image")));
            this.btnMedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(72, 22);
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
            this.btnPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(77, 22);
            this.btnPacientes.Text = "Pacientes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesteBeg.Vet.Properties.Resources._5447153_veterinario_clinica_medico_examinando_vacinacao_e_saude_para_animais_de_animais_como_caes_e_gatos_em_plano_de_fundo_ilustracao_para_cartaz_ou_banner_vetor1;
            this.ClientSize = new System.Drawing.Size(867, 451);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.dtgConsultas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.Text = "Sistema de Controle veterinario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Médico;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMedicos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

