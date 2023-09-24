namespace TP3_SIM
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.gbSimular = new System.Windows.Forms.GroupBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.gbEdicion = new System.Windows.Forms.GroupBox();
            this.checkBoxEdicion = new System.Windows.Forms.CheckBox();
            this.lblDescripcionNormal = new System.Windows.Forms.Label();
            this.numLimiteSuperiorNormal = new System.Windows.Forms.NumericUpDown();
            this.numLimiteInferiorNormal = new System.Windows.Forms.NumericUpDown();
            this.lblCostoDescarga = new System.Windows.Forms.Label();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtFilaHasta = new System.Windows.Forms.MaskedTextBox();
            this.txtFilaDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroSimulaciones = new System.Windows.Forms.Label();
            this.lblFilaDesde = new System.Windows.Forms.Label();
            this.txtNumeroSimulaciones = new System.Windows.Forms.MaskedTextBox();
            this.gbPrincipal.SuspendLayout();
            this.gbSimular.SuspendLayout();
            this.gbParametros.SuspendLayout();
            this.gbEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteSuperiorNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteInferiorNormal)).BeginInit();
            this.gbDatosGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.gbSimular);
            this.gbPrincipal.Controls.Add(this.gbParametros);
            this.gbPrincipal.Controls.Add(this.gbDatosGenerales);
            this.gbPrincipal.Location = new System.Drawing.Point(13, 13);
            this.gbPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Padding = new System.Windows.Forms.Padding(4);
            this.gbPrincipal.Size = new System.Drawing.Size(964, 470);
            this.gbPrincipal.TabIndex = 1;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Simulación - Método Montecarlo";
            // 
            // gbSimular
            // 
            this.gbSimular.Controls.Add(this.btnSimular);
            this.gbSimular.Location = new System.Drawing.Point(11, 336);
            this.gbSimular.Margin = new System.Windows.Forms.Padding(4);
            this.gbSimular.Name = "gbSimular";
            this.gbSimular.Padding = new System.Windows.Forms.Padding(4);
            this.gbSimular.Size = new System.Drawing.Size(359, 123);
            this.gbSimular.TabIndex = 21;
            this.gbSimular.TabStop = false;
            this.gbSimular.Text = "Simular";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(24, 47);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(128, 42);
            this.btnSimular.TabIndex = 19;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.gbEdicion);
            this.gbParametros.Controls.Add(this.lblDescripcionNormal);
            this.gbParametros.Controls.Add(this.numLimiteSuperiorNormal);
            this.gbParametros.Controls.Add(this.numLimiteInferiorNormal);
            this.gbParametros.Controls.Add(this.lblCostoDescarga);
            this.gbParametros.Location = new System.Drawing.Point(395, 43);
            this.gbParametros.Margin = new System.Windows.Forms.Padding(4);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Padding = new System.Windows.Forms.Padding(4);
            this.gbParametros.Size = new System.Drawing.Size(559, 416);
            this.gbParametros.TabIndex = 20;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // gbEdicion
            // 
            this.gbEdicion.Controls.Add(this.checkBoxEdicion);
            this.gbEdicion.Location = new System.Drawing.Point(440, 358);
            this.gbEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.gbEdicion.Name = "gbEdicion";
            this.gbEdicion.Padding = new System.Windows.Forms.Padding(4);
            this.gbEdicion.Size = new System.Drawing.Size(109, 50);
            this.gbEdicion.TabIndex = 35;
            this.gbEdicion.TabStop = false;
            this.gbEdicion.Text = "Permitir edición:";
            // 
            // checkBoxEdicion
            // 
            this.checkBoxEdicion.AutoSize = true;
            this.checkBoxEdicion.Location = new System.Drawing.Point(76, 20);
            this.checkBoxEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEdicion.Name = "checkBoxEdicion";
            this.checkBoxEdicion.Size = new System.Drawing.Size(18, 17);
            this.checkBoxEdicion.TabIndex = 0;
            this.checkBoxEdicion.UseVisualStyleBackColor = true;
            this.checkBoxEdicion.CheckedChanged += new System.EventHandler(this.checkBoxEdicion_CheckedChanged);
            // 
            // lblDescripcionNormal
            // 
            this.lblDescripcionNormal.AutoSize = true;
            this.lblDescripcionNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionNormal.Location = new System.Drawing.Point(20, 90);
            this.lblDescripcionNormal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionNormal.Name = "lblDescripcionNormal";
            this.lblDescripcionNormal.Size = new System.Drawing.Size(267, 17);
            this.lblDescripcionNormal.TabIndex = 24;
            this.lblDescripcionNormal.Text = "(Mínimo y máximo de distribución normal)";
            // 
            // numLimiteSuperiorNormal
            // 
            this.numLimiteSuperiorNormal.DecimalPlaces = 2;
            this.numLimiteSuperiorNormal.Location = new System.Drawing.Point(133, 62);
            this.numLimiteSuperiorNormal.Margin = new System.Windows.Forms.Padding(4);
            this.numLimiteSuperiorNormal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numLimiteSuperiorNormal.Name = "numLimiteSuperiorNormal";
            this.numLimiteSuperiorNormal.Size = new System.Drawing.Size(99, 22);
            this.numLimiteSuperiorNormal.TabIndex = 23;
            // 
            // numLimiteInferiorNormal
            // 
            this.numLimiteInferiorNormal.DecimalPlaces = 2;
            this.numLimiteInferiorNormal.Location = new System.Drawing.Point(24, 62);
            this.numLimiteInferiorNormal.Margin = new System.Windows.Forms.Padding(4);
            this.numLimiteInferiorNormal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numLimiteInferiorNormal.Name = "numLimiteInferiorNormal";
            this.numLimiteInferiorNormal.Size = new System.Drawing.Size(103, 22);
            this.numLimiteInferiorNormal.TabIndex = 22;
            // 
            // lblCostoDescarga
            // 
            this.lblCostoDescarga.AutoSize = true;
            this.lblCostoDescarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoDescarga.Location = new System.Drawing.Point(20, 32);
            this.lblCostoDescarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoDescarga.Name = "lblCostoDescarga";
            this.lblCostoDescarga.Size = new System.Drawing.Size(230, 20);
            this.lblCostoDescarga.TabIndex = 21;
            this.lblCostoDescarga.Text = "Ingrese el costo de descarga:";
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.txtFilaHasta);
            this.gbDatosGenerales.Controls.Add(this.txtFilaDesde);
            this.gbDatosGenerales.Controls.Add(this.label1);
            this.gbDatosGenerales.Controls.Add(this.lblNumeroSimulaciones);
            this.gbDatosGenerales.Controls.Add(this.lblFilaDesde);
            this.gbDatosGenerales.Controls.Add(this.txtNumeroSimulaciones);
            this.gbDatosGenerales.Location = new System.Drawing.Point(11, 43);
            this.gbDatosGenerales.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosGenerales.Size = new System.Drawing.Size(359, 286);
            this.gbDatosGenerales.TabIndex = 18;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // txtFilaHasta
            // 
            this.txtFilaHasta.Location = new System.Drawing.Point(39, 218);
            this.txtFilaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilaHasta.Mask = "9999999";
            this.txtFilaHasta.Name = "txtFilaHasta";
            this.txtFilaHasta.Size = new System.Drawing.Size(75, 22);
            this.txtFilaHasta.TabIndex = 20;
            this.txtFilaHasta.ValidatingType = typeof(int);
            // 
            // txtFilaDesde
            // 
            this.txtFilaDesde.Location = new System.Drawing.Point(39, 151);
            this.txtFilaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilaDesde.Mask = "9999999";
            this.txtFilaDesde.Name = "txtFilaDesde";
            this.txtFilaDesde.Size = new System.Drawing.Size(75, 22);
            this.txtFilaDesde.TabIndex = 19;
            this.txtFilaDesde.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingrese hasta qué fila desea visualizar:";
            // 
            // lblNumeroSimulaciones
            // 
            this.lblNumeroSimulaciones.AutoSize = true;
            this.lblNumeroSimulaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSimulaciones.Location = new System.Drawing.Point(8, 53);
            this.lblNumeroSimulaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroSimulaciones.Name = "lblNumeroSimulaciones";
            this.lblNumeroSimulaciones.Size = new System.Drawing.Size(274, 20);
            this.lblNumeroSimulaciones.TabIndex = 16;
            this.lblNumeroSimulaciones.Text = "Ingrese el número de simulaciones:";
            // 
            // lblFilaDesde
            // 
            this.lblFilaDesde.AutoSize = true;
            this.lblFilaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilaDesde.Location = new System.Drawing.Point(8, 127);
            this.lblFilaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilaDesde.Name = "lblFilaDesde";
            this.lblFilaDesde.Size = new System.Drawing.Size(304, 20);
            this.lblFilaDesde.TabIndex = 17;
            this.lblFilaDesde.Text = "Ingrese desde qué fila desea visualizar:";
            // 
            // txtNumeroSimulaciones
            // 
            this.txtNumeroSimulaciones.Location = new System.Drawing.Point(39, 82);
            this.txtNumeroSimulaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroSimulaciones.Mask = "9999999";
            this.txtNumeroSimulaciones.Name = "txtNumeroSimulaciones";
            this.txtNumeroSimulaciones.Size = new System.Drawing.Size(75, 22);
            this.txtNumeroSimulaciones.TabIndex = 3;
            this.txtNumeroSimulaciones.ValidatingType = typeof(int);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 492);
            this.Controls.Add(this.gbPrincipal);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.gbPrincipal.ResumeLayout(false);
            this.gbSimular.ResumeLayout(false);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.gbEdicion.ResumeLayout(false);
            this.gbEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteSuperiorNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimiteInferiorNormal)).EndInit();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.GroupBox gbSimular;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.GroupBox gbEdicion;
        private System.Windows.Forms.CheckBox checkBoxEdicion;
        private System.Windows.Forms.Label lblDescripcionNormal;
        private System.Windows.Forms.NumericUpDown numLimiteSuperiorNormal;
        private System.Windows.Forms.NumericUpDown numLimiteInferiorNormal;
        private System.Windows.Forms.Label lblCostoDescarga;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.MaskedTextBox txtFilaHasta;
        private System.Windows.Forms.MaskedTextBox txtFilaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroSimulaciones;
        private System.Windows.Forms.Label lblFilaDesde;
        private System.Windows.Forms.MaskedTextBox txtNumeroSimulaciones;
    }
}

