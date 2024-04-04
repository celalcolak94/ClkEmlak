namespace ClkEmlak.WebUI.Models
{
	public class CreateEstateModel
	{
		public int EstateID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public DateTime Date { get; set; }
		public string CoverPhoto { get; set; }
		public string Country { get; set; }
		public string Province { get; set; }
		public string District { get; set; }
		public string Address { get; set; }
		public int GrossSquareMeters { get; set; }
		public int NetSquareMeters { get; set; }
		public string Rooms { get; set; }
		public int BuildingAge { get; set; }
		public int NumberOfFloors { get; set; }
		public int FloorLocation { get; set; }
		public string Heating { get; set; }
		public int BathNumber { get; set; }
		public bool Balcony { get; set; }
		public bool Lift { get; set; }
		public string CarPark { get; set; }
		public int CategoryID { get; set; }
		public bool HomePage { get; set; }
		public bool Status { get; set; }
		public List<IFormFile> Images { get; set; }
	}
}
