namespace DefectiveProduct.Model
{
    public class Product
    {
        public int Id { get; set; }
        public String Item { get; set; }
        public Supplier Supplier { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public String Description { get; set; }
        public int Quantity { get; set; }

        //perguntar

        //public int SupplierId { get; set; }

        //public String Image { get; set; }
        //public double Price { get; set; }
    }
}