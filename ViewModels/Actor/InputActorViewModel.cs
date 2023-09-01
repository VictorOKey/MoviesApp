using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using MoviesApp.Filters;


namespace MoviesApp.ViewModels.Actor
{
    public class InputActorViewModel
    {
        
        [Required]
        [MinStringLengthAttribute(4)]
        public string Name { get; set; }
        [Required] 
        [MinStringLengthAttribute(4)] 
        public string LastName { get; set; } 
        
        [Required] 
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}