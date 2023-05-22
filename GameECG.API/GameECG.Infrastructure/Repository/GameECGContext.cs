using Microsoft.EntityFrameworkCore;

namespace GameECG.Infrastructure.Repository
{
    public class GameECGContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;database=ecg_game;user=root;password=Mokuton:Hashirama;";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }


    }
}