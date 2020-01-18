using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Serialization;

namespace ImportProducts.ProductSources
{
    /// <summary>
    /// The class representing Caprerra Product Source.
    /// </summary>
    public class Capterra : IProductSource
    {
        /// <summary>
        /// Parses the specified file and displays contents on the console.
        /// </summary>
        /// <param name="filePath">The local path to input file.</param>
        public void ParseFile(string filePath)
        {
            var data = ReadFile(filePath);
            Deserializer deserializer = new Deserializer();
            var result = deserializer.Deserialize<List<Hashtable>>(new StringReader(data));
            StringBuilder sb;
            foreach (var item in result)
            {
                sb = new StringBuilder();
                if (item["name"] != null)
                {
                    sb.Append("Name: " + item["name"]);
                    sb.Append("; ");
                }
                if (item["tags"] != null)
                {
                    sb.Append("Categories: " + item["tags"]);
                    sb.Append("; ");
                }
                if (item["twitter"] != null)
                {
                    sb.Append("Twitter: " + item["twitter"]);
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
