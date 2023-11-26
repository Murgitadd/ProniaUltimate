﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProniaUltimate.Models
{
    public class Slide
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name...")]
        [MaxLength(25, ErrorMessage = "Name should be 1-25 characters long...")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter Name...")]
        [MaxLength(50, ErrorMessage = "Name should be 1-50 characters long...")]
        public string SubTitle { get; set; }
        [Required(ErrorMessage = "Please Enter Name...")]
        [MaxLength(100, ErrorMessage = "Name should be 1-100 characters long...")]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}