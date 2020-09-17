using DataService.Interfaces;
using ModelService;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiCatalog.Controllers.Api.v1;

namespace UrlBookApiTest
{
    public class AccountControllerTest
    {
        AccountController _controller;
        private readonly Mock<IUserService> _userServiceMock = new Mock<IUserService>();
        private readonly Mock<IAuthService> _authServiceMock = new Mock<IAuthService>();
        public AccountControllerTest()
        {
            _controller = new AccountController(_userServiceMock.Object, _authServiceMock.Object);
        }

        [Test]
        public void Test_Register()
        {
            var model = new RegisterViewModel()
            {
                Email ="purukumar16@gmail.com",
                Firstname ="purushottam",
                Lastname ="kumar",
                Password="12345"

            };

            var response = new ResponseObject()
            {
                IsValid = true,
                Message = "Success",
                Data = new { username = "Test123", email = "Test@gmail.com", status = 1, message = "Registration Successful" }
            };

            _userServiceMock.Setup(x => x.RegisterUserAsync(model)).ReturnsAsync(response);

            var result = _controller.Register(model);
            Assert.IsTrue(result.IsCompleted);
        }
    }
}
