namespace ClkEmlak.EntityLayer.Entities
{
    public class Image
    {
        public int ImageID { get; set; }
        public string ImageUrl { get; set; }
        public int EstateID { get; set; }
        public Estate Estate { get; set; }
    }
}
