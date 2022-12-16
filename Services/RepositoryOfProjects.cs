using Pract01_ASP_RubenPeña.Models;

namespace Pract01_ASP_RubenPeña.Services
{
    public class RepositoryOfProjects
    {
        public List<ClassProjects> GetProjects()
        {
            return new List<ClassProjects>() {
                new ClassProjects {
                    Title = "Formularios con HTML",
                    Description = "REALIZADO TODO CON HTML Y CSS3",
                    Link = "/proyectos/M4-UF1-PRACT03-FORMULARIOS",
                    ImageURL = "/img/Forms.png"
                },
                new ClassProjects {
                    Title = "Portfolio HTML",
                    Description = "REALIZADO TODO CON HTML Y CSS3",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/portfolio.png"
                    },

                new ClassProjects {
                    Title = "Prototipo Responsive",
                    Description = "REALIZADO TODO CON HTML, CSS3 Y BOOTSTRAP",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/prototipo.png"
                    },

                new ClassProjects {
                    Title = "Java Scrip",
                    Description = "Animación realizado en JS",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/shadow.png"
                    },

                new ClassProjects {
                    Title = "Java Script",
                    Description = "Animación realizado en JS",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/shadow.png"
                    },
                new ClassProjects {
                    Title = "Java Script",
                    Description = "Animación realizado en JS",
                    Link = "https://Monlau.com",
                    ImageURL = "/img/shadow.png"
                    }
                };
        }
    }
}