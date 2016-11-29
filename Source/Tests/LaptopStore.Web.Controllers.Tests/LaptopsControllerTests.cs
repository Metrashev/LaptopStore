namespace LaptopStore.Web.Controllers.Tests
{
    using Moq;

    using LaptopStore.Data.Models;
    using LaptopStore.Services.Data;
    using LaptopStore.Web.Infrastructure.Mapping;
    using LaptopStore.Web.ViewModels.Home;

    using NUnit.Framework;

    using TestStack.FluentMVCTesting;

    //[TestFixture]
    //public class JokesControllerTests
    //{
    //    [Test]
    //    public void ByIdShouldWorkCorrectly()
    //    {
    //        var autoMapperConfig = new AutoMapperConfig();
    //        autoMapperConfig.Execute(typeof(JokesController).Assembly);
    //        const string JokeContent = "SomeContent";
    //        var LaptopsServiceMock = new Mock<ILaptopsService>();
    //        LaptopsServiceMock.Setup(x => x.GetById(It.IsAny<string>()))
    //            .Returns(new Joke { Content = JokeContent, Category = new JokeCategory { Name = "asda" } });
    //        var controller = new JokesController(LaptopsServiceMock.Object);
    //        controller.WithCallTo(x => x.ById("asdasasd"))
    //            .ShouldRenderView("ById")
    //            .WithModel<LaptopViewModel>(
    //                viewModel =>
    //                    {
    //                        Assert.AreEqual(JokeContent, viewModel.Content);
    //                    }).AndNoModelErrors();
    //    }
    //}
}
