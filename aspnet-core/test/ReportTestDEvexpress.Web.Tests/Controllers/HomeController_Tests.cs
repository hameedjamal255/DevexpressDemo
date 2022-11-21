using System.Threading.Tasks;
using ReportTestDEvexpress.Models.TokenAuth;
using ReportTestDEvexpress.Web.Controllers;
using Shouldly;
using Xunit;

namespace ReportTestDEvexpress.Web.Tests.Controllers
{
    public class HomeController_Tests: ReportTestDEvexpressWebTestBase
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