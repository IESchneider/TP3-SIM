namespace TP3_SIM.Formularios
{
    partial class FormMontecarlo
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
            this.dgvGrillaMontecarlo = new System.Windows.Forms.DataGridView();
            this.Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDRta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recordaba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDRta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDRta3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCompras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.lblPorcentajeSi = new System.Windows.Forms.Label();
            this.lblResultadoOcupacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaMontecarlo)).BeginInit();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrillaMontecarlo
            // 
            this.dgvGrillaMontecarlo.AllowUserToAddRows = false;
            this.dgvGrillaMontecarlo.AllowUserToDeleteRows = false;
            this.dgvGrillaMontecarlo.AllowUserToResizeColumns = false;
            this.dgvGrillaMontecarlo.AllowUserToResizeRows = false;
            this.dgvGrillaMontecarlo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvGrillaMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaMontecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Persona,
            this.RNDRta1,
            this.Recordaba,
            this.RNDRta2,
            this.Compra1,
            this.RNDRta3,
            this.Compra2,
            this.CantCompras});
            this.dgvGrillaMontecarlo.Location = new System.Drawing.Point(13, 13);
            this.dgvGrillaMontecarlo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrillaMontecarlo.Name = "dgvGrillaMontecarlo";
            this.dgvGrillaMontecarlo.ReadOnly = true;
            this.dgvGrillaMontecarlo.RowHeadersWidth = 51;
            this.dgvGrillaMontecarlo.Size = new System.Drawing.Size(1079, 711);
            this.dgvGrillaMontecarlo.TabIndex = 1;
            // 
            // Persona
            // 
            this.Persona.HeaderText = "Persona";
            this.Persona.MinimumWidth = 6;
            this.Persona.Name = "Persona";
            this.Persona.ReadOnly = true;
            this.Persona.Width = 125;
            // 
            // RNDRta1
            // 
            this.RNDRta1.HeaderText = "RND Rta 1";
            this.RNDRta1.MinimumWidth = 6;
            this.RNDRta1.Name = "RNDRta1";
            this.RNDRta1.ReadOnly = true;
            this.RNDRta1.Width = 125;
            // 
            // Recordaba
            // 
            this.Recordaba.HeaderText = "¿Recordaba?";
            this.Recordaba.MinimumWidth = 6;
            this.Recordaba.Name = "Recordaba";
            this.Recordaba.ReadOnly = true;
            this.Recordaba.Width = 125;
            // 
            // RNDRta2
            // 
            this.RNDRta2.HeaderText = "RND Rta 2";
            this.RNDRta2.MinimumWidth = 6;
            this.RNDRta2.Name = "RNDRta2";
            this.RNDRta2.ReadOnly = true;
            this.RNDRta2.Width = 125;
            // 
            // Compra1
            // 
            this.Compra1.HeaderText = "¿Compra?";
            this.Compra1.MinimumWidth = 6;
            this.Compra1.Name = "Compra1";
            this.Compra1.ReadOnly = true;
            this.Compra1.Width = 125;
            // 
            // RNDRta3
            // 
            this.RNDRta3.HeaderText = "RND Rta 3";
            this.RNDRta3.MinimumWidth = 6;
            this.RNDRta3.Name = "RNDRta3";
            this.RNDRta3.ReadOnly = true;
            this.RNDRta3.Width = 125;
            // 
            // Compra2
            // 
            this.Compra2.HeaderText = "¿Compra?";
            this.Compra2.MinimumWidth = 6;
            this.Compra2.Name = "Compra2";
            this.Compra2.ReadOnly = true;
            this.Compra2.Width = 125;
            // 
            // CantCompras
            // 
            this.CantCompras.HeaderText = "Cant Compras";
            this.CantCompras.MinimumWidth = 6;
            this.CantCompras.Name = "CantCompras";
            this.CantCompras.ReadOnly = true;
            this.CantCompras.Width = 125;
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.lblPorcentajeSi);
            this.gbResultado.Controls.Add(this.lblResultadoOcupacion);
            this.gbResultado.Location = new System.Drawing.Point(13, 732);
            this.gbResultado.Margin = new System.Windows.Forms.Padding(4);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Padding = new System.Windows.Forms.Padding(4);
            this.gbResultado.Size = new System.Drawing.Size(311, 90);
            this.gbResultado.TabIndex = 19;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // lblPorcentajeSi
            // 
            this.lblPorcentajeSi.AutoSize = true;
            this.lblPorcentajeSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeSi.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPorcentajeSi.Location = new System.Drawing.Point(184, 34);
            this.lblPorcentajeSi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentajeSi.Name = "lblPorcentajeSi";
            this.lblPorcentajeSi.Size = new System.Drawing.Size(78, 29);
            this.lblPorcentajeSi.TabIndex = 19;
            this.lblPorcentajeSi.Text = "100%";
            this.lblPorcentajeSi.Click += new System.EventHandler(this.lblPorcentajeSi_Click);
            // 
            // lblResultadoOcupacion
            // 
            this.lblResultadoOcupacion.AutoSize = true;
            this.lblResultadoOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoOcupacion.Location = new System.Drawing.Point(21, 41);
            this.lblResultadoOcupacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultadoOcupacion.Name = "lblResultadoOcupacion";
            this.lblResultadoOcupacion.Size = new System.Drawing.Size(155, 20);
            this.lblResultadoOcupacion.TabIndex = 17;
            this.lblResultadoOcupacion.Text = "El porcentaje de SI:";
            // 
            // FormMontecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 831);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.dgvGrillaMontecarlo);
            this.Name = "FormMontecarlo";
            this.Text = "Montecarlo";
            this.Load += new System.EventHandler(this.FormMontecarlo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaMontecarlo)).EndInit();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrillaMontecarlo;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label lblResultadoOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDRta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recordaba;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDRta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDRta3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCompras;
        private System.Windows.Forms.Label lblPorcentajeSi;
    }
}