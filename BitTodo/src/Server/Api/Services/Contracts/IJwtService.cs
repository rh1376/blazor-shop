using BitTodo.Server.Api.Models.Identity;
using BitTodo.Shared.Dtos.Identity;

namespace BitTodo.Server.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
