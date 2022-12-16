using Pract01_ASP_RubenPeña.Models;

namespace Pract01_ASP_RubenPeña.Services
{
    public class RepositoryOfDescCV
    {
        public List<ClassDescCV> GetDescCV()
        {
            return new List<ClassDescCV>() {
                new ClassDescCV {
                    Title = "DESCARGA CV",
                    Description = "REALIZADO TODO CON HTML Y CSS3",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/Forms.png"
                }
                };
        }
    }
}