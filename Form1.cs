using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace XML_Report
{
    public partial class frmReporte : Form
    {
        public string dir_raiz = "";
        public int no_archivos = 0;
        public frmReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fdBwCargaXML.ShowDialog() == DialogResult.OK)
            {
                dir_raiz = fdBwCargaXML.SelectedPath + "\\";
                string[] dirs = Directory.GetFiles(dir_raiz, "*.xml");
                no_archivos = Convert.ToInt32(dirs.Length);
            }
            pbEstatusProceso.Visible = true;
            Load_XML(dir_raiz);
            pbEstatusProceso.Visible = false;
        }

        public void Load_XML(string dir)
        {
            pbEstatusProceso.Value = 1;
            pbEstatusProceso.Step = 1;
            pbEstatusProceso.Maximum = no_archivos+1;
            dgvReporte.Rows.Clear();
            try
            {
                DirectoryInfo d = new DirectoryInfo(dir);
            
            int fila = 0;
            
                foreach (FileInfo file in d.GetFiles("*.xml"))
                {
                    XmlDataDocument doc = new XmlDataDocument();
                    doc.Load(dir + file.Name.ToString());

                    XmlNode node;
                    node = doc.DocumentElement;
                    string rfc_emisor = "", rfc_receptor = "", total = "", uuid = "";

                    dgvReporte.Rows.Add();
                    dgvReporte.Rows[fila].Cells[0].Value = (fila+1).ToString();
                    foreach (XmlNode node1 in node.Attributes)
                    {
                        if (node1.Name == "Serie" || node1.Name == "serie")
                        {
                            dgvReporte.Rows[fila].Cells[1].Value = node1.Value.ToString();
                        }
                        if (node1.Name == "Folio" || node1.Name == "folio")
                        {
                            dgvReporte.Rows[fila].Cells[2].Value = node1.Value.ToString();
                        }
                        if (node1.Name == "Version" || node1.Name == "version")
                        {
                            dgvReporte.Rows[fila].Cells[3].Value = node1.Value.ToString();
                        }
                        if (node1.Name == "Fecha" || node1.Name == "fecha")
                        {
                            dgvReporte.Rows[fila].Cells[10].Value = Convert.ToDateTime(node1.Value.ToString());
                        }
                        if (node1.Name == "Total" || node1.Name == "total")
                        {
                            dgvReporte.Rows[fila].Cells[12].Value = node1.Value.ToString();
                            total = node1.Value.ToString();
                        }
                        foreach (XmlNode node1_a in node.ChildNodes)
                        {
                            if (node1_a.Name == "cfdi:Emisor")
                            {
                                foreach (XmlNode node1_aa in node1_a.Attributes)
                                {
                                    if (node1_aa.Name == "Rfc" || node1_aa.Name == "rfc")
                                    {
                                        dgvReporte.Rows[fila].Cells[4].Value = node1_aa.Value.ToString();
                                        rfc_emisor = node1_aa.Value.ToString();
                                    }
                                }
                            }
                        }
                        foreach (XmlNode node1_a in node.ChildNodes)
                        {
                            if (node1_a.Name == "cfdi:Receptor")
                            {
                                foreach (XmlNode node1_aa in node1_a.Attributes)
                                {
                                    if (node1_aa.Name == "Rfc" || node1_aa.Name == "rfc")
                                    {
                                        dgvReporte.Rows[fila].Cells[5].Value = node1_aa.Value.ToString();
                                        rfc_receptor = node1_aa.Value.ToString();
                                    }
                                    if (node1_aa.Name == "Nombre" || node1_aa.Name == "nombre")
                                    {
                                        dgvReporte.Rows[fila].Cells[6].Value = node1_aa.Value.ToString();
                                    }
                                }
                            }
                        }
                        foreach (XmlNode node1_a in node.ChildNodes)
                        {
                            if (node1_a.Name == "cfdi:Complemento")
                            {
                                foreach (XmlNode node1_aa in node1_a.ChildNodes)
                                {
                                    if (node1_aa.Name == "nomina12:Nomina" || node1_aa.Name == "nomina:Nomina")
                                    {
                                        foreach (XmlNode node1_at in node1_aa.Attributes)
                                        {
                                            if (node1_at.Name == "FechaInicialPago")
                                            {
                                                dgvReporte.Rows[fila].Cells[13].Value = Convert.ToDateTime(node1_at.Value.ToString());
                                            }
                                            if (node1_at.Name == "FechaFinalPago")
                                            {
                                                dgvReporte.Rows[fila].Cells[14].Value = Convert.ToDateTime(node1_at.Value.ToString());
                                            }
                                            if (node1_at.Name == "TotalPercepciones")
                                            {
                                                dgvReporte.Rows[fila].Cells[15].Value = node1_at.Value.ToString();
                                            }
                                            if (node1_at.Name == "TotalDeducciones")
                                            {
                                                dgvReporte.Rows[fila].Cells[16].Value = node1_at.Value.ToString();
                                            }
                                            if (node1_at.Name == "Version")
                                            {
                                                dgvReporte.Rows[fila].Cells[18].Value = node1_at.Value.ToString();
                                            }
                                        }
                                        foreach (XmlNode node1_ab in node1_aa.ChildNodes)
                                        {
                                            //Deducciones (ISR)
                                            if (node1_ab.Name == "nomina12:Deducciones")
                                            {
                                                double imp_002 = 0;
                                                foreach (XmlNode node1_ac in node1_ab.ChildNodes)
                                                {
                                                    if (node1_ac.Name == "nomina12:Deduccion")
                                                    {
                                                        foreach (XmlNode node1_ad in node1_ac.Attributes)
                                                        {
                                                            if (node1_ad.Name == "TipoDeduccion")
                                                            {
                                                                if (node1_ad.Value == "002")
                                                                {
                                                                    foreach (XmlNode node1_impo in node1_ac.Attributes)
                                                                    {
                                                                        if (node1_impo.Name == "Importe")
                                                                        {
                                                                            imp_002 = imp_002 + Convert.ToDouble(node1_impo.Value);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            
                                                        }
                                                        
                                                    }
                                                }
                                                dgvReporte.Rows[fila].Cells[7].Value = imp_002.ToString();
                                            }
                                            //Otros pagos

                                            if (node1_ab.Name == "nomina12:OtrosPagos")
                                            {
                                                double imp_446 = 0, imp_491 = 0;
                                                foreach (XmlNode node1_ac in node1_ab.ChildNodes)
                                                {
                                                    if (node1_ac.Name == "nomina12:OtroPago")
                                                    {
                                                        foreach (XmlNode node1_ad in node1_ac.Attributes)
                                                        {
                                                            if (node1_ad.Name == "Clave")
                                                            {
                                                                if (node1_ad.Value == "_446")
                                                                {
                                                                    foreach (XmlNode node1_impo in node1_ac.Attributes)
                                                                    {
                                                                        if (node1_impo.Name == "Importe")
                                                                        {
                                                                            imp_446 = imp_446 + Convert.ToDouble(node1_impo.Value);
                                                                        }
                                                                    }
                                                                }
                                                                if (node1_ad.Value == "_491")
                                                                {
                                                                    foreach (XmlNode node1_impo in node1_ac.Attributes)
                                                                    {
                                                                        if (node1_impo.Name == "Importe")
                                                                        {
                                                                            imp_491 = imp_491 + Convert.ToDouble(node1_impo.Value);
                                                                        }
                                                                    }
                                                                }
                                                            }

                                                        }

                                                    }
                                                }
                                                dgvReporte.Rows[fila].Cells[8].Value = imp_446.ToString();
                                                dgvReporte.Rows[fila].Cells[9].Value = imp_491.ToString();
                                            }
                                        }
                                    }
                                    if (node1_aa.Name == "tfd:TimbreFiscalDigital")
                                    {
                                        foreach (XmlNode node1_ab in node1_aa.Attributes)
                                        {
                                            if (node1_ab.Name == "UUID")
                                            {
                                                dgvReporte.Rows[fila].Cells[11].Value = node1_ab.Value.ToString();
                                                uuid = node1_ab.Value.ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (cbValidaSAT.Checked == true)
                    {
                        WS_SAT.ConsultaCFDIServiceClient servicio = new WS_SAT.ConsultaCFDIServiceClient();
                        dgvReporte.Rows[fila].Cells[17].Value = servicio.Consulta("?re=" + rfc_emisor + "&rr=" + rfc_receptor + "&tt=" + total + "&id=" + uuid).Estado.ToString();
                        frmReporte.ActiveForm.Update();
                    }
                    pbEstatusProceso.Value += 1;
                    ++fila;
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnReporteXLS_Click(object sender, EventArgs e)
        {
            pbEstatusProceso.Value = 1;
            pbEstatusProceso.Step = 1;
            pbEstatusProceso.Maximum = no_archivos + 5;
            pbEstatusProceso.Visible = true;
            //Excel
            Excel.Application App_Excel = default(Excel.Application);
            Excel.Workbook LibroExcel = default(Excel.Workbook);
            Excel.Worksheet HojaExcel = default(Excel.Worksheet);

            App_Excel = new Excel.Application();
                        LibroExcel = App_Excel.Workbooks.Add();
            HojaExcel = LibroExcel.Worksheets[1];
            HojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;

            HojaExcel.Activate();

            HojaExcel.Range["A1:E1"].Font.Bold = true;
            HojaExcel.Range["A1:E1"].Font.Size = 15;

            HojaExcel.Range["E2:J2"].Merge();
            HojaExcel.Range["E2:J2"].Value = "REPORTE DE COMPROBANTES FISCALES DIGITALES";
            HojaExcel.Range["E2:J2"].Font.Bold = true;
            HojaExcel.Range["E2:J2"].Font.Size = 15;

            Excel.Range objCelda = HojaExcel.Range["A3", Type.Missing];
            objCelda.Value = "Consecutivo";

            objCelda = HojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "Serie";

            objCelda = HojaExcel.Range["C3", Type.Missing];
            objCelda.Value = "Folio";
            objCelda.EntireColumn.NumberFormat = "###";

            objCelda = HojaExcel.Range["D3", Type.Missing];
            objCelda.Value = "Versión";

            objCelda = HojaExcel.Range["E3", Type.Missing];
            objCelda.Value = "RFC Emisor";

            objCelda = HojaExcel.Range["F3", Type.Missing];
            objCelda.Value = "RFC Receptor";

            objCelda = HojaExcel.Range["G3", Type.Missing];
            objCelda.Value = "Nombre";

            objCelda = HojaExcel.Range["H3", Type.Missing];
            objCelda.Value = "ISR";

            objCelda = HojaExcel.Range["I3", Type.Missing];
            objCelda.Value = "O Pag (446)";

            objCelda = HojaExcel.Range["J3", Type.Missing];
            objCelda.Value = "O Pag (491)";

            objCelda = HojaExcel.Range["K3", Type.Missing];
            objCelda.Value = "Fecha";

            objCelda = HojaExcel.Range["L3", Type.Missing];
            objCelda.Value = "UUID";
            
            objCelda = HojaExcel.Range["M3", Type.Missing];
            objCelda.Value = "Total";

            objCelda = HojaExcel.Range["N3", Type.Missing];
            objCelda.Value = "Fecha I Pago";

            objCelda = HojaExcel.Range["O3", Type.Missing];
            objCelda.Value = "Fecha F Pago";

            objCelda = HojaExcel.Range["P3", Type.Missing];
            objCelda.Value = "Total Percepciones";

            objCelda = HojaExcel.Range["Q3", Type.Missing];
            objCelda.Value = "Total Deducciones";

            objCelda = HojaExcel.Range["R3", Type.Missing];
            objCelda.Value = "Estatus SAT";

            objCelda = HojaExcel.Range["S3", Type.Missing];
            objCelda.Value = "Versión N";

            int i = 4;
            foreach(DataGridViewRow Row in dgvReporte.Rows)
                {
                // Asignar los valores de los registros a las celdas
                HojaExcel.Cells[i, "A"] = Row.Cells[0].Value;
                HojaExcel.Cells[i, "B"] = Row.Cells[1].Value;
                HojaExcel.Cells[i, "C"] = Row.Cells[2].Value;
                HojaExcel.Cells[i, "D"] = Row.Cells[3].Value;
                HojaExcel.Cells[i, "E"] = Row.Cells[4].Value;
                HojaExcel.Cells[i, "F"] = Row.Cells[5].Value;
                HojaExcel.Cells[i, "G"] = Row.Cells[6].Value;
                HojaExcel.Cells[i, "H"] = Row.Cells[7].Value;
                HojaExcel.Cells[i, "I"] = Row.Cells[8].Value;
                HojaExcel.Cells[i, "J"] = Row.Cells[9].Value;
                HojaExcel.Cells[i, "K"] = Row.Cells[10].Value;
                HojaExcel.Cells[i, "L"] = Row.Cells[11].Value;
                HojaExcel.Cells[i, "M"] = Row.Cells[12].Value;
                HojaExcel.Cells[i, "N"] = Row.Cells[13].Value;
                HojaExcel.Cells[i, "O"] = Row.Cells[14].Value;
                HojaExcel.Cells[i, "P"] = Row.Cells[15].Value;
                HojaExcel.Cells[i, "Q"] = Row.Cells[16].Value;
                HojaExcel.Cells[i, "R"] = Row.Cells[17].Value;
                HojaExcel.Cells[i, "S"] = Row.Cells[18].Value;

                pbEstatusProceso.Value += 1;
                i++;
            }
            App_Excel.Visible = true;
            pbEstatusProceso.Visible = false;
            //Termina Excel
        }
    }
}