using EF6DataBase;
using EF6DataBase.Model;

namespace Chapter0201
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var efDbContext = new EFDBContext())
            {
                efDbContext.Blogs.Add(new Blog
                {
                    Name = "Materal",
                    Url = "http://www.cnblogs.com/CreateMyself"
                });
                efDbContext.SaveChanges();
            }
        }
    }
}
