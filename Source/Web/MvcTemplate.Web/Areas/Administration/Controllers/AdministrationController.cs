namespace MvcTemplate.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;
    using MvcTemplate.Web.Controllers;

    [Authorize(Roles = "Administrator")]
    public class AdministrationController : BaseController
    {
    }
}
