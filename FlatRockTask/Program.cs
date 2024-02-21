using iTextSharp.text.pdf;

namespace FlatRockTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var reader = new PdfReader(@"C:\Users\lukak\OneDrive\Desktop\Test_Task.pdf");

            var htmlPage = PdfFetcher.FetchData(reader, 2);

            HtmlExtractor.Extract(htmlPage, "item");
        }
    }
}

