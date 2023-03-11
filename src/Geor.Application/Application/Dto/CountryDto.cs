using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application.Dto
{
    [AutoMapFrom(typeof(Country))]
    [AutoMapTo(typeof(Country))]
    public  class CountryDto: EntityDto<int>
    {
        [Required]
        public String Name { get; set; }
        [Required]
        public String Code { get; set; }

    }
}
