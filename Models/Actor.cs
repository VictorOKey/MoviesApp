using System;
using System.ComponentModel.DataAnnotations;
//using MoviesApp.Filters;

namespace MoviesApp.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        
        [DataType(DataType.Date)]
        
        public DateTime Birthday { get; set; }
   
        
    }
}   