using Microsoft.AspNetCore.Mvc;
using SupplierManangement.BusinessService;
using SupplierManangement.Model;

namespace SupplierManangement.Controllers
{
    [Route("Supplier")]
    public class SupplierController : ControllerBase
    {
        public ISupplierService _supplierService { get; set; }
        /// <summary>
        /// Create instance of the ISupplierService
        /// </summary>
        /// <param name="supplierService"></param>
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        /// <summary>
        /// Gets Supplierdetails
        /// </summary>
        /// <returns>Returns IActionResult </returns>
        [HttpGet("getsupplier")]
        public IActionResult GetSupplierDetails()
        {
            var result = _supplierService.GetSupplierDetails();
            return Ok(result);
        }
        /// <summary>
        /// Gets SupplierDetails by categoryname
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Returns IActionResult success or bad request based on input parameter</returns>
        [HttpGet("getsupplierbycategory")]
        public IActionResult GetSupplierDetailsByCategory(string category)
        {
            var result = _supplierService.GetSupplierDetailsByCategory(category);
            return Ok(result);
        }
        /// <summary>
        /// Create new supplier
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns>Returns IActionResult success or bad request based on input parameter</returns>
        [HttpPost("registersupplier")]
        public IActionResult RegisterSupplierDetails([FromBody]Supplier supplier)
        {
            var result = _supplierService.RegisterSupplierDetails(supplier);
            if (result == Constant.Fail)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}