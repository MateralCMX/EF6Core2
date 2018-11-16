using System;

namespace EF6DataBase.Model
{
    public class Blog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime? CreatedTime { get; set; }
        public double Double { get; set; }
        public float Float { get; set; }
    }
}
