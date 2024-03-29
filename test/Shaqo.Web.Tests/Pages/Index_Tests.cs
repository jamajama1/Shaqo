﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Shaqo.Pages;

public class Index_Tests : ShaqoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
