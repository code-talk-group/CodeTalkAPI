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
using CodeTalkAPI.Models;

namespace UserControllerUnitTests
{
    public class UnitTest1
    {
        //[Fact]
        public void CanCreateUserSnippetRecordWithPost()
        {
            var options = new DbContextOptionsBuilder<CodeTalkDBContext>()
                .Options;

            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            var configuration = builder.Build();

            using (var context = new CodeTalkDBContext(options))
            {
                var controller = new DefaultController(context, configuration);

                User user = new User()
                {
                    Name = "TestRecord",
                    ReturnString = "NameOfMethod is a public method with a void return type that takes in a TestType called NameOfParameter. When the method is called all the statements and arguments defined within the curly braces will run.",
                    Input = "NameOfMethod, TestType, NameOfParameter"
                };

                var actualOption = controller.PostUser(user);

                Assert.NotNull(actualOption);
            }

        }


    }
}