using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using Spire.Pdf;
using System.Diagnostics;

namespace Projeto4
{
    public partial class FormRelatorioCurso : MaterialForm
    {
        string cs = @"server=localhost;" +
                      "uid=root;" +
                      "pwd=;" +
                      "database=academico";
        public FormRelatorioCurso()
        {
            InitializeComponent();
            CarregaImpressoras();
        }

        private void CarregaImpressoras()
        {

            foreach (string printer in
                System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
            }
        }

        private void MontaRelatorio()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM curso WHERE 1 = 1";
            if (cboNome.Text != "")
                sql += " and nome = @nome";
            if (cboTipo.Text != "")
                sql += " and tipo = @tipo";

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            if (cboNome.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@nome", cboNome.Text);
            if (cboTipo.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@tipo", cboTipo.Text);

            var dt = new DataTable();
            sqlAd.Fill(dt);
            con.Close();

            //Inicio geração PDF
            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 20;
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatório de Cursos", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);


            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            //table.Style.HeaderRowCount = 1;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
            table.DataSource = dt;
            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(
                    PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            table.Draw(page, new PointF(0, y + 30));

            doc.SaveToFile("RelatorioCursos.pdf");


        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            PdfDocument doc = new PdfDocument();
            doc.Print();
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioCursos.pdf")
            { UseShellExecute = true };
            p.Start();
        }
    }
}
