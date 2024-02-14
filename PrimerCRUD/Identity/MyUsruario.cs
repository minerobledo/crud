using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PrimerCRUD.Identity
{
    public class MyUsruario : IdentityUser
    {

        public DateTime FechaRegistro { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public override string? UserName { get => base.UserName; set => base.UserName = value; }


        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public override string? PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }


        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email error")]
        public override string? Email { get => base.Email; set => base.Email = value; }

    }
}
