using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Olympic.Trader.Pages;

public class Index_Tests : TraderWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
