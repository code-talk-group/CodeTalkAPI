using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using CodeTalkAPI.Controllers;
using Microsoft.EntityFrameworkCore;
using CodeTalkAPI.Data;
using CodeTalkAPI.Interfaces;
using Microsoft.Extensions.Configuration;
using CodeTalkAPI;

namespace DefaultControllerUnitTests
{
    public class UnitTest1
    {
        ////[Theory]
        //[InlineData(1)]
        //[InlineData(2)]
        //[InlineData(3)]
        //[InlineData(4)]
        //public void CanGetDefaultById(int id)
        //{
        //    var options = new DbContextOptionsBuilder<CodeTalkDBContext>()
        //        .Options;

        //    var builder = new ConfigurationBuilder().AddEnvironmentVariables();
        //    builder.AddUserSecrets<Startup>();
        //    var configuration = builder.Build();

        //    using (var context = new CodeTalkDBContext(options))
        //    {
        //        var controller = new DefaultController(context, configuration);

        //        var actualOption = controller.GetDefaultById(id);

        //        Assert.Equal(id, actualOption.Id);
        //    }

        //}


    }
}
