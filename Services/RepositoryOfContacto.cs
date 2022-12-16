using Pract01_ASP_RubenPeña.Models;

namespace Pract01_ASP_RubenPeña.Services
{
    public class RepositoryOfContacto
    {
        public List<ClassContacto> GetContacto()
        {
            return new List<ClassContacto>() {
                new ClassContacto {
                    Title = "CONTACTO",
                    Description = "REALIZADO TODO CON HTML Y CSS3",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/Forms.png"
                }
                };
        }
    }
}