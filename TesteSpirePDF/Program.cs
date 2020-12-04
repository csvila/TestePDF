using Spire.Pdf;
using System;

namespace TesteSpirePDF
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
                throw new Exception("Necessário informar o arquivo de entrada e pasta de saída.");

            //open an existing pdf document
            PdfDocument doc = new PdfDocument(args[0]);
            //Split one PDF document to multiple files
            String pattern = $@"{args[1]}\SplitDocument-{0}.pdf";
            doc.Split(pattern);
            String lastPageFileName = String.Format(pattern, doc.Pages.Count - 1);
            doc.Close();
        }
    }
}
