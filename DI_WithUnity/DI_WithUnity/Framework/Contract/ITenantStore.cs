using DI_WithUnity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_WithUnity.Framework.Contract
{
    public interface ITenantStore
    {
        void Initialize();
        Tenant GetTenant(string tenant);
        IEnumerable<string> GetTenantNames();
        void SaveTenant(Tenant tenant);        
    }

    /// <summary>
    /// In case UploadLogo is not common function (some of places need to use, the rest of them is not need)
    /// So we will seperate to different interface by Interface Segregation Principle
    /// </summary>
    public interface ITenantStoreLogo
    {
        void UploadLogo(string tenant, byte[] logo);
    }
}
