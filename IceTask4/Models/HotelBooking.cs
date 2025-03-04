using System.ComponentModel.DataAnnotations;

namespace IceTask4.Models
{
    public class HotelBooking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [Required]
        public string RoomType { get; set; } // Single, Double, Suite

        public decimal Price { get; set; }
    }
}
