
using Core.Entities.Concrete;

namespace BackendProject.Business.Constants
{
    public static class Messages
    {
        public static string ProductListed = "Product Listed";
        public static string ProductListedByCategoryId = "Product Listed By Category Id";
        public static string ProductListedByUnitPrice= "Product Listed By Unit Price";
        public static string ProductDtoListed="Product DTOs Listed";
        public static string GetProductById = "Get Product By Id";

        public static string ProductAdded = "Product Added";
        public static string ProductUpdated = "Product Updated";
        public static string ProductDeleted = "Product Deleted";

        public static string CategoryListed = "Category Listed";
        public static string GetCategoryById = "Get Category By Id";

        public static string CategoryAdded = "Category Added";
        public static string CategoryUpdated = "Category Updated";
        public static string CategoryDeleted = "Category Deleted";
        public static string ProductCountOfCategoryError = "Product count must be higher than 10 in one category";
        public static string ProductNameAlreadyExists="Product name already exists";
        public static string CategoryLimitExceeded="Category count must be smaller than 15";
        public static string AuthorizationDenied = "Authorization denied";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password is not correct";
        public static string SuccessfulLogin = "Login Successfully";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "User logged";
    }
}
