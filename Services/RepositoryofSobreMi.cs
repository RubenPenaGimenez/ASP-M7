using Pract01_ASP_RubenPeña.Models;

namespace Pract01_ASP_RubenPeña.Services
{
    public class RepositoryOfSobreMi
    {
        public List<ClassSobreMi> GetSobreMi()
        {
            return new List<ClassSobreMi>() {
                new ClassSobreMi {
                    Title = "SOBRE MI",
                    Description = "REALIZADO TODO CON HTML Y CSS3",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/Forms.png"
                }
                };
        }
    }
}