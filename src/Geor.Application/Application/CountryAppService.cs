using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Geor.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.Application
{
    public class CountryAppService : AsyncCrudAppService<Country, CountryDto, int, PagedCountryResultDto, CreateCountryDto, CountryDto>
    {
        public CountryAppService(IRepository<Country, int> repository) : base(repository)
        {
        }
    }
}
