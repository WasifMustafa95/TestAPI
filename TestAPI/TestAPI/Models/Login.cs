using System;
using System.Collections.Generic;

namespace TestAPI.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
