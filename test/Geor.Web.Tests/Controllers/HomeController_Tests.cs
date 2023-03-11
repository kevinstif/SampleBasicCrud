using System.Threading.Tasks;
using Geor.Models.TokenAuth;
using Geor.Web.Controllers;
using Shouldly;
using Xunit;

namespace Geor.Web.Tests.Controllers
{
    public class HomeController_Tests: GeorWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}