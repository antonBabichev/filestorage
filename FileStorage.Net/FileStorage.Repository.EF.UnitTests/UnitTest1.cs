using System.Configuration;
using FileStorage.Repository.EF;

namespace FileStorage.Repository.EF.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void BasicTest()
        {
            var efContext = new EfFileStorage(ConfigurationManager.ConnectionStrings["EfFileStorage"]?.ConnectionString);
            var f = efContext.GetFolder("test");
            Console.WriteLine(f.Id);
        }
    }
}