namespace MyPdfTools
{
    using iText.Kernel.Pdf;
    using iText.Kernel.Pdf.Canvas;
    using iText.Kernel.Utils;

    public class PdfTools
    {
        public static void MergePDF(string dest, string[] Files)
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

        public static void RotarPDF(string ficheroDestino, string ficheroOrigen, int angulo)
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
