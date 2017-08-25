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
        private void Buscar_btn_Click(object sender, EventArgs e)
        {
            Reporte = "find_tickets.rdlc";
            FindTickets();
        }
        private void ShowHidePanel()
        {
            if(panel==false)
            {
                panel1.Visible = panel;
                reportViewer1.Dock = DockStyle.Fill;
            }
        }
    }
}
