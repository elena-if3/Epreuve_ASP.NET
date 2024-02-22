namespace BLL.Entities
{
    public class Media
    {
        private string fileName;

        public int Media_Id { get; set; }
        public string Link { get; set; }
        public int Product_Id { get; set; }
        public Product Product { get; set; }
        
        public Media (string link, int product_Id)
        {
            Link = link;
            Product_Id = product_Id;
        }

        public Media (int media_Id, string link, int product_Id) : this(link, product_Id)
        {
            Media_Id = media_Id;
        }

        public Media(int media_Id, string link, int product_Id, Product product) : this(media_Id, link, product_Id)
        {
            Product = product;
        }
    }
}
