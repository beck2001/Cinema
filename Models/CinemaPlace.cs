﻿using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
    public class CinemaPlace
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string CinemaLogo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
