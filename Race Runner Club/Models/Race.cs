﻿using Race_Runner_Club.Models.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Race_Runner_Club.Models
{
    public class Race
    
    {
        public class Club
        {
            [Key]
            public int Id { get; set; }
            public string? Title { get; set; }
            public string? Description { get; set; }
            public string? Image { get; set; }
            [ForeignKey("Addresses")]
            public int? AddressId { get; set; }
            public Addresses? Addresses { get; set; }
            public ClubCategory ClubCategory { get; set; }
            [ForeignKey("AppUser")]
            public string? AppUserId { get; set; }
            public AppUser? AppUser { get; set; }
        }
    }
}

