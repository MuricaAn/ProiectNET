﻿using Proiect.Models.User;


namespace Proiect.Models.DTOs.UserDto
{
    public class UserResponseDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Token { get; set; }

        public UserResponseDTO(User.User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            UserName = user.Username;
            Token = token;
        }
    }
}
