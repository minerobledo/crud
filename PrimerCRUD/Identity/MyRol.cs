using Microsoft.AspNetCore.Identity;

namespace PrimerCRUD.Identity
{
    public class MyRol:IdentityRole
    {
        public String Rol { get; set; }
        public DateTime Registro { get; set; }
    }
}
