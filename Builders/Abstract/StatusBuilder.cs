using JwtProjeClient.Builders.Concrete;
using JwtProjeClient.Models;

namespace JwtProjeClient.Builders.Abstract{
    public abstract class StatusBuilder{
        public abstract Status GenerateStatus(AppUser activeUser, string roles); 
    }
}