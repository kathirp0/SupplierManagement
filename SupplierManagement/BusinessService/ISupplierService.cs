using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupplierManangement.Model;

namespace SupplierManangement.BusinessService
{
    public interface ISupplierService
    {
        List<Supplier> GetSupplierDetails();
        string RegisterSupplierDetails(Supplier supplier);
        List<Supplier> GetSupplierDetailsByCategory(string category);
    }
}
