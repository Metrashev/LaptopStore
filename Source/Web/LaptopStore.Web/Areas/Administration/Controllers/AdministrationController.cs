namespace LaptopStore.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;
    using LaptopStore.Web.Controllers;

    [Authorize(Roles = "Administrator")]
    public class AdministrationController : BaseController
    {
    }
}
