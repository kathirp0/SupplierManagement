using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SupplierManangement.Model;
using SupplierManangement.Repository;

namespace SupplierManangement.BusinessService
{
    public class SupplierService : ISupplierService
    {
        public IRepository<Supplier> _IRepository { get; set; }
        public SupplierService(IRepository<Supplier> _iRepository)
        {
            _IRepository = _iRepository;
        }

        public List<Supplier> GetSupplierDetailsByCategory(string category)
        {
            var result = _IRepository.GetById(x => x.Category == category);
            if (result.Count() > 0)
            {
                return result.ToList();
            }
            return new List<Supplier>();
        }
        public List<Supplier> GetSupplierDetails()
        {
            var result = _IRepository.Get();
            if (result.Count() > 0)
            {
                return result.ToList();
            }
            return new List<Supplier>();
        }
        public string RegisterSupplierDetails(Supplier supplier)
        {
            var result =  ValidateSupplierDetails(supplier);
            if (!string.IsNullOrEmpty(result))
            {
                return result;
            }
            var response = _IRepository.Create(supplier);
            if (!response)
            {
                return Constant.Fail;
            }
            return Constant.Success;
        }
        private string ValidateSupplierDetails(Supplier supplier)
        {
            bool isEmailValid = Regex.IsMatch(supplier.EmailId, Constant.EmailPattern);
            bool isZipValid = Regex.IsMatch(supplier.ZipCode, Constant.ZipCodePattern);
            bool isPhoneValid = Regex.Match(supplier.ContactNumber, Constant.PhonePattern).Success;
            if (string.IsNullOrEmpty(supplier.Name))
            {
                return Constant.InvalidSupplierName;
            }
            if (string.IsNullOrEmpty(supplier.Category))
            {
                return Constant.InvalidSupplierCategory;
            }
            if (string.IsNullOrEmpty(supplier.Address))
            {
                return Constant.InvalidSupplierAddress;
            }
            if(!isEmailValid)
            {
                return Constant.InvalidEmailId;
            }
            if (!isZipValid)
            {
                return Constant.InvalidZipCode;
            }
            if (!isPhoneValid)
            {
                return Constant.InvalidContactNumber;
            }
            return string.Empty;
        }

    }

}
