using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthService.Domain.Entities;
using AuthService.Domain.Interfaces;

namespace AuthService.Application.UseCases.RegisterUser;

/// <summary>
/// Handles user registration by checking for an existing user,
/// creating a new User entity and persisting it via IUserRepository.
/// </summary>

public class RegisterUserHandler
{
    private readonly IUserRepository _userRepository;

    public RegisterUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task HandleAsync(RegisterUserCommand command)
    {
        var existingUser = await _userRepository.GetByEmailAsync(command.Email);

        if (existingUser != null)
        {
            throw new Exception("User already exists");
        }

        var user = new User(
            email: command.Email,
            passwordHash: HashPassword(command.Password)
        );

        await _userRepository.AddAsync(user);
    }

    private string HashPassword(string password)
    {
        return $"HASHED_{password}";
    }
}
