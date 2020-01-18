namespace ImportProducts.Constants
{
    public class Messages
    {
        public const string IMPORTING = "importing: ";
        public const string INVALID_ARGS = "Invalid arguments provided. Please provide arguments in the format : {source type} {file path}. e.g. capterra C:/feed-products/capterra.yaml";
        public const string PARSE_FAILED = "Failed to parse the specified file.";
        public const string INVALID_SOURCE = "The specified source type could not be recognized.";
    }
}
