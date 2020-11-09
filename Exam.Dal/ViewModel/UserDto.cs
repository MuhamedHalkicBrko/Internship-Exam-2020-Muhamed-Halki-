using Exam.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Exam.Dal.ViewModel
{
    public class UserDto
    {
        public UserDto()
        {
        }

        public UserDto(User user)
        {
            Name = user.Name;
            Age = user.Age;
            Email = user.Email;
            Password = user.Password;
            Id = user.Id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; }
        public string Email { get; set; }
        public string Password { get; }
    }
}
