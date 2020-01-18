using System;

namespace ImportProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Show error message if all arguments are not passed.
            if (args.Length < 2)
            {
                Console.WriteLine(Constants.Messages.INVALID_ARGS);
                return;
            }
            //Try to obtain source instance based on input source type.
            IProductSource source = ProductSourceFactory.GetProductSource(args[0].ToLower());
            if (source != null)
            {
                //Try to parse the input file, and display contents or error if parsing fails.
                try
                {
                    source.ParseFile(args[1]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Constants.Messages.PARSE_FAILED + ex.Message);
                }
            }
            //Specified source not found/implemented.
            else
            {
                Console.WriteLine(Constants.Messages.INVALID_SOURCE);
            }
        }
    }
}
