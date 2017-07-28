using DI_WithUnity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI_WithUnity.Framework
{
    public class TenantStore : Contract.ITenantStore, Contract.ITenantStoreLogo
    {       
        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public Tenant GetTenant(string tenant)
        {
            return null;
        }

        public IEnumerable<string> GetTenantNames()
        {
            return new List<string>();
        }

        public void SaveTenant(Tenant tenant)
        {
            throw new NotImplementedException();
        }

        public void UploadLogo(string tenant, byte[] logo)
        {
            throw new NotImplementedException();
        }
    }
}