namespace BLL.Entities
{
    public class Category
    {
        public int Cat_Id { get; set; }
        public string CatName { get; set; }
        public string? CatDescr { get; set; }

        public Category(int cat_Id, string catName, string? catDescr)
        {
            Cat_Id = cat_Id;
            CatName = catName;
            CatDescr = catDescr;
        }
    }
}
