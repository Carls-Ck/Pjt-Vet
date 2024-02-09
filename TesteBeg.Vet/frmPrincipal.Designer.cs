using System;
using TesteBeg.Vet;
using System.Windows.Forms;

namespace TesteBeg.Vet
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados!
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
            this.btnConsultas = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMedicos = new System.Windows.Forms.ToolStripButton();
            this.btnPacientes = new System.Windows.Forms.ToolStripButton();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.DataConsul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Médico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConsultas
            // 
            this.dtgConsultas.AllowUserToAddRows = false;
            this.dtgConsultas.AllowUserToDeleteRows = false;
            this.dtgConsultas.BackgroundColor = System.Drawing.Color.Sienna;
            this.dtgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataConsul,
            this.Médico,
            this.Paciente,
            this.Pet});
            this.dtgConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgConsultas.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtgConsultas.Location = new System.Drawing.Point(82, 247);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.Size = new System.Drawing.Size(611, 181);
            this.dtgConsultas.TabIndex = 0;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultas.BackgroundImage")));
            this.btnConsultas.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultas.Location = new System.Drawing.Point(244, 28);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(263, 139);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = " Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Peru;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMedicos,
            this.btnPacientes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(735, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMedicos
            // 
            this.btnMedicos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMedicos.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicos.Image")));
            this.btnMedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(72, 22);
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
            this.btnPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(77, 22);
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // GB1
            // 
            this.GB1.BackColor = System.Drawing.Color.Peru;
            this.GB1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB1.Location = new System.Drawing.Point(179, 173);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(397, 68);
            this.GB1.TabIndex = 4;
            this.GB1.TabStop = false;
            this.GB1.Text = "Não trabalhamos com: espécies marinhas, espécies silvestres - selvagens - tropici" +
    "as e de fazenda.";
            // 
            // DataConsul
            // 
            this.DataConsul.HeaderText = "Consultas";
            this.DataConsul.Name = "DataConsul";
            this.DataConsul.ReadOnly = true;
            this.DataConsul.Width = 120;
            // 
            // Médico
            // 
            this.Médico.HeaderText = "Medicos";
            this.Médico.Name = "Médico";
            this.Médico.ReadOnly = true;
            this.Médico.Width = 150;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Width = 150;
            // 
            // Pet
            // 
            this.Pet.HeaderText = "Especie";
            this.Pet.Name = "Pet";
            this.Pet.ReadOnly = true;
            this.Pet.Width = 150;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 451);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.dtgConsultas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.Text = " Centro de Consultas Médicas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMedicos;
        private System.Windows.Forms.ToolStripButton btnPacientes;
        private System.Windows.Forms.GroupBox GB1;
        private DataGridViewTextBoxColumn DataConsul;
        private DataGridViewTextBoxColumn Médico;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn Pet;
        public DataGridView dtgConsultas;
    }
}

