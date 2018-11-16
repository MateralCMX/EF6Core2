using EF6DataBase;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace Chapter0202
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var efDbContext = new EFDBContext())
            {
                IEnumerable<DbEntityValidationResult> dbEntityValidationResults = efDbContext.GetValidationErrors();
            }
        }
    }
}
