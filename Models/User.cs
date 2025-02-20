﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace carpool.Models
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        [StringLength(255)]
        public string UserId { get; set; }
        [StringLength(255)]
        public string UserName { get; set; }
        [StringLength(255)]
        public string PhoneNumber { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Passwords { get; set; }
        [StringLength(10)]
        public string Role { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CreateionDate { get; set; }

        [InverseProperty(nameof(Booking.Passenger))]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
