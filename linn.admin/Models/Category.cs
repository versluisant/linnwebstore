namespace linn.admin.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public Category ParentCategory { get; set; }
    }
}
