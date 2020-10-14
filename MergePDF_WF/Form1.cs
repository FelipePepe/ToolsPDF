using System;
using System.Collections;
using System.Windows.Forms;
using MyPdfTools;

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
            PdfTools.MergePDF(txtFicheroDestino.Text, (string[])lstFiles.ToArray(typeof(string)));
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
                PdfTools.RotarPDF(txtFicheroDestino.Text, ficheroOrigen, int.Parse(txtAngulo.Text));
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
                    PdfTools.RotarPDF(txtFicheroDestino.Text, ficheroOrigen, int.Parse(txtAngulo.Text));
                }
            }
        }

       
    }
}
