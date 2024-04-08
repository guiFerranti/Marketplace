using Marketplace.Communication.Request;
using Marketplace.Communication.Response;

namespace Marketplace.Application.UseCases.User.Signup;

public class SignupUseCase : ISignupUseCase
{
    public Task<ResponseSignupUserJson> Execute(RequestSignupUserJson request)
    {
        throw new NotImplementedException();
    }
}
