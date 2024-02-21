using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Collections.Generic;

namespace FlatRockTask
{
    public static class PdfFetcher
    {
        public static string FetchData(PdfReader reader,int pageCount)
        {
            string pageText = string.Empty;

            for (int page = 1; page <= pageCount; page++)
            {
                pageText += PdfTextExtractor.GetTextFromPage(reader, page).Trim();
            }
            return pageText;
        }
    }
}

