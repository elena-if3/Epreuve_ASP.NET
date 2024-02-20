namespace BLL.Entities
{
    public class Media
    {
        public int Media_Id { get; set; }
        public string Link { get; set; }
        public int Product_Id { get; set; }

        public Media(int media_Id, string link, int product_Id)
        {
            Media_Id = media_Id;
            Link = link;
            Product_Id = product_Id;
        }
    }
}
