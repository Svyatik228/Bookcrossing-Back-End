﻿using System.Threading.Tasks;
using Application.Dto;
using Application.Dto.Password;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> VerifyUserCredentials(LoginDto loginModel);
        Task SendPasswordResetConfirmation(string email);
        Task ResetPassword(ResetPasswordDto newPassword);

    }
}