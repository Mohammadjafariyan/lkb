using System;
using System.Collections.Generic;

namespace WebApplication.abbas_lkb
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RememberToken { get; set; }
        public int? DepotId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
