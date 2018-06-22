using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoAdministracion.Forms
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        public LocalReport lc;
        public string Reporte;
        public bool panel=true;
        public int Valor;
        public int Idturno;
        public int Idusuario;
        private void Reportes_Load(object sender, EventArgs e)
        {
            FechaInicial_dtp.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            ShowHidePanel();
            if (Valor == 0)
            {
                CierreDiario();
            }
            //this.reportViewer1.RefreshReport();
        }

        private void FindTickets()
        {
            //ReportParameter[] parametros = new ReportParameter[4];
            //parametros[0] = new ReportParameter("Itbis", itbis.ToString());
            //parametros[1] = new ReportParameter("Total", total.ToString());
            //parametros[2] = new ReportParameter("Descuento", descuento.ToString());
            //parametros[3] = new ReportParameter("Subtotal", subtotal.ToString());
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.FIND_TICKETSTableAdapter sta = new DataSet1TableAdapters.FIND_TICKETSTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.FIND_TICKETS, FechaInicial_dtp.Value,FechaFinal_dtp.Value);
            ReportDataSource rds = new ReportDataSource();
            //ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["FIND_TICKETS"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
        private void CierreDiario()
        {
            //ReportParameter[] parametros = new ReportParameter[4];
            //parametros[0] = new ReportParameter("Itbis", itbis.ToString());
            //parametros[1] = new ReportParameter("Total", total.ToString());
            //parametros[2] = new ReportParameter("Descuento", descuento.ToString());
            //parametros[3] = new ReportParameter("Subtotal", subtotal.ToString());
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.CIERRE_DIARIOTableAdapter sta = new DataSet1TableAdapters.CIERRE_DIARIOTableAdapter();
            DataSet1TableAdapters.GET_EMPRESATableAdapter sta1 = new DataSet1TableAdapters.GET_EMPRESATableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.CIERRE_DIARIO, Idturno, Idusuario);
            sta1.Fill(ds.GET_EMPRESA);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["CIERRE_DIARIO"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["GET_EMPRESA"]);
            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
        private void DetalleCierre()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("Fechai", FechaInicial_dtp.Value.ToShortDateString());
            parametros[1] = new ReportParameter("Fechaf", FechaFinal_dtp.Value.ToShortDateString());
            //parametros[2] = new ReportParameter("Descuento", descuento.ToString());
            //parametros[3] = new ReportParameter("Subtotal", subtotal.ToString());
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.RPT_DETALLE_CIERRETableAdapter sta = new DataSet1TableAdapters.RPT_DETALLE_CIERRETableAdapter();
            DataSet1TableAdapters.GET_EMPRESATableAdapter sta1 = new DataSet1TableAdapters.GET_EMPRESATableAdapter();
            DataSet1TableAdapters.RPT_DET_LOST_TICKETSTableAdapter sta2 = new DataSet1TableAdapters.RPT_DET_LOST_TICKETSTableAdapter();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            string ruta = "Reportes\\" + Reporte;
            lc.ReportPath = ruta;
            sta.Fill(ds.RPT_DETALLE_CIERRE, FechaInicial_dtp.Value.Date, FechaFinal_dtp.Value.Date);
            sta1.Fill(ds.GET_EMPRESA);
            sta2.Fill(ds.RPT_DET_LOST_TICKETS, FechaInicial_dtp.Value.Date, FechaFinal_dtp.Value.Date);
            ReportDataSource rds = new ReportDataSource();
            ReportDataSource rds1 = new ReportDataSource();
            ReportDataSource rds2 = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = (ds.Tables["RPT_DETALLE_CIERRE"]);
            rds1.Name = "DataSet2";
            rds1.Value = (ds.Tables["GET_EMPRESA"]);
            rds2.Name = "DataSet3";
            rds2.Value=(ds.Tables["RPT_DET_LOST_TICKETS"]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rds);
            lc.DataSources.Add(rds1);
            lc.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
        }
        private void Buscar_btn_Click(object sender, EventArgs e)
        {
            if (Valor == 1)
            {
                Reporte = "find_tickets.rdlc";
                FindTickets();
            }
            else if (Valor == 2)
            {
                Reporte = "det_cierre.rdlc";
                DetalleCierre();
            }
            
        }
        private void ShowHidePanel()
        {
            if(panel==false)
            {
                //panel1.Visible = panel;
                FechaFinal_dtp.Visible = panel;
                FechaInicial_dtp.Visible = panel;
                Buscar_btn.Visible = panel;
                label1.Visible = panel;
                label2.Visible = panel;
                reportViewer1.Dock = DockStyle.Fill;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Restaurar.Visible = true;
            btn_Maximize.Visible = false;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btn_Maximize.Visible = true;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
