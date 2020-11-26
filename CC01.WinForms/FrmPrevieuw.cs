using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmPrevieuw : Form
    {
        private object items { get; set; }
        private object ReportPath { get; set; }
        public FrmPrevieuw()
        {
            InitializeComponent();
        }

        public FrmPrevieuw(object items, object reportPath) : this()
        {
            this.items = items;
            ReportPath = reportPath;
        }

        private void FrmPrevieuw_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "EtudiantlistRpt.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource
                ("DataSet1",
                    items
                    )
                );
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
            
        }
    }
}
