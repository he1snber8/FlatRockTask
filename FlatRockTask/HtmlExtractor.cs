using HtmlAgilityPack;
using System.Linq;
using System.Net.Http;
using System;
using System.Threading.Tasks;

namespace FlatRockTask
{
    public static class HtmlExtractor
    {
        public static void Extract(string html,string obj)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var productNodes = htmlDoc.DocumentNode.SelectNodes($"//div[@class='{obj}']");

            foreach ( var productNode in productNodes )
            {
                if (productNode == null) continue;

                string productName = productNode.SelectSingleNode(".//h4/a").InnerText.Trim();
                string priceText = productNode.SelectSingleNode(".//span[@class='price-display formatted']").ChildNodes[0].InnerText.Trim('$');
                double rating = double.Parse(productNode.GetAttributeValue("rating", "0"));

                Console.WriteLine($"Product Name: '{productName}'");
                Console.WriteLine($"Price: '{priceText}'");
                Console.WriteLine($"Rating: {rating}");
                Console.WriteLine();
            }
        }
    }
}

