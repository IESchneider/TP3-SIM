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
            this.probNoResponde = new System.Windows.Forms.NumericUpDown();
            this.probNoRecordaba = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtFilaHasta = new System.Windows.Forms.MaskedTextBox();
            this.txtFilaDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroSimulaciones = new System.Windows.Forms.Label();
            this.lblFilaDesde = new System.Windows.Forms.Label();
            this.txtNumeroSimulaciones = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.probRecordaba = new System.Windows.Forms.NumericUpDown();
            this.probDudoso1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.probNo1 = new System.Windows.Forms.NumericUpDown();
            this.probSi1 = new System.Windows.Forms.NumericUpDown();
            this.probDudoso2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.probNo2 = new System.Windows.Forms.NumericUpDown();
            this.probSi2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbPrincipal.SuspendLayout();
            this.gbSimular.SuspendLayout();
            this.gbParametros.SuspendLayout();
            this.gbEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probNoResponde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probNoRecordaba)).BeginInit();
            this.gbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probRecordaba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probDudoso1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probNo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probSi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probDudoso2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probNo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probSi2)).BeginInit();
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
            this.gbPrincipal.Size = new System.Drawing.Size(1088, 470);
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
            this.gbParametros.Controls.Add(this.label12);
            this.gbParametros.Controls.Add(this.label11);
            this.gbParametros.Controls.Add(this.probDudoso2);
            this.gbParametros.Controls.Add(this.label8);
            this.gbParametros.Controls.Add(this.label9);
            this.gbParametros.Controls.Add(this.label10);
            this.gbParametros.Controls.Add(this.probNo2);
            this.gbParametros.Controls.Add(this.probSi2);
            this.gbParametros.Controls.Add(this.probDudoso1);
            this.gbParametros.Controls.Add(this.label5);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.label7);
            this.gbParametros.Controls.Add(this.probNo1);
            this.gbParametros.Controls.Add(this.probSi1);
            this.gbParametros.Controls.Add(this.probRecordaba);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.gbEdicion);
            this.gbParametros.Controls.Add(this.probNoResponde);
            this.gbParametros.Controls.Add(this.probNoRecordaba);
            this.gbParametros.Controls.Add(this.lbl1);
            this.gbParametros.Location = new System.Drawing.Point(395, 43);
            this.gbParametros.Margin = new System.Windows.Forms.Padding(4);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Padding = new System.Windows.Forms.Padding(4);
            this.gbParametros.Size = new System.Drawing.Size(685, 416);
            this.gbParametros.TabIndex = 20;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // gbEdicion
            // 
            this.gbEdicion.Controls.Add(this.checkBoxEdicion);
            this.gbEdicion.Location = new System.Drawing.Point(441, 358);
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
            // probNoResponde
            // 
            this.probNoResponde.DecimalPlaces = 2;
            this.probNoResponde.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probNoResponde.Location = new System.Drawing.Point(255, 51);
            this.probNoResponde.Margin = new System.Windows.Forms.Padding(4);
            this.probNoResponde.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.probNoResponde.Name = "probNoResponde";
            this.probNoResponde.Size = new System.Drawing.Size(103, 22);
            this.probNoResponde.TabIndex = 23;
            // 
            // probNoRecordaba
            // 
            this.probNoRecordaba.DecimalPlaces = 2;
            this.probNoRecordaba.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probNoRecordaba.Location = new System.Drawing.Point(255, 114);
            this.probNoRecordaba.Margin = new System.Windows.Forms.Padding(4);
            this.probNoRecordaba.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.probNoRecordaba.Name = "probNoRecordaba";
            this.probNoRecordaba.Size = new System.Drawing.Size(103, 22);
            this.probNoRecordaba.TabIndex = 22;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(8, 19);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(236, 20);
            this.lbl1.TabIndex = 21;
            this.lbl1.Text = "Ingrese las probabilidades:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Se nego a responder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Recordaba el mensaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "No recordaba el mensaje";
            // 
            // probRecordaba
            // 
            this.probRecordaba.DecimalPlaces = 2;
            this.probRecordaba.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probRecordaba.Location = new System.Drawing.Point(255, 82);
            this.probRecordaba.Margin = new System.Windows.Forms.Padding(4);
            this.probRecordaba.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.probRecordaba.Name = "probRecordaba";
            this.probRecordaba.Size = new System.Drawing.Size(103, 22);
            this.probRecordaba.TabIndex = 39;
            // 
            // probDudoso1
            // 
            this.probDudoso1.DecimalPlaces = 2;
            this.probDudoso1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probDudoso1.Location = new System.Drawing.Point(205, 249);
            this.probDudoso1.Margin = new System.Windows.Forms.Padding(4);
            this.probDudoso1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.probDudoso1.Name = "probDudoso1";
            this.probDudoso1.Size = new System.Drawing.Size(103, 22);
            this.probDudoso1.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Definitivamente si";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Dudoso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Definitivamente no";
            // 
            // probNo1
            // 
            this.probNo1.DecimalPlaces = 2;
            this.probNo1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probNo1.Location = new System.Drawing.Point(205, 218);
            this.probNo1.Margin = new System.Windows.Forms.Padding(4);
            this.probNo1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.probNo1.Name = "probNo1";
            this.probNo1.Size = new System.Drawing.Size(103, 22);
            this.probNo1.TabIndex = 41;
            // 
            // probSi1
            // 
            this.probSi1.DecimalPlaces = 2;
            this.probSi1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probSi1.Location = new System.Drawing.Point(205, 281);
            this.probSi1.Margin = new System.Windows.Forms.Padding(4);
            this.probSi1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.probSi1.Name = "probSi1";
            this.probSi1.Size = new System.Drawing.Size(103, 22);
            this.probSi1.TabIndex = 40;
            // 
            // probDudoso2
            // 
            this.probDudoso2.DecimalPlaces = 2;
            this.probDudoso2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probDudoso2.Location = new System.Drawing.Point(550, 247);
            this.probDudoso2.Margin = new System.Windows.Forms.Padding(4);
            this.probDudoso2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.probDudoso2.Name = "probDudoso2";
            this.probDudoso2.Size = new System.Drawing.Size(103, 22);
            this.probDudoso2.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Definitivamente si";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(349, 251);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Dudoso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 220);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Definitivamente no";
            // 
            // probNo2
            // 
            this.probNo2.DecimalPlaces = 2;
            this.probNo2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probNo2.Location = new System.Drawing.Point(550, 216);
            this.probNo2.Margin = new System.Windows.Forms.Padding(4);
            this.probNo2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.probNo2.Name = "probNo2";
            this.probNo2.Size = new System.Drawing.Size(103, 22);
            this.probNo2.TabIndex = 47;
            // 
            // probSi2
            // 
            this.probSi2.DecimalPlaces = 2;
            this.probSi2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probSi2.Location = new System.Drawing.Point(550, 279);
            this.probSi2.Margin = new System.Windows.Forms.Padding(4);
            this.probSi2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.probSi2.Name = "probSi2";
            this.probSi2.Size = new System.Drawing.Size(103, 22);
            this.probSi2.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Recordaba el mensaje:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 184);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "No recordaba el mensaje:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 492);
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
            ((System.ComponentModel.ISupportInitialize)(this.probNoResponde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probNoRecordaba)).EndInit();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probRecordaba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probDudoso1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probNo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probSi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probDudoso2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probNo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probSi2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.GroupBox gbSimular;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.GroupBox gbEdicion;
        private System.Windows.Forms.CheckBox checkBoxEdicion;
        private System.Windows.Forms.NumericUpDown probNoResponde;
        private System.Windows.Forms.NumericUpDown probNoRecordaba;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.MaskedTextBox txtFilaHasta;
        private System.Windows.Forms.MaskedTextBox txtFilaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroSimulaciones;
        private System.Windows.Forms.Label lblFilaDesde;
        private System.Windows.Forms.MaskedTextBox txtNumeroSimulaciones;
        private System.Windows.Forms.NumericUpDown probDudoso1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown probNo1;
        private System.Windows.Forms.NumericUpDown probSi1;
        private System.Windows.Forms.NumericUpDown probRecordaba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown probDudoso2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown probNo2;
        private System.Windows.Forms.NumericUpDown probSi2;
        private System.Windows.Forms.Label label12;
    }
}

