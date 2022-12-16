using Pract01_ASP_RubenPeña.Models;

namespace Pract01_ASP_RubenPeña.Services
{
    public class RepositoryOfConTec
    {
        public List<ClassConTec> GetConTec()
        {
            return new List<ClassConTec>() {
                new ClassConTec {
                    Title = "CONOCIMIENTOS TÉCNICOS",
                    Description = "REALIZADO TODO CON HTML Y CSS3",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/Forms.png"
                }
                };
        }
    }
}