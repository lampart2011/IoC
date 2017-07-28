using DI_WithUnity.Framework;
using DI_WithUnity.Framework.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DI_WithUnity.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ITenantStore tenantStore;

        public ManagementController(ITenantStore tenantStore)
        {
            this.tenantStore = tenantStore;
        }

        // GET: Management
        public ActionResult Index()
        {
            var model = tenantStore.GetTenantNames();

            return View(model);
        }

        public ActionResult Detail(string tenant)
        {
            var model = tenantStore.GetTenant(tenant);

            return View(model);
        }
    }
}