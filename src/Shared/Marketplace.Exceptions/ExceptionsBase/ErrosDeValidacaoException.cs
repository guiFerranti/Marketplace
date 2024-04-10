namespace Marketplace.Exceptions.ExceptionsBase;

public class ErrosDeValidacaoException : MarketplaceException
{
    public List<string> ErrorMessages {  get; set; }

    public ErrosDeValidacaoException(List<string> errorMessages) : base(string.Empty)
    {
        ErrorMessages = errorMessages;
    }
}
