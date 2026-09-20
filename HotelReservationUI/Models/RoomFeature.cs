namespace HotelReservationUI.Models
{
    public class RoomFeature
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public string FeatureName { get; set; } = "";
        public bool IsActive { get; set; }
    }
}
