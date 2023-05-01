using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using NavesPortalforWebWithCoreMvc.Controllers.AuthFromIntranetController;

namespace NavesPortalforWebWithCoreMvc.Controllers.DIS
{
    [Authorize]
    [CheckSession]
    public class DisReferenceDocumentController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }

        public async Task<IActionResult> Create()
        {
            return await Task.Run(() => View());
        }

        public async Task<IActionResult> Detail()
        {
            return await Task.Run(() => View());
        }
    }
}
