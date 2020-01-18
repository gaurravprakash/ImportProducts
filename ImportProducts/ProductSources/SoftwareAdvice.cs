using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace ImportProducts.ProductSources
{
    /// <summary>
    /// The class representing SoftwareAdvice Product Source.
    /// </summary>
    public class SoftwareAdvice : IProductSource
    {
        /// <summary>
        /// Parses the specified file and displays contents on the console.
        /// </summary>
        /// <param name="filePath">The local path to input file.</param>
        public void ParseFile(string filePath)
        {
            var data = ReadFile(filePath);
            dynamic array = JsonConvert.DeserializeObject(data);
            StringBuilder sb;
            foreach (dynamic item in array.products)
            {
                sb = new StringBuilder();
                if (item.title != null)
                {
                    sb.Append("Name: " + item.title);
                    sb.Append("; ");
                }
                if (item.categories != null)
                {
                    sb.Append("Categories: " + string.Join(",", item.categories.ToObject<string[]>()));
                    sb.Append("; ");
                }
                if (item.twitter != null)
                {
                    sb.Append("Twitter: " + item.twitter);
                }
                //Write parsed data to console for now.
                Console.WriteLine(Constants.Messages.IMPORTING + sb);
            }
        }

        /// <summary>
        /// Returns the contents of specified file as a string.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
