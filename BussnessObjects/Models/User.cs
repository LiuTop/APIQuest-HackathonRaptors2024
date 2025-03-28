﻿using QAHackathon.Core.LoggingLogic;

namespace QAHackathon.BussinesObjects.Models
{
    public partial class User
    {
        private LoggingBL loggingBL = LoggingBL.Instance;

        public int AvatarUrl { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(int avatarUrl, string email, string name, string nickname, string password)
        {
            AvatarUrl = avatarUrl;
            Email = email;
            Name = name;
            Nickname = nickname;
            Password = password;
        }

        public User(string email, string name, string nickname, string password) 
        {
            Email = email;
            Name = name;
            Nickname = nickname;
            Password = password;
        }

        public void Show()
        {
            loggingBL.Info($"User: " +
                $"Avatar URL:{AvatarUrl}, " +
                $"Email:{Email}, " +
                $"Name:{Name}, " +
                $"Nickname:{Nickname}, " +
                $"Password:{Password}");
        }
    }
}