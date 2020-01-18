namespace ImportProducts
{
    public interface IProductSource
    {
        string ReadFile(string filePath);
        void ParseFile(string filePath);
    }
}