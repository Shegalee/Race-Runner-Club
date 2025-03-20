using RunGroopWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace Race_Runner_Club.Models
{
    public class Addresses
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City{ get; set; }
        public string State { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }
    }

}
