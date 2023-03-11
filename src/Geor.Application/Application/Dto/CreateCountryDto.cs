using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application.Dto
{
    [AutoMapTo(typeof(Country))]
    public class CreateCountryDto
    {
        [Required]
        [MaxLength(20)]
        public String Name { get; set; }

        [Required]
        public String Code { get; set; }

    }
}
