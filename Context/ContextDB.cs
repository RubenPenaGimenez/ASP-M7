using Microsoft.EntityFrameworkCore;
using Pract01_ASP_RubenPeña.Models;

namespace Pract01_ASP_RubenPeña.Context;

public class ContextDB : DbContext
{

	public ContextDB(DbContextOptions<ContextDB> options) : base(options)
	{

	}
	public DbSet<ClassProjects> ClassProjects { get; set; }
}