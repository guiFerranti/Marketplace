namespace Marketplace.Exceptions.ExceptionsBase;

public class LoginInvalidoException : MarketplaceException
{
    public LoginInvalidoException() : base(ResourceErrorMessages.LOGIN_INVALIDO) 
    { }
}
