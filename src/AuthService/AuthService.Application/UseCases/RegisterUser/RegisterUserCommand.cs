using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Application.UseCases.RegisterUser;

public class RegisterUserCommand
{
    public string Email { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
}
