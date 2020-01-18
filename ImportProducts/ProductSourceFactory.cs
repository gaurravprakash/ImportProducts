using ImportProducts.ProductSources;

namespace ImportProducts
{
    public class ProductSourceFactory
    {
        public static IProductSource GetProductSource(string sourceType)
        {
            switch (sourceType)
            {
                case Constants.SourceType.CAPTERRA:
                    return new Capterra();
                case Constants.SourceType.SOFTWAREADVICE:
                    return new SoftwareAdvice();
                default:
                    return null;
            }
        }
    }
}
