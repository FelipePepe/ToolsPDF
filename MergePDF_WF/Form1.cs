using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Utils;
using iText.Layout;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace MergePDF_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string fichero in openFileDialog1.FileNames)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = (lstFicheros.Items.Count + 1).ToString();
                    lvi.SubItems.Add(fichero);

                    lstFicheros.Items.Add(lvi);
                }
            }
        }

        private void MergePDF(string dest, string[] Files)
        {
            PdfDocument pdf = new PdfDocument(new PdfWriter(dest));
            PdfMerger merger = new PdfMerger(pdf);

            foreach (string filePDF in Files)
            {

                //Add pages from the first document
                PdfDocument firstSourcePdf = new PdfDocument(new PdfReader(filePDF));
                merger.Merge(firstSourcePdf, 1, firstSourcePdf.GetNumberOfPages());
                firstSourcePdf.Close();
            }


            pdf.Close();
        }

        private void btnFicheroDestino_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFicheroDestino.Text = saveFileDialog1.FileName;
            }
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            ArrayList lstFiles = null;

            if (lstFicheros.Items.Count > 0)
            {
                lstFiles = new ArrayList();

                for (int index = 0; index < lstFicheros.Items.Count; index++)
                {
                    lstFiles.Add(lstFicheros.Items[index].SubItems[1].Text);
                }

            }
            MergePDF(txtFicheroDestino.Text, (string[])lstFiles.ToArray(typeof(string)));
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngulo.Text))
            {
                MessageBox.Show("Introduzca el angulo que debe de rotar el documento.");
            }

            if (lstFicheros.SelectedItems.Count == 1)
            {
                string ficheroOrigen = lstFicheros.SelectedItems[0].SubItems[1].Text;
                RotarPDF(txtFicheroDestino.Text, ficheroOrigen, int.Parse(txtAngulo.Text));
            }
            else
            {
                if (lstFicheros.Items.Count > 1)
                {
                    MessageBox.Show("Seleccione el documento que quiere rotar.");
                }
                else
                {
                    lstFicheros.Items[0].Selected = true;
                    string ficheroOrigen = lstFicheros.SelectedItems[0].SubItems[1].Text;
                    RotarPDF(txtFicheroDestino.Text, ficheroOrigen, int.Parse(txtAngulo.Text));
                }
            }
        }

        private void RotarPDF(string ficheroDestino, string ficheroOrigen, int angulo)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(ficheroOrigen), new PdfWriter(ficheroDestino));
            int margin = 72;
            for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
            {
                PdfPage page = pdfDoc.GetPage(i);
                // change page size
                iText.Kernel.Geom.Rectangle mediaBox = page.GetMediaBox();
                iText.Kernel.Geom.Rectangle newMediaBox = new iText.Kernel.Geom.Rectangle((int)mediaBox.GetLeft() - margin, (int)mediaBox.GetBottom() - margin, (int)mediaBox.GetWidth() + margin * 2, (int)mediaBox.GetHeight() + margin * 2);
                page.SetMediaBox(newMediaBox);
                // add border
                PdfCanvas over = new PdfCanvas(page);
                over.Rectangle(mediaBox.GetLeft(), mediaBox.GetBottom(), mediaBox.GetWidth(), mediaBox.GetHeight());
                over.Stroke();
                // change rotation of the even pages
                page.SetRotation(angulo);
            }
            pdfDoc.Close();
        }
    }
}
