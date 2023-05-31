namespace DefectiveProduct.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public Supplier Supplier { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public int isActive { get; set; }

        //perguntar

        //public int SupplierId { get; set; }

        //public String Image { get; set; }
        //public double Price { get; set; }
    }
}