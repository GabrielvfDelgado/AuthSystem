using AuthSystem.Domain.Models;
using System;

namespace AuthSystem.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
