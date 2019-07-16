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
using System.Threading.Tasks;

namespace UserControllerUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateUserSnippetRecordWithPost()
        {
            DbContextOptions<CodeTalkDBContext> options = new DbContextOptionsBuilder<CodeTalkDBContext>().UseInMemoryDatabase("CreateUser").Options;
            using (var context = new CodeTalkDBContext(options))
            {
                var controller = new UserController(context, options);

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

        [Fact]
        public void CanRetrieveUserSnippetRecordWithGetUserByName()
        {
            DbContextOptions<CodeTalkDBContext> options = new DbContextOptionsBuilder<CodeTalkDBContext>().UseInMemoryDatabase("CreateUser").Options;
            using (var context = new CodeTalkDBContext(options))
            {
                var controller = new UserController(context, options);

                var actualOption = controller.GetUserByName("TestRecord");

                Assert.NotNull(actualOption);
            }
        }

        [Fact]
        public void CanRetrieveUserSnippetRecordWithGetUserById()
        {
            DbContextOptions<CodeTalkDBContext> options = new DbContextOptionsBuilder<CodeTalkDBContext>().UseInMemoryDatabase("CreateUser").Options;
            using (var context = new CodeTalkDBContext(options))
            {
                var controller = new UserController(context, options);

                var actualOption = controller.GetUserById(1);

                Assert.NotNull(actualOption);
            }
        }

        [Fact]
        public async Task CanRemoveUserSnippetRecordWithDeleteAsync()
        {
            DbContextOptions<CodeTalkDBContext> options = new DbContextOptionsBuilder<CodeTalkDBContext>().UseInMemoryDatabase("CreateUser").Options;
            using (var context = new CodeTalkDBContext(options))
            {
                var controller = new UserController(context, options);

                User user = new User()
                {
                    Name = "TestRecord",
                    ReturnString = "NameOfMethod is a public method with a void return type that takes in a TestType called NameOfParameter. When the method is called all the statements and arguments defined within the curly braces will run.",
                    Input = "NameOfMethod, TestType, NameOfParameter"
                };

                var createdRecord = controller.PostUser(user);

                var deletedRecord = await controller.Delete(1);
                var deleteStatus = deletedRecord.ToString();

                Assert.Contains("NoContentResult", deleteStatus);
            }
        }
    }
}