using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TourManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Role { get; set; } = "User";

        // Navigation properties (optional, helpful for EF Core)
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<CarRental> CarRentals { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public ICollection<Trip> Trips { get; set; }
        public ICollection<Cruise> Cruises { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }

}
