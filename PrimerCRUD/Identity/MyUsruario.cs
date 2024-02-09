using Microsoft.AspNetCore.Identity;

namespace PrimerCRUD.Identity
{
    public class MyUsruario: IdentityUser
    {
        public DateTime FechaRegistro { get; set; }
    }
}
