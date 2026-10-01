namespace HotelReservationUI.Models
{
    public class RoomAvailability
    {
        public int RoomTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal BasePrice { get; set; }
        public int Capacity { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int AvailableRooms { get; set; }
        public List<RoomFeature> Features { get; set; } = new();
    }
}
