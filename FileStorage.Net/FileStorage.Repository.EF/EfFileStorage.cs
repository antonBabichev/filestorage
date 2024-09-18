using Microsoft.EntityFrameworkCore;
using FileStorage.Models;
using FileStorage.Repository;

namespace FileStorage.Repository.EF
{
  public class EfFileStorage : DbContext, IFileStorage
  {
    private readonly string  connectionString;
    public EfFileStorage(string connectionString)
    {
      this.connectionString = connectionString;
    }

    public Dictionary<string, string> Config { get; set; }

    public DbSet<Folder> Folder {get; set;}
    public Folder GetFolder(string path)
    {
      return this.Folder.Where(f => f.Path == path)?.ToList()[0];
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL(this.connectionString);
    }
  }
}
