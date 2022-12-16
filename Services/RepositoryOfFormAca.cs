using Pract01_ASP_RubenPeña.Models;

namespace Pract01_ASP_RubenPeña.Services
{
    public class RepositoryOfFormAca
    {
        public List<ClassFormAca> GetFormAca()
        {
            return new List<ClassFormAca>() {
                new ClassFormAca {
                    Title = "FORMACIÓN ACADÉMICA",
                    Description = "REALIZADO TODO CON HTML Y CSS3",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/Forms.png"
                }
                };
        }
    }
}