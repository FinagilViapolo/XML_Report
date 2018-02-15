namespace XML_Report
{
    partial class frmReporte
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
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.fdBwCargaXML = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.cbValidaSAT = new System.Windows.Forms.CheckBox();
            this.btnReporteXLS = new System.Windows.Forms.Button();
            this.pbEstatusProceso = new System.Windows.Forms.ProgressBar();
            this.svfReporteXLS = new System.Windows.Forms.SaveFileDialog();
            this.dgCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRFCEmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRFCRec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgISR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgOP446 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgOP491 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFechaIPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFechaFPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTPercepciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTDeducciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVersionN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCons,
            this.dgSerie,
            this.dgFolio,
            this.dgVersion,
            this.dgRFCEmi,
            this.dgRFCRec,
            this.dgNombre,
            this.dgISR,
            this.dgOP446,
            this.dgOP491,
            this.dgFecha,
            this.dgUUID,
            this.dgTotal,
            this.dgFechaIPago,
            this.dgFechaFPago,
            this.dgTPercepciones,
            this.dgTDeducciones,
            this.dgEstatus,
            this.dgVersionN});
            this.dgvReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReporte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReporte.Location = new System.Drawing.Point(0, 0);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.Size = new System.Drawing.Size(937, 315);
            this.dgvReporte.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(862, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbValidaSAT
            // 
            this.cbValidaSAT.AutoSize = true;
            this.cbValidaSAT.Location = new System.Drawing.Point(727, 325);
            this.cbValidaSAT.Name = "cbValidaSAT";
            this.cbValidaSAT.Size = new System.Drawing.Size(120, 17);
            this.cbValidaSAT.TabIndex = 2;
            this.cbValidaSAT.Text = "Validar Estatus SAT";
            this.cbValidaSAT.UseVisualStyleBackColor = true;
            // 
            // btnReporteXLS
            // 
            this.btnReporteXLS.Location = new System.Drawing.Point(534, 321);
            this.btnReporteXLS.Name = "btnReporteXLS";
            this.btnReporteXLS.Size = new System.Drawing.Size(102, 23);
            this.btnReporteXLS.TabIndex = 3;
            this.btnReporteXLS.Text = "Reporte XLS";
            this.btnReporteXLS.UseVisualStyleBackColor = true;
            this.btnReporteXLS.Click += new System.EventHandler(this.btnReporteXLS_Click);
            // 
            // pbEstatusProceso
            // 
            this.pbEstatusProceso.Location = new System.Drawing.Point(240, 161);
            this.pbEstatusProceso.Name = "pbEstatusProceso";
            this.pbEstatusProceso.Size = new System.Drawing.Size(493, 23);
            this.pbEstatusProceso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbEstatusProceso.TabIndex = 4;
            this.pbEstatusProceso.Visible = false;
            // 
            // dgCons
            // 
            this.dgCons.HeaderText = "No";
            this.dgCons.Name = "dgCons";
            this.dgCons.ReadOnly = true;
            // 
            // dgSerie
            // 
            this.dgSerie.HeaderText = "Serie";
            this.dgSerie.Name = "dgSerie";
            this.dgSerie.ReadOnly = true;
            // 
            // dgFolio
            // 
            this.dgFolio.HeaderText = "Folio";
            this.dgFolio.Name = "dgFolio";
            this.dgFolio.ReadOnly = true;
            // 
            // dgVersion
            // 
            this.dgVersion.HeaderText = "Versión";
            this.dgVersion.Name = "dgVersion";
            this.dgVersion.ReadOnly = true;
            // 
            // dgRFCEmi
            // 
            this.dgRFCEmi.HeaderText = "RFC Emi";
            this.dgRFCEmi.Name = "dgRFCEmi";
            this.dgRFCEmi.ReadOnly = true;
            // 
            // dgRFCRec
            // 
            this.dgRFCRec.HeaderText = "RFC Rec";
            this.dgRFCRec.Name = "dgRFCRec";
            this.dgRFCRec.ReadOnly = true;
            // 
            // dgNombre
            // 
            this.dgNombre.HeaderText = "Nombre";
            this.dgNombre.Name = "dgNombre";
            this.dgNombre.ReadOnly = true;
            // 
            // dgISR
            // 
            this.dgISR.HeaderText = "ISR";
            this.dgISR.Name = "dgISR";
            this.dgISR.ReadOnly = true;
            // 
            // dgOP446
            // 
            this.dgOP446.HeaderText = "O Pag (446)";
            this.dgOP446.Name = "dgOP446";
            this.dgOP446.ReadOnly = true;
            // 
            // dgOP491
            // 
            this.dgOP491.HeaderText = "O Pago (491)";
            this.dgOP491.Name = "dgOP491";
            this.dgOP491.ReadOnly = true;
            // 
            // dgFecha
            // 
            this.dgFecha.HeaderText = "Fecha";
            this.dgFecha.Name = "dgFecha";
            this.dgFecha.ReadOnly = true;
            // 
            // dgUUID
            // 
            this.dgUUID.HeaderText = "UUID";
            this.dgUUID.Name = "dgUUID";
            this.dgUUID.ReadOnly = true;
            // 
            // dgTotal
            // 
            this.dgTotal.HeaderText = "Total";
            this.dgTotal.Name = "dgTotal";
            this.dgTotal.ReadOnly = true;
            // 
            // dgFechaIPago
            // 
            this.dgFechaIPago.HeaderText = "Fecha In Pago";
            this.dgFechaIPago.Name = "dgFechaIPago";
            this.dgFechaIPago.ReadOnly = true;
            // 
            // dgFechaFPago
            // 
            this.dgFechaFPago.HeaderText = "Fecha Fin Pago";
            this.dgFechaFPago.Name = "dgFechaFPago";
            this.dgFechaFPago.ReadOnly = true;
            // 
            // dgTPercepciones
            // 
            this.dgTPercepciones.HeaderText = "Total Percepciones";
            this.dgTPercepciones.Name = "dgTPercepciones";
            this.dgTPercepciones.ReadOnly = true;
            // 
            // dgTDeducciones
            // 
            this.dgTDeducciones.HeaderText = "Total Deducciones";
            this.dgTDeducciones.Name = "dgTDeducciones";
            this.dgTDeducciones.ReadOnly = true;
            // 
            // dgEstatus
            // 
            this.dgEstatus.HeaderText = "Estatus SAT";
            this.dgEstatus.Name = "dgEstatus";
            this.dgEstatus.ReadOnly = true;
            // 
            // dgVersionN
            // 
            this.dgVersionN.HeaderText = "Versión Nómina";
            this.dgVersionN.Name = "dgVersionN";
            this.dgVersionN.ReadOnly = true;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 347);
            this.Controls.Add(this.pbEstatusProceso);
            this.Controls.Add(this.btnReporteXLS);
            this.Controls.Add(this.cbValidaSAT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvReporte);
            this.Name = "frmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.FolderBrowserDialog fdBwCargaXML;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbValidaSAT;
        private System.Windows.Forms.Button btnReporteXLS;
        private System.Windows.Forms.ProgressBar pbEstatusProceso;
        private System.Windows.Forms.SaveFileDialog svfReporteXLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRFCEmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRFCRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgISR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgOP446;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgOP491;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFechaIPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFechaFPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTPercepciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTDeducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVersionN;
    }
}

