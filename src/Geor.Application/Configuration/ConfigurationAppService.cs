﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Geor.Configuration.Dto;

namespace Geor.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GeorAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
