﻿using System;

namespace BILLING.Models;

public class User
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }

    public User()
    {
        
    }

    public User(Guid id, string name, string surname, string username, string password)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Username = username;
        Password = password;
    }
}
