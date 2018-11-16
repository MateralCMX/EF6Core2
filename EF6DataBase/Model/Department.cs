using System.Collections.Generic;

namespace EF6DataBase.Model
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
