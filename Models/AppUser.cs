using System.Collections.Generic;

namespace JwtProjeClient.Models{
    public class AppUser{
        public string FullName { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}