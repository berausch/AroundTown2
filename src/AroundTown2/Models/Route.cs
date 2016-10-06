﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AroundTown2.Models
{
    [Table("Routes")]
    public class Route
    {
        public Route()
        {
            this.Locations = new HashSet<Location>();
        }
        [Key]
        public int Id { get; set; }
        public string RouteName { get; set; }
        
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
