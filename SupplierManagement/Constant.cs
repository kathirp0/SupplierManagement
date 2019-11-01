namespace SupplierManangement
{
    public static class Constant
    {
        public static string InvalidSupplierName = "Invalid Supplier Name";
        public static string InvalidSupplierCategory = "Invalid Supplier Category";
        public static string InvalidSupplierAddress = "Invalid Supplier Address";
        public static string Success = "Success";
        public static string Fail = "Unable to register Supplier information";
        public static string InvalidEmailId = "Invalid EmailId";
        public static string InvalidZipCode = "Invalid Zipcode";
        public static string InvalidContactNumber = "Invalid Contact Number";
        // Create string variables that contain the patterns   
        public static string EmailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"; // Email address pattern  
        // Email address pattern  
        
        public static string ZipCodePattern = @"^\d{3}\s?\d{3}$";
        public static string PhonePattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"; // Phone number pattern 
    }
}
