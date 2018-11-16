namespace EF6DataBase.Model
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}
