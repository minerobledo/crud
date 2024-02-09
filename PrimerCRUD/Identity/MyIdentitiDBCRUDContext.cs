using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PrimerCRUD.Identity
{
    public class MyIdentitiDBCRUDContext : IdentityDbContext<MyUsruario,MyRol,String>
    {
        public MyIdentitiDBCRUDContext(DbContextOptions<MyIdentitiDBCRUDContext> options) 
            :  base(options)
        {
        }
    }
}
