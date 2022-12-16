using Pract01_ASP_RubenPeña.Models;

namespace Pract01_ASP_RubenPeña.Services
{
    public class RepositoryOfExp
    {
        public List<ClassExp> GetExp()
        {
            return new List<ClassExp>() {
                new ClassExp {
                    Title = "EXPERIENCIA",
                    Description = "REALIZADO TODO CON HTML Y CSS3",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/Forms.png"
                }
                };
        }
    }
}