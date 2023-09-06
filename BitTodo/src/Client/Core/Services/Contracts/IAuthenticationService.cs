using BitTodo.Shared.Dtos.Identity;

namespace BitTodo.Client.Core.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
