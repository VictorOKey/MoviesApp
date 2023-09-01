using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Filters;

namespace MoviesApp.Services.Dto
{
    public class ActorDto
    {
        //Id - null, когда отправлена нам для создания
        //Обратите внимание на конфигурацию мэппинга
        //Id может отсуствовать в DTO, если практикуются разделения на Input/Output модели
        public int? Id { get; set; }
        
        [Required]
        [MinStringLengthAttribute(4)]
        public string Name { get; set; }

        [Required]
        [MinStringLengthAttribute(4)]
        public string LastName { get; set; }

        [Required] [DataType(DataType.Date)] public DateTime Birthday { get; set; }

        public IEnumerable<Models.Actor> Actors{ get; set; }


    }
}