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
        //There is no create method for the default snippets table
        //[Theory]
        //[InlineData(1)]
        //[InlineData(2)]
        //[InlineData(3)]
        //[InlineData(4)]
        //public void CanGetDefaultById(int id)
        //{
        //    DbContextOptions<CodeTalkDBContext> options = new DbContextOptionsBuilder<CodeTalkDBContext>()
        //        .UseInMemoryDatabase("CreateDefault")
        //        .Options;

        //    using (var context = new CodeTalkDBContext(options))
        //    {
        //        var controller = new DefaultController(context, options);

        //        var actualOption = controller.GetDefaultById(id);

        //        Assert.Equal(id, actualOption.Id);
        //    }

        //}
    }
}
