﻿namespace BankApplication.Data.Interfaces;

public interface IUserRepository
{
    Task<User> GetUserByEmailAsync(string email);
    Task CreateUser(User user);
    Task<bool> UserExist(string email);
    bool CheckPassword(string passwordLogin, User user );
}